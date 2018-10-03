using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WarfaceRichPresence
{
	public static class Program
	{
		public const string Separator = "\u2014";

		public const string ZeroWidthSpace = "\u200b";

		public static PrivateFontCollection FontCollection { get; } = new PrivateFontCollection();

		static Bitmap [] _bitmaps;

		[STAThread]
		static void Main()
		{
			CheckDiscord();

			_bitmaps = new Bitmap []
			{
				Properties.Resources.blackmamba,
				Properties.Resources.d17,
				Properties.Resources.hangar20,
				Properties.Resources.invasion,
				Properties.Resources.mojave,
				Properties.Resources.oildepot,
				Properties.Resources.palace,
				Properties.Resources.sirius,
				Properties.Resources.streetwars,
				Properties.Resources.vault
			};

			Application.EnableVisualStyles();

			var FontData = Properties.Resources.TitilliumWeb_Regular;

			IntPtr pFontData = Marshal.AllocHGlobal(FontData.Length);
			Marshal.Copy(FontData, 0, pFontData, FontData.Length);
			FontCollection.AddMemoryFont(pFontData, FontData.Length);

			var mf = new MainForm();
			PatchControlFonts(mf);
			Application.Run(mf);

			Marshal.FreeHGlobal(pFontData);
		}

		static void CheckDiscord()
		{
			var procs = Process.GetProcesses()
				.Where(x => x.ProcessName.Contains("Discord"));

			if(procs.Count() == 0)
			{
				MessageBox.Show("Discord não foi detectado em execução! O Warface Rich Presence não pode continuar...");
				Environment.Exit(1);
			}
		}

		public static Bitmap[] Backgrounds {
			get
			{
				return _bitmaps;
			}
		}

		public static void PatchControlFonts(Control c)
		{
			try
			{
				var oldFont = c.Font;

				var newFont = new Font(FontCollection.Families [0], oldFont.Size, oldFont.Style,
					oldFont.Unit, oldFont.GdiCharSet, oldFont.GdiVerticalFont);

				c.Font = newFont;

				Trace.TraceInformation("Aplicando fonte personalizada para o controle do tipo: {0}, nome: {1}", c.GetType().Name, c.Name ?? "desconhecido");

				var em = c.Controls.GetEnumerator();
				while (em.MoveNext())
				{
					if (em.Current is Control ctl)
						PatchControlFonts(ctl);
				}
			}
			catch(Exception ex)
			{
				Trace.TraceWarning(ex.ToString());
			}
		}
	}
}
