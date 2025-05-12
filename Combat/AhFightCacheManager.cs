using System;
using System.Collections.Generic;

namespace AhFight.Combat
{
	// Token: 0x0200000F RID: 15
	public static class AhFightCacheManager
	{
		// Token: 0x0600019C RID: 412
		public static void CleanupCache(float currentTime)
		{
			if (currentTime - AhFightCacheManager._lastCleanupTime < AhFightConfig.cacheCleanupInterval)
			{
				return;
			}
			AhFightCacheManager._lastCleanupTime = currentTime;
			List<string> list = new List<string>();
			float num = currentTime - AhFightConfig.cacheEntryMaxAge;
			foreach (string text in AhFightCacheManager._processedAttacks.Keys)
			{
				if (AhFightCacheManager.IsKeyExpired(text, num))
				{
					list.Add(text);
				}
			}
			foreach (string text2 in list)
			{
				AhFightCacheManager._processedAttacks.Remove(text2);
			}
			list.Clear();
			foreach (string text3 in AhFightCacheManager._randomValues.Keys)
			{
				if (AhFightCacheManager.IsKeyExpired(text3, num))
				{
					list.Add(text3);
				}
			}
			foreach (string text4 in list)
			{
				AhFightCacheManager._randomValues.Remove(text4);
				AhFightCacheManager._perfectBlockResults.Remove(text4);
			}
		}

		// Token: 0x0600019D RID: 413
		private static bool IsKeyExpired(string key, float cutoffTime)
		{
			string[] array = key.Split(new char[] { '_' });
			float num;
			return array.Length < 3 || !float.TryParse(array[array.Length - 1], out num) || num < cutoffTime;
		}

		// Token: 0x0600019E RID: 414
		public static bool IsAttackProcessed(string attackKey)
		{
			return AhFightCacheManager._processedAttacks.ContainsKey(attackKey);
		}

		// Token: 0x0600019F RID: 415
		public static void MarkAttackProcessed(string attackKey)
		{
			AhFightCacheManager._processedAttacks[attackKey] = true;
		}

		// Token: 0x060001A0 RID: 416
		public static float GetRandomValue(string attackKey)
		{
			if (AhFightCacheManager._randomValues.ContainsKey(attackKey))
			{
				return AhFightCacheManager._randomValues[attackKey];
			}
			float num = (float)AhFightCacheManager._random.NextDouble();
			AhFightCacheManager._randomValues[attackKey] = num;
			return num;
		}

		// Token: 0x060001A1 RID: 417
		public static void SetPerfectBlockResult(string attackKey, bool result)
		{
			AhFightCacheManager._perfectBlockResults[attackKey] = result;
		}

		// Token: 0x060001A2 RID: 418
		public static bool GetPerfectBlockResult(string attackKey)
		{
			bool flag;
			return AhFightCacheManager._perfectBlockResults.TryGetValue(attackKey, out flag) && flag;
		}

		// Token: 0x060001A3 RID: 419
		public static void ClearAllCache()
		{
			AhFightCacheManager._processedAttacks.Clear();
			AhFightCacheManager._perfectBlockResults.Clear();
			AhFightCacheManager._randomValues.Clear();
			AhFightCacheManager._lastCleanupTime = 0f;
		}

		// Token: 0x040000B8 RID: 184
		private const string MODULE_NAME = "AhFightCacheManager";

		// Token: 0x040000B9 RID: 185
		private static float _lastCleanupTime = 0f;

		// Token: 0x040000BA RID: 186
		private static Dictionary<string, bool> _processedAttacks = new Dictionary<string, bool>();

		// Token: 0x040000BB RID: 187
		private static Dictionary<string, bool> _perfectBlockResults = new Dictionary<string, bool>();

		// Token: 0x040000BC RID: 188
		private static Dictionary<string, float> _randomValues = new Dictionary<string, float>();

		// Token: 0x040000BD RID: 189
		private static Random _random = new Random();
	}
}
