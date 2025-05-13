using System;
using System.Collections.Generic;
using AhFight.Combat;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace AhFight
{
	// Token: 0x02000003 RID: 3
	public static class AhFightBlow
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002A18 File Offset: 0x00000C18
		public static void MakeBlowEffect(ref Mission mission, Agent attackerAgent, Agent victimAgent, ref AttackCollisionData collisionData, in MissionWeapon attackerWeapon, Vec3 blowDirection, Vec3 swingDirection, string attackKey)
		{
			if (mission == null || attackerAgent == null || victimAgent == null || string.IsNullOrEmpty(attackKey))
			{
				return;
			}
			if (AhFightAgent.values == null)
			{
				return;
			}
			if (!attackerAgent.IsActive() || !victimAgent.IsActive())
			{
				return;
			}
			AhFightCacheManager.CleanupCache(mission.CurrentTime);
			Blow blow = new Blow(attackerAgent.Index);
			if (attackerAgent.Monster == null)
			{
				return;
			}
			blow.StrikeType = (StrikeType)collisionData.StrikeType;
			blow.BoneIndex = collisionData.CollisionBoneIndex;
			blow.GlobalPosition = collisionData.CollisionGlobalPosition;
			blow.VictimBodyPart = collisionData.VictimHitBodyPart;
			MissionWeapon missionWeapon = attackerWeapon;
			if (!missionWeapon.IsEmpty)
			{
				missionWeapon = attackerWeapon;
				if (missionWeapon.Item == null)
				{
					return;
				}
			}
			missionWeapon = attackerWeapon;
			ItemObject item = missionWeapon.Item;
			missionWeapon = attackerWeapon;
			WeaponComponentData currentUsageItem = missionWeapon.CurrentUsageItem;
			int affectorWeaponSlotOrMissileIndex = collisionData.AffectorWeaponSlotOrMissileIndex;
			missionWeapon = attackerWeapon;
			sbyte b;
			if (!missionWeapon.IsEmpty)
			{
				Monster monster = attackerAgent.Monster;
				missionWeapon = attackerWeapon;
				b = monster.GetBoneToAttachForItemFlags(missionWeapon.Item.ItemFlags);
			}
			else
			{
				b = -1;
			}
			blow.WeaponRecord.FillAsMeleeBlow(item, currentUsageItem, affectorWeaponSlotOrMissileIndex, b);
			blow.NoIgnore = true;
			WeaponComponentData weaponComponentData = null;
			missionWeapon = attackerWeapon;
			if (!missionWeapon.IsEmpty)
			{
				missionWeapon = attackerWeapon;
				weaponComponentData = missionWeapon.GetWeaponComponentDataForUsage(attackerWeapon.CurrentUsageIndex);
			}
			if (!attackerAgent.IsPlayerControlled)
			{
				bool isPlayerControlled = victimAgent.IsPlayerControlled;
			}
			if (collisionData.CollisionResult == CombatCollisionResult.Parried)
			{
				missionWeapon = attackerWeapon;
				if (!missionWeapon.IsEmpty)
				{
					AhFightData ahFightData;
					AhFightData ahFightData2;
					if (!AhFightAgent.values.TryGetValue(attackerAgent, out ahFightData) || !AhFightAgent.values.TryGetValue(victimAgent, out ahFightData2) || ahFightData == null || ahFightData2 == null)
					{
						return;
					}
					bool attackBlockedWithShield = collisionData.AttackBlockedWithShield;
					if (attackBlockedWithShield)
					{
						float num = 0f;
						if (victimAgent != null)
						{
							MissionGameModels missionGameModels = MissionGameModels.Current;
							if (((missionGameModels != null) ? missionGameModels.AgentStatCalculateModel : null) != null)
							{
								num = (float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(victimAgent, DefaultSkills.OneHanded);
							}
						}
						float num2 = WeaponCalculator.CalculateSkillModifier(WeaponCalculator.GetEffectiveSkillWithDR(num));
						bool flag;
						if (AhFightCacheManager.GetPerfectBlockResult(attackKey))
						{
							float num3 = AhFightCacheManager.GetRandomValue(attackKey);
							flag = true;
						}
						else
						{
							float num3 = AhFightCacheManager.GetRandomValue(attackKey);
							float perfectBlockBaseChance = AhFightConfig.perfectBlockBaseChance;
							float num4 = num2 * AhFightConfig.perfectBlockSkillBonusMax;
							float num5 = 1f;
							switch (collisionData.AttackDirection)
							{
							case Agent.UsageDirection.AttackUp:
								num5 = AhFightConfig.overheadAttackBlockModifier;
								break;
							case Agent.UsageDirection.AttackDown:
								num5 = AhFightConfig.thrustAttackBlockModifier;
								break;
							case Agent.UsageDirection.AttackLeft:
							case Agent.UsageDirection.AttackRight:
								num5 = AhFightConfig.sideAttackBlockModifier;
								break;
							}
							float num6 = 1f;
							if (weaponComponentData != null)
							{
								switch (weaponComponentData.WeaponClass)
								{
								case WeaponClass.TwoHandedSword:
								case WeaponClass.TwoHandedPolearm:
									num6 = AhFightConfig.twoHandedBlockModifier;
									break;
								case WeaponClass.OneHandedAxe:
								case WeaponClass.Mace:
									num6 = AhFightConfig.oneHandedBluntBlockModifier;
									break;
								case WeaponClass.TwoHandedAxe:
								case WeaponClass.TwoHandedMace:
									num6 = AhFightConfig.twoHandedHeavyBlockModifier;
									break;
								}
							}
							float num7 = 1f;
							if (WeaponCalculator.HitWithWeaponBladeTip(collisionData, attackerWeapon))
							{
								num7 = AhFightConfig.weaponTipBlockModifier;
							}
							else if (WeaponCalculator.HitWithWeaponBlade(collisionData, attackerWeapon))
							{
								num7 = AhFightConfig.weaponBladeBlockModifier;
							}
							float num8 = (perfectBlockBaseChance + num4) * num5 * num6 * num7;
							num8 = TaleWorlds.Library.MathF.Clamp(num8, 0.01f, 0.3f);
							flag = num3 < num8;
							AhFightCacheManager.SetPerfectBlockResult(attackKey, flag);
						}
						if (!flag)
						{
							return;
						}
					}
					float num9 = ahFightData.ahfight / ahFightData.maxAhFight;
					float num10 = ahFightData2.ahfight / ahFightData2.maxAhFight;
					float num11 = AhFightConfig.baseWeaponDropChance;
					if (attackBlockedWithShield)
					{
						num11 *= AhFightConfig.shieldBlockDropModifier;
					}
					if (num9 < 0.5f)
					{
						num11 += (0.5f - num9) * AhFightConfig.attackerStanceDropModifier;
					}
					if (num10 > 0.5f)
					{
						num11 += (num10 - 0.5f) * AhFightConfig.defenderStanceDropModifier;
					}
					float num12 = 0f;
					if (weaponComponentData != null)
					{
						MissionGameModels missionGameModels2 = MissionGameModels.Current;
						if (((missionGameModels2 != null) ? missionGameModels2.AgentStatCalculateModel : null) != null)
						{
							SkillObject relevantSkillFromWeaponClass = WeaponComponentData.GetRelevantSkillFromWeaponClass(weaponComponentData.WeaponClass);
							if (relevantSkillFromWeaponClass != null)
							{
								float num13 = (float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(attackerAgent, relevantSkillFromWeaponClass);
								float num14 = (float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(victimAgent, relevantSkillFromWeaponClass);
								float effectiveSkillWithDR = WeaponCalculator.GetEffectiveSkillWithDR(num13);
								float effectiveSkillWithDR2 = WeaponCalculator.GetEffectiveSkillWithDR(num14);
								float num15 = WeaponCalculator.CalculateSkillModifier(effectiveSkillWithDR);
								float num16 = WeaponCalculator.CalculateSkillModifier(effectiveSkillWithDR2) - num15;
								num12 = (float)TaleWorlds.Library.MathF.Sign(num16) * TaleWorlds.Library.MathF.Sqrt(TaleWorlds.Library.MathF.Abs(num16)) * AhFightConfig.skillDifferenceDropModifier;
								num12 = TaleWorlds.Library.MathF.Clamp(num12, -AhFightConfig.maxSkillDifferenceEffect, AhFightConfig.maxSkillDifferenceEffect);
							}
						}
					}
					float num17 = 0f;
					if (weaponComponentData != null)
					{
						switch (weaponComponentData.WeaponClass)
						{
						case WeaponClass.Dagger:
							num17 = AhFightConfig.daggerDropModifier;
							break;
						case WeaponClass.OneHandedSword:
							num17 = AhFightConfig.oneHandedSwordDropModifier;
							break;
						case WeaponClass.TwoHandedSword:
							num17 = AhFightConfig.twoHandedSwordDropModifier;
							break;
						case WeaponClass.OneHandedAxe:
						case WeaponClass.TwoHandedAxe:
							num17 = AhFightConfig.axeDropModifier;
							break;
						case WeaponClass.Mace:
						case WeaponClass.TwoHandedMace:
							num17 = AhFightConfig.bluntDropModifier;
							break;
						}
					}
					float comHitModifier = WeaponCalculator.GetComHitModifier(collisionData, attackerWeapon);
					float num18;
					if (WeaponCalculator.HitWithWeaponBladeTip(collisionData, attackerWeapon))
					{
						num18 = AhFightConfig.weaponTipDropModifier;
					}
					else if (WeaponCalculator.HitWithWeaponBlade(collisionData, attackerWeapon))
					{
						num18 = AhFightConfig.weaponBladeDropModifier;
					}
					else
					{
						num18 = AhFightConfig.weaponHandleDropModifier;
					}
					float num19 = num17 + num18 + comHitModifier * 0.2f;
					float num20 = num11 + num12 + num19;
					if (attackerAgent.HasMount)
					{
						num20 *= AhFightConfig.mountedDropResistance;
						num20 = TaleWorlds.Library.MathF.Clamp(num20, AhFightConfig.minPerfectBlockDropChance, AhFightConfig.mountedMaxDropChance);
					}
					else
					{
						num20 = TaleWorlds.Library.MathF.Clamp(num20, AhFightConfig.minPerfectBlockDropChance, AhFightConfig.maxWeaponDropChance);
					}
					float randomValue = AhFightCacheManager.GetRandomValue(attackKey);
					if (victimAgent.Monster == null)
					{
						return;
					}
					if (victimAgent.WieldedWeapon.IsEmpty)
					{
						return;
					}
					if (victimAgent.WieldedWeapon.Item == null || victimAgent.WieldedWeapon.CurrentUsageItem == null)
					{
						return;
					}
					Blow blow2 = new Blow(victimAgent.Index);
					blow2.StrikeType = StrikeType.Swing;
					blow2.GlobalPosition = collisionData.CollisionGlobalPosition;
					blow2.BoneIndex = collisionData.CollisionBoneIndex;
					blow2.Direction = -blowDirection;
					blow2.SwingDirection = -swingDirection;
					blow2.WeaponRecord.FillAsMeleeBlow(victimAgent.WieldedWeapon.Item, victimAgent.WieldedWeapon.CurrentUsageItem, 0, (sbyte)(victimAgent.WieldedWeapon.IsEmpty ? -1 : victimAgent.Monster.GetBoneToAttachForItemFlags(victimAgent.WieldedWeapon.Item.ItemFlags)));
					blow2.NoIgnore = true;
					blow2.InflictedDamage = 0;
					blow2.DamageCalculated = true;
					bool flag2 = false;
					bool flag3 = false;
					if (randomValue < num20)
					{
						if (!AhFightMissionLogic.agentsToDropWeapon.Contains(attackerAgent))
						{
							AhFightMissionLogic.agentsToDropWeapon.Add(attackerAgent);
							flag2 = true;
							flag3 = true;
							float num21 = (attackBlockedWithShield ? AhFightConfig.shieldPerfectBlockStanceBonus : AhFightConfig.perfectBlockStanceBonus);
							float ahfight = ahFightData2.ahfight;
							ahFightData2.ahfight = Math.Min(ahFightData2.maxAhFight, ahFightData2.ahfight + ahFightData2.maxAhFight * num21);
						}
					}
					else
					{
						float num22 = AhFightConfig.baseKnockbackChance;
						if (attackBlockedWithShield)
						{
							num22 *= AhFightConfig.shieldBlockKnockbackModifier;
						}
						if (num9 < 0.5f)
						{
							num22 += (0.5f - num9) * AhFightConfig.attackerStanceKnockbackModifier;
						}
						if (num10 > 0.5f)
						{
							num22 += (num10 - 0.5f) * AhFightConfig.defenderStanceKnockbackModifier;
						}
						if (num12 != 0f)
						{
							num22 += num12 * AhFightConfig.skillDifferenceKnockbackModifier;
						}
						num22 = TaleWorlds.Library.MathF.Clamp(num22, AhFightConfig.minKnockbackChance, AhFightConfig.maxKnockbackChance);
						if (randomValue < num22)
						{
							flag2 = true;
							flag3 = false;
						}
					}
					if (flag2)
					{
						blow2.BlowFlag = BlowFlags.KnockBack | BlowFlags.ShrugOff;
						blow2.DamageType = DamageTypes.Blunt;
						blow2.InflictedDamage = (flag3 ? 5 : 0);
						blow2.DamageCalculated = true;
						attackerAgent.RegisterBlow(blow2, collisionData);
						goto IL_C0D;
					}
					goto IL_C0D;
				}
			}
			AhFightData ahFightData6;
			if (victimAgent.HasMount)
			{
				AhFightData ahFightData3;
				if (weaponComponentData != null && collisionData.CollisionResult != CombatCollisionResult.Parried && AhFightAgent.values.TryGetValue(victimAgent, out ahFightData3))
				{
					float num23 = ahFightData3.ahfight / ahFightData3.maxAhFight;
					float num24 = WeaponCalculator.CalculateDismountChance(victimAgent, weaponComponentData.WeaponClass, collisionData.VictimHitBodyPart, num23);
					if (collisionData.CollisionResult == CombatCollisionResult.Blocked)
					{
						num24 *= AhFightConfig.blockDismountChanceModifier;
					}
					float num25;
					if (AhFightBlow.lastRandomValues.ContainsKey(attackKey))
					{
						num25 = AhFightBlow.lastRandomValues[attackKey];
					}
					else
					{
						num25 = (float)AhFightBlow.sharedRandom.NextDouble();
						AhFightBlow.lastRandomValues[attackKey] = num25;
					}
					if (num25 < num24)
					{
						blow.BlowFlag = BlowFlags.CanDismount;
						blow.Direction = blowDirection;
						blow.SwingDirection = swingDirection;
						blow.DamageType = DamageTypes.Blunt;
						blow.InflictedDamage = 8;
						blow.DamageCalculated = true;
						blow.DefenderStunPeriod = collisionData.DefenderStunPeriod;
						blow.MovementSpeedDamageModifier = collisionData.MovementSpeedDamageModifier;
						blow.BaseMagnitude = collisionData.BaseMagnitude;
						MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(victimAgent, DefaultSkills.Riding);
					}
				}
			}
			else if (collisionData.VictimHitBodyPart == BoneBodyPartType.Legs && (collisionData.AttackDirection == Agent.UsageDirection.AttackLeft || collisionData.AttackDirection == Agent.UsageDirection.AttackRight) && collisionData.CollisionResult != CombatCollisionResult.Blocked && collisionData.CollisionResult != CombatCollisionResult.Parried && (weaponComponentData.WeaponClass == WeaponClass.TwoHandedAxe || weaponComponentData.WeaponClass == WeaponClass.TwoHandedMace || weaponComponentData.WeaponClass == WeaponClass.TwoHandedPolearm || weaponComponentData.WeaponClass == WeaponClass.TwoHandedSword || weaponComponentData.WeaponClass == WeaponClass.TwoHandedMace || weaponComponentData.WeaponClass == WeaponClass.Mace))
			{
				AhFightData ahFightData4;
				if (AhFightAgent.values.TryGetValue(victimAgent, out ahFightData4) && ahFightData4.ahfight < AhFightConfig.legHitKnockDownThreshold)
				{
					blow.BlowFlag = BlowFlags.KnockDown;
					blow.DamageType = DamageTypes.Blunt;
					blow.Direction = blowDirection;
					blow.SwingDirection = swingDirection;
					blow.InflictedDamage = 0;
					blow.DamageCalculated = true;
				}
			}
			else if (weaponComponentData != null && (weaponComponentData.WeaponClass == WeaponClass.TwoHandedAxe || weaponComponentData.WeaponClass == WeaponClass.TwoHandedMace || weaponComponentData.WeaponClass == WeaponClass.TwoHandedPolearm || weaponComponentData.WeaponClass == WeaponClass.TwoHandedSword))
			{
				AhFightData ahFightData5;
				if (AhFightAgent.values != null && AhFightAgent.values.TryGetValue(victimAgent, out ahFightData5) && ahFightData5 != null && ahFightData5.maxAhFight > 0f)
				{
					float num26 = ahFightData5.ahfight / ahFightData5.maxAhFight;
					float num27;
					if (AhFightBlow.lastRandomValues.ContainsKey(attackKey))
					{
						num27 = AhFightBlow.lastRandomValues[attackKey];
					}
					else
					{
						num27 = (float)AhFightBlow.sharedRandom.NextDouble();
						AhFightBlow.lastRandomValues[attackKey] = num27;
					}
					float num28 = AhFightConfig.heavyWeaponKnockDownBaseChance;
					float num29 = AhFightConfig.heavyWeaponKnockBackBaseChance;
					if (num26 < AhFightConfig.lowAhFightEffectThreshold)
					{
						float num30 = (AhFightConfig.lowAhFightEffectThreshold - num26) * AhFightConfig.lowAhFightEffectMultiplier;
						num28 += num30;
						num29 += num30;
					}
					num28 = TaleWorlds.Library.MathF.Min(num28, AhFightConfig.maxEffectChance);
					num29 = TaleWorlds.Library.MathF.Min(num29, AhFightConfig.maxEffectChance);
					bool flag4 = true;
					if (ahFightData5.maxAhFight >= 120f && AhFightStateManager.GetCurrentState(victimAgent) == AhFightState.Normal)
					{
						flag4 = false;
					}
					if (flag4 && num27 < num28)
					{
						blow.BlowFlag = BlowFlags.KnockDown;
						blow.DamageType = DamageTypes.Blunt;
						blow.Direction = blowDirection;
						blow.SwingDirection = swingDirection;
						blow.InflictedDamage = 0;
						blow.DamageCalculated = true;
						string.Format("击倒(概率:{0:P0})", num28);
					}
					else if (num27 < num29)
					{
						blow.BlowFlag = BlowFlags.KnockBack;
						blow.Direction = blowDirection;
						blow.SwingDirection = swingDirection;
						blow.DamageType = DamageTypes.Blunt;
						blow.InflictedDamage = 0;
						blow.DamageCalculated = true;
						string.Format("击退(概率:{0:P0})", num29);
					}
				}
			}
			else if (weaponComponentData != null && AhFightAgent.values != null && AhFightAgent.values.TryGetValue(victimAgent, out ahFightData6) && ahFightData6 != null && ahFightData6.maxAhFight > 0f)
			{
				float num31 = ahFightData6.ahfight / ahFightData6.maxAhFight;
				float num32;
				if (AhFightBlow.lastRandomValues.ContainsKey(attackKey))
				{
					num32 = AhFightBlow.lastRandomValues[attackKey];
				}
				else
				{
					num32 = (float)AhFightBlow.sharedRandom.NextDouble();
					AhFightBlow.lastRandomValues[attackKey] = num32;
				}
				float num33 = AhFightConfig.normalWeaponKnockBackBaseChance;
				if (num31 < AhFightConfig.lowAhFightEffectThreshold)
				{
					num33 += (AhFightConfig.lowAhFightEffectThreshold - num31) * AhFightConfig.lowAhFightEffectMultiplier;
				}
				num33 = TaleWorlds.Library.MathF.Min(num33, AhFightConfig.maxEffectChance);
				if (num32 < num33)
				{
					blow.BlowFlag = BlowFlags.KnockBack;
					blow.Direction = blowDirection;
					blow.SwingDirection = swingDirection;
					blow.DamageType = DamageTypes.Blunt;
					blow.InflictedDamage = 0;
					blow.DamageCalculated = true;
					string.Format("击退(概率:{0:P0})", num33);
				}
			}
			IL_C0D:
			if (blow.BlowFlag != BlowFlags.None && victimAgent != null)
			{
				victimAgent.RegisterBlow(blow, collisionData);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003648 File Offset: 0x00001848
		public static void MakeStanceBreakEffect(Agent exhaustedAgent, Agent otherAgent, ref AttackCollisionData collisionData, Vec3 blowDirection, Vec3 swingDirection)
		{
			if (exhaustedAgent == null || otherAgent == null || exhaustedAgent.Monster == null)
			{
				return;
			}
			if (!exhaustedAgent.IsActive() || !otherAgent.IsActive())
			{
				return;
			}
			Blow blow = new Blow(otherAgent.Index);
			blow.StrikeType = StrikeType.Swing;
			blow.BoneIndex = collisionData.CollisionBoneIndex;
			blow.GlobalPosition = collisionData.CollisionGlobalPosition;
			blow.Direction = -blowDirection;
			blow.SwingDirection = -swingDirection;
			if (!otherAgent.WieldedWeapon.IsEmpty)
			{
				if (otherAgent.Monster != null && otherAgent.WieldedWeapon.Item != null)
				{
					if (otherAgent.WieldedWeapon.CurrentUsageItem == null)
					{
						return;
					}
					blow.WeaponRecord.FillAsMeleeBlow(otherAgent.WieldedWeapon.Item, otherAgent.WieldedWeapon.CurrentUsageItem, 0, otherAgent.Monster.GetBoneToAttachForItemFlags(otherAgent.WieldedWeapon.Item.ItemFlags));
				}
			}
			else if (!exhaustedAgent.WieldedWeapon.IsEmpty && exhaustedAgent.WieldedWeapon.Item != null)
			{
				if (exhaustedAgent.WieldedWeapon.CurrentUsageItem == null)
				{
					return;
				}
				blow.WeaponRecord.FillAsMeleeBlow(exhaustedAgent.WieldedWeapon.Item, exhaustedAgent.WieldedWeapon.CurrentUsageItem, 0, exhaustedAgent.Monster.GetBoneToAttachForItemFlags(exhaustedAgent.WieldedWeapon.Item.ItemFlags));
			}
			blow.BlowFlag = BlowFlags.ShrugOff;
			blow.BaseMagnitude = collisionData.BaseMagnitude;
			blow.DamageType = DamageTypes.Blunt;
			blow.NoIgnore = true;
			blow.InflictedDamage = 1;
			blow.DamageCalculated = true;
			if (exhaustedAgent != null && exhaustedAgent.IsActive())
			{
				exhaustedAgent.RegisterBlow(blow, collisionData);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000380C File Offset: 0x00001A0C
		public static void MakeMissileHitEffect(Agent attackerAgent, Agent victimAgent, ref AttackCollisionData collisionData, in MissionWeapon attackerWeapon, Vec3 blowDirection, Vec3 swingDirection)
		{
			if (attackerAgent == null || victimAgent == null || !collisionData.IsMissile)
			{
				return;
			}
			if (!attackerAgent.IsActive() || !victimAgent.IsActive())
			{
				return;
			}
			MissionWeapon missionWeapon = attackerWeapon;
			if (missionWeapon.IsEmpty)
			{
				return;
			}
			missionWeapon = attackerWeapon;
			WeaponComponentData weaponComponentDataForUsage = missionWeapon.GetWeaponComponentDataForUsage(attackerWeapon.CurrentUsageIndex);
			if (weaponComponentDataForUsage == null)
			{
				return;
			}
			if (weaponComponentDataForUsage.WeaponClass == WeaponClass.ThrowingKnife || weaponComponentDataForUsage.WeaponClass == WeaponClass.Stone)
			{
				return;
			}
			missionWeapon = attackerWeapon;
			if (!missionWeapon.IsEmpty)
			{
				missionWeapon = attackerWeapon;
				if (missionWeapon.Item == null)
				{
					return;
				}
			}
			missionWeapon = attackerWeapon;
			if (!missionWeapon.IsEmpty)
			{
				missionWeapon = attackerWeapon;
				if (missionWeapon.CurrentUsageItem == null)
				{
					return;
				}
			}
			Blow blow = new Blow(attackerAgent.Index);
			missionWeapon = attackerWeapon;
			if (missionWeapon.Item != null)
			{
				missionWeapon = attackerWeapon;
				ItemObject item = missionWeapon.Item;
				missionWeapon = attackerWeapon;
				blow.WeaponRecord.FillAsMissileBlow(item, missionWeapon.CurrentUsageItem, collisionData.AffectorWeaponSlotOrMissileIndex, collisionData.CollisionBoneIndex, collisionData.MissileStartingPosition, collisionData.CollisionGlobalPosition, collisionData.MissileVelocity);
			}
			blow.BoneIndex = collisionData.CollisionBoneIndex;
			blow.GlobalPosition = collisionData.CollisionGlobalPosition;
			blow.VictimBodyPart = collisionData.VictimHitBodyPart;
			blow.Direction = blowDirection;
			blow.SwingDirection = swingDirection;
			blow.DamageType = DamageTypes.Blunt;
			blow.NoIgnore = true;
			blow.InflictedDamage = 0;
			blow.DamageCalculated = true;
			blow.BaseMagnitude = collisionData.BaseMagnitude;
			blow.MovementSpeedDamageModifier = collisionData.MovementSpeedDamageModifier;
			blow.AbsorbedByArmor = (float)collisionData.AbsorbedByArmor;
			blow.DefenderStunPeriod = collisionData.DefenderStunPeriod;
			MissionGameModels missionGameModels = MissionGameModels.Current;
			if (((missionGameModels != null) ? missionGameModels.AgentApplyDamageModel : null) == null)
			{
				return;
			}
			if (!MissionGameModels.Current.AgentApplyDamageModel.DecideAgentKnockedBackByBlow(attackerAgent, victimAgent, collisionData, weaponComponentDataForUsage, blow))
			{
				float totalEncumbrance = victimAgent.GetTotalEncumbrance();
				float num = AhFightConfig.rangedBaseResistance;
				if (totalEncumbrance > 0f)
				{
					num += TaleWorlds.Library.MathF.Min(0.75f, 0.5f * TaleWorlds.Library.MathF.Log10(1f + totalEncumbrance / 10f));
				}
				float num2 = 0f;
				if (victimAgent.HasMount)
				{
					float num3 = 0f;
					MissionGameModels missionGameModels2 = MissionGameModels.Current;
					if (((missionGameModels2 != null) ? missionGameModels2.AgentStatCalculateModel : null) != null)
					{
						num3 = (float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(victimAgent, DefaultSkills.Riding);
					}
					num2 = TaleWorlds.Library.MathF.Min(0.5f, num3 / 300f);
				}
				if (victimAgent.HasMount)
				{
					float num4 = num + num2;
					float num5 = AhFightConfig.rangedMaxEffectChance * (1f - TaleWorlds.Library.MathF.Min(0.95f, num4));
					if (AhFightAgent.values == null)
					{
						return;
					}
					AhFightData ahFightData;
					if (!AhFightAgent.values.TryGetValue(victimAgent, out ahFightData) || ahFightData == null)
					{
						if (false && Mission.Current != null && AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_{2}_effect", attackerAgent.Index, victimAgent.Index, Math.Floor((double)(Mission.Current.CurrentTime * 10f)) / 10.0)) < num5)
						{
							blow.BlowFlag = BlowFlags.CanDismount;
						}
					}
					else if (AhFightStateManager.GetCurrentState(victimAgent) != AhFightState.Normal && Mission.Current != null && AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_{2}_effect", attackerAgent.Index, victimAgent.Index, Math.Floor((double)(Mission.Current.CurrentTime * 10f)) / 10.0)) < num5)
					{
						blow.BlowFlag = BlowFlags.CanDismount;
					}
				}
				else
				{
					float num6 = AhFightConfig.rangedMaxEffectChance * (1f - num);
					if (AhFightAgent.values == null)
					{
						return;
					}
					AhFightData ahFightData2;
					if (!AhFightAgent.values.TryGetValue(victimAgent, out ahFightData2) || ahFightData2 == null)
					{
						AhFightState ahFightState = AhFightState.Normal;
						if (Mission.Current != null && AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_{2}_effect", attackerAgent.Index, victimAgent.Index, Math.Floor((double)(Mission.Current.CurrentTime * 10f)) / 10.0)) < num6)
						{
							if (ahFightState > AhFightState.Weak)
							{
								if (ahFightState - AhFightState.Tired <= 1)
								{
									blow.BlowFlag = BlowFlags.KnockDown;
								}
							}
							else
							{
								blow.BlowFlag = BlowFlags.KnockBack;
							}
						}
					}
					else
					{
						AhFightState currentState = AhFightStateManager.GetCurrentState(victimAgent);
						if (Mission.Current != null && AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_{2}_effect", attackerAgent.Index, victimAgent.Index, Math.Floor((double)(Mission.Current.CurrentTime * 10f)) / 10.0)) < num6)
						{
							if (currentState > AhFightState.Weak)
							{
								if (currentState - AhFightState.Tired <= 1)
								{
									blow.BlowFlag = BlowFlags.KnockDown;
								}
							}
							else
							{
								blow.BlowFlag = BlowFlags.KnockBack;
							}
						}
					}
				}
			}
			if (victimAgent != null && victimAgent.IsActive())
			{
				victimAgent.RegisterBlow(blow, collisionData);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003CE5 File Offset: 0x00001EE5
		public static bool IsPerfectShieldBlock(string attackKey)
		{
			return !string.IsNullOrEmpty(attackKey) && AhFightCacheManager.GetPerfectBlockResult(attackKey);
		}

		// Token: 0x04000022 RID: 34
		private const string MODULE_NAME = "AhFightBlow";

		// Token: 0x04000023 RID: 35
		private static Random sharedRandom = new Random();

		// Token: 0x04000024 RID: 36
		private static readonly Dictionary<string, float> lastRandomValues = new Dictionary<string, float>();
	}
}
