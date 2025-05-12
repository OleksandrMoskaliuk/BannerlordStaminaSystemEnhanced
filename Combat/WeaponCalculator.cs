using System;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
	// Token: 0x02000014 RID: 20
	public static class WeaponCalculator
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001AE RID: 430
		public static float SwingSpeedTransfer
		{
			get
			{
				return AhFightConfig.swingSpeedTransfer;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001AF RID: 431
		public static float ThrustSpeedTransfer
		{
			get
			{
				return AhFightConfig.thrustSpeedTransfer;
			}
		}

		// Token: 0x060001B0 RID: 432
		public static float GetEffectiveSkillWithDR(float effectiveSkill)
		{
			if (effectiveSkill > 200f)
			{
				return 200f + (effectiveSkill - 200f) * 0.5f;
			}
			if (effectiveSkill > 100f)
			{
				return 100f + (effectiveSkill - 100f) * 0.75f;
			}
			return effectiveSkill;
		}

		// Token: 0x060001B1 RID: 433
		public static float CalculateSkillModifier(float effectiveSkill)
		{
			float num3 = 0.5f;
			float num2 = effectiveSkill / 100f * 0.25f;
			return TaleWorlds.Library.MathF.Min(num3 + num2, 1f);
		}

		// Token: 0x060001B2 RID: 434
		public static void CalculateVisualSpeeds(MissionWeapon weapon, int weaponUsageIndex, float effectiveSkillDR, out int swingSpeedReal, out int thrustSpeedReal, out int handlingReal)
		{
			swingSpeedReal = weapon.GetModifiedSwingSpeedForCurrentUsage();
			thrustSpeedReal = weapon.GetModifiedThrustSpeedForCurrentUsage();
			handlingReal = weapon.GetModifiedHandlingForCurrentUsage();
		}

		// Token: 0x060001B3 RID: 435
		public static float CalculateDetailedThrustSpeed(float weaponWeight, float inertia, float com)
		{
			float num5 = 50f;
			float num2 = 1f - weaponWeight * 0.05f;
			float num3 = 1f - inertia * 1f;
			float num4 = 1f - com * 0.2f;
			return TaleWorlds.Library.MathF.Max(num5 * num2 * num3 * num4, 30f);
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060001B4 RID: 436
		private static float OneHandedPolearmThrustStrength
		{
			get
			{
				return AhFightConfig.oneHandedPolearmThrustStrength;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060001B5 RID: 437
		private static float TwoHandedPolearmThrustStrength
		{
			get
			{
				return AhFightConfig.twoHandedPolearmThrustStrength;
			}
		}

		// Token: 0x060001B6 RID: 438
		public static float CalculateThrustMagnitudeForOneHandedWeapon(float weaponWeight, float effectiveSkill, float thrustSpeed, float extraLinearSpeed, Agent.UsageDirection attackDirection)
		{
			float oneHandedPolearmThrustStrength = WeaponCalculator.OneHandedPolearmThrustStrength;
			float num = WeaponCalculator.CalculateSkillModifier(effectiveSkill);
			float num2 = oneHandedPolearmThrustStrength * num * (1f + weaponWeight * 0.3f);
			num2 *= thrustSpeed / 100f;
			if (attackDirection == Agent.UsageDirection.AttackUp)
			{
				num2 *= 1.5f;
			}
			num2 += 10f;
			return TaleWorlds.Library.MathF.Min(num2, 100f);
		}

		// Token: 0x060001B7 RID: 439
		public static float CalculateThrustMagnitudeForTwoHandedWeapon(float weaponWeight, float effectiveSkill, float thrustSpeed, float extraLinearSpeed, Agent.UsageDirection attackDirection)
		{
			float twoHandedPolearmThrustStrength = WeaponCalculator.TwoHandedPolearmThrustStrength;
			float num = WeaponCalculator.CalculateSkillModifier(effectiveSkill);
			float num2 = twoHandedPolearmThrustStrength * num * (1f + weaponWeight * 0.4f);
			num2 *= thrustSpeed / 100f;
			if (attackDirection == Agent.UsageDirection.AttackUp)
			{
				num2 *= 1.5f;
			}
			num2 += 15f;
			return TaleWorlds.Library.MathF.Min(num2, 150f);
		}

		// Token: 0x060001B8 RID: 440
		public static float GetComHitModifier(in AttackCollisionData collisionData, in MissionWeapon weapon)
		{
			MissionWeapon missionWeapon = weapon;
			if (missionWeapon.CurrentUsageItem == null)
			{
				return 0f;
			}
			AttackCollisionData attackCollisionData = collisionData;
			float collisionDistanceOnWeapon = attackCollisionData.CollisionDistanceOnWeapon;
			missionWeapon = weapon;
			float realWeaponLength = missionWeapon.CurrentUsageItem.GetRealWeaponLength();
			if (realWeaponLength <= 0f)
			{
				return 0f;
			}
			float num = collisionDistanceOnWeapon / realWeaponLength;
			float num2 = TaleWorlds.Library.MathF.Max(0f, 1f - TaleWorlds.Library.MathF.Abs(num - 0.5f) * 2f);
			attackCollisionData = collisionData;
			if (attackCollisionData.StrikeType == 1 && num2 < 0.2f)
			{
				num2 = 0.2f;
			}
			return num2;
		}

		// Token: 0x060001B9 RID: 441
		public static bool HitWithWeaponBlade(in AttackCollisionData collisionData, in MissionWeapon weapon)
		{
			MissionWeapon missionWeapon = weapon;
			if (missionWeapon.CurrentUsageItem != null)
			{
				missionWeapon = weapon;
				ItemObject item = missionWeapon.Item;
				bool flag;
				if (item == null)
				{
					flag = false;
				}
				else
				{
					WeaponDesign weaponDesign = item.WeaponDesign;
					flag = ((weaponDesign != null) ? weaponDesign.UsedPieces : null) != null;
				}
				if (flag)
				{
					missionWeapon = weapon;
					if (missionWeapon.Item.WeaponDesign.UsedPieces.Length != 0)
					{
						missionWeapon = weapon;
						bool flag2;
						if (missionWeapon.CurrentUsageItem.WeaponClass != WeaponClass.Dagger)
						{
							missionWeapon = weapon;
							if (missionWeapon.CurrentUsageItem.WeaponClass != WeaponClass.OneHandedSword)
							{
								missionWeapon = weapon;
								flag2 = missionWeapon.CurrentUsageItem.WeaponClass == WeaponClass.TwoHandedSword;
								goto IL_B3;
							}
						}
						flag2 = true;
						IL_B3:
						bool flag3 = flag2;
						missionWeapon = weapon;
						float num = missionWeapon.Item.WeaponDesign.UsedPieces[0].ScaledBladeLength + (flag3 ? 0f : 0.15f);
						missionWeapon = weapon;
						float realWeaponLength = missionWeapon.CurrentUsageItem.GetRealWeaponLength();
						AttackCollisionData attackCollisionData = collisionData;
						return attackCollisionData.CollisionDistanceOnWeapon >= realWeaponLength - num;
					}
				}
			}
			return true;
		}

		// Token: 0x060001BA RID: 442
		public static bool HitWithWeaponBladeTip(in AttackCollisionData collisionData, in MissionWeapon weapon)
		{
			MissionWeapon missionWeapon = weapon;
			if (missionWeapon.CurrentUsageItem == null)
			{
				return false;
			}
			missionWeapon = weapon;
			float realWeaponLength = missionWeapon.CurrentUsageItem.GetRealWeaponLength();
			AttackCollisionData attackCollisionData = collisionData;
			return attackCollisionData.CollisionDistanceOnWeapon > realWeaponLength * 0.95f;
		}

		// Token: 0x060001BB RID: 443
		public static float CalculateDismountChance(Agent agent, WeaponClass attackerWeaponClass, BoneBodyPartType hitBodyPart, float ahFightPercentage)
		{
			if (agent == null)
			{
				return AhFightConfig.baseDismountChance;
			}
			float effectiveSkillWithDR = WeaponCalculator.GetEffectiveSkillWithDR((float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(agent, DefaultSkills.Riding));
			float num = AhFightConfig.baseDismountChance;
			switch (attackerWeaponClass)
			{
			case WeaponClass.TwoHandedAxe:
			case WeaponClass.TwoHandedMace:
				num *= AhFightConfig.heavyWeaponDismountModifier;
				goto IL_69;
			case WeaponClass.OneHandedPolearm:
			case WeaponClass.TwoHandedPolearm:
				num *= AhFightConfig.polearmDismountModifier;
				goto IL_69;
			}
			num *= AhFightConfig.otherWeaponDismountModifier;
			IL_69:
			if (hitBodyPart != BoneBodyPartType.Head)
			{
				if (hitBodyPart - BoneBodyPartType.Chest > 1)
				{
					if (hitBodyPart != BoneBodyPartType.Legs)
					{
						num *= AhFightConfig.otherHitDismountModifier;
					}
					else
					{
						num *= AhFightConfig.legHitDismountModifier;
					}
				}
				else
				{
					num *= AhFightConfig.bodyHitDismountModifier;
				}
			}
			else
			{
				num *= AhFightConfig.headHitDismountModifier;
			}
			float num2 = effectiveSkillWithDR * AhFightConfig.ridingSkillDismountResistance;
			num *= 1f - num2;
			if (ahFightPercentage < AhFightConfig.lowAhFightDismountThreshold)
			{
				num *= 1f + (AhFightConfig.lowAhFightDismountThreshold - ahFightPercentage) * AhFightConfig.lowAhFightDismountMultiplier;
			}
			return TaleWorlds.Library.MathF.Clamp(num, AhFightConfig.minDismountChance, AhFightConfig.maxDismountChance);
		}

		// Token: 0x060001BC RID: 444
		public static void LogPlayerWeaponCalculation(Agent agent, MissionWeapon weapon, float effectiveSkill, float thrustSpeed, float magnitude, string context)
		{
			if (agent != null && agent.IsPlayerControlled)
			{
				ItemObject item = weapon.Item;
				if (item != null)
				{
					TextObject name = item.Name;
					if (name != null)
					{
						name.ToString();
					}
				}
				WeaponComponentData currentUsageItem = weapon.CurrentUsageItem;
				if (currentUsageItem != null)
				{
					currentUsageItem.WeaponClass.ToString();
				}
				weapon.GetWeight();
				WeaponComponentData currentUsageItem2 = weapon.CurrentUsageItem;
				if (currentUsageItem2 == null)
				{
					return;
				}
				currentUsageItem2.GetRealWeaponLength();
			}
		}

		// Token: 0x060001BD RID: 445
		public static void LogPlayerStanceLoss(Agent agent, float stanceLoss, float baseLoss, float weaponModifier, float skillModifier, float hitModifier, string context)
		{
		}

		// Token: 0x040000C1 RID: 193
		private const string MODULE_NAME = "WeaponCalc";
	}
}
