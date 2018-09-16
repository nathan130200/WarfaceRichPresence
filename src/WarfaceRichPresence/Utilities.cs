using System.Threading;

namespace WarfaceRichPresence
{
	public static class Utilities
	{
		public static bool ShouldWaitOne(ref Mutex mutex)
		{
#if DEBUG
			return false;
#else
			return mutex.WaitOne();
#endif
		}
	}
}
