using System;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
	// Token: 0x02000013 RID: 19
	public static class MovementPenaltyEffect
	{
		// Token: 0x060001AB RID: 427
		public static float GetSpeedModifier(Agent agent)
		{
			if (agent == null)
			{
				return AhFightConfig.normalSpeedModifier;
			}
			AhFightState currentState = AhFightStateManager.GetCurrentState(agent);
			float num = AhFightConfig.normalSpeedModifier;
			switch (currentState)
			{
			case AhFightState.Normal:
				num = AhFightConfig.normalSpeedModifier;
				break;
			case AhFightState.Weak:
				num = AhFightConfig.weakSpeedModifier;
				break;
			case AhFightState.Tired:
				num = AhFightConfig.tiredSpeedModifier;
				break;
			case AhFightState.Powerless:
				num = AhFightConfig.powerlessSpeedModifier;
				break;
			}
			return num;
		}

		// Token: 0x060001AC RID: 428
		public static void ApplyMovementPenalty(Agent agent)
		{
			if (agent == null)
			{
				return;
			}
			float speedModifier = MovementPenaltyEffect.GetSpeedModifier(agent);
			if (!agent.HasMount)
			{
				agent.SetMaximumSpeedLimit(speedModifier, true);
				return;
			}
		}

		// Token: 0x060001AD RID: 429
		public static void ResetMovementSpeed(Agent agent)
		{
			if (agent == null)
			{
				return;
			}
			agent.SetMaximumSpeedLimit(1f, true);
		}

		// Token: 0x040000C0 RID: 192
		private const string MODULE_NAME = "MovementPenalty";
	}
}
