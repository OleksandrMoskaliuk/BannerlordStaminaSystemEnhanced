using System;
using HarmonyLib;
using TaleWorlds.Engine;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
    // This patch applies a stamina-based damage penalty before a blow is registered
    [HarmonyPatch(typeof(Mission))]
    [HarmonyPatch("RegisterBlow")]
    public static class DamagePenaltyPatch
    {
        private static void Prefix(
            Agent attacker,
            Agent victim,
            GameEntity realHitEntity,
            ref Blow b,
            ref AttackCollisionData collisionData,
            in MissionWeapon attackerWeapon,
            ref CombatLogData combatLogData)
        {
            // Only apply if the feature is enabled and the attacker is valid and this isn't a missile hit
            if (!AhFightConfig.hitDamagePenaltyEnabled || attacker == null || b.InflictedDamage <= 0 || b.IsMissile)
                return;

            // Cache original damage as float
            float originalDamage = b.InflictedDamage;

            // Apply stamina-based penalty
            float modifiedDamage = DamagePenaltyEffect.ApplyDamagePenalty(attacker, (int)originalDamage);

            // Update damage values in all relevant structs
            b.InflictedDamage = (int)modifiedDamage;
            collisionData.InflictedDamage = (int)modifiedDamage;
            combatLogData.InflictedDamage = (int)modifiedDamage;
            combatLogData.ModifiedDamage = (int)(modifiedDamage - originalDamage);
        }
    }
}
