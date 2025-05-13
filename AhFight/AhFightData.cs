using System;

namespace AhFight
{
	// Token: 0x02000007 RID: 7
	public class AhFightData
	{
		// Token: 0x06000083 RID: 131
		public AhFightData()
		{
			this.ahfight = AhFightConfig.baseAhFight;
			this.maxAhFight = AhFightConfig.baseAhFight;
			this.regenPerTick = AhFightConfig.baseAhFightRegen;
			this.lastAhFightLossTime = 0f;
			this.maxAhFightLossCount = 0;
		}

		// Token: 0x0400002D RID: 45
		public float ahfight;

		// Token: 0x0400002E RID: 46
		public float maxAhFight;

		// Token: 0x0400002F RID: 47
		public float regenPerTick;

		// Token: 0x04000030 RID: 48
		public float lastAhFightLossTime;

		// Token: 0x04000031 RID: 49
		public int maxAhFightLossCount;
	}
}
