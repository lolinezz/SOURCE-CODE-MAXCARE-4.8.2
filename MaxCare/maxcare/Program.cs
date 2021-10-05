using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// maxcare.Program
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Windows.Forms;
	using maxcare;
	using maxcare.Helper;
	using MCommon;

	internal static class Program
	{
		public static int intro;

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		    Application.Run(new fIntro());
		}
	}

}
