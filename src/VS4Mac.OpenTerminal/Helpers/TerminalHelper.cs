using System.Diagnostics;
using MonoDevelop.Core;

namespace VS4Mac.OpenTerminal.Helpers
{
	public static class TerminalHelper
	{
		public static void OpenTerminal(FilePath filePath)
		{
			var proc = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "open",
					Arguments = $"-a Terminal {filePath.FullPath}"
				}
			};

			proc.Start();
		}
	}
}