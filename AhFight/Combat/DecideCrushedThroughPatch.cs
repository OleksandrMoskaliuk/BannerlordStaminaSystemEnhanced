
using System;
using HarmonyLib;
using SandBox.GameComponents;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
    // Token: 0x0200001C RID: 28
    [HarmonyPatch(typeof(SandboxAgentApplyDamageModel))]
    [HarmonyPatch("DecideCrushedThrough")]
    public static class DecideCrushedThroughPatch
    {
        // Token: 0x060001CF RID: 463
        private static void Prefix(ref bool __result, Agent attackerAgent, Agent defenderAgent, float totalAttackEnergy, Agent.UsageDirection attackDirection, StrikeType strikeType, WeaponComponentData defendItem, bool isPassiveUsage)
        {
            float DefenderAh = AhFightAPI.GetCurrentAhFight(defenderAgent);
            float DefenderRemainAh = AhFightAPI.GetCurrentAhFight(defenderAgent) / AhFightAPI.GetMaxAhFight(defenderAgent);
            float CrushBlockThreshold = 0.45f;
            float ReduceStaminaDamageAmountFactor_m = 0.65f;
            if (DefenderRemainAh < CrushBlockThreshold)
            {
                __result = true;
                return;
            }

            if ((DefenderRemainAh > CrushBlockThreshold))
            {
                __result = false;
                float StaminaDamageAmount = 1f;
                EquipmentIndex wieldedItemIndex = attackerAgent.GetWieldedItemIndex(Agent.HandIndex.MainHand);
                if ((wieldedItemIndex != EquipmentIndex.None))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        WeaponComponentData currentUsageItem = attackerAgent.Equipment[i].CurrentUsageItem;
                        if (currentUsageItem != null && currentUsageItem.WeaponFlags.HasFlag(WeaponFlags.MeleeWeapon))
                        {
                            if (StaminaDamageAmount < currentUsageItem.SwingDamage)
                            {
                                StaminaDamageAmount = currentUsageItem.SwingDamage;
                            }
                            if (StaminaDamageAmount < currentUsageItem.ThrustDamage)
                            {
                                StaminaDamageAmount = currentUsageItem.ThrustDamage;
                            }
                        }
                    }
                }
                float HP = attackerAgent.BaseHealthLimit * 0.1f;
                float Lv = attackerAgent.Character.Level * 0.1f;
                float AgeDebuff = Math.Max(1f, attackerAgent.Age - 18f) * 0.1f;
                float Athletics = MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(attackerAgent, DefaultSkills.Athletics) * 0.01f;
                float OneHanded = MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(attackerAgent, DefaultSkills.OneHanded) * 0.01f;
                float TwoHanded = MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(attackerAgent, DefaultSkills.TwoHanded) * 0.01f;
                float Polearm = MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(attackerAgent, DefaultSkills.Polearm) * 0.01f;
                float Riding = MissionGameModels.Current.AgentStatCalculateModel.GetEffectiveSkill(attackerAgent, DefaultSkills.Riding) * 0.01f;
                float SkillsBonus = (HP + Lv + Athletics + OneHanded + TwoHanded + Polearm * Riding - AgeDebuff) * 1.2f;
                float Damage = (StaminaDamageAmount * totalAttackEnergy) * 0.002f;
                StaminaDamageAmount = ((Damage * SkillsBonus) * 0.65f) * ReduceStaminaDamageAmountFactor_m;
                AhFightAPI.ModifyAhFight(defenderAgent, DefenderAh - StaminaDamageAmount);
                return;
            }

        }
    }
}