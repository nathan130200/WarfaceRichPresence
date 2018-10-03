using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WarfaceRichPresence.Core;

namespace WarfaceRichPresence.Controls
{
	public partial class InLobbyControl : UserControl
	{
		long? timestamp = null;

		public InLobbyControl()
		{
			InitializeComponent();
		}

		private void InLobbyControl_Load(object sender, EventArgs e)
		{
			timestamp = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
		}

		private void rbNovatos_CheckedChanged(object sender, EventArgs e)
		{
			nudCanal.Enabled = true;
		}

		private void rbExperientes_CheckedChanged(object sender, EventArgs e)
		{
			nudCanal.Enabled = true;
		}

		private void rbProfissionais_CheckedChanged(object sender, EventArgs e)
		{
			nudCanal.Enabled = true;
		}

		private void rbCoop_CheckedChanged(object sender, EventArgs e)
		{
			nudCanal.Enabled = false;
		}

		private void rbSobrevivencia_CheckedChanged(object sender, EventArgs e)
		{
			nudCanal.Enabled = false;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (chkbResetarTempo.Checked)
				timestamp = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

			var rp = new RichPresenceBuilder()
				.WithStartTimestamp(timestamp)
				.WithLargeImage("warface")
				.WithLargeText("Warface");

			if (rbCoop.Checked || rbSobrevivencia.Checked)
			{
				rp.WithState("PVE");

				if (rbCoop.Checked)
					rp.WithDetails($"No Lobby {Program.Separator} Coop");
				else if(rbSobrevivencia.Checked)
					rp.WithDetails($"No Lobby {Program.Separator} Sobrevivência");
			}
			else
			{
				rp.WithState("PVP");

				var id = string.Format("{0:00}", nudCanal.Value);

				if (rbNovatos.Checked)
					rp.WithDetails($"No Lobby {Program.Separator} Novatos {id}");

				else if (rbExperientes.Checked)
					rp.WithDetails($"No Lobby {Program.Separator} Experiêntes {id}");

				else if (rbProfissionais.Checked)
					rp.WithDetails($"No Lobby {Program.Separator} Profissionais {id}");
			}

			DiscordRpc.UpdatePresence(rp);
		}
	}
}