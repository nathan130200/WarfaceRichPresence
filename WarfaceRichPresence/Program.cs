using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarfaceRichPresence.Forms;
using WarfaceRichPresence.Interop;

namespace WarfaceRichPresence
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			AppDomain.CurrentDomain.UnhandledException += (s, e) =>
			{
				var exception = (Exception)e.ExceptionObject;

				while (exception is AggregateException)
					exception = exception.InnerException;

				MessageBox.Show(exception.ToString(), exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			};

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}