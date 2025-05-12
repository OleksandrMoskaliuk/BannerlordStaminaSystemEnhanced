using System;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
	// Token: 0x02000011 RID: 17
	public static class DamagePenaltyEffect
	{
		// Token: 0x060001A8 RID: 424
		public static float GetDamageModifier(Agent agent)
		{
			if (agent == null)
			{
				return 1f;
			}
			AhFightState currentState = AhFightStateManager.GetCurrentState(agent);
			float num = 1f;
			switch (currentState)
			{
			case AhFightState.Normal:
				num = AhFightConfig.NormalStateHitDamageModifier;
				break;
			case AhFightState.Weak:
				num = AhFightConfig.WeakStateHitDamageModifier;
				break;
			case AhFightState.Tired:
				num = AhFightConfig.TiredStateHitDamageModifier;
				break;
			case AhFightState.Powerless:
				num = AhFightConfig.PowerlessStateHitDamageModifier;
				break;
			}
			return num;
		}

		// Token: 0x060001A9 RID: 425
		public static int ApplyDamagePenalty(Agent attacker, int damage)
		{
			if (attacker == null)
			{
				return damage;
			}
			float damageModifier = DamagePenaltyEffect.GetDamageModifier(attacker);
			return (int)((float)damage * damageModifier);
		}

		// Token: 0x040000BF RID: 191
		private const string MODULE_NAME = "DamagePenalty";
	}
}
