using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WarfaceRichPresence.Core
{
	public class RichPresence
	{
		private RichPresenceStruct _presence;
		private readonly List<IntPtr> _buffers = new List<IntPtr>(10);

		public string state; /* max 128 bytes */
		public string details; /* max 128 bytes */
		public long? startTimestamp;
		public long? endTimestamp;
		public string largeImageKey; /* max 32 bytes */
		public string largeImageText; /* max 128 bytes */
		public string smallImageKey; /* max 32 bytes */
		public string smallImageText; /* max 128 bytes */
		public string partyId; /* max 128 bytes */
		public int? partySize;
		public int? partyMax;
		public string matchSecret; /* max 128 bytes */
		public string joinSecret; /* max 128 bytes */
		public string spectateSecret; /* max 128 bytes */
		public bool? instance;

		/// <summary>
		/// Get the <see cref="RichPresenceStruct"/> reprensentation of this instance
		/// </summary>
		/// <returns><see cref="RichPresenceStruct"/> reprensentation of this instance</returns>
		internal RichPresenceStruct GetStruct()
		{
			if (_buffers.Count > 0)
			{
				FreeMem();
			}

			_presence.state = StrToPtr(state);
			_presence.details = StrToPtr(details);

			_presence.startTimestamp = startTimestamp ?? default(long);
			_presence.endTimestamp = endTimestamp ?? default(long);

			_presence.largeImageKey = StrToPtr(largeImageKey);
			_presence.largeImageText = StrToPtr(largeImageText);
			_presence.smallImageKey = StrToPtr(smallImageKey);
			_presence.smallImageText = StrToPtr(smallImageText);
			_presence.partyId = StrToPtr(partyId);


			_presence.partySize = partySize ?? default(int);
			_presence.partyMax = partyMax ?? default(int);

			_presence.matchSecret = StrToPtr(matchSecret);
			_presence.joinSecret = StrToPtr(joinSecret);
			_presence.spectateSecret = StrToPtr(spectateSecret);

			_presence.instance = instance ?? default(bool);

			return _presence;
		}

		/// <summary>
		/// Returns a pointer to a representation of the given string with a size of maxbytes
		/// </summary>
		/// <param name="input">String to convert</param>
		/// <returns>Pointer to the UTF-8 representation of <see cref="input"/></returns>
		private IntPtr StrToPtr(string input)
		{
			if (string.IsNullOrEmpty(input)) return IntPtr.Zero;
			var convbytecnt = Encoding.UTF8.GetByteCount(input);
			var buffer = Marshal.AllocHGlobal(convbytecnt + 1);
			for (int i = 0; i < convbytecnt + 1; i++)
			{
				Marshal.WriteByte(buffer, i, 0);
			}
			_buffers.Add(buffer);
			Marshal.Copy(Encoding.UTF8.GetBytes(input), 0, buffer, convbytecnt);
			return buffer;
		}

		/// <summary>
		/// Convert string to UTF-8 and add null termination
		/// </summary>
		/// <param name="toconv">string to convert</param>
		/// <returns>UTF-8 representation of <see cref="toconv"/> with added null termination</returns>
		private static string StrToUtf8NullTerm(string toconv)
		{
			var str = toconv.Trim();
			var bytes = Encoding.Default.GetBytes(str);
			if (bytes.Length > 0 && bytes[ bytes.Length - 1 ] != 0)
			{
				str += "\0\0";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(str));
		}

		/// <summary>
		/// Free the allocated memory for conversion to <see cref="RichPresenceStruct"/>
		/// </summary>
		internal void FreeMem()
		{
			for (var i = _buffers.Count - 1; i >= 0; i--)
			{
				Marshal.FreeHGlobal(_buffers[ i ]);
				_buffers.RemoveAt(i);
			}
		}
	}
}