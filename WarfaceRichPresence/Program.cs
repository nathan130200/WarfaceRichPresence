using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarfaceRichPresence.Interop;

namespace WarfaceRichPresence
{
	static class Program
	{
		static EventHandlers Handlers;

		[STAThread]
		static void Main()
		{
			Handlers = new EventHandlers();
			Handlers.readyCallback = OnReady;
			Handlers.errorCallback = OnFail;
			Handlers.disconnectedCallback = OnFail;

			DiscordRpc.Initialize("479021344625917953", ref Handlers);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			DiscordRpc.RunCallbacks();
			DiscordRpc.UpdatePresence(new RichPresence
			{
				largeImageKey = "ct_survival",
				state = "Missão: The Great White",
				details = "Sobrevivência: Difícil",
				startTimestamp = Utilities.GetUnixTimestamp()
			});

			Application.Run();
		}

		static void OnReady(ref DiscordUser self)
		{
			MessageBox.Show($"[DiscordRpc]: Connected. {self.username}#{self.discriminator} ({self.userId})", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		static void OnFail(int code, string msg)
		{
			MessageBox.Show($"[{code}]: {msg}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}