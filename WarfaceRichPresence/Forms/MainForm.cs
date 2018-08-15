using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WarfaceRichPresence.Interop;

namespace WarfaceRichPresence.Forms
{
	public partial class MainForm : WarfaceRichPresence.Forms.BaseForm
	{
		public RichPresence Rp;
		public DiscordUser Self;
		public EventHandlers Handlers;
		public Thread RunCallbacksThread;

		public MainForm()
		{
			InitializeComponent();
		}

		void MainForm_Load(object sender, EventArgs e)
		{
			Handlers = new EventHandlers();
			Rp = new RichPresence();
		}

		private void tbAppId_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				gbStatus.Enabled = true;
				DiscordRpc.Initialize(tbAppId.Text, ref Handlers, true);
				tbAppId.Enabled = false;

				ckbMostrarTempo.Enabled = ckbEnableStopTime.Enabled = true;

				Rp = new RichPresence
				{
					largeImageKey = "warface",
					largeImageText = "Warface",
				};
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if(!ckbMostrarTempo.Checked)
			{
				var old = Rp;
				var @new = new RichPresence();
				@new.largeImageKey = old.largeImageKey;
				@new.largeImageText = old.largeImageText;
				@new.smallImageKey = old.smallImageKey;
				@new.smallImageText = old.smallImageText;
				Rp = @new;
			}


			Rp.largeImageKey = tbLargeImageKey.Text;
			Rp.largeImageText = tbLargeImageText.Text;
			Rp.smallImageKey = tbSmallImageKey.Text;
			Rp.smallImageText = tbSmallImageText.Text;

			Rp.state = tbState.Text;
			Rp.details = tbDetails.Text;

			if (ckbMostrarTempo.Checked)
			{
				if(ckbReplaceTimestamp.Checked)
					Rp.startTimestamp = Utilities.GetUnixTimestamp();
				else
				{
					if(Rp.startTimestamp == null)
						Rp.startTimestamp = Utilities.GetUnixTimestamp();
				}

				if (!ckbEnableStopTime.Checked)
					Rp.endTimestamp = null;
				else
				{
					if(ckbReplaceTimestamp.Checked)
						Rp.endTimestamp = Utilities.GetUnixTimestampFromTimespan(TimeSpan.Parse(mtbStopTime.Text));
					else
					{
						if (Rp.endTimestamp == null)
							Rp.endTimestamp = Utilities.GetUnixTimestampFromTimespan(TimeSpan.Parse(mtbStopTime.Text));
					}
				}
			}

			DiscordRpc.UpdatePresence(Rp);
		}

		private void ckbEnableStopTime_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbEnableStopTime.Enabled)
				mtbStopTime.Enabled = true;
			else
				mtbStopTime.Enabled = false;
		}

		private void ckbMostrarTempo_CheckedChanged(object sender, EventArgs e)
		{
			if (!ckbMostrarTempo.Checked)
				ckbEnableStopTime.Enabled = mtbStopTime.Enabled = false;
			else
				ckbEnableStopTime.Enabled = mtbStopTime.Enabled = true;
		}
	}
}
