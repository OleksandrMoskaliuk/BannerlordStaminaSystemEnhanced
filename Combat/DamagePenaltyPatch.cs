using System;
using HarmonyLib;
using TaleWorlds.Engine;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
	// Token: 0x02000012 RID: 18
	[HarmonyPatch(typeof(Mission))]
	[HarmonyPatch("RegisterBlow")]
	public static class DamagePenaltyPatch
	{
		// Token: 0x060001AA RID: 426
		private static void Prefix(Agent attacker, Agent victim, GameEntity realHitEntity, ref Blow b, ref AttackCollisionData collisionData, in MissionWeapon attackerWeapon, ref CombatLogData combatLogData)
		{
			if (AhFightConfig.hitDamagePenaltyEnabled)
			{
				if (attacker == null || b.InflictedDamage <= 0 || b.IsMissile)
				{
					return;
				}
				float num = (float)b.InflictedDamage;
				float num2 = (float)DamagePenaltyEffect.ApplyDamagePenalty(attacker, (int)num);
				b.InflictedDamage = (int)num2;
				collisionData.InflictedDamage = (int)num2;
				combatLogData.InflictedDamage = (int)num2;
				combatLogData.ModifiedDamage = (int)(num2 - num);
			}
		}
	}
}
