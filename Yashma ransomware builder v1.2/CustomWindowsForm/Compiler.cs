using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace CustomWindowsForm
{
	// Token: 0x02000006 RID: 6
	public class Compiler
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00007D54 File Offset: 0x00005F54
		public Compiler(string sourceCode, string savePath, string iconLocation)
		{
			string[] assemblyNames = new string[]
			{
				"System.dll",
				"System.Linq.dll",
				"System.Windows.Forms.dll",
				"System.Text.RegularExpressions.dll",
				"System.Runtime.InteropServices.dll",
				"System.ServiceProcess.dll",
				"System.Security.dll"
			};
			Dictionary<string, string> providerOptions = new Dictionary<string, string>
			{
				{
					"CompilerVersion",
					"v4.0"
				}
			};
			string text = "/target:winexe /platform:anycpu /optimize+ ";
			if (iconLocation != "")
			{
				text = text + "/win32icon:" + iconLocation;
			}
			using (CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider(providerOptions))
			{
				CompilerParameters options = new CompilerParameters(assemblyNames)
				{
					GenerateExecutable = true,
					GenerateInMemory = false,
					OutputAssembly = savePath,
					CompilerOptions = text,
					TreatWarningsAsErrors = false,
					IncludeDebugInformation = false
				};
				CompilerResults compilerResults = csharpCodeProvider.CompileAssemblyFromSource(options, new string[]
				{
					sourceCode
				});
				if (compilerResults.Errors.Count > 0)
				{
					foreach (object obj in compilerResults.Errors)
					{
						CompilerError compilerError = (CompilerError)obj;
						MessageBox.Show(string.Format("{0}\nLine: {1} - Column: {2}\nFile: {3}", new object[]
						{
							compilerError.ErrorText,
							compilerError.Line,
							compilerError.Column,
							compilerError.FileName
						}));
					}
				}
				else
				{
					MessageBox.Show("Done!");
				}
			}
		}
	}
}
