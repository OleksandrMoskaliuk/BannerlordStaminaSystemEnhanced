using System;
using System.Reflection;
using AhFight.Settings;
using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace AhFight
{
	// Token: 0x0200000A RID: 10
	public class SubModule : MBSubModuleBase
	{
		// Token: 0x06000088 RID: 136
		protected override void OnSubModuleLoad()
		{
			base.OnSubModuleLoad();
		}

		// Token: 0x06000089 RID: 137
		public override void OnGameInitializationFinished(Game game)
		{
			base.OnGameInitializationFinished(game);
			try
			{
				AhFightConfig.Initialize();
				new McmSetting();
				string text = "mod.bannerlord.ahfight";
				foreach (MethodBase methodBase in Harmony.GetAllPatchedMethods())
				{
					Patches patchInfo = Harmony.GetPatchInfo(methodBase);
					if (patchInfo != null && patchInfo.Owners.Contains(text))
					{
						SubModule.harmony.UnpatchAll(text);
						break;
					}
				}
				SubModule.harmony = new Harmony(text);
				SubModule.harmony.PatchAll(Assembly.GetExecutingAssembly());
			}
			catch (Exception ex)
			{
				InformationManager.DisplayMessage(new InformationMessage("Ahfight: Harmony补丁失败" + ex.Message, Colors.Red));
			}
		}

		// Token: 0x0600008A RID: 138
		protected override void OnBeforeInitialModuleScreenSetAsRoot()
		{
			base.OnBeforeInitialModuleScreenSetAsRoot();
		}

		// Token: 0x0600008B RID: 139
		public override void OnMissionBehaviorInitialize(Mission mission)
		{
			try
			{
				base.OnMissionBehaviorInitialize(mission);
				if (mission == null)
				{
					DebugHelper.LogError("Main", "Mission对象为空", null);
				}
				else
				{
					mission.AddMissionBehavior(new AhFightMissionLogic());
					if (mission.GetMissionBehavior<AhFightViewControl>() == null)
					{
						mission.AddMissionBehavior(new AhFightViewControl());
					}
				}
			}
			catch (Exception ex)
			{
				InformationManager.DisplayMessage(new InformationMessage("战斗行为初始化错误，" + ex.Message, Colors.Red));
			}
		}

		// Token: 0x0600008C RID: 140
		public override void OnGameEnd(Game game)
		{
			base.OnGameEnd(game);
			SubModule.harmony.UnpatchAll("mod.bannerlord.ahfight");
		}

		// Token: 0x04000038 RID: 56
		protected static Harmony harmony;

		// Token: 0x04000039 RID: 57
		private const string MODULE_NAME = "Main";
	}
}
