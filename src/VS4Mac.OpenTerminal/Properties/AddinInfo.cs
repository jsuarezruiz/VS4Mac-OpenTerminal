using System;
using System.Runtime.InteropServices;
using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
	"OpenTerminal",
	Namespace = "MonoDevelop",
	Version = "0.1"
)]

[assembly: AddinName("OpenTerminal")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("VS4Mac addin to open a terminal from the IDE.")]
[assembly: AddinAuthor("Javier Suárez Ruiz")]
[assembly: AddinUrl("https://github.com/jsuarezruiz/VS4Mac-OpenTerminal")]

[assembly: CLSCompliant(false)]
[assembly: ComVisible(false)]
