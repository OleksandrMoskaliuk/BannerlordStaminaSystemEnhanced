using System;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
	// Token: 0x02000010 RID: 16
	public static class AhFightDamageCalculator
	{
		// Token: 0x060001A5 RID: 421
		public static float CalculateBaseAhFightDamage(float baseAhFightDamage, float comModifier, WeaponComponentData weaponData, Agent.UsageDirection attackDirection, bool isPlayerInvolved = false, Agent agent = null)
		{
			float num = 1f;
			float num2 = baseAhFightDamage * ((comModifier > 0f) ? comModifier : 0.5f);
			float num3;
			if (attackDirection == Agent.UsageDirection.AttackDown)
			{
				num3 = AhFightConfig.thrustStanceLossModifier;
			}
			else
			{
				num3 = AhFightConfig.swingStanceLossModifier;
			}
			if (weaponData != null)
			{
				switch (weaponData.WeaponClass)
				{
				case WeaponClass.Dagger:
				case WeaponClass.OneHandedSword:
					num = AhFightConfig.oneHandedSwordSwingModifier;
					break;
				case WeaponClass.TwoHandedSword:
					num = AhFightConfig.twoHandedSwordSwingModifier;
					break;
				case WeaponClass.OneHandedAxe:
				case WeaponClass.Mace:
				case WeaponClass.OneHandedPolearm:
					num = AhFightConfig.oneHandedBluntSwingModifier;
					break;
				case WeaponClass.TwoHandedAxe:
				case WeaponClass.TwoHandedMace:
					num = AhFightConfig.twoHandedBluntSwingModifier;
					break;
				case WeaponClass.TwoHandedPolearm:
					num = AhFightConfig.polearmSwingModifier;
					break;
				}
			}
			num2 *= num3 * num;
			return num2 * AhFightConfig.stanceLossBaseMultiplier;
		}

		// Token: 0x060001A6 RID: 422
		public static float CalculateDefenderAhFightDamage(float baseAhFightDamage, AttackCollisionData collisionData, float skillModifier, bool isShieldBlock, bool isPerfectBlock, bool isCorrectSideBlock, float shieldDefenseModifier, bool isPlayerInvolved = false, Agent agent = null)
		{
			float num = 1f;
			float defenderAhFightMultiplier = AhFightConfig.defenderAhFightMultiplier;
			if (isShieldBlock)
			{
				float num2 = AhFightConfig.shieldStanceLossModifier;
				if (isPerfectBlock)
				{
					num2 *= 0.3f;
				}
				else
				{
					num2 *= (isCorrectSideBlock ? 0.5f : 0.8f);
				}
				num = num2 * shieldDefenseModifier;
			}
			else if (collisionData.CollisionResult == CombatCollisionResult.Blocked)
			{
				num = 0.7f;
			}
			else if (collisionData.CollisionResult == CombatCollisionResult.Parried)
			{
				num = 0.4f;
			}
			else if (collisionData.CollisionResult == CombatCollisionResult.StrikeAgent)
			{
				num = 1f;
			}
			float num4 = baseAhFightDamage * (defenderAhFightMultiplier * num);
			skillModifier = TaleWorlds.Library.MathF.Max(skillModifier, 0.5f);
			float num5 = num4 * skillModifier;
			float num3 = 0.9f + MBRandom.RandomFloat * 0.2f;
			return TaleWorlds.Library.MathF.Max(TaleWorlds.Library.MathF.Min(num5 * num3, AhFightConfig.maxDefenderStanceLoss), 1f);
		}

		// Token: 0x060001A7 RID: 423
		public static float CalculateAttackerAhFightDamage(float baseAhFightDamage, AttackCollisionData collisionData, bool isShieldBlock, bool isPerfectBlock, float skillModifier, bool isPlayerInvolved = false, Agent agent = null)
		{
			float attackerAhFightMultiplier = AhFightConfig.attackerAhFightMultiplier;
			float num = 1f;
			if (collisionData.CollisionResult == CombatCollisionResult.Blocked)
			{
				num = 1.2f;
			}
			else if (collisionData.CollisionResult == CombatCollisionResult.Parried)
			{
				if (isShieldBlock)
				{
					num = (isPerfectBlock ? 1.3f : 1f);
				}
				else
				{
					num = 1.5f;
				}
			}
			else if (collisionData.CollisionResult == CombatCollisionResult.StrikeAgent)
			{
				num = 0.9f;
			}
			float num3 = baseAhFightDamage * (attackerAhFightMultiplier * num);
			skillModifier = TaleWorlds.Library.MathF.Max(skillModifier, 0.5f);
			float num4 = num3 * skillModifier;
			float num2 = 0.9f + MBRandom.RandomFloat * 0.2f;
			return TaleWorlds.Library.MathF.Max(TaleWorlds.Library.MathF.Min(num4 * num2, AhFightConfig.maxAttackerStanceLoss), 0.5f);
		}

		// Token: 0x040000BE RID: 190
		private const string MODULE_NAME = "DamageCalc";
	}
}
