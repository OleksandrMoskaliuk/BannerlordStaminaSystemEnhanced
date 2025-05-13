using System;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace AhFight.Combat
{
    internal class AttackSpeedPenalty
    {

        public static void ApplyAttackSpeedPenalty(Agent agent, AhFightData data)
        {
            if (agent != null && data != null && agent.IsActive() && agent.IsHuman)
            {

                if (data.origSwingSpeedMultiplier == 0f && data.origThrustSpeedMultiplier == 0f)
                {
                    // Save original attack speed
                    data.origSwingSpeedMultiplier = agent.AgentDrivenProperties.SwingSpeedMultiplier;
                    data.origThrustSpeedMultiplier = agent.AgentDrivenProperties.ThrustOrRangedReadySpeedMultiplier;
                }
                if (data.origSwingSpeedMultiplier != 0f && data.origSwingSpeedMultiplier != 0f)
                {
                    // "UpdateCustomDrivenProperties" may be slightly costly depending on how many agents are on the battlefield
                    float currentTime = MBCommon.GetTotalMissionTime();
                    if (currentTime < data.nextUpdateTime)
                        return; // Skip this update

                    if (agent.IsPlayerControlled && false)
                    {
                        InformationManager.DisplayMessage(new InformationMessage(string.Format("origSwingSpeedMultiplier: {0:F2}", data.origSwingSpeedMultiplier), Colors.Green));
                        InformationManager.DisplayMessage(new InformationMessage(string.Format("origThrustSpeedMultiplier: {0:F2}", data.origThrustSpeedMultiplier), Colors.Blue));
                    }

                    float agentAH = AhFightAPI.GetCurrentAhFight(agent) / AhFightAPI.GetMaxAhFight(agent); // Expected: 0.0 to 1.0
                    float threshold = AhFightConfig.LowAhAttackSpeedThreshold;
                    float minMultiplier = AhFightConfig.MinAttackSpeedMultiplier;
                    float AttackSpeedMultiplier = 1f;
                    if (agentAH < threshold)
                    {
                        // Normalize t: 0 when stamina == threshold, 1 when stamina == 0
                        float t = (threshold - agentAH) / threshold;
                        t = TaleWorlds.Library.MathF.Clamp(t, 0f, 1f);

                        // Smoothstep curve: 3t^2 - 2t^3
                        float smooth = t * t * (3f - 2f * t);

                        AttackSpeedMultiplier = Math.Max(1f - smooth * (1f - minMultiplier), minMultiplier);

                        //Apply debuff 
                        agent.AgentDrivenProperties.SwingSpeedMultiplier  = data.origSwingSpeedMultiplier * AttackSpeedMultiplier;
                        agent.AgentDrivenProperties.ThrustOrRangedReadySpeedMultiplier = data.origThrustSpeedMultiplier * AttackSpeedMultiplier;

                        if (agent.IsPlayerControlled && false)
                        {
                            InformationManager.DisplayMessage(new InformationMessage(string.Format("AttackSpeedMultiplier: {0:F2}", data.origSwingSpeedMultiplier * AttackSpeedMultiplier), Colors.Yellow));
                        }
                    }
                    else
                    {
                        agent.AgentDrivenProperties.SwingSpeedMultiplier = data.origSwingSpeedMultiplier;
                        agent.AgentDrivenProperties.ThrustOrRangedReadySpeedMultiplier = data.origThrustSpeedMultiplier;
                    }

                    agent.UpdateCustomDrivenProperties();
                    if (agent.IsPlayerControlled && false)
                    {
                        InformationManager.DisplayMessage(new InformationMessage(string.Format("AttackSpeedMultiplier: {0:F2}", data.origSwingSpeedMultiplier * AttackSpeedMultiplier), Colors.Yellow));
                    }

                    data.nextUpdateTime = currentTime + 0.35f; // Only update every 0.35 seconds
                }

            }
        }

        private const string MODULE_NAME = "Attack Speed Penalty";
    }

}


