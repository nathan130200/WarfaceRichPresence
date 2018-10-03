using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WarfaceRichPresence.Core;

namespace WarfaceRichPresence
{
	public partial class MainForm : Form
	{
		public EventHandlers Handlers;
		public DiscordUser CurrentUser;
		private Random rnd;

		public MainForm()
		{
			rnd = new Random(Environment.TickCount);
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Handlers = new EventHandlers();
			Handlers.readyCallback = Discord_Ready;
			Handlers.disconnectedCallback = Discord_Disconnect;
			Handlers.errorCallback = Discord_Error;

			var off = rnd.Next(0, Program.Backgrounds.Length);
			var bg = Program.Backgrounds [off];
			BackgroundImage = bg;
		}

		void Discord_Ready(ref DiscordUser pUser)
		{
			Invoke(new Action<DiscordUser>((user) =>
			{
				btnToggle.Enabled = true;

				pbAvatarImage.ImageLocation = $"https://cdn.discordapp.com/avatars/{user.userId}/{user.avatar}.png?size=128";
				lbUsername.Text = $"{user.username}#{user.discriminator}\n{user.userId}";

				flpMain.Enabled = true;
			}), pUser);

			CurrentUser = pUser;
		}

		void Discord_Disconnect(int code, string message)
		{
			MessageBox.Show($"Conexão com Discord perdida!\n{message}", code.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		void Discord_Error(int code, string message)
		{
			MessageBox.Show($"Conexão com Discord ocorreu erro!\n{message}", code.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		bool initialized = false;

		private void btnToggle_Click(object sender, EventArgs e)
		{
			if(!ulong.TryParse(tbApplicationId.Text, out var _))
			{
				MessageBox.Show("Id da aplicação digitado está incorreto!\nhttps://discordapp.com/developers/applications/",
					"",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1,
					MessageBoxOptions.DefaultDesktopOnly);
				return;
			}

			if (!initialized)
			{
				DiscordRpc.Initialize(tbApplicationId.Text, ref Handlers, false, null);
				btnToggle.Text = "Desconectar";
				initialized = true;
				btnToggle.Enabled = false;
				tbApplicationId.Enabled = false;
				btnLimparPresenca.Enabled = true;
			}
			else
			{
				pbAvatarImage.ImageLocation = null;

				DiscordRpc.ClearPresence();
				DiscordRpc.Shutdown();
				btnToggle.Text = "Conectar";
				initialized = false;
				btnToggle.Enabled = true;
				tbApplicationId.Enabled = true;
				lbUsername.Text = null;

				flpMain.Enabled = false;
				btnLimparPresenca.Enabled = false;
			}
		}

		private void RunCallbacksTimer_Tick(object sender, EventArgs e)
		{
			DiscordRpc.RunCallbacks();
		}

		private void btnLimparPresenca_Click(object sender, EventArgs e)
		{
			if (initialized)
				DiscordRpc.ClearPresence();
			else
				return;
		}
	}
}
