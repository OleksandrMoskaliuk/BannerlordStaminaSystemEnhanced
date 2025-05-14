using System;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
	public static class MovementPenaltyEffect
	{
		public static float GetSpeedModifier(Agent agent)
		{
			if (agent != null && agent.IsActive() && agent.IsHuman) 
			{
                float AgenAh = AhFightAPI.GetCurrentAhFight(agent) / AhFightAPI.GetMaxAhFight(agent); // Expected: 0.0 to 1.0
                float threshold = AhFightConfig.MovementPenaltyAHThreshold;
                float minMultiplier = AhFightConfig.MinMovementPenaltyMultiplier;

                float moveMultiplier;

                if (AgenAh < threshold)
                {
                    float t = (threshold - AgenAh) / threshold;
                    t = TaleWorlds.Library.MathF.Clamp(t, 0f, 1f);

                    // Smoothstep curve
                    float smooth = t * t * (3f - 2f * t);

                    // Invert and remap from [1.0 → minMultiplier]
                    moveMultiplier = 1f - (1f - minMultiplier) * smooth;
                }
                else
                {
                    moveMultiplier = 1.0f;
                }
                moveMultiplier = Math.Max(moveMultiplier, minMultiplier);
                if (agent.IsPlayerControlled && false)
                {
                    InformationManager.DisplayMessage(new InformationMessage(string.Format("Movement Speed Multiplier: {0:F2}", moveMultiplier), Colors.Red));
                }
                return moveMultiplier;

            }
            return 1f;
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
