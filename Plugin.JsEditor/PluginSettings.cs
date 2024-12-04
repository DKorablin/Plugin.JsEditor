using System;
using System.ComponentModel;
using Plugin.JsEditor.Script;

namespace Plugin.JsEditor
{
	public class PluginSettings
	{
		[DefaultValue(JsEngineType.Jint)]
		[Category("Engine")]
		[DisplayName("Interpreter Type")]
		[Description("JavaScript interpreter type")]
		public JsEngineType Type { get; set; } = JsEngineType.Jint;

		internal IJsHelper GetEngine()
		{
			switch(this.Type)
			{
			case JsEngineType.MsScript:
				return new MsScriptHelper();
			case JsEngineType.Jint:
				return new JintHelper();
			default:
				throw new NotImplementedException();
			}
		}
	}
}