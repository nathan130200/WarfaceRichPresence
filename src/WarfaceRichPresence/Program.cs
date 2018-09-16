using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarfaceRichPresence
{
	static class Program
	{
		static Mutex mutex = new Mutex(false, "Global\\Warface Rich Presence");

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);

			if (Utilities.ShouldWaitOne(ref mutex))
				Application.Run(new Forms.MainForm());
			else
			{
				MessageBox.Show("Já existe uma instância em execução!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
