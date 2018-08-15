using System;

namespace WarfaceRichPresence
{
	public static class Utilities
	{
		public static long GetUnixTimestamp()
		{
			return (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
		}

		public static long GetUnixTimestampFromDate(DateTime dateTime)
		{
			return (long)dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
		}

		public static long GetUnixTimestampFromTimespan(TimeSpan ts)
		{
			return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).Add(ts).TotalSeconds;
		}
	}
}
