using MonoDevelop.Components.Commands;
using VS4Mac.OpenTerminal.Helpers;

namespace VS4Mac.OpenTerminal.Commands
{
	public class OpenTerminalCommand : CommandHandler
	{
		protected override void Run()
		{
			TerminalHelper.OpenTerminal(ProjectHelper.GetCurrentPath());
		}
	}
}