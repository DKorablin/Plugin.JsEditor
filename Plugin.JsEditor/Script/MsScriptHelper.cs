using System;
using System.Diagnostics;
using System.IO;
using MSScriptControl;

namespace Plugin.JsEditor.Script
{
	internal class MsScriptHelper : IJsHelper
	{
		private readonly ScriptControl _script;

		public MsScriptHelper()
		{
			this._script = new ScriptControl() { Language = "JScript", AllowUI = false, };
			this.LoadShim();
		}

		public void AddCode(String js)
			=> this._script.AddCode(js);

		public void LoadExternalFiles(params String[] paths)
		{
			foreach(String path in paths)
				this.LoadExternalFile(path);
		}

		public void LoadExternalFile(String path)
		{
			String fileContent = File.ReadAllText(path);
			this._script.AddCode(fileContent);
		}

		public T Eval<T>(String scriptToExecute)
			=> (T)this.Eval(scriptToExecute);

		public Object Eval(String scriptToExecute)
		{
			Object result = null;
			try
			{
				result = this._script.Eval(scriptToExecute);
			} catch(Exception exc)
			{
				this.ThrowException(exc);
			}

			return result;
		}

		public T Run<T>(String methodName, params Object[] args)
		{
			Object result = null;
			try
			{
				result = this._script.Run(methodName, args);
			} catch(Exception exc)
			{
				this.ThrowException(exc);
			}

			return (T)result;
		}

		public void Restart()
			=> this._script.Reset();

		[DebuggerStepThrough]
		[DebuggerHidden]
		private void ThrowException(Exception managedException)
		{
			var error = ((IScriptControl)this._script).Error;

			String message = error.Description;
			if(String.IsNullOrEmpty(message))
				message = managedException.Message;

			throw new JsRuntimeException(message, error.Line.ToString());
		}

		protected virtual void LoadShim()
			=> this._script.AddCode("var isMsScriptEngineContext = true; var window = window || {}; var document = document || {};");
	}
}