using System;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
	// Token: 0x02000011 RID: 17
	public static class DamagePenaltyEffect
	{
		public static float GetDamageModifier(Agent agent)
		{	
			if (agent != null && agent.IsActive() && agent.IsHuman) 
			{
                float agentAH = AhFightAPI.GetCurrentAhFight(agent) / AhFightAPI.GetMaxAhFight(agent); // Expected: 0.0 to 1.0
                float threshold = AhFightConfig.DamageReductionThreshold;
                float minMultiplier = AhFightConfig.MinDamageMultiplier;

                float dmgMultiplier = 1f;

                if (agentAH < threshold)
                {
                    float t = (threshold - agentAH) / threshold;
                    t = TaleWorlds.Library.MathF.Clamp(t, 0f, 1f);

                    // Smoothstep curve
                    float smooth = t * t * (3f - 2f * t);

                    // Invert and remap from [1.0 → minMultiplier]
                    dmgMultiplier = 1f - (1f - minMultiplier) * smooth;
                    dmgMultiplier = Math.Max(dmgMultiplier, minMultiplier);
                }
                else
                {
                    dmgMultiplier = 1.0f;
                }
				if (agent.IsPlayerControlled && false) 
				{
                    InformationManager.DisplayMessage(new InformationMessage(string.Format("Damage Multiplier: {0:F2}", dmgMultiplier), Colors.Red));
                }
                return dmgMultiplier;
            }
			return 1f;
		}

		// Token: 0x060001A9 RID: 425
		public static int ApplyDamagePenalty(Agent attacker, int damage)
		{
			if (attacker != null && attacker.IsActive() && attacker.IsHuman )
			{
			float damageModifier = DamagePenaltyEffect.GetDamageModifier(attacker);
			return (int)((float)damage * damageModifier);
			}
			return damage;
		}

		// Token: 0x040000BF RID: 191
		private const string MODULE_NAME = "DamagePenalty";
	}
}
