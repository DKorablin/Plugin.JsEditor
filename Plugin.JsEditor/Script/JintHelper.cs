using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Jint;
using Jint.Parser;
using Jint.Runtime;

namespace Plugin.JsEditor.Script
{
	internal class JintHelper : IJsHelper
	{
		private readonly Engine _engine = new Engine();
		private readonly StringBuilder _payload = new StringBuilder();

		public JintHelper()
		{
			this._engine = new Engine(cfg => cfg.AllowClr());
			this._engine.SetValue("alert", new Action<Object>(Alert));
			this._engine.SetValue("console.log", new Action<Object>(Console.WriteLine));
		}

		public void LoadExternalFile(String path)
		{
			String fileContent = File.ReadAllText(path);
			this._payload.AppendLine(fileContent);
		}

		public Object Eval(String scriptToExecute)
		{
			String js = this._payload.Insert(0, scriptToExecute).ToString();
			this._payload.Clear();

			try
			{
				this._engine.Execute(js);
				return null;
			} catch(ParserException exc)
			{
				Exception exc1 = new JsRuntimeException(exc.Message, exc.LineNumber);
				throw exc1;
			} catch(JavaScriptException exc)
			{
				Exception exc1 = new JsRuntimeException(exc.Message, exc.LineNumber);
				throw exc1;
			}
		}

		private static void Alert(Object message)
			=> MessageBox.Show(message == null ? "null" : message.ToString());
	}
}