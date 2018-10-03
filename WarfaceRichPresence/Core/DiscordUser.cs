using System;

namespace WarfaceRichPresence.Core
{
	[Serializable]
	public struct DiscordUser
	{
		public string userId;
		public string username;
		public string discriminator;
		public string avatar;
	}
}