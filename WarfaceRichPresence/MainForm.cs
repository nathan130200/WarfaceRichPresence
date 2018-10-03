using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WarfaceRichPresence
{
	public partial class MainForm : Form
	{
		public EventHandlers RpcHandlers;
		private Thread RunCallbacksThread;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			RpcHandlers = new EventHandlers
			{
				readyCallback = DiscordRpc_Ready
			};
		}

		void DiscordRpc_Ready(ref DiscordUser connectedUser)
		{
			BeginInvoke(new Action<DiscordUser>((user) =>
			{
				lbUsername.Text = $"{user.username}#{user.discriminator}";

				var format = "";

				if (user.avatar.StartsWith("a_"))
					format = "gif";
				else
					format = "jpeg";

				pboxAvatar.ImageLocation = "https://cdn.discordapp.com/avatars/" + user.userId + "/" + user.avatar + "." + format + "?size=512";
			}), connectedUser);
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			DiscordRpc.Initialize(tbApplicationId.Text, ref RpcHandlers, true, null);

			RunCallbacksThread = new Thread(() =>
			{
				while (true)
				{
					DiscordRpc.RunCallbacks();
					Thread.Sleep(1000);
				}
			});

			RunCallbacksThread.Start();
		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{

		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if(RunCallbacksThread != null)
			{
				RunCallbacksThread.Abort(); ;
				RunCallbacksThread = null;
			}

			base.OnClosing(e);
		}
	}
}
