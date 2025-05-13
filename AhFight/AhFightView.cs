using System;
using TaleWorlds.Library;

namespace AhFight
{
	// Token: 0x0200000C RID: 12
	public class AhFightView : ViewModel
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000094 RID: 148
		// (set) Token: 0x06000095 RID: 149
		[DataSourceProperty]
		public string AhFightStateText
		{
			get
			{
				return this._ahfightStateText;
			}
			set
			{
				if (this._ahfightStateText != value)
				{
					this._ahfightStateText = value;
					base.OnPropertyChangedWithValue<string>(value, "AhFightStateText");
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000096 RID: 150
		// (set) Token: 0x06000097 RID: 151
		[DataSourceProperty]
		public bool ShowPlayerAhFightStatus
		{
			get
			{
				return this._showPlayerAhFightStatus;
			}
			set
			{
				if (this._showPlayerAhFightStatus != value)
				{
					this._showPlayerAhFightStatus = value;
					base.OnPropertyChanged("ShowPlayerAhFightStatus");
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000098 RID: 152
		// (set) Token: 0x06000099 RID: 153
		[DataSourceProperty]
		public int PlayerAhFight
		{
			get
			{
				return this._playerAhFight;
			}
			set
			{
				if (this._playerAhFight != value)
				{
					this._playerAhFight = value;
					if (AhFightConfig.ahfightTextEnabled)
					{
						this.PlayerAhFightText = value.ToString();
					}
					this.UpdateAhFightStateText((float)(value / this._playerAhFightMax));
					base.OnPropertyChanged("PlayerAhFight");
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600009A RID: 154
		// (set) Token: 0x0600009B RID: 155
		[DataSourceProperty]
		public int PlayerAhFightMax
		{
			get
			{
				return this._playerAhFightMax;
			}
			set
			{
				if (this._playerAhFightMax != value)
				{
					this._playerAhFightMax = value;
					if (AhFightConfig.ahfightTextEnabled)
					{
						this.PlayerAhFightMaxText = value.ToString();
					}
					this.UpdateAhFightStateText((float)(this._playerAhFight / value));
					base.OnPropertyChanged("PlayerAhFightMax");
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600009C RID: 156
		// (set) Token: 0x0600009D RID: 157
		[DataSourceProperty]
		public string PlayerAhFightText
		{
			get
			{
				if (!AhFightConfig.ahfightTextEnabled)
				{
					return "";
				}
				return this._playerAhFightText;
			}
			set
			{
				if (this._playerAhFightText != value)
				{
					this._playerAhFightText = value;
					base.OnPropertyChangedWithValue<string>(value, "PlayerAhFightText");
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600009E RID: 158
		// (set) Token: 0x0600009F RID: 159
		[DataSourceProperty]
		public string PlayerAhFightMaxText
		{
			get
			{
				if (!AhFightConfig.ahfightTextEnabled)
				{
					return "";
				}
				return this._playerAhFightMaxText;
			}
			set
			{
				if (this._playerAhFightMaxText != value)
				{
					this._playerAhFightMaxText = value;
					base.OnPropertyChangedWithValue<string>(value, "PlayerAhFightMaxText");
				}
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000A0 RID: 160
		// (set) Token: 0x060000A1 RID: 161
		[DataSourceProperty]
		public string SeparatorText
		{
			get
			{
				if (!AhFightConfig.ahfightTextEnabled)
				{
					return "";
				}
				return "/";
			}
			set
			{
			}
		}

		// Token: 0x060000A2 RID: 162
		public AhFightView()
		{
			this._showPlayerAhFightStatus = false;
			this._playerAhFight = 0;
			this._playerAhFightMax = 100;
		}

		// Token: 0x060000A3 RID: 163
		private void UpdateAhFightStateText(float ratio)
		{
			AhFightState ahFightState;
			if (ratio >= 0.75f)
			{
				ahFightState = AhFightState.Normal;
			}
			else if (ratio >= 0.5f)
			{
				ahFightState = AhFightState.Weak;
			}
			else if (ratio >= 0.25f)
			{
				ahFightState = AhFightState.Tired;
			}
			else
			{
				ahFightState = AhFightState.Powerless;
			}
			this._ahfightStateText = AhFightStateManager.GetStateDescription(ahFightState);
			base.OnPropertyChanged("AhFightStateText");
		}

		// Token: 0x0400003D RID: 61
		private bool _showPlayerAhFightStatus;

		// Token: 0x0400003E RID: 62
		private int _playerAhFight;

		// Token: 0x0400003F RID: 63
		private int _playerAhFightMax;

		// Token: 0x04000040 RID: 64
		private string _playerAhFightText = "100";

		// Token: 0x04000041 RID: 65
		private string _playerAhFightMaxText = "100";

		// Token: 0x04000042 RID: 66
		private string _ahfightStateText;
	}
}
