using System;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace AhFight
{
	// Token: 0x02000009 RID: 9
	public class AhFightStateManager
	{
		// Token: 0x06000084 RID: 132
		public static AhFightState GetCurrentState(Agent agent)
		{
			if (agent == null || !AhFightAgent.values.ContainsKey(agent))
			{
				return AhFightState.Normal;
			}
			AhFightData ahFightData = AhFightAgent.values[agent];
			float ahfight = ahFightData.ahfight;
			float num = ahFightData.ahfight / ahFightData.maxAhFight;
			if (ahfight > 30f && num >= 0.75f)
			{
				return AhFightState.Normal;
			}
			if (ahfight > 20f && num >= 0.5f)
			{
				return AhFightState.Weak;
			}
			if (ahfight > 10f && num >= 0.25f)
			{
				return AhFightState.Tired;
			}
			return AhFightState.Powerless;
		}

		// Token: 0x06000085 RID: 133
		public static bool IsInState(Agent agent, AhFightState state)
		{
			return AhFightStateManager.GetCurrentState(agent) == state;
		}

		// Token: 0x06000086 RID: 134
		public static string GetStateDescription(AhFightState state)
		{
			switch (state)
			{
			case AhFightState.Normal:
				return new TextObject("{=ahfight_state_normal}Normal", null).ToString();
			case AhFightState.Weak:
				return new TextObject("{=ahfight_state_weak}Weak", null).ToString();
			case AhFightState.Tired:
				return new TextObject("{=ahfight_state_tired}Tired", null).ToString();
			case AhFightState.Powerless:
				return new TextObject("{=ahfight_state_powerless}Powerless", null).ToString();
			default:
				return new TextObject("{=ahfight_state_unknown}Unknown", null).ToString();
			}
		}

		// Token: 0x04000037 RID: 55
		private const string MODULE_NAME = "StateManager";
	}
}
