using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarfaceRichPresence.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_HelpRequested(object sender, HelpEventArgs e)
		{
			Process.Start(@"https://github.com/nathan130200/WarfaceRichPresence");
		}
	}
}
