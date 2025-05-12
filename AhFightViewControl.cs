using System;
using TaleWorlds.Engine.GauntletUI;
using TaleWorlds.GauntletUI.Data;
using TaleWorlds.MountAndBlade;
using TaleWorlds.MountAndBlade.View.Screens;
using TaleWorlds.ScreenSystem;

namespace AhFight
{
	// Token: 0x0200000D RID: 13
	public class AhFightViewControl : MissionBehavior
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000A4 RID: 164
		public override MissionBehaviorType BehaviorType
		{
			get
			{
				return MissionBehaviorType.Other;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000A5 RID: 165
		// (set) Token: 0x060000A6 RID: 166
		public AhFightView _dataSource { get; private set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000A7 RID: 167
		public bool IsEnabled
		{
			get
			{
				return AhFightConfig.ahfightGUIEnabled;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000A8 RID: 168
		// (set) Token: 0x060000A9 RID: 169
		public int PlayerAhFight
		{
			get
			{
				AhFightView dataSource = this._dataSource;
				if (dataSource == null)
				{
					return 0;
				}
				return dataSource.PlayerAhFight;
			}
			set
			{
				if (this._dataSource != null)
				{
					this._dataSource.PlayerAhFight = value;
				}
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000AA RID: 170
		// (set) Token: 0x060000AB RID: 171
		public int PlayerAhFightMax
		{
			get
			{
				AhFightView dataSource = this._dataSource;
				if (dataSource == null)
				{
					return 0;
				}
				return dataSource.PlayerAhFightMax;
			}
			set
			{
				if (this._dataSource != null)
				{
					this._dataSource.PlayerAhFightMax = value;
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000AC RID: 172
		// (set) Token: 0x060000AD RID: 173
		public string PlayerAhFightText
		{
			get
			{
				AhFightView dataSource = this._dataSource;
				if (dataSource == null)
				{
					return null;
				}
				return dataSource.PlayerAhFightText;
			}
			set
			{
				if (this._dataSource != null)
				{
					this._dataSource.PlayerAhFightText = value;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000AE RID: 174
		// (set) Token: 0x060000AF RID: 175
		public string PlayerAhFightMaxText
		{
			get
			{
				AhFightView dataSource = this._dataSource;
				if (dataSource == null)
				{
					return null;
				}
				return dataSource.PlayerAhFightMaxText;
			}
			set
			{
				if (this._dataSource != null)
				{
					this._dataSource.PlayerAhFightMaxText = value;
				}
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060000B0 RID: 176
		// (set) Token: 0x060000B1 RID: 177
		public string AhFightStateText
		{
			get
			{
				AhFightView dataSource = this._dataSource;
				if (dataSource == null)
				{
					return null;
				}
				return dataSource.AhFightStateText;
			}
			set
			{
				if (this._dataSource != null)
				{
					this._dataSource.AhFightStateText = value;
				}
			}
		}

		// Token: 0x060000B2 RID: 178
		public override void AfterStart()
		{
			try
			{
				base.AfterStart();
				if (this.IsEnabled)
				{
					MissionScreen missionScreen = ScreenManager.TopScreen as MissionScreen;
					if (missionScreen != null)
					{
						this._dataSource = new AhFightView();
						this._gauntletLayer = new GauntletLayer(-1, "GauntletLayer", false);
						missionScreen.AddLayer(this._gauntletLayer);
						this._gauntletMovie = this._gauntletLayer.LoadMovie("FightUI", this._dataSource);
						this._dataSource.ShowPlayerAhFightStatus = true;
						AhFightAgent.ahfightVisual = this;
						this._isInitialized = true;
					}
				}
			}
			catch (Exception ex)
			{
				DebugHelper.LogError("UI", "初始化错误", ex);
			}
		}

		// Token: 0x060000B3 RID: 179
		public override void OnMissionTick(float dt)
		{
			if (!this._isInitialized || !this.IsEnabled || this._dataSource == null)
			{
				return;
			}
			if (Agent.Main != null)
			{
				DateTime now = DateTime.Now;
				this.UpdatePlayerAhFight();
				double totalMilliseconds = (DateTime.Now - now).TotalMilliseconds;
			}
		}

		// Token: 0x060000B4 RID: 180
		private void UpdatePlayerAhFight()
		{
			if (this._dataSource == null)
			{
				return;
			}
			AhFightData ahFightData;
			if (AhFightAgent.values.TryGetValue(Agent.Main, out ahFightData))
			{
				this._dataSource.PlayerAhFight = (int)ahFightData.ahfight;
				this._dataSource.PlayerAhFightMax = (int)ahFightData.maxAhFight;
				if (AhFightConfig.ahfightTextEnabled)
				{
					this._dataSource.PlayerAhFightText = ((int)ahFightData.ahfight).ToString();
					this._dataSource.PlayerAhFightMaxText = ((int)ahFightData.maxAhFight).ToString();
				}
				AhFightState currentState = AhFightStateManager.GetCurrentState(Agent.Main);
				this._dataSource.AhFightStateText = AhFightStateManager.GetStateDescription(currentState);
				this._dataSource.ShowPlayerAhFightStatus = true;
			}
		}

		// Token: 0x060000B5 RID: 181
		public override void OnRemoveBehavior()
		{
			try
			{
				if (this._gauntletLayer != null)
				{
					MissionScreen missionScreen = ScreenManager.TopScreen as MissionScreen;
					if (missionScreen != null)
					{
						missionScreen.RemoveLayer(this._gauntletLayer);
					}
				}
				this._gauntletLayer = null;
				this._gauntletMovie = null;
				this._dataSource = null;
				this._isInitialized = false;
				base.OnRemoveBehavior();
			}
			catch (Exception ex)
			{
				DebugHelper.LogError("UI", "清理错误", ex);
			}
		}

		// Token: 0x04000043 RID: 67
		private const string MODULE_NAME = "UI";

		// Token: 0x04000044 RID: 68
		protected GauntletLayer _gauntletLayer;

		// Token: 0x04000045 RID: 69
		protected IGauntletMovie _gauntletMovie;

		// Token: 0x04000047 RID: 71
		protected bool _isInitialized;
	}
}
