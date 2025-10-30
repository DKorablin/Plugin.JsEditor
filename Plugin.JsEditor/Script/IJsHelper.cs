using System;

namespace Plugin.JsEditor.Script
{
	internal interface IJsHelper
	{
		void LoadExternalFile(String path);

		Object Eval(String scriptToExecute);
	}
}