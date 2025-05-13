using System;

namespace AhFight
{
	// Token: 0x0200000B RID: 11
	public static class DebugHelper
	{
		// Token: 0x0600008E RID: 142
		public static void Log(string module, string message)
		{
		}

		// Token: 0x0600008F RID: 143
		public static void LogWarning(string module, string message)
		{
		}

		// Token: 0x06000090 RID: 144
		public static void LogError(string module, string message, Exception ex = null)
		{
		}

		// Token: 0x06000091 RID: 145
		public static void LogPerformance(string module, string operation, float elapsedMs)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000092 RID: 146
		public static bool IsDebug
		{
			get
			{
				return DebugHelper.IsDebugMode;
			}
		}

		// Token: 0x0400003A RID: 58
		private static readonly bool IsDebugMode = false;

		// Token: 0x0400003B RID: 59
		private const string LOG_PREFIX = "[AH]";

		// Token: 0x0400003C RID: 60
		private static readonly object _lockObj = new object();
	}
}
