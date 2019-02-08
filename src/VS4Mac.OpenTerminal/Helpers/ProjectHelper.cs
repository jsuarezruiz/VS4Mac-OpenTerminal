using System;
using MonoDevelop.Core;
using MonoDevelop.Ide;
using MonoDevelop.Projects;

namespace VS4Mac.OpenTerminal.Helpers
{
	public static class ProjectHelper
	{
		public static string GetCurrentPath()
		{
			try
			{
				FilePath path = null;

				if (IdeApp.ProjectOperations.CurrentSelectedItem is WorkspaceItem workspaceItem)
				{
					path = workspaceItem.FileName.ParentDirectory;
				}

				if (IdeApp.ProjectOperations.CurrentSelectedItem is SolutionItem solutionItem)
				{
					path = solutionItem.FileName.ParentDirectory;
				}

				if (path != null)
					return path.FullPath;

				return string.Empty;
			}
			catch(Exception ex)
			{
				LoggingService.LogError("Getting current selected item path failed.", ex);
				return string.Empty;
			}
		}
	}
}
