using System;

namespace Plugin.JsEditor.Script
{
	internal class JsRuntimeException : ApplicationException
	{
		public Int32 LineNumber { get; set; }

		public JsRuntimeException(String message, Int32 lineNumber)
			: base(message)
			=> this.LineNumber = lineNumber;
	}
}