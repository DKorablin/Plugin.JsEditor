using System;
using System.Collections.Generic;
using System.Diagnostics;
using SAL.Flatbed;
using SAL.Windows;

namespace Plugin.JsEditor
{
	public class PluginWindows : IPlugin, IPluginSettings<PluginSettings>
	{
		private TraceSource _trace;
		private PluginSettings _settings;
		private Dictionary<String, DockState> _documentTypes;

		internal TraceSource Trace => this._trace ?? (this._trace = PluginWindows.CreateTraceSource<PluginWindows>());

		internal IHost Host { get; }
		internal IHostWindows HostWindows => this.Host as IHostWindows;

		/// <summary>Settings for interaction from the host</summary>
		Object IPluginSettings.Settings => this.Settings;

		/// <summary>Settings for interaction from the plugin</summary>
		public PluginSettings Settings
		{
			get
			{
				if(this._settings == null)
				{
					this._settings = new PluginSettings();
					this.Host.Plugins.Settings(this).LoadAssemblyParameters(this._settings);
				}
				return this._settings;
			}
		}

		private IMenuItem MenuCompilers { get; set; }
		private IMenuItem PluginMenu { get; set; }

		private Dictionary<String, DockState> DocumentTypes
		{
			get
			{
				if(this._documentTypes == null)
					this._documentTypes = new Dictionary<String, DockState>()
					{
						{ typeof(DocumentJsEditor).ToString(), DockState.Document }
					};
				return this._documentTypes;
			}
		}

		public PluginWindows(IHost host)
			=> this.Host = host ?? throw new ArgumentNullException(nameof(host));

		public IWindow GetPluginControl(String typeName, Object args)
			=> this.CreateWindow(typeName, false, args);

		Boolean IPlugin.OnConnection(ConnectMode mode)
		{
			IHostWindows host = this.HostWindows;
			if(host == null)
				this.Trace.TraceEvent(TraceEventType.Error, 10, "Plugin {0} requires {1}", this, typeof(IHostWindows));
			else
			{
				IMenuItem menuTools = host.MainMenu.FindMenuItem("Tools");
				if(menuTools == null)
					this.Trace.TraceEvent(TraceEventType.Error, 10, "Menu item 'Tools' not found");
				else
				{
					this.MenuCompilers = menuTools.FindMenuItem("Compilers");
					if(this.MenuCompilers == null)
					{
						this.MenuCompilers = menuTools.Create("Compilers");
						this.MenuCompilers.Name = "Tools.Compilers";
						menuTools.Items.Add(this.MenuCompilers);
					}

					this.PluginMenu = menuTools.Create("&JsEditor");
					this.PluginMenu.Name = "Tools.Compilers.JsEditor";
					this.PluginMenu.Click += (sender, e) => { this.CreateWindow(typeof(DocumentJsEditor).ToString(), false); };

					this.MenuCompilers.Items.Insert(0, this.PluginMenu);
					return true;
				}
			}
			return false;
		}

		Boolean IPlugin.OnDisconnection(DisconnectMode mode)
		{
			if(this.PluginMenu != null)
				this.HostWindows.MainMenu.Items.Remove(this.PluginMenu);
			if(this.MenuCompilers != null && this.MenuCompilers.Items.Count == 0)
				this.HostWindows.MainMenu.Items.Remove(this.MenuCompilers);
			return true;
		}

		private IWindow CreateWindow(String typeName, Boolean searchForOpened, Object args = null)
			=> this.DocumentTypes.TryGetValue(typeName, out DockState state)
				? this.HostWindows.Windows.CreateWindow(this, typeName, searchForOpened, state, args)
				: null;

		private static TraceSource CreateTraceSource<T>(String name = null) where T : IPlugin
		{
			TraceSource result = new TraceSource(typeof(T).Assembly.GetName().Name + name);
			result.Switch.Level = SourceLevels.All;
			result.Listeners.Remove("Default");
			result.Listeners.AddRange(System.Diagnostics.Trace.Listeners);
			return result;
		}
	}
}