using System;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
	public static class MovementPenaltyEffect
	{
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

		public static void ApplyAttackSpeedPenalty(Agent agent, AhFightData data)
		{
			
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
