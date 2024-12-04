using System;

namespace Plugin.JsEditor.Script
{
	internal class JsRuntimeException : ApplicationException
	{
		public String Location { get; }

		public JsRuntimeException(String message, String location)
			: base(message)
			=> this.Location = location;
	}
}