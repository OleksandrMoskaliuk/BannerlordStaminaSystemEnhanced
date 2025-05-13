using System;
using TaleWorlds.MountAndBlade;

namespace AhFight
{
	// Token: 0x02000006 RID: 6
	public static class AhFightAPI
	{
		// Token: 0x06000072 RID: 114
		public static AhFightState GetAgentState(Agent agent)
		{
			if (agent == null)
			{
				return AhFightState.Normal;
			}
			return AhFightStateManager.GetCurrentState(agent);
		}

		// Token: 0x06000073 RID: 115
		public static float GetCurrentAhFight(Agent agent)
		{
			if (agent == null || !AhFightAgent.values.ContainsKey(agent))
			{
				return 0f;
			}
			return AhFightAgent.values[agent].ahfight;
		}

		// Token: 0x06000074 RID: 116
		public static float GetMaxAhFight(Agent agent)
		{
			if (agent == null || !AhFightAgent.values.ContainsKey(agent))
			{
				return 0f;
			}
			return AhFightAgent.values[agent].maxAhFight;
		}

		// Token: 0x06000075 RID: 117
		public static float GetAhFightRegen(Agent agent)
		{
			if (agent == null || !AhFightAgent.values.ContainsKey(agent))
			{
				return 0f;
			}
			return AhFightAgent.values[agent].regenPerTick;
		}

		// Token: 0x06000076 RID: 118
		public static float ModifyAhFight(Agent agent, float amount)
		{
			if (agent == null || !AhFightAgent.values.ContainsKey(agent))
			{
				return 0f;
			}
			AhFightAgent.values[agent].ahfight += amount;
			AhFightAgent.values[agent].ahfight = Math.Max(0f, Math.Min(AhFightAgent.values[agent].ahfight, AhFightAgent.values[agent].maxAhFight));
			if (amount < 0f)
			{
				AhFightData ahFightData = AhFightAgent.values[agent];
				Mission mission = Mission.Current;
				ahFightData.lastAhFightLossTime = ((mission != null) ? mission.CurrentTime : 0f);
			}
			return AhFightAgent.values[agent].ahfight;
		}

		// Token: 0x06000077 RID: 119
		public static float ModifyMaxAhFight(Agent agent, float amount)
		{
			if (agent == null || !AhFightAgent.values.ContainsKey(agent))
			{
				return 0f;
			}
			AhFightAgent.values[agent].maxAhFight += amount;
			AhFightAgent.values[agent].maxAhFight = Math.Max(1f, AhFightAgent.values[agent].maxAhFight);
			if (AhFightAgent.values[agent].ahfight > AhFightAgent.values[agent].maxAhFight)
			{
				AhFightAgent.values[agent].ahfight = AhFightAgent.values[agent].maxAhFight;
			}
			return AhFightAgent.values[agent].maxAhFight;
		}

		// Token: 0x06000078 RID: 120
		public static float ModifyAhFightRegen(Agent agent, float amount)
		{
			if (agent == null || !AhFightAgent.values.ContainsKey(agent))
			{
				return 0f;
			}
			AhFightAgent.values[agent].regenPerTick += amount;
			AhFightAgent.values[agent].regenPerTick = Math.Max(0f, AhFightAgent.values[agent].regenPerTick);
			return AhFightAgent.values[agent].regenPerTick;
		}

		// Token: 0x06000079 RID: 121
		public static bool IsAgentInState(Agent agent, AhFightState state)
		{
			return agent != null && AhFightStateManager.IsInState(agent, state);
		}

		// Token: 0x0600007A RID: 122
		public static string GetStateDescription(AhFightState state)
		{
			return AhFightStateManager.GetStateDescription(state);
		}

		// Token: 0x0600007B RID: 123
		public static bool HasAhFightData(Agent agent)
		{
			return agent != null && AhFightAgent.values.ContainsKey(agent);
		}

		// Token: 0x0600007C RID: 124
		public static bool InitializeAhFightData(Agent agent)
		{
			if (agent == null || AhFightAgent.values.ContainsKey(agent))
			{
				return false;
			}
			AhFightAgent.values[agent] = new AhFightData();
			return true;
		}

		// Token: 0x0600007D RID: 125
		public static bool IsDefaultUIEnabled()
		{
			return AhFightConfig.ahfightGUIEnabled;
		}

		// Token: 0x0600007E RID: 126
		public static AhFightView GetAhFightView()
		{
			AhFightViewControl ahfightVisual = AhFightAgent.ahfightVisual;
			if (ahfightVisual == null)
			{
				return null;
			}
			return ahfightVisual._dataSource;
		}

		// Token: 0x0600007F RID: 127
		public static int GetMainAgentAhFightUIValue()
		{
			if (AhFightAgent.ahfightVisual == null)
			{
				return 0;
			}
			return AhFightAgent.ahfightVisual.PlayerAhFight;
		}

		// Token: 0x06000080 RID: 128
		public static int GetMainAgentMaxAhFightUIValue()
		{
			if (AhFightAgent.ahfightVisual == null)
			{
				return 0;
			}
			return AhFightAgent.ahfightVisual.PlayerAhFightMax;
		}

		// Token: 0x06000081 RID: 129
		public static string GetMainAgentAhFightStateText()
		{
			if (AhFightAgent.ahfightVisual == null)
			{
				return string.Empty;
			}
			return AhFightAgent.ahfightVisual.AhFightStateText;
		}

		// Token: 0x0400002C RID: 44
		public static readonly string Version = "1.0.0";
	}
}
