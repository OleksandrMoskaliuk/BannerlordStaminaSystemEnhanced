using System;
using System.Collections.Generic;
using AhFight.Combat;
using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace AhFight
{
	// Token: 0x02000004 RID: 4
	public class AhFightMissionLogic : MissionLogic
	{
		// Token: 0x0600006C RID: 108
		public override void OnMissionTick(float dt)
		{
			base.OnMissionTick(dt);
			if (AhFightConfig.ahfightEnabled && Mission.Current.AllowAiTicking)
			{
				if (AhFightMissionLogic.currentDt < AhFightMissionLogic.timeToCalc)
				{
					AhFightMissionLogic.currentDt += dt;
					return;
				}
				DateTime now = DateTime.Now;
				this.UpdateAhFight();
				this.ProcessWeaponDrops();
				double totalMilliseconds = (DateTime.Now - now).TotalMilliseconds;
				AhFightMissionLogic.currentDt = 0f;
			}
		}

		private void UpdateAhFight()
		{
			List<Agent> list = new List<Agent>();
			foreach (KeyValuePair<Agent, AhFightData> keyValuePair in AhFightAgent.values)
			{
				Agent key = keyValuePair.Key;
				AhFightData value = keyValuePair.Value;
				
				if (key == null || key.Mission == null || !key.IsActive())
				{
					list.Add(key);
				}
				else
				{
                    if (AhFightConfig.movementPenaltyEnabled)
					{
						MovementPenaltyEffect.ApplyMovementPenalty(key);
					}
                    if (AhFightConfig.AttackSpeedPenaltyEnabled)
                    {
						AttackSpeedPenalty.ApplyAttackSpeedPenalty(key, value);
                    }
                    if (value.ahfight < value.maxAhFight)
					{
						AhFightState currentState = AhFightStateManager.GetCurrentState(key);
						float num = value.regenPerTick;
						switch (currentState)
						{
						case AhFightState.Normal:
							num *= AhFightConfig.normalRegenModifier;
							break;
						case AhFightState.Weak:
							num *= AhFightConfig.weakRegenModifier;
							break;
						case AhFightState.Tired:
							num *= AhFightConfig.tiredRegenModifier;
							break;
						case AhFightState.Powerless:
							num *= AhFightConfig.powerlessRegenModifier;
							break;
						}
						if (key.IsPlayerControlled)
						{
							num *= AhFightConfig.playerAhFightRegenBase;
						}
						float num2 = num * 30f;
						float ahfight = value.ahfight;
						value.ahfight = Math.Min(value.maxAhFight, value.ahfight + num2);
						if (key.IsPlayerControlled)
						{
							AhFightStateManager.GetCurrentState(key);
						}
					}
				}
			}
			foreach (Agent agent in list)
			{
				AhFightAgent.values.Remove(agent);
			}
		}

		private void ProcessWeaponDrops()
		{
			if (AhFightConfig.ShieldDropEnabled)
			{
				for (int i = AhFightMissionLogic.agentsToDropShield.Count - 1; i >= 0; i--)
				{
					Agent agent = AhFightMissionLogic.agentsToDropShield[i];
					try
					{
						if (agent != null && agent.IsActive())
						{
							AhFightState currentState = AhFightStateManager.GetCurrentState(agent);
							bool flag = false;
							switch (currentState)
							{
							case AhFightState.Normal:
								flag = AhFightConfig.StateDropSettings.NormalStateDropEnabled;
								break;
							case AhFightState.Weak:
								flag = AhFightConfig.StateDropSettings.WeakStateDropEnabled;
								break;
							case AhFightState.Tired:
								flag = AhFightConfig.StateDropSettings.TiredStateDropEnabled;
								break;
							case AhFightState.Powerless:
								flag = AhFightConfig.StateDropSettings.PowerlessStateDropEnabled;
								break;
							}
							if (flag)
							{
								EquipmentIndex wieldedItemIndex = agent.GetWieldedItemIndex(Agent.HandIndex.OffHand);
								if (wieldedItemIndex != EquipmentIndex.None)
								{
									agent.DropItem(wieldedItemIndex, WeaponClass.Undefined);
								}
							}
						}
					}
					finally
					{
						AhFightMissionLogic.agentsToDropShield.Remove(agent);
					}
				}
			}
			else
			{
				AhFightMissionLogic.agentsToDropShield.Clear();
			}
			if (AhFightConfig.WeaponDropEnabled)
			{
				for (int j = AhFightMissionLogic.agentsToDropWeapon.Count - 1; j >= 0; j--)
				{
					Agent agent2 = AhFightMissionLogic.agentsToDropWeapon[j];
					try
					{
						if (agent2 != null && agent2.IsActive())
						{
							AhFightState currentState2 = AhFightStateManager.GetCurrentState(agent2);
							bool flag2 = false;
							switch (currentState2)
							{
							case AhFightState.Normal:
								flag2 = AhFightConfig.StateDropSettings.NormalStateDropEnabled;
								break;
							case AhFightState.Weak:
								flag2 = AhFightConfig.StateDropSettings.WeakStateDropEnabled;
								break;
							case AhFightState.Tired:
								flag2 = AhFightConfig.StateDropSettings.TiredStateDropEnabled;
								break;
							case AhFightState.Powerless:
								flag2 = AhFightConfig.StateDropSettings.PowerlessStateDropEnabled;
								break;
							}
							if (flag2)
							{
								EquipmentIndex wieldedItemIndex2 = agent2.GetWieldedItemIndex(Agent.HandIndex.MainHand);
								if (wieldedItemIndex2 != EquipmentIndex.None)
								{
									agent2.DropItem(wieldedItemIndex2, WeaponClass.Undefined);
									agent2.UpdateAgentProperties();
								}
							}
						}
					}
					finally
					{
						AhFightMissionLogic.agentsToDropWeapon.Remove(agent2);
					}
				}
				return;
			}
			AhFightMissionLogic.agentsToDropWeapon.Clear();
		}

		// Token: 0x04000025 RID: 37
		private static readonly float timeToCalc = 0.5f;

		// Token: 0x04000026 RID: 38
		private static float currentDt = 0f;

		// Token: 0x04000027 RID: 39
		public static MBArrayList<Agent> agentsToDropShield = new MBArrayList<Agent>();

		// Token: 0x04000028 RID: 40
		public static MBArrayList<Agent> agentsToDropWeapon = new MBArrayList<Agent>();

		// Token: 0x04000029 RID: 41
		private const string MODULE_NAME = "MissionLogic";

		// Token: 0x02000016 RID: 22
		[HarmonyPatch(typeof(Agent))]
		[HarmonyPatch("EquipItemsFromSpawnEquipment")]
		private class EquipItemsFromSpawnEquipmentPatch
		{
			// Token: 0x060001C2 RID: 450
			private static void Prefix(ref Agent __instance)
			{
				if (__instance.IsHuman)
				{
					AhFightAgent.values[__instance] = new AhFightData();
				}
			}
		}

		// Token: 0x02000017 RID: 23
		[HarmonyPatch(typeof(Agent))]
		[HarmonyPatch("OnWieldedItemIndexChange")]
		private class OnWieldedItemIndexChangePatch
		{
			// Token: 0x060001C4 RID: 452
			private static void Postfix(ref Agent __instance)
			{
				if (AhFightConfig.ahfightEnabled)
				{
					AhFightData ahFightData;
					AhFightAgent.values.TryGetValue(__instance, out ahFightData);
					if (ahFightData == null)
					{
						AhFightAgent.values[__instance] = new AhFightData();
						AhFightAgent.values.TryGetValue(__instance, out ahFightData);
					}
					if (ahFightData != null)
					{
						float num = ahFightData.ahfight / ahFightData.maxAhFight;
						EquipmentIndex wieldedItemIndex = __instance.GetWieldedItemIndex(Agent.HandIndex.MainHand);
						if (wieldedItemIndex != EquipmentIndex.None)
						{
							WeaponComponentData weaponComponentDataForUsage = __instance.Equipment[wieldedItemIndex].GetWeaponComponentDataForUsage(__instance.Equipment[wieldedItemIndex].CurrentUsageIndex);
							SkillObject relevantSkillFromWeaponClass = WeaponComponentData.GetRelevantSkillFromWeaponClass(weaponComponentDataForUsage.WeaponClass);
							float num2 = 0f;
							if (relevantSkillFromWeaponClass != null)
							{
								num2 = (float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(__instance, relevantSkillFromWeaponClass);
							}
							float num3;
							if (__instance.HasMount)
							{
								num3 = (float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(__instance, DefaultSkills.Riding);
							}
							else
							{
								num3 = (float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(__instance, DefaultSkills.Athletics);
							}
							float athleticBase = AhFightConfig.athleticBase;
							float weaponSkillBase = AhFightConfig.weaponSkillBase;
							float weaponSkillModifier = AhFightConfig.weaponSkillModifier;
							float weaponSkillModifier2 = AhFightConfig.weaponSkillModifier;
							float baseAhFightRegen = AhFightConfig.baseAhFightRegen;
							float weaponSkillRegenBase = AhFightConfig.weaponSkillRegenBase;
							float num4 = 1f;
							float effectiveSkillWithDR = WeaponCalculator.GetEffectiveSkillWithDR(num2);
							float effectiveSkillWithDR2 = WeaponCalculator.GetEffectiveSkillWithDR(num3);
							WeaponCalculator.CalculateSkillModifier(effectiveSkillWithDR);
							int num5;
							int num6;
							int num7;
							WeaponCalculator.CalculateVisualSpeeds(__instance.Equipment[wieldedItemIndex], __instance.Equipment[wieldedItemIndex].CurrentUsageIndex, effectiveSkillWithDR, out num5, out num6, out num7);
							float num8 = 1f;
							if (weaponComponentDataForUsage != null)
							{
								num8 = TaleWorlds.Library.MathF.Clamp((WeaponCalculator.CalculateDetailedThrustSpeed(__instance.Equipment[wieldedItemIndex].GetWeight(), weaponComponentDataForUsage.Inertia, weaponComponentDataForUsage.CenterOfMass) * 0.1f + (float)num6 / WeaponCalculator.ThrustSpeedTransfer) / 30f, 0.8f, 1.2f);
							}
							float num13 = athleticBase * (num4 + effectiveSkillWithDR2 / weaponSkillModifier);
							float num9 = weaponSkillBase * (num4 + effectiveSkillWithDR / weaponSkillModifier2);
							float num10 = (num13 + num9) * num8;
							if (__instance.IsPlayerControlled)
							{
								num10 *= AhFightConfig.playerAhFightBase;
							}
							ahFightData.maxAhFight = num10;
							ahFightData.ahfight = ahFightData.maxAhFight * num;
							float num11 = baseAhFightRegen * (num4 + effectiveSkillWithDR2 / weaponSkillModifier);
							float num12 = weaponSkillRegenBase * (num4 + effectiveSkillWithDR / weaponSkillModifier2);
							ahFightData.regenPerTick = (num11 + num12) * num8;
						}
					}
				}
			}
		}

		// Token: 0x02000018 RID: 24
		[HarmonyPatch(typeof(MissionState))]
		[HarmonyPatch("LoadMission")]
		public class LoadMissionPatch
		{
			// Token: 0x060001C6 RID: 454
			private static void Postfix()
			{
				AhFightAgent.values.Clear();
				AhFightMissionLogic.agentsToDropShield.Clear();
				AhFightMissionLogic.agentsToDropWeapon.Clear();
				AhFightCacheManager.ClearAllCache();
			}
		}

		// Token: 0x02000019 RID: 25
		[HarmonyPatch(typeof(MissionState))]
		[HarmonyPatch("OnDeactivate")]
		public class OnDeactivatePatch
		{
			// Token: 0x060001C8 RID: 456
			private static void Postfix()
			{
				AhFightAgent.values.Clear();
				AhFightMissionLogic.agentsToDropShield.Clear();
				AhFightMissionLogic.agentsToDropWeapon.Clear();
				AhFightCacheManager.ClearAllCache();
			}
		}

		// Token: 0x0200001A RID: 26
		[HarmonyPatch(typeof(Mission))]
		[HarmonyPatch("CreateMeleeBlow")]
		private class CreateMeleeBlowPatch
		{
			// Token: 0x060001CA RID: 458
			private static void Postfix(ref Mission __instance, ref Blow __result, Agent attackerAgent, Agent victimAgent, ref AttackCollisionData collisionData, in MissionWeapon attackerWeapon)
			{
				if (!AhFightConfig.ahfightEnabled || attackerAgent == null || victimAgent == null || attackerAgent.IsFriendOf(victimAgent) || !attackerAgent.IsActive() || !victimAgent.IsActive() || attackerAgent.IsMount || victimAgent.IsMount)
				{
					return;
				}
				if (AhFightAgent.values == null)
				{
					return;
				}
				if (attackerAgent.Monster == null || victimAgent.Monster == null)
				{
					return;
				}
				MissionWeapon missionWeapon = attackerWeapon;
				if (!missionWeapon.IsEmpty)
				{
					missionWeapon = attackerWeapon;
					if (missionWeapon.Item != null)
					{
						missionWeapon = attackerWeapon;
						if (missionWeapon.CurrentUsageItem != null)
						{
							goto IL_84;
						}
					}
					return;
				}
				IL_84:
				bool flag = attackerAgent.IsPlayerControlled || victimAgent.IsPlayerControlled;
				AhFightCacheManager.CleanupCache(__instance.CurrentTime);
				string text = string.Format("{0}_{1}_{2}", attackerAgent.Index, victimAgent.Index, Math.Floor((double)(__instance.CurrentTime * 10f)) / 10.0);
				if (AhFightCacheManager.IsAttackProcessed(text))
				{
					return;
				}
				AhFightCacheManager.MarkAttackProcessed(text);
				Vec3 weaponBlowDir = collisionData.WeaponBlowDir;
				Vec3 weaponRotUp = collisionData.WeaponRotUp;
				if (!attackerAgent.IsActive() || !victimAgent.IsActive())
				{
					return;
				}
				AhFightBlow.MakeBlowEffect(ref __instance, attackerAgent, victimAgent, ref collisionData, attackerWeapon, weaponRotUp, weaponBlowDir, text);
				missionWeapon = attackerWeapon;
				if (missionWeapon.IsEmpty)
				{
					return;
				}
				if (victimAgent.Health <= 0f)
				{
					return;
				}
				if (AhFightAgent.values == null)
				{
					return;
				}
				AhFightData ahFightData = null;
				AhFightData ahFightData2 = null;
				if (!AhFightAgent.values.TryGetValue(victimAgent, out ahFightData) || !AhFightAgent.values.TryGetValue(attackerAgent, out ahFightData2) || ahFightData == null || ahFightData2 == null)
				{
					return;
				}
				float num = 0f;
				float num2 = 1f;
				float num3 = 1f;
				missionWeapon = attackerWeapon;
				if (!missionWeapon.IsEmpty)
				{
					missionWeapon = attackerWeapon;
					if (missionWeapon.CurrentUsageItem != null)
					{
						missionWeapon = attackerWeapon;
						WeaponComponentData weaponComponentDataForUsage = missionWeapon.GetWeaponComponentDataForUsage(attackerWeapon.CurrentUsageIndex);
						if (weaponComponentDataForUsage != null)
						{
							SkillObject relevantSkillFromWeaponClass = WeaponComponentData.GetRelevantSkillFromWeaponClass(weaponComponentDataForUsage.WeaponClass);
							if (relevantSkillFromWeaponClass != null)
							{
								num = (float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(attackerAgent, relevantSkillFromWeaponClass);
							}
							float effectiveSkillWithDR = WeaponCalculator.GetEffectiveSkillWithDR(num);
							num2 = WeaponCalculator.CalculateSkillModifier(effectiveSkillWithDR);
							num3 = WeaponCalculator.GetComHitModifier(collisionData, attackerWeapon);
							float num4 = 1f;
							if (collisionData.StrikeType == 1)
							{
								float thrustStanceLossModifier = AhFightConfig.thrustStanceLossModifier;
								if (weaponComponentDataForUsage.WeaponClass == WeaponClass.OneHandedPolearm || weaponComponentDataForUsage.WeaponClass == WeaponClass.OneHandedSword || weaponComponentDataForUsage.WeaponClass == WeaponClass.Mace || weaponComponentDataForUsage.WeaponClass == WeaponClass.OneHandedAxe || weaponComponentDataForUsage.WeaponClass == WeaponClass.Dagger)
								{
									missionWeapon = attackerWeapon;
									float weight = missionWeapon.GetWeight();
									float num5 = effectiveSkillWithDR;
									missionWeapon = attackerWeapon;
									num4 = WeaponCalculator.CalculateThrustMagnitudeForOneHandedWeapon(weight, num5, (float)missionWeapon.GetModifiedThrustSpeedForCurrentUsage() / WeaponCalculator.ThrustSpeedTransfer, 0f, collisionData.AttackDirection) / 100f;
								}
								else if (weaponComponentDataForUsage.WeaponClass == WeaponClass.TwoHandedPolearm || weaponComponentDataForUsage.WeaponClass == WeaponClass.TwoHandedSword)
								{
									missionWeapon = attackerWeapon;
									float weight2 = missionWeapon.GetWeight();
									float num6 = effectiveSkillWithDR;
									missionWeapon = attackerWeapon;
									num4 = WeaponCalculator.CalculateThrustMagnitudeForTwoHandedWeapon(weight2, num6, (float)missionWeapon.GetModifiedThrustSpeedForCurrentUsage() / WeaponCalculator.ThrustSpeedTransfer, 0f, collisionData.AttackDirection) / 100f;
								}
								num4 *= thrustStanceLossModifier;
							}
							else if (collisionData.StrikeType == 0)
							{
								missionWeapon = attackerWeapon;
								float num7 = (float)missionWeapon.GetModifiedSwingSpeedForCurrentUsage() / WeaponCalculator.SwingSpeedTransfer;
								float num8 = AhFightConfig.swingStanceLossModifier;
								switch (weaponComponentDataForUsage.WeaponClass)
								{
								case WeaponClass.Dagger:
								case WeaponClass.OneHandedSword:
									num8 *= AhFightConfig.oneHandedSwordSwingModifier;
									break;
								case WeaponClass.TwoHandedSword:
									num8 *= AhFightConfig.twoHandedSwordSwingModifier;
									break;
								case WeaponClass.OneHandedAxe:
								case WeaponClass.Mace:
								case WeaponClass.OneHandedPolearm:
									num8 *= AhFightConfig.oneHandedBluntSwingModifier;
									break;
								case WeaponClass.TwoHandedAxe:
								case WeaponClass.TwoHandedMace:
									num8 *= AhFightConfig.twoHandedBluntSwingModifier;
									break;
								case WeaponClass.TwoHandedPolearm:
									num8 *= AhFightConfig.polearmSwingModifier;
									break;
								}
								num4 = num7 * num8 * (1f + effectiveSkillWithDR / 300f) / 100f;
								num4 = TaleWorlds.Library.MathF.Clamp(num4, 0.5f, 2f);
							}
							bool flag6 = WeaponCalculator.HitWithWeaponBladeTip(collisionData, attackerWeapon);
							bool flag2 = WeaponCalculator.HitWithWeaponBlade(collisionData, attackerWeapon);
							if (flag6)
							{
								num3 *= AhFightConfig.weaponTipHitStanceLossModifier * num4;
							}
							else if (flag2)
							{
								num3 *= AhFightConfig.weaponBladeHitStanceLossModifier * num4;
							}
						}
						float num26 = AhFightConfig.baseAhFightDamage * AhFightConfig.stanceLossBaseMultiplier;
						float num9 = num3;
						missionWeapon = attackerWeapon;
						float num27 = AhFightDamageCalculator.CalculateBaseAhFightDamage(num26, num9, missionWeapon.GetWeaponComponentDataForUsage(attackerWeapon.CurrentUsageIndex), collisionData.AttackDirection, flag, attackerAgent.IsPlayerControlled ? attackerAgent : (victimAgent.IsPlayerControlled ? victimAgent : null));
						float num10 = 1f;
						if (collisionData.AttackBlockedWithShield)
						{
							EquipmentIndex wieldedItemIndex = victimAgent.GetWieldedItemIndex(Agent.HandIndex.OffHand);
							if (wieldedItemIndex != EquipmentIndex.None && victimAgent.Equipment[wieldedItemIndex].Item != null)
							{
								WeaponComponentData weaponComponentDataForUsage2 = victimAgent.Equipment[wieldedItemIndex].GetWeaponComponentDataForUsage(0);
								if (weaponComponentDataForUsage2 != null)
								{
									WeaponClass weaponClass = weaponComponentDataForUsage2.WeaponClass;
									if (weaponClass != WeaponClass.SmallShield)
									{
										if (weaponClass == WeaponClass.LargeShield)
										{
											num10 = AhFightConfig.largeShieldDefenseModifier;
										}
									}
									else
									{
										num10 = AhFightConfig.smallShieldDefenseModifier;
									}
								}
							}
						}
						float num11 = AhFightDamageCalculator.CalculateDefenderAhFightDamage(num27, collisionData, num2, collisionData.AttackBlockedWithShield, collisionData.CollisionResult == CombatCollisionResult.Parried, collisionData.CorrectSideShieldBlock, num10, flag, victimAgent.IsPlayerControlled ? victimAgent : null);
						float num12 = AhFightDamageCalculator.CalculateAttackerAhFightDamage(num27, collisionData, collisionData.AttackBlockedWithShield, collisionData.CollisionResult == CombatCollisionResult.Parried, num2, flag, attackerAgent.IsPlayerControlled ? attackerAgent : null) * num2 * AhFightConfig.stanceDamageReductionFactor;
						float ahfight = ahFightData2.ahfight;
						ahFightData2.ahfight = Math.Max(0f, ahFightData2.ahfight - num12);
						if (ahFightData2.ahfight <= 0f)
						{
							if (attackerAgent.GetWieldedItemIndex(Agent.HandIndex.MainHand) != EquipmentIndex.None)
							{
								AhFightMissionLogic.agentsToDropWeapon.Add(attackerAgent);
								AhFightBlow.MakeStanceBreakEffect(attackerAgent, victimAgent, ref collisionData, weaponRotUp, weaponBlowDir);
							}
							ahFightData2.ahfight = ahFightData2.maxAhFight * AhFightConfig.ahfightResetModifier;
						}
						if (collisionData.AttackBlockedWithShield)
						{
							WeaponCalculator.CalculateSkillModifier(WeaponCalculator.GetEffectiveSkillWithDR((float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(victimAgent, DefaultSkills.OneHanded)));
							victimAgent.GetWieldedItemIndex(Agent.HandIndex.OffHand);
							bool correctSideShieldBlock = collisionData.CorrectSideShieldBlock;
							float num13;
							if (AhFightBlow.IsPerfectShieldBlock(text))
							{
								num13 = AhFightConfig.perfectShieldBlockModifier;
							}
							else
							{
								num13 = (correctSideShieldBlock ? AhFightConfig.correctSideShieldBlockModifier : AhFightConfig.wrongSideShieldBlockModifier);
							}
							num11 *= num13;
						}
						float ahfight2 = ahFightData.ahfight;
						ahFightData.ahfight = Math.Max(0f, ahFightData.ahfight - num11);
						if (collisionData.CollisionResult == CombatCollisionResult.StrikeAgent)
						{
							bool flag3 = collisionData.VictimHitBodyPart == BoneBodyPartType.ArmRight;
							bool flag4 = collisionData.VictimHitBodyPart == BoneBodyPartType.ArmLeft;
							if (flag3 || flag4)
							{
								bool flag5 = false;
								EquipmentIndex wieldedItemIndex2 = victimAgent.GetWieldedItemIndex(Agent.HandIndex.MainHand);
								if (wieldedItemIndex2 != EquipmentIndex.None)
								{
									WeaponComponentData weaponComponentDataForUsage3 = victimAgent.Equipment[wieldedItemIndex2].GetWeaponComponentDataForUsage(victimAgent.Equipment[wieldedItemIndex2].CurrentUsageIndex);
									if (weaponComponentDataForUsage3 != null)
									{
										flag5 = weaponComponentDataForUsage3.WeaponClass == WeaponClass.TwoHandedAxe || weaponComponentDataForUsage3.WeaponClass == WeaponClass.TwoHandedMace || weaponComponentDataForUsage3.WeaponClass == WeaponClass.TwoHandedPolearm || weaponComponentDataForUsage3.WeaponClass == WeaponClass.TwoHandedSword;
									}
								}
								float num14 = 1f;
								missionWeapon = attackerWeapon;
								WeaponComponentData currentUsageItem = missionWeapon.CurrentUsageItem;
								switch ((currentUsageItem != null) ? currentUsageItem.WeaponClass : WeaponClass.Undefined)
								{
								case WeaponClass.Dagger:
									num14 = 0.8f;
									break;
								case WeaponClass.OneHandedSword:
								case WeaponClass.OneHandedPolearm:
									num14 = 1f;
									break;
								case WeaponClass.TwoHandedSword:
								case WeaponClass.TwoHandedPolearm:
									num14 = 1.2f;
									break;
								case WeaponClass.OneHandedAxe:
								case WeaponClass.Mace:
									num14 = 1.3f;
									break;
								case WeaponClass.TwoHandedAxe:
								case WeaponClass.TwoHandedMace:
									num14 = 1.5f;
									break;
								}
								float num15 = 0f;
								if (wieldedItemIndex2 != EquipmentIndex.None)
								{
									WeaponComponentData weaponComponentDataForUsage4 = victimAgent.Equipment[wieldedItemIndex2].GetWeaponComponentDataForUsage(victimAgent.Equipment[wieldedItemIndex2].CurrentUsageIndex);
									if (weaponComponentDataForUsage4 != null)
									{
										SkillObject relevantSkillFromWeaponClass2 = WeaponComponentData.GetRelevantSkillFromWeaponClass(weaponComponentDataForUsage4.WeaponClass);
										if (relevantSkillFromWeaponClass2 != null)
										{
											num15 = (float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(victimAgent, relevantSkillFromWeaponClass2);
										}
									}
								}
								float effectiveSkillWithDR2 = WeaponCalculator.GetEffectiveSkillWithDR(num15);
								float handHitWeaponDropBaseChance = AhFightConfig.handHitWeaponDropBaseChance;
								float num16 = ahFightData.ahfight / ahFightData.maxAhFight;
								float num17 = TaleWorlds.Library.MathF.Clamp(ahFightData.ahfight / 30f, 0f, 1f);
								float num18 = 1f - num16;
								float num19 = 1f + (num18 * 0.7f + (1f - num17) * 0.3f) * AhFightConfig.stanceWeaponDropModifier;
								float num20 = 1f - TaleWorlds.Library.MathF.Sqrt(effectiveSkillWithDR2) / TaleWorlds.Library.MathF.Sqrt(AhFightConfig.skillWeaponDropDivisor);
								num20 = TaleWorlds.Library.MathF.Clamp(num20, 0.25f, 1f);
								float num21 = handHitWeaponDropBaseChance * num14 * num19 * num20;
								num21 = TaleWorlds.Library.MathF.Clamp(num21, AhFightConfig.minWeaponDropChance, AhFightConfig.maxWeaponDropChance);
								if (flag5)
								{
									num21 *= 0.5f;
								}
								if (AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_random_drop", victimAgent.Index, Mission.Current.CurrentTime)) < num21)
								{
									if (flag5)
									{
										if (!AhFightMissionLogic.agentsToDropWeapon.Contains(victimAgent))
										{
											AhFightMissionLogic.agentsToDropWeapon.Add(victimAgent);
										}
									}
									else if (flag3 && wieldedItemIndex2 != EquipmentIndex.None)
									{
										if (!AhFightMissionLogic.agentsToDropWeapon.Contains(victimAgent))
										{
											AhFightMissionLogic.agentsToDropWeapon.Add(victimAgent);
										}
									}
									else if (flag4 && victimAgent.GetWieldedItemIndex(Agent.HandIndex.OffHand) != EquipmentIndex.None && !AhFightMissionLogic.agentsToDropShield.Contains(victimAgent))
									{
										AhFightMissionLogic.agentsToDropShield.Add(victimAgent);
									}
								}
							}
						}
						if (ahFightData.ahfight <= 0f)
						{
							if (collisionData.AttackBlockedWithShield && victimAgent.GetWieldedItemIndex(Agent.HandIndex.OffHand) != EquipmentIndex.None && !AhFightMissionLogic.agentsToDropShield.Contains(victimAgent))
							{
								AhFightBlow.MakeStanceBreakEffect(victimAgent, attackerAgent, ref collisionData, -weaponRotUp, -weaponBlowDir);
								float maxShieldBlockExhaustedDropChance = AhFightConfig.maxShieldBlockExhaustedDropChance;
								if (AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_shield_drop", victimAgent.Index, Mission.Current.CurrentTime)) < maxShieldBlockExhaustedDropChance)
								{
									AhFightMissionLogic.agentsToDropShield.Add(victimAgent);
								}
							}
							else if (collisionData.CollisionResult == CombatCollisionResult.Blocked && victimAgent.GetWieldedItemIndex(Agent.HandIndex.MainHand) != EquipmentIndex.None && !AhFightMissionLogic.agentsToDropWeapon.Contains(victimAgent))
							{
								AhFightBlow.MakeStanceBreakEffect(victimAgent, attackerAgent, ref collisionData, -weaponRotUp, -weaponBlowDir);
								float maxWeaponBlockExhaustedDropChance = AhFightConfig.maxWeaponBlockExhaustedDropChance;
								if (AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_weapon_block_drop", victimAgent.Index, Mission.Current.CurrentTime)) < maxWeaponBlockExhaustedDropChance)
								{
									AhFightMissionLogic.agentsToDropWeapon.Add(victimAgent);
								}
							}
							else if (collisionData.CollisionResult == CombatCollisionResult.StrikeAgent)
							{
								AhFightBlow.MakeStanceBreakEffect(victimAgent, attackerAgent, ref collisionData, -weaponRotUp, -weaponBlowDir);
								float randomValue = AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_strike_drop", victimAgent.Index, Mission.Current.CurrentTime));
								float num22 = 0f;
								EquipmentIndex wieldedItemIndex3 = victimAgent.GetWieldedItemIndex(Agent.HandIndex.MainHand);
								if (wieldedItemIndex3 != EquipmentIndex.None)
								{
									WeaponComponentData weaponComponentDataForUsage5 = victimAgent.Equipment[wieldedItemIndex3].GetWeaponComponentDataForUsage(victimAgent.Equipment[wieldedItemIndex3].CurrentUsageIndex);
									if (weaponComponentDataForUsage5 != null)
									{
										SkillObject relevantSkillFromWeaponClass3 = WeaponComponentData.GetRelevantSkillFromWeaponClass(weaponComponentDataForUsage5.WeaponClass);
										if (relevantSkillFromWeaponClass3 != null)
										{
											num22 = (float)MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(victimAgent, relevantSkillFromWeaponClass3);
										}
									}
								}
								float num23 = TaleWorlds.Library.MathF.Sqrt(WeaponCalculator.GetEffectiveSkillWithDR(num22)) / TaleWorlds.Library.MathF.Sqrt(AhFightConfig.skillBothDropDivisor);
								num23 = TaleWorlds.Library.MathF.Clamp(num23, 0f, 0.75f);
								float num24 = AhFightConfig.exhaustedBothDropBaseChance * (1f - num23);
								if (victimAgent.HasMount)
								{
									num24 *= AhFightConfig.mountedDropResistance;
									num24 = Math.Min(num24, AhFightConfig.mountedMaxDropChance);
								}
								else
								{
									num24 = Math.Min(num24, AhFightConfig.maxStrikeExhaustedDropChance);
								}
								if (randomValue < num24 && victimAgent.GetWieldedItemIndex(Agent.HandIndex.MainHand) != EquipmentIndex.None && victimAgent.GetWieldedItemIndex(Agent.HandIndex.OffHand) != EquipmentIndex.None && !AhFightMissionLogic.agentsToDropWeapon.Contains(victimAgent) && !AhFightMissionLogic.agentsToDropShield.Contains(victimAgent))
								{
									AhFightMissionLogic.agentsToDropWeapon.Add(victimAgent);
									AhFightMissionLogic.agentsToDropShield.Add(victimAgent);
								}
								else
								{
									float randomValue2 = AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_single_drop", victimAgent.Index, Mission.Current.CurrentTime));
									float num25 = AhFightConfig.exhaustedWeaponDropChance;
									if (victimAgent.HasMount)
									{
										num25 *= AhFightConfig.mountedDropResistance;
										num25 = Math.Min(num25, AhFightConfig.mountedMaxDropChance);
									}
									else
									{
										num25 = Math.Min(num25, AhFightConfig.maxStrikeExhaustedDropChance);
									}
									if (randomValue2 < num25 && victimAgent.GetWieldedItemIndex(Agent.HandIndex.MainHand) != EquipmentIndex.None && !AhFightMissionLogic.agentsToDropWeapon.Contains(victimAgent))
									{
										AhFightMissionLogic.agentsToDropWeapon.Add(victimAgent);
									}
									else if (victimAgent.GetWieldedItemIndex(Agent.HandIndex.OffHand) != EquipmentIndex.None && !AhFightMissionLogic.agentsToDropShield.Contains(victimAgent))
									{
										AhFightMissionLogic.agentsToDropShield.Add(victimAgent);
									}
								}
							}
							else if (victimAgent.GetWieldedItemIndex(Agent.HandIndex.MainHand) != EquipmentIndex.None && !AhFightMissionLogic.agentsToDropWeapon.Contains(victimAgent))
							{
								AhFightBlow.MakeStanceBreakEffect(victimAgent, attackerAgent, ref collisionData, -weaponRotUp, -weaponBlowDir);
								float maxWeaponBlockExhaustedDropChance2 = AhFightConfig.maxWeaponBlockExhaustedDropChance;
								if (AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_other_drop", victimAgent.Index, Mission.Current.CurrentTime)) < maxWeaponBlockExhaustedDropChance2)
								{
									AhFightMissionLogic.agentsToDropWeapon.Add(victimAgent);
								}
							}
							ahFightData.ahfight = ahFightData.maxAhFight * AhFightConfig.ahfightResetModifier;
							return;
						}
						return;
					}
				}
			}
		}

		// Token: 0x0200001B RID: 27
		[HarmonyPatch(typeof(Mission))]
		[HarmonyPatch("MissileHitCallback")]
		private class MissileHitCallbackPatch
		{
			// Token: 0x060001CC RID: 460
			private static void Postfix(ref AttackCollisionData collisionData, Agent attacker, Agent victim)
			{
				if (!AhFightConfig.ahfightEnabled || !AhFightConfig.missileEffectEnabled || attacker == null || victim == null || !victim.IsHuman)
				{
					return;
				}
				if (!collisionData.IsMissile)
				{
					return;
				}
				if (!attacker.IsActive() || !victim.IsActive())
				{
					return;
				}
				MissionWeapon wieldedWeapon = attacker.WieldedWeapon;
				if (wieldedWeapon.IsEmpty)
				{
					return;
				}
				if (wieldedWeapon.Item == null || wieldedWeapon.CurrentUsageItem == null)
				{
					return;
				}
				Vec3 weaponBlowDir = collisionData.WeaponBlowDir;
				Vec3 weaponBlowDir2 = collisionData.WeaponBlowDir;
				if (AhFightConfig.missileLossEnabled)
				{
					if (AhFightAgent.values == null)
					{
						return;
					}
					AhFightData ahFightData;
					AhFightAgent.values.TryGetValue(victim, out ahFightData);
					if (ahFightData != null)
					{
						bool attackBlockedWithShield = collisionData.AttackBlockedWithShield;
						if (Mission.Current == null)
						{
							return;
						}
						float num = AhFightCacheManager.GetRandomValue(string.Format("{0}_{1}_{2}_effect", attacker.Index, victim.Index, Math.Floor((double)(Mission.Current.CurrentTime * 10f)) / 10.0)) * 2f - 1f;
						float num2;
						if (attackBlockedWithShield)
						{
							num2 = AhFightConfig.missileBlockedAhLossBase + AhFightConfig.missileBlockedAhLossVariation * num;
						}
						else
						{
							num2 = AhFightConfig.missileDirectHitAhLossBase + AhFightConfig.missileDirectHitAhLossVariation * num;
						}
						num2 = TaleWorlds.Library.MathF.Max(0f, num2);
						ahFightData.ahfight = TaleWorlds.Library.MathF.Max(0f, ahFightData.ahfight - num2);
					}
				}
				if (!attacker.IsActive() || !victim.IsActive())
				{
					return;
				}
				AhFightBlow.MakeMissileHitEffect(attacker, victim, ref collisionData, wieldedWeapon, weaponBlowDir, weaponBlowDir2);
			}
		}
	}
}
