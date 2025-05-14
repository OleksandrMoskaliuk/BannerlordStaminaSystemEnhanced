using System;
using AhFight.Settings;
using MCM.Abstractions.Base.Global;

namespace AhFight
{
	// Token: 0x02000002 RID: 2
	public static class AhFightConfig
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		public static bool ahfightEnabled
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				return instance == null || instance.AhfightEnabled;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2
		public static bool ahfightGUIEnabled
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				return instance == null || instance.AhfightGUIEnabled;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3
		public static bool ahfightTextEnabled
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				return instance == null || instance.AhfightTextEnabled;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4
		public static bool movementPenaltyEnabled
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				return instance == null || instance.MovementPenaltyEnabled;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000005 RID: 5
		public static bool hitDamagePenaltyEnabled
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				return instance == null || instance.HitDamagePenaltyEnabled;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000006 RID: 6
		public static bool WeaponDropEnabled
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				return instance == null || instance.WeaponDropEnabled;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000007 RID: 7
		public static bool ShieldDropEnabled
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				return instance == null || instance.ShieldDropEnabled;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000008 RID: 8
		public static float playerAhFightBase
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1f;
				}
				return instance.PlayerAhFightBase;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000009 RID: 9
		public static float playerAhFightRegenBase
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1f;
				}
				return instance.PlayerAhFightRegenBase;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000A RID: 10
		public static float baseAhFight
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 100f;
				}
				return instance.BaseAhFight;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000B RID: 11
		public static float baseAhFightRegen
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.05f;
				}
				return instance.BaseAhFightRegen;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000C RID: 12
		public static float ahfightResetModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.4f;
				}
				return instance.AhfightResetModifier;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600000D RID: 13
		public static float normalRegenModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.2f;
				}
				return instance.NormalRegenModifier;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600000E RID: 14
		public static float weakRegenModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1f;
				}
				return instance.WeakRegenModifier;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600000F RID: 15
		public static float tiredRegenModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.8f;
				}
				return instance.TiredRegenModifier;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000010 RID: 16
		public static float powerlessRegenModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.5f;
				}
				return instance.PowerlessRegenModifier;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000011 RID: 17
		public static float athleticBase
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 35f;
				}
				return instance.AthleticBase;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000012 RID: 18
		public static float weaponSkillBase
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 65f;
				}
				return instance.WeaponSkillBase;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000013 RID: 19
		public static float weaponSkillModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 200f;
				}
				return instance.WeaponSkillModifier;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000014 RID: 20
		public static float weaponSkillRegenBase
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.021f;
				}
				return instance.WeaponSkillRegenBase;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000017 RID: 23
		public static float MinMovementPenaltyMultiplier
        {
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.45f;
				}
				return instance.MinMovementPenaltyMultiplier;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000018 RID: 24
		public static float MovementPenaltyAHThreshold
        {
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.8f;
				}
				return instance.MovementPenaltyAHThreshold;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000019 RID: 25
		public static float baseAhFightDamage
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 20f;
				}
				return instance.BaseAhFightDamage;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600001A RID: 26
		public static float attackerAhFightMultiplier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.5f;
				}
				return instance.AttackerAhFightMultiplier;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600001B RID: 27
		public static float defenderAhFightMultiplier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1f;
				}
				return instance.DefenderAhFightMultiplier;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600001C RID: 28
		public static float stanceLossModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 20f;
				}
				return instance.StanceLossModifier;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600001D RID: 29
		public static float shieldStanceLossModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 8f;
				}
				return instance.ShieldStanceLossModifier;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600001E RID: 30
		public static float heavyWeaponKnockDownBaseChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.3f;
				}
				return instance.HeavyWeaponKnockDownBaseChance;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600001F RID: 31
		public static float heavyWeaponKnockBackBaseChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.4f;
				}
				return instance.HeavyWeaponKnockBackBaseChance;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000020 RID: 32
		public static float normalWeaponKnockBackBaseChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.25f;
				}
				return instance.NormalWeaponKnockBackBaseChance;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000021 RID: 33
		public static float lowAhFightEffectThreshold
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.3f;
				}
				return instance.LowAhFightEffectThreshold;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000022 RID: 34
		public static float lowAhFightEffectMultiplier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 2f;
				}
				return instance.LowAhFightEffectMultiplier;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000023 RID: 35
		public static float maxEffectChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.7f;
				}
				return instance.MaxEffectChance;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000024 RID: 36
		public static float legHitKnockDownThreshold
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 80f;
				}
				return instance.LegHitKnockDownThreshold;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000025 RID: 37
		public static float baseDismountChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.4f;
				}
				return instance.BaseDismountChance;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000026 RID: 38
		public static float ridingSkillDismountResistance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.003f;
				}
				return instance.RidingSkillDismountResistance;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000027 RID: 39
		public static float minDismountChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.01f;
				}
				return instance.MinDismountChance;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000028 RID: 40
		public static float maxDismountChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.7f;
				}
				return instance.MaxDismountChance;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000029 RID: 41
		public static float blockDismountChanceModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.5f;
				}
				return instance.BlockDismountChanceModifier;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600002A RID: 42
		public static float polearmDismountModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1f;
				}
				return instance.PolearmDismountModifier;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600002B RID: 43
		public static float heavyWeaponDismountModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.8f;
				}
				return instance.HeavyWeaponDismountModifier;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600002C RID: 44
		public static float otherWeaponDismountModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.4f;
				}
				return instance.OtherWeaponDismountModifier;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600002D RID: 45
		public static float mountedDropResistance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.4f;
				}
				return instance.MountedDropResistance;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600002E RID: 46
		public static float mountedMaxDropChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.4f;
				}
				return instance.MountedMaxDropChance;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600002F RID: 47
		public static float maxShieldBlockExhaustedDropChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.08f;
				}
				return instance.MaxShieldBlockExhaustedDropChance;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000030 RID: 48
		public static float maxWeaponBlockExhaustedDropChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.1f;
				}
				return instance.MaxWeaponBlockExhaustedDropChance;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000031 RID: 49
		public static float maxStrikeExhaustedDropChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.13f;
				}
				return instance.MaxStrikeExhaustedDropChance;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000032 RID: 50
		public static float headHitDismountModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.5f;
				}
				return instance.HeadHitDismountModifier;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000033 RID: 51
		public static float legHitDismountModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.3f;
				}
				return instance.LegHitDismountModifier;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000034 RID: 52
		public static float bodyHitDismountModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1f;
				}
				return instance.BodyHitDismountModifier;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000035 RID: 53
		public static float otherHitDismountModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.6f;
				}
				return instance.OtherHitDismountModifier;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000036 RID: 54
		public static float lowAhFightDismountThreshold
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.15f;
				}
				return instance.LowAhFightDismountThreshold;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000037 RID: 55
		public static float lowAhFightDismountMultiplier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.5f;
				}
				return instance.LowAhFightDismountMultiplier;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000038 RID: 56
		public static float perfectBlockBaseChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.15f;
				}
				return instance.PerfectBlockBaseChance;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000039 RID: 57
		public static float perfectBlockSkillBonusMax
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.15f;
				}
				return instance.PerfectBlockSkillBonusMax;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600003A RID: 58
		public static float sideAttackBlockModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.9f;
				}
				return instance.SideAttackBlockModifier;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600003B RID: 59
		public static float overheadAttackBlockModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.7f;
				}
				return instance.OverheadAttackBlockModifier;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600003C RID: 60
		public static float thrustAttackBlockModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.8f;
				}
				return instance.ThrustAttackBlockModifier;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600003D RID: 61
		public static float twoHandedHeavyBlockModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.6f;
				}
				return instance.TwoHandedHeavyBlockModifier;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600003E RID: 62
		public static float oneHandedBluntBlockModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.7f;
				}
				return instance.OneHandedBluntBlockModifier;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600003F RID: 63
		public static float twoHandedBlockModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.8f;
				}
				return instance.TwoHandedBlockModifier;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000040 RID: 64
		public static float perfectBlockStanceBonus
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.18f;
				}
				return instance.PerfectBlockStanceBonus;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000041 RID: 65
		public static float shieldPerfectBlockStanceBonus
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.095f;
				}
				return instance.ShieldPerfectBlockStanceBonus;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000042 RID: 66
		public static float thrustStanceLossModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.2f;
				}
				return instance.ThrustStanceLossModifier;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000043 RID: 67
		public static float swingStanceLossModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.8f;
				}
				return instance.SwingStanceLossModifier;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000044 RID: 68
		public static float oneHandedSwordSwingModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.85f;
				}
				return instance.OneHandedSwordSwingModifier;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000045 RID: 69
		public static float twoHandedSwordSwingModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.1f;
				}
				return instance.TwoHandedSwordSwingModifier;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000046 RID: 70
		public static float oneHandedBluntSwingModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1f;
				}
				return instance.OneHandedBluntSwingModifier;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000047 RID: 71
		public static float twoHandedBluntSwingModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.25f;
				}
				return instance.TwoHandedBluntSwingModifier;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000048 RID: 72
		public static float polearmSwingModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.15f;
				}
				return instance.PolearmSwingModifier;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000049 RID: 73
		public static float stanceLossBaseMultiplier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 20f;
				}
				return instance.StanceLossBaseMultiplier;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600004A RID: 74
		public static float stanceDamageReductionFactor
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1f;
				}
				return instance.StanceDamageReductionFactor;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600004B RID: 75
		public static float weaponTipHitStanceLossModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.08f;
				}
				return instance.WeaponTipHitStanceLossModifier;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600004C RID: 76
		public static float weaponBladeHitStanceLossModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.05f;
				}
				return instance.WeaponBladeHitStanceLossModifier;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600004D RID: 77
		public static float largeShieldDefenseModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.7f;
				}
				return instance.LargeShieldDefenseModifier;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600004E RID: 78
		public static float smallShieldDefenseModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.9f;
				}
				return instance.SmallShieldDefenseModifier;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600004F RID: 79
		public static float perfectShieldBlockModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.3f;
				}
				return instance.PerfectShieldBlockModifier;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000050 RID: 80
		public static float correctSideShieldBlockModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.4f;
				}
				return instance.CorrectSideShieldBlockModifier;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000051 RID: 81
		public static float wrongSideShieldBlockModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.1f;
				}
				return instance.WrongSideShieldBlockModifier;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000052 RID: 82
		public static float handHitWeaponDropBaseChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.1f;
				}
				return instance.HandHitWeaponDropBaseChance;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000053 RID: 83
		public static float stanceWeaponDropModifier
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 1.5f;
				}
				return instance.StanceWeaponDropModifier;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000054 RID: 84
		public static float skillWeaponDropDivisor
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 30f;
				}
				return instance.SkillWeaponDropDivisor;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000055 RID: 85
		public static float minWeaponDropChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.03f;
				}
				return instance.MinWeaponDropChance;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000056 RID: 86
		public static float maxWeaponDropChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.45f;
				}
				return instance.MaxWeaponDropChance;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000057 RID: 87
		public static float exhaustedBothDropBaseChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.3f;
				}
				return instance.ExhaustedBothDropBaseChance;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000058 RID: 88
		public static float exhaustedWeaponDropChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.6f;
				}
				return instance.ExhaustedWeaponDropChance;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000059 RID: 89
		public static float maxAttackerStanceLoss
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 15f;
				}
				return instance.MaxAttackerStanceLoss;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600005A RID: 90
		public static float maxDefenderStanceLoss
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 25f;
				}
				return instance.MaxDefenderStanceLoss;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600005B RID: 91
		public static bool missileEffectEnabled
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				return instance == null || instance.MissileEffectEnabled;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600005C RID: 92
		public static bool missileLossEnabled
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				return instance == null || instance.MissileLossEnabled;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600005D RID: 93
		public static float rangedBaseResistance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.25f;
				}
				return instance.RangedBaseResistance;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600005E RID: 94
		public static float rangedMaxEffectChance
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.6f;
				}
				return instance.RangedMaxEffectChance;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600005F RID: 95
		public static float missileBlockedAhLossBase
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 8f;
				}
				return instance.RangedShieldLoss;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000060 RID: 96
		public static float missileDirectHitAhLossBase
		{
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 12f;
				}
				return instance.RangedHitLoss;
			}
		}

		

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000063 RID: 99
		public static float MinDamageMultiplier
        {
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.7f;
				}
				return instance.MinDamageMultiplier;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000064 RID: 100
		public static float DamageReductionThreshold
        {
			get
			{
				McmSetting instance = GlobalSettings<McmSetting>.Instance;
				if (instance == null)
				{
					return 0.1f;
				}
				return instance.DamageReductionThreshold;
			}
		}

        public static float CrushThroughBlockThreshold
        {
            get
            {
                McmSetting instance = GlobalSettings<McmSetting>.Instance;
                if (instance == null)
                {
                    return 0.45f;
                }
                return instance.CrushThroughBlockThreshold;
            }
        }

        public static float StaminaDamageAmountOnBlock
        {
            get
            {
                McmSetting instance = GlobalSettings<McmSetting>.Instance;
                if (instance == null)
                {
                    return 0.45f;
                }
                return instance.StaminaDamageAmountOnBlock;
            }
        }

        public static bool AttackSpeedPenaltyEnabled
        {
            get
            {
                McmSetting instance = GlobalSettings<McmSetting>.Instance;
                return instance == null || instance.AttackSpeedPenaltyEnabled;
            }
        }

        public static float MinAttackSpeedMultiplier
        {
            get
            {
                McmSetting instance = GlobalSettings<McmSetting>.Instance;
                if (instance == null)
                {
                    return 0.2f;
                }
                return instance.MinAttackSpeedMultiplier;
            }
        }

        public static float LowAhAttackSpeedThreshold
        {
            get
            {
                McmSetting instance = GlobalSettings<McmSetting>.Instance;
                if (instance == null)
                {
                    return 0.8f;
                }
                return instance.LowStaminaAttackSpeedThreshold;
            }
        }

        // Token: 0x06000065 RID: 101
        public static void Initialize()
		{
		}

		// Token: 0x04000001 RID: 1
		public static float cacheCleanupInterval = 5f;

		// Token: 0x04000002 RID: 2
		public static float cacheEntryMaxAge = 1.5f;

		// Token: 0x04000003 RID: 3
		public static float weaponTipBlockModifier = 0.7f;

		// Token: 0x04000004 RID: 4
		public static float weaponBladeBlockModifier = 0.8f;

		// Token: 0x04000005 RID: 5
		public static float swingSpeedTransfer = 4.5454545f;

		// Token: 0x04000006 RID: 6
		public static float thrustSpeedTransfer = 4f;

		// Token: 0x04000007 RID: 7
		public static float oneHandedPolearmThrustStrength = 1.2f;

		// Token: 0x04000008 RID: 8
		public static float twoHandedPolearmThrustStrength = 2f;

		// Token: 0x04000009 RID: 9
		public static float skillBothDropDivisor = 350f;

		// Token: 0x0400000A RID: 10
		public static float minPerfectBlockDropChance = 0.02f;

		// Token: 0x0400000B RID: 11
		public static float baseWeaponDropChance = 0.08f;

		// Token: 0x0400000C RID: 12
		public static float shieldBlockDropModifier = 0.15f;

		// Token: 0x0400000D RID: 13
		public static float attackerStanceDropModifier = 0.4f;

		// Token: 0x0400000E RID: 14
		public static float defenderStanceDropModifier = 0.3f;

		// Token: 0x0400000F RID: 15
		public static float skillDifferenceDropModifier = 0.2f;

		// Token: 0x04000010 RID: 16
		public static float maxSkillDifferenceEffect = 0.12f;

		// Token: 0x04000011 RID: 17
		public static float daggerDropModifier = 0.15f;

		// Token: 0x04000012 RID: 18
		public static float oneHandedSwordDropModifier = 0.03f;

		// Token: 0x04000013 RID: 19
		public static float twoHandedSwordDropModifier = -0.1f;

		// Token: 0x04000014 RID: 20
		public static float axeDropModifier = -0.14f;

		// Token: 0x04000015 RID: 21
		public static float bluntDropModifier = -0.15f;

		// Token: 0x04000016 RID: 22
		public static float weaponTipDropModifier = -0.05f;

		// Token: 0x04000017 RID: 23
		public static float weaponBladeDropModifier = 0.02f;

		// Token: 0x04000018 RID: 24
		public static float weaponHandleDropModifier = 0.04f;

		// Token: 0x04000019 RID: 25
		public static float baseKnockbackChance = 0.4f;

		// Token: 0x0400001A RID: 26
		public static float shieldBlockKnockbackModifier = 0.4f;

		// Token: 0x0400001B RID: 27
		public static float attackerStanceKnockbackModifier = 0.3f;

		// Token: 0x0400001C RID: 28
		public static float defenderStanceKnockbackModifier = 0.2f;

		// Token: 0x0400001D RID: 29
		public static float skillDifferenceKnockbackModifier = 0.6f;

		// Token: 0x0400001E RID: 30
		public static float minKnockbackChance = 0.2f;

		// Token: 0x0400001F RID: 31
		public static float maxKnockbackChance = 0.8f;

		// Token: 0x04000020 RID: 32
		public static float missileBlockedAhLossVariation = 3f;

		// Token: 0x04000021 RID: 33
		public static float missileDirectHitAhLossVariation = 5f;

		// Token: 0x02000015 RID: 21
		public static class StateDropSettings
		{
			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060001BE RID: 446
			public static bool NormalStateDropEnabled
			{
				get
				{
					McmSetting instance = GlobalSettings<McmSetting>.Instance;
					return instance != null && instance.NormalStateDropEnabled;
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060001BF RID: 447
			public static bool WeakStateDropEnabled
			{
				get
				{
					McmSetting instance = GlobalSettings<McmSetting>.Instance;
					return instance == null || instance.WeakStateDropEnabled;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060001C0 RID: 448
			public static bool TiredStateDropEnabled
			{
				get
				{
					McmSetting instance = GlobalSettings<McmSetting>.Instance;
					return instance == null || instance.TiredStateDropEnabled;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060001C1 RID: 449
			public static bool PowerlessStateDropEnabled
			{
				get
				{
					McmSetting instance = GlobalSettings<McmSetting>.Instance;
					return instance == null || instance.PowerlessStateDropEnabled;
				}
			}
		}
	}
}
