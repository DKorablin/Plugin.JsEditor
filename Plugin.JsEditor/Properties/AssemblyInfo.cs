using System.Reflection;
using System.Runtime.InteropServices;

[assembly: Guid("5953cd13-d4b0-407b-88ab-ed41113f1b93")]
[assembly: System.CLSCompliant(true)]

[assembly: AssemblyDescription("JavaScript editor with MSScriptControl or JINT")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2017-2025")]

/*if $(ConfigurationName) == Release (
..\..\..\..\..\ILMerge.exe /targetplatform:v4  "/out:$(ProjectDir)..\..\bin\$(TargetFileName)" "$(TargetPath)" "$(TargetDir)FastColoredTextBox.dll" "$(TargetDir)Jint.dll" "/lib:..\..\..\..\SAL\bin"
)*/