using System;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;
using TaleWorlds.Localization;

namespace AhFight.Settings
{
	// Token: 0x0200000E RID: 14
	public class McmSetting : AttributeGlobalSettings<McmSetting>
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060000B7 RID: 183
		public override string Id
		{
			get
			{
				return "AhFight_b1";
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060000B8 RID: 184
		public override string DisplayName
		{
			get
			{
				return new TextObject("AhFight", null).ToString();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060000B9 RID: 185
		public override string FolderName
		{
			get
			{
				return "AhFight";
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060000BA RID: 186
		public override string FormatType
		{
			get
			{
				return "json";
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060000BB RID: 187
		// (set) Token: 0x060000BC RID: 188
		[SettingPropertyBool("{=ah_advanced_settings}Advanced Settings", RequireRestart = false, HintText = "{=ah_advanced_settings_hint}Caution! Advanced parameter settings, please modify with care!", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings", GroupOrder = 100)]
		public bool AdvancedModeEnabled { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060000BD RID: 189
		// (set) Token: 0x060000BE RID: 190
		[SettingPropertyBool("{=ah_main_enabled}Enable MOD Features", RequireRestart = true, HintText = "{=ah_main_enabled_hint}Master Switch", Order = 0)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool AhfightEnabled { get; set; } = true;

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060000BF RID: 191
		// (set) Token: 0x060000C0 RID: 192
		[SettingPropertyBool("{=ah_gui_enabled}Enable UI", RequireRestart = false, HintText = "{=ah_gui_enabled_hint}When enabled, displays AH interface on screen", Order = 1)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool AhfightGUIEnabled { get; set; } = true;

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060000C1 RID: 193
		// (set) Token: 0x060000C2 RID: 194
		[SettingPropertyBool("{=ah_text_enabled}Show Specific Numbers", RequireRestart = false, HintText = "{=ah_text_enabled_hint}Enable or disable the display of specific AH numbers", Order = 2)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool AhfightTextEnabled { get; set; } = true;

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060000C3 RID: 195
		// (set) Token: 0x060000C4 RID: 196
		[SettingPropertyBool("{=ah_movement_penalty_enabled}Enable Movement Speed Penalty", RequireRestart = false, HintText = "{=ah_movement_penalty_enabled_hint}Enable or disable movement speed penalties based on AH status", Order = 3)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool MovementPenaltyEnabled { get; set; } = true;

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060000C5 RID: 197
		// (set) Token: 0x060000C6 RID: 198
		[SettingPropertyBool("{=ah_hit_damage_penalty_enabled}Enable Damage Penalty", RequireRestart = false, HintText = "{=ah_hit_damage_penalty_enabled_hint}When Enable, there are different melee hit damage penalties for different states. The penalty multiplier can be adjusted and even increased .lol", Order = 4)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool HitDamagePenaltyEnabled { get; set; } = true;

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060000C7 RID: 199
		// (set) Token: 0x060000C8 RID: 200
		[SettingPropertyBool("{=ah_weapon_drop_enabled}Enable Weapon Drop", RequireRestart = false, HintText = "{=ah_weapon_drop_enabled_hint}Weapon drop mechanism total switch, disable will not cause weapon drop in any case", Order = 5)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool WeaponDropEnabled { get; set; } = true;

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060000C9 RID: 201
		// (set) Token: 0x060000CA RID: 202
		[SettingPropertyBool("{=ah_shield_drop_enabled}Enable Shield Drop", RequireRestart = false, HintText = "{=ah_shield_drop_enabled_hint}Shield drop mechanism total switch, disable will not cause shield drop in any case", Order = 6)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool ShieldDropEnabled { get; set; } = true;

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060000CB RID: 203
		// (set) Token: 0x060000CC RID: 204
		[SettingPropertyBool("{=ah_normal_state_drop_enabled}Enable weapon drops in Normal state", RequireRestart = false, HintText = "{=ah_normal_state_drop_enabled_hint}When unchecked, weapons won't drop in Normal state. Unchecked by default", Order = 7)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings/{=ah_state_drop_settings}States that can trigger drops", GroupOrder = 0)]
		public bool NormalStateDropEnabled { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060000CD RID: 205
		// (set) Token: 0x060000CE RID: 206
		[SettingPropertyBool("{=ah_weak_state_drop_enabled}Enable weapon drops in Weak state", RequireRestart = false, HintText = "{=ah_weak_state_drop_enabled_hint}When unchecked, weapons won't drop in Weak state", Order = 8)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings/{=ah_state_drop_settings}States that can trigger drops", GroupOrder = 0)]
		public bool WeakStateDropEnabled { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060000CF RID: 207
		// (set) Token: 0x060000D0 RID: 208
		[SettingPropertyBool("{=ah_tired_state_drop_enabled}Enable weapon drops in Tired state", RequireRestart = false, HintText = "{=ah_tired_state_drop_enabled_hint}When unchecked, weapons won't drop in Tired state", Order = 9)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings/{=ah_state_drop_settings}States that can trigger drops", GroupOrder = 0)]
		public bool TiredStateDropEnabled { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060000D1 RID: 209
		// (set) Token: 0x060000D2 RID: 210
		[SettingPropertyBool("{=ah_powerless_state_drop_enabled}Enable weapon drops in Powerless state", RequireRestart = false, HintText = "{=ah_powerless_state_drop_enabled_hint}When unchecked, weapons won't drop in Powerless state", Order = 10)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings/{=ah_state_drop_settings}States that can trigger drops", GroupOrder = 0)]
		public bool PowerlessStateDropEnabled { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060000D3 RID: 211
		// (set) Token: 0x060000D4 RID: 212
		[SettingPropertyFloatingInteger("{=ah_player_ah_multiplier}Player AH Multiplier", 0.1f, 3f, "0.0", RequireRestart = false, HintText = "{=ah_player_ah_multiplier_hint}Player AH multiplier, greater than 1 enhances player, less than 1削弱玩家", Order = 0)]
		[SettingPropertyGroup("{=ah_player_settings}Player Settings", GroupOrder = 1)]
		public float PlayerAhFightBase { get; set; } = 1f;

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060000D5 RID: 213
		// (set) Token: 0x060000D6 RID: 214
		[SettingPropertyFloatingInteger("{=ah_player_ah_regen_multiplier}Player AH Regeneration Multiplier", 0.1f, 5f, "0.0", RequireRestart = false, HintText = "{=ah_player_ah_regen_multiplier_hint}Player AH regeneration multiplier, greater than 1 recovers faster, less than 1 recovers slower. For example: 1.5 means the player recovers twice as fast as NPC", Order = 1)]
		[SettingPropertyGroup("{=ah_player_settings}Player Settings", GroupOrder = 1)]
		public float PlayerAhFightRegenBase { get; set; } = 1f;

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060000D7 RID: 215
		// (set) Token: 0x060000D8 RID: 216
		[SettingPropertyFloatingInteger("{=ah_base_ah}Base AH", 50f, 300f, "0.0", RequireRestart = false, HintText = "{=ah_base_ah_hint}Base without any bonus reduction", Order = 0)]
		[SettingPropertyGroup("{=ah_base_config}Base Configuration", GroupOrder = 2)]
		public float BaseAhFight { get; set; } = 100f;

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060000D9 RID: 217
		// (set) Token: 0x060000DA RID: 218
		[SettingPropertyFloatingInteger("{=ah_base_regen_speed}Base Regeneration Speed", 0.01f, 0.5f, "0.000", RequireRestart = false, HintText = "{=ah_base_regen_speed_hint}Base regeneration speed without any bonus reduction", Order = 1)]
		[SettingPropertyGroup("{=ah_base_config}Base Configuration", GroupOrder = 2)]
		public float BaseAhFightRegen { get; set; } = 0.05f;

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060000DB RID: 219
		// (set) Token: 0x060000DC RID: 220
		[SettingPropertyFloatingInteger("{=ah_exhausted_reset_ratio}Exhausted Regeneration Ratio", 0f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_exhausted_reset_ratio_hint}AH drops to 0 will recover to this ratio. For example: 0.6 means recovery to 60% of the base value,0 means recovery to 0", Order = 2)]
		[SettingPropertyGroup("{=ah_base_config}Base Configuration", GroupOrder = 2)]
		public float AhfightResetModifier { get; set; } = 0.4f;

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060000DD RID: 221
		// (set) Token: 0x060000DE RID: 222
		[SettingPropertyFloatingInteger("{=ah_base_athletic_skill}Base Athletic Skill", 10f, 150f, "0.0", RequireRestart = false, HintText = "{=ah_base_athletic_skill_hint}Base athletic skill value, every character has a base athletic skill value", Order = 0)]
		[SettingPropertyGroup("{=ah_skill_effects}Skill Effects", GroupOrder = 3)]
		public float AthleticBase { get; set; } = 35f;

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060000DF RID: 223
		// (set) Token: 0x060000E0 RID: 224
		[SettingPropertyFloatingInteger("{=ah_base_weapon_skill}Base Weapon Skill", 20f, 200f, "0.0", RequireRestart = false, HintText = "{=ah_base_weapon_skill_hint}Base weapon skill value, every character has a corresponding weapon base weapon skill value", Order = 1)]
		[SettingPropertyGroup("{=ah_skill_effects}Skill Effects", GroupOrder = 3)]
		public float WeaponSkillBase { get; set; } = 65f;

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060000E1 RID: 225
		// (set) Token: 0x060000E2 RID: 226
		[SettingPropertyFloatingInteger("{=ah_weapon_skill_effect_strength}Weapon Skill Effect Strength", 100f, 800f, "0.0", RequireRestart = false, HintText = "{=ah_weapon_skill_effect_strength_hint}Determines the degree of influence of weapon skill on AH. Larger will bring more obvious advantages from skill level differences", Order = 2)]
		[SettingPropertyGroup("{=ah_skill_effects}Skill Effects", GroupOrder = 3)]
		public float WeaponSkillModifier { get; set; } = 200f;

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060000E3 RID: 227
		// (set) Token: 0x060000E4 RID: 228
		[SettingPropertyFloatingInteger("{=ah_weapon_skill_regen_bonus}Weapon Skill Regeneration Bonus", 0.01f, 0.2f, "0.000", RequireRestart = false, HintText = "{=ah_weapon_skill_regen_bonus_hint}Weapon skill's influence on AH regeneration speed. 0.03 means each weapon skill increases 3% of the regeneration speed", Order = 3)]
		[SettingPropertyGroup("{=ah_skill_effects}Skill Effects", GroupOrder = 3)]
		public float WeaponSkillRegenBase { get; set; } = 0.021f;

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060000E5 RID: 229
		// (set) Token: 0x060000E6 RID: 230
		[SettingPropertyFloatingInteger("{=ah_normal_state_speed}Normal State Speed", 0.5f, 2f, "0.0", RequireRestart = false, HintText = "{=ah_normal_state_speed_hint}Movement speed when AH is sufficient. 1.0 is normal speed", Order = 0)]
		[SettingPropertyGroup("{=ah_movement_speed_penalty}Movement Speed Penalty", GroupOrder = 4)]
		public float NormalSpeedModifier { get; set; } = 1f;

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060000E7 RID: 231
		// (set) Token: 0x060000E8 RID: 232
		[SettingPropertyFloatingInteger("{=ah_weak_state_speed}Weak State Speed", 0.2f, 1.5f, "0.0", RequireRestart = false, HintText = "{=ah_weak_state_speed_hint}Movement speed when AH is weak. 0.8 means speed is halved", Order = 1)]
		[SettingPropertyGroup("{=ah_movement_speed_penalty}Movement Speed Penalty", GroupOrder = 4)]
		public float WeakSpeedModifier { get; set; } = 0.8f;

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060000E9 RID: 233
		// (set) Token: 0x060000EA RID: 234
		[SettingPropertyFloatingInteger("{=ah_tired_state_speed}Tired State Speed", 0.1f, 1f, "0.0", RequireRestart = false, HintText = "{=ah_tired_state_speed_hint}Movement speed when AH is tired. 0.5 means speed is reduced to normal 50%", Order = 2)]
		[SettingPropertyGroup("{=ah_movement_speed_penalty}Movement Speed Penalty", GroupOrder = 4)]
		public float TiredSpeedModifier { get; set; } = 0.5f;

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060000EB RID: 235
		// (set) Token: 0x060000EC RID: 236
		[SettingPropertyFloatingInteger("{=ah_powerless_state_speed}Powerless State Speed", 0.05f, 0.8f, "0.0", RequireRestart = false, HintText = "{=ah_powerless_state_speed_hint}Movement speed when AH is powerless. 0.3 means speed is reduced to normal 30%", Order = 3)]
		[SettingPropertyGroup("{=ah_movement_speed_penalty}Movement Speed Penalty", GroupOrder = 4)]
		public float PowerlessSpeedModifier { get; set; } = 0.3f;

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060000ED RID: 237
		// (set) Token: 0x060000EE RID: 238
		[SettingPropertyFloatingInteger("{=ah_normal_state_hit_damage_modifier}Normal State Hit Damage Penalty", 0.1f, 2f, "0.0", RequireRestart = false, HintText = "{=ah_normal_state_hit_damage_modifier_hint}Normal state hit damage penalty, e.g.: 1.0 means no damage change, 0.8 means 20% reduction", Order = 0)]
		[SettingPropertyGroup("{=ah_damage_penalty}Damage Penalty(Only melee)", GroupOrder = 5)]
		public float NormalStateHitDamageModifier { get; set; } = 1f;

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060000EF RID: 239
		// (set) Token: 0x060000F0 RID: 240
		[SettingPropertyFloatingInteger("{=ah_weak_state_hit_damage_modifier}Weak State Hit Damage Penalty", 0.1f, 1.8f, "0.0", RequireRestart = false, HintText = "{=ah_weak_state_hit_damage_modifier_hint}Weak state hit damage penalty, default 0.8, means 20% reduction", Order = 1)]
		[SettingPropertyGroup("{=ah_damage_penalty}Damage Penalty(Only melee)", GroupOrder = 5)]
		public float WeakStateHitDamageModifier { get; set; } = 0.8f;

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060000F1 RID: 241
		// (set) Token: 0x060000F2 RID: 242
		[SettingPropertyFloatingInteger("{=ah_tired_state_hit_damage_modifier}Tired State Hit Damage Penalty", 0.1f, 1.7f, "0.0", RequireRestart = false, HintText = "{=ah_tired_state_hit_damage_modifier_hint}Tired state hit damage penalty, default 0.7, means 30% reduction", Order = 2)]
		[SettingPropertyGroup("{=ah_damage_penalty}Damage Penalty(Only melee)", GroupOrder = 5)]
		public float TiredStateHitDamageModifier { get; set; } = 0.7f;

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060000F3 RID: 243
		// (set) Token: 0x060000F4 RID: 244
		[SettingPropertyFloatingInteger("{=ah_powerless_state_hit_damage_modifier}Powerless State Hit Damage Penalty", 0.1f, 1.6f, "0.0", RequireRestart = false, HintText = "{=ah_powerless_state_hit_damage_modifier_hint}Powerless state hit damage penalty, default 0.5, means 50% reduction", Order = 3)]
		[SettingPropertyGroup("{=ah_damage_penalty}Damage Penalty(Only melee)", GroupOrder = 5)]
		public float PowerlessStateHitDamageModifier { get; set; } = 0.5f;

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060000F5 RID: 245
		// (set) Token: 0x060000F6 RID: 246
		[SettingPropertyFloatingInteger("{=ah_base_ah_loss}Base AH Loss", 10f, 50f, "0.0", RequireRestart = false, HintText = "{=ah_base_ah_loss_hint}Base AH loss per attack or defense, final loss amount adjusted by other factors", Order = 0)]
		[SettingPropertyGroup("{=ah_ah_loss}AH Loss", GroupOrder = 6)]
		public float BaseAhFightDamage { get; set; } = 20f;

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060000F7 RID: 247
		// (set) Token: 0x060000F8 RID: 248
		[SettingPropertyFloatingInteger("{=ah_attacker_hit_ah_loss}Attacker Hit AH Loss Multiplier", 0.1f, 0.7f, "0.00", RequireRestart = false, HintText = "{=ah_attacker_hit_ah_loss_hint}Attacker AH loss multiplier when attacking hits, relative to base AH loss multiplier. 0.5 means reducing 50% loss (successful hit on enemy, loss reduction)", Order = 1)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 6)]
		public float AttackerAhFightMultiplier { get; set; } = 0.5f;

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060000F9 RID: 249
		// (set) Token: 0x060000FA RID: 250
		[SettingPropertyFloatingInteger("{=ah_defender_hit_ah_loss}Defender Hit AH Loss Multiplier", 0.1f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_defender_hit_ah_loss_hint}Defender AH loss multiplier when attacked hits, relative to base AH loss multiplier", Order = 2)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 6)]
		public float DefenderAhFightMultiplier { get; set; } = 1f;

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060000FB RID: 251
		// (set) Token: 0x060000FC RID: 252
		[SettingPropertyFloatingInteger("{=ah_ah_loss_base_modifier}AH Loss Base Adjustment Factor", 15f, 40f, "0.0", RequireRestart = false, HintText = "{=ah_ah_loss_base_modifier_hint}Adjusts the base multiplier of all AH loss. The larger the value, the more AH loss per hit or block", Order = 3)]
		[SettingPropertyGroup("{=ah_ah_loss}AH Loss/{=ah_loss_modifier_config}Loss Modifier Configuration", GroupOrder = 6)]
		public float StanceLossModifier { get; set; } = 20f;

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060000FD RID: 253
		// (set) Token: 0x060000FE RID: 254
		[SettingPropertyFloatingInteger("{=ah_shield_block_ah_loss}Shield Block AH Loss Adjustment Factor", 5f, 20f, "0.0", RequireRestart = false, HintText = "{=ah_shield_block_ah_loss_hint}Weapon block AH loss multiplier when using shield, the smaller the value, the more advantageous shield blocking is", Order = 4)]
		[SettingPropertyGroup("{=ah_ah_loss}AH Loss/{=ah_loss_modifier_config}Loss Modifier Configuration", GroupOrder = 6)]
		public float ShieldStanceLossModifier { get; set; } = 8f;

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060000FF RID: 255
		// (set) Token: 0x06000100 RID: 256
		[SettingPropertyFloatingInteger("{=ah_heavy_weapon_knockdown_chance}Heavy Weapon Base Knockdown Chance", 0f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_heavy_weapon_knockdown_chance_hint}Base knockdown chance of heavy weapon", Order = 7)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float HeavyWeaponKnockDownBaseChance { get; set; } = 0.3f;

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000101 RID: 257
		// (set) Token: 0x06000102 RID: 258
		[SettingPropertyFloatingInteger("{=ah_heavy_weapon_knockback_chance}Heavy Weapon Base Knockback Chance", 0f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_heavy_weapon_knockback_chance_hint}Base knockback chance of heavy weapon", Order = 6)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float HeavyWeaponKnockBackBaseChance { get; set; } = 0.4f;

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000103 RID: 259
		// (set) Token: 0x06000104 RID: 260
		[SettingPropertyFloatingInteger("{=ah_normal_weapon_knockback_chance}Normal Weapon Base Knockback Chance", 0f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_normal_weapon_knockback_chance_hint}Set base knockback chance of normal weapon", Order = 5)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float NormalWeaponKnockBackBaseChance { get; set; } = 0.25f;

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000105 RID: 261
		// (set) Token: 0x06000106 RID: 262
		[SettingPropertyFloatingInteger("{=ah_low_ah_effect_threshold}Low AH Additional Effect Probability Threshold", 0.1f, 0.9f, "0.00", RequireRestart = false, HintText = "{=ah_low_ah_effect_threshold_hint}When AH value is below this value, additional effect probability begins to increase", Order = 3)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float LowAhFightEffectThreshold { get; set; } = 0.3f;

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000107 RID: 263
		// (set) Token: 0x06000108 RID: 264
		[SettingPropertyFloatingInteger("{=ah_low_ah_effect_multiplier}Low AH Additional Effect Probability Multiplier", 0.5f, 10f, "0.00", RequireRestart = false, HintText = "{=ah_low_ah_effect_multiplier_hint}Actual increase probability = (Threshold - Current AH Percentage) * This Multiplier", Order = 4)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float LowAhFightEffectMultiplier { get; set; } = 2f;

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000109 RID: 265
		// (set) Token: 0x0600010A RID: 266
		[SettingPropertyFloatingInteger("{=ah_max_effect_chance}Effect Probability Upper Limit", 0.5f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_effect_chance_hint}Maximum trigger probability of knockdown/knockback effect. 0.8 means 80% chance to trigger effect regardless of stacking", Order = 2)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float MaxEffectChance { get; set; } = 0.7f;

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600010B RID: 267
		// (set) Token: 0x0600010C RID: 268
		[SettingPropertyFloatingInteger("{=ah_leg_hit_knockdown_threshold}Leg Hit Knockdown AH Threshold", 20f, 300f, "0.00", RequireRestart = false, HintText = "{=ah_leg_hit_knockdown_threshold_hint}Target AH below this value when using heavy weapon horizontally attacks hit leg, there will be a probability of knockdown", Order = 1)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float LegHitKnockDownThreshold { get; set; } = 80f;

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600010D RID: 269
		// (set) Token: 0x0600010E RID: 270
		[SettingPropertyFloatingInteger("{=ah_base_dismount_chance}Base Dismount Chance", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_base_dismount_chance_hint}Set base dismount probability without any bonus", Order = 0)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float BaseDismountChance { get; set; } = 0.4f;

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600010F RID: 271
		// (set) Token: 0x06000110 RID: 272
		[SettingPropertyFloatingInteger("{=ah_riding_skill_dismount_resistance}Riding Skill Dismount Resistance Influence Factor", 0.001f, 0.02f, "0.000", RequireRestart = false, HintText = "{=ah_riding_skill_dismount_resistance_hint}Actual reduction = Riding Skill (with decay) * This Factor. For example, when 0.03, 150 Riding Skill can reduce about 45% Dismount Probability", Order = 1)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float RidingSkillDismountResistance { get; set; } = 0.003f;

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000111 RID: 273
		// (set) Token: 0x06000112 RID: 274
		[SettingPropertyFloatingInteger("{=ah_min_dismount_chance}Minimum Dismount Chance", 0.01f, 0.5f, "0.00", RequireRestart = false, HintText = "{=ah_min_dismount_chance_hint}Even if riding skill is high, it cannot be lower than this value to prevent riding skill from completely immune dismount", Order = 2)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float MinDismountChance { get; set; } = 0.01f;

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000113 RID: 275
		// (set) Token: 0x06000114 RID: 276
		[SettingPropertyFloatingInteger("{=ah_block_dismount_chance_modifier}Normal Block Dismount Chance Reduction Factor", 0f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_block_dismount_chance_modifier_hint}Normal block successful dismount probability reduction percentage", Order = 3)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float BlockDismountChanceModifier { get; set; } = 0.5f;

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000115 RID: 277
		// (set) Token: 0x06000116 RID: 278
		[SettingPropertyFloatingInteger("{=ah_polearm_dismount_modifier}Polearm Dismount Probability Correction", 0.5f, 3f, "0.00", RequireRestart = false, HintText = "{=ah_polearm_dismount_modifier_hint}Polearm weapon attack dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 4)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float PolearmDismountModifier { get; set; } = 1f;

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000117 RID: 279
		// (set) Token: 0x06000118 RID: 280
		[SettingPropertyFloatingInteger("{=ah_heavy_weapon_dismount_modifier}Heavy Weapon Dismount Probability Correction", 0.5f, 3f, "0.00", RequireRestart = false, HintText = "{=ah_heavy_weapon_dismount_modifier_hint}Heavy weapon dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 5)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float HeavyWeaponDismountModifier { get; set; } = 0.8f;

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000119 RID: 281
		// (set) Token: 0x0600011A RID: 282
		[SettingPropertyFloatingInteger("{=ah_other_weapon_dismount_modifier}Other Weapon Dismount Probability Correction", 0.1f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_other_weapon_dismount_modifier_hint}Other weapon dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 6)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float OtherWeaponDismountModifier { get; set; } = 0.4f;

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600011B RID: 283
		// (set) Token: 0x0600011C RID: 284
		[SettingPropertyFloatingInteger("{=ah_head_hit_dismount_modifier}Head Hit Dismount Probability Correction", 0.5f, 5f, "0.00", RequireRestart = false, HintText = "{=ah_head_hit_dismount_modifier_hint}Head hit dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 7)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float HeadHitDismountModifier { get; set; } = 1.5f;

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600011D RID: 285
		// (set) Token: 0x0600011E RID: 286
		[SettingPropertyFloatingInteger("{=ah_leg_hit_dismount_modifier}Leg Hit Dismount Probability Correction", 0.1f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_leg_hit_dismount_modifier_hint}Leg hit dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 8)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float LegHitDismountModifier { get; set; } = 0.3f;

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600011F RID: 287
		// (set) Token: 0x06000120 RID: 288
		[SettingPropertyFloatingInteger("{=ah_body_hit_dismount_modifier}Body Hit Dismount Probability Correction", 0.1f, 3f, "0.00", RequireRestart = false, HintText = "{=ah_body_hit_dismount_modifier_hint}Body hit dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 9)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float BodyHitDismountModifier { get; set; } = 1f;

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000121 RID: 289
		// (set) Token: 0x06000122 RID: 290
		[SettingPropertyFloatingInteger("{=ah_other_hit_dismount_modifier}Other Part Hit Dismount Probability Correction", 0.1f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_other_hit_dismount_modifier_hint}Other part hit dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 10)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float OtherHitDismountModifier { get; set; } = 0.6f;

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000123 RID: 291
		// (set) Token: 0x06000124 RID: 292
		[SettingPropertyFloatingInteger("{=ah_low_ah_dismount_threshold}Low AH Additional Dismount Probability Threshold", 0.1f, 0.8f, "0.00", RequireRestart = false, HintText = "{=ah_low_ah_dismount_threshold_hint}When rider AH is below this time, additional dismount probability will increase. 0.3 means starting to increase when AH is below 30%", Order = 11)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float LowAhFightDismountThreshold { get; set; } = 0.15f;

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000125 RID: 293
		// (set) Token: 0x06000126 RID: 294
		[SettingPropertyFloatingInteger("{=ah_low_ah_dismount_multiplier}Low AH Additional Dismount Probability Multiplier", 0.5f, 10f, "0.00", RequireRestart = false, HintText = "{=ah_low_ah_dismount_multiplier_hint}Low additional dismount probability multiplier when below additional dismount probability threshold 2.0 means increasing 1x probability", Order = 12)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float LowAhFightDismountMultiplier { get; set; } = 1.5f;

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000127 RID: 295
		// (set) Token: 0x06000128 RID: 296
		[SettingPropertyFloatingInteger("{=ah_max_dismount_chance}Dismount Probability Upper Limit", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_dismount_chance_hint}Dismount probability will not exceed this value to prevent dismount probability from being too high", Order = 3)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float MaxDismountChance { get; set; } = 0.7f;

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000129 RID: 297
		// (set) Token: 0x0600012A RID: 298
		[SettingPropertyFloatingInteger("{=ah_perfect_block_base_chance}Base Shield Perfect Block Probability", 0.1f, 0.3f, "0.00", RequireRestart = false, HintText = "{=ah_perfect_block_base_chance_hint}Base trigger probability of shield perfect block. 0.15 means 15% base chance, will be adjusted by other factors", Order = 0)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float PerfectBlockBaseChance { get; set; } = 0.15f;

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600012B RID: 299
		// (set) Token: 0x0600012C RID: 300
		[SettingPropertyFloatingInteger("{=ah_perfect_block_skill_bonus_max}Skill Maximum Bonus", 0.05f, 0.25f, "0.00", RequireRestart = false, HintText = "{=ah_perfect_block_skill_bonus_max_hint}Skill level can provide maximum shield perfect block bonus. 0.15 means up to 15% trigger probability increase", Order = 1)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float PerfectBlockSkillBonusMax { get; set; } = 0.15f;

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600012D RID: 301
		// (set) Token: 0x0600012E RID: 302
		[SettingPropertyFloatingInteger("{=ah_side_attack_block_modifier}Side Attack Perfect Block Correction", 0.5f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_side_attack_block_modifier_hint}Side attack perfect block trigger probability correction. 0.9 means reducing 10%", Order = 2)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float SideAttackBlockModifier { get; set; } = 0.9f;

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600012F RID: 303
		// (set) Token: 0x06000130 RID: 304
		[SettingPropertyFloatingInteger("{=ah_overhead_attack_block_modifier}Overhead Attack Perfect Block Correction", 0.3f, 1.2f, "0.00", RequireRestart = false, HintText = "{=ah_overhead_attack_block_modifier_hint}Overhead attack shield perfect block trigger probability correction. 0.7 means reducing 30%", Order = 3)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float OverheadAttackBlockModifier { get; set; } = 0.7f;

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000131 RID: 305
		// (set) Token: 0x06000132 RID: 306
		[SettingPropertyFloatingInteger("{=ah_thrust_attack_block_modifier}Thrust Attack Perfect Block Correction", 0.4f, 1.3f, "0.00", RequireRestart = false, HintText = "{=ah_thrust_attack_block_modifier_hint}Thrust attack shield perfect block trigger probability correction. 0.8 means reducing 20%", Order = 4)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float ThrustAttackBlockModifier { get; set; } = 0.8f;

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000133 RID: 307
		// (set) Token: 0x06000134 RID: 308
		[SettingPropertyFloatingInteger("{=ah_two_handed_heavy_block_modifier}Two Handed Heavy Weapon Block Correction", 0.3f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_two_handed_heavy_block_modifier_hint}Two handed heavy weapon shield perfect block trigger probability correction. 0.6 means reducing 40%")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 10)]
		public float TwoHandedHeavyBlockModifier { get; set; } = 0.6f;

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000135 RID: 309
		// (set) Token: 0x06000136 RID: 310
		[SettingPropertyFloatingInteger("{=ah_one_handed_blunt_block_modifier}One Handed Blunt Block Correction", 0.4f, 1.1f, "0.00", RequireRestart = false, HintText = "{=ah_one_handed_blunt_block_modifier_hint}One handed blunt block trigger probability correction. 0.7 means reducing 30%")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 10)]
		public float OneHandedBluntBlockModifier { get; set; } = 0.7f;

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000137 RID: 311
		// (set) Token: 0x06000138 RID: 312
		[SettingPropertyFloatingInteger("{=ah_two_handed_block_modifier}Two Handed Sword Block Correction", 0.5f, 1.2f, "0.00", RequireRestart = false, HintText = "{=ah_two_handed_block_modifier_hint}Two handed sword shield perfect block trigger probability correction. 0.8 means reducing 20%")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 10)]
		public float TwoHandedBlockModifier { get; set; } = 0.8f;

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000139 RID: 313
		// (set) Token: 0x0600013A RID: 314
		[SettingPropertyFloatingInteger("{=ah_weapon_tip_block_modifier}Weapon Tip Block Correction", 0.5f, 1.2f, "0.00", RequireRestart = false, HintText = "{=ah_weapon_tip_block_modifier_hint}Weapon tip shield perfect block trigger probability correction. 0.8 means reducing 20%")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 10)]
		public float WeaponTipBlockModifier { get; set; } = 0.8f;

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600013B RID: 315
		// (set) Token: 0x0600013C RID: 316
		[SettingPropertyFloatingInteger("{=ah_weapon_blade_block_modifier}Weapon Blade Block Correction", 0.6f, 1.3f, "0.00", RequireRestart = false, HintText = "{=ah_weapon_blade_block_modifier_hint}Weapon blade shield perfect block trigger probability correction. 0.9 means reducing 10%")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 10)]
		public float WeaponBladeBlockModifier { get; set; } = 0.9f;

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600013D RID: 317
		// (set) Token: 0x0600013E RID: 318
		[SettingPropertyFloatingInteger("{=ah_perfect_block_stance_bonus}Perfect Block AH Reward (Non Shield)", 0.05f, 0.5f, "0.000", RequireRestart = false, HintText = "{=ah_perfect_block_stance_bonus_hint}AH reward for successful perfect block using weapon. 0.15 means recovering 15% of max AH, reward high risk high return block", Order = 10)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float PerfectBlockStanceBonus { get; set; } = 0.18f;

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600013F RID: 319
		// (set) Token: 0x06000140 RID: 320
		[SettingPropertyFloatingInteger("{=ah_shield_perfect_block_stance_bonus}Perfect Block AH Reward (Shield)", 0.025f, 0.25f, "0.000", RequireRestart = false, HintText = "{=ah_shield_perfect_block_stance_bonus_hint}AH reward for successful perfect block using shield. 0.075 means recovering 7.5% of max AH, lower weapon block because risk is lower", Order = 11)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float ShieldPerfectBlockStanceBonus { get; set; } = 0.095f;

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000141 RID: 321
		// (set) Token: 0x06000142 RID: 322
		[SettingPropertyFloatingInteger("{=ah_thrust_stance_loss}Thrust Stance Loss Factor", 0.7f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_thrust_stance_loss_hint}Control thrust attack AH loss multiplier, value越大刺击造成的AH损失越高")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float ThrustStanceLossModifier { get; set; } = 1.2f;

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000143 RID: 323
		// (set) Token: 0x06000144 RID: 324
		[SettingPropertyFloatingInteger("{=ah_swing_stance_loss}Swing Stance Loss Factor", 0.5f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_swing_stance_loss_hint}Control swing attack AH loss multiplier, value越大挥砍造成的AH损失越高")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float SwingStanceLossModifier { get; set; } = 0.8f;

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000145 RID: 325
		// (set) Token: 0x06000146 RID: 326
		[SettingPropertyFloatingInteger("{=ah_one_handed_sword_swing}One Handed Sword AH Consumption", 0.7f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_one_handed_sword_swing_hint}Control one handed sword and dagger swing AH loss multiplier, 0.85 means reducing 15% of base consumption")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float OneHandedSwordSwingModifier { get; set; } = 0.85f;

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000147 RID: 327
		// (set) Token: 0x06000148 RID: 328
		[SettingPropertyFloatingInteger("{=ah_two_handed_sword_swing}Two Handed Sword AH Consumption", 0.7f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_two_handed_sword_swing_hint}Control two handed sword swing AH loss multiplier, 1.1 means increasing 10% of base consumption")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float TwoHandedSwordSwingModifier { get; set; } = 1.1f;

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000149 RID: 329
		// (set) Token: 0x0600014A RID: 330
		[SettingPropertyFloatingInteger("{=ah_one_handed_blunt_swing}One Handed Blunt AH Consumption", 0.7f, 1.3f, "0.00", RequireRestart = false, HintText = "{=ah_one_handed_blunt_swing_hint}Control one handed axe and blunt swing AH loss multiplier, 1.0 means equal to base consumption")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float OneHandedBluntSwingModifier { get; set; } = 1f;

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600014B RID: 331
		// (set) Token: 0x0600014C RID: 332
		[SettingPropertyFloatingInteger("{=ah_two_handed_blunt_swing}Two Handed Blunt AH Consumption", 0.7f, 1.6f, "0.00", RequireRestart = false, HintText = "{=ah_two_handed_blunt_swing_hint}Control two handed axe and heavy blunt swing AH loss multiplier, 1.25 means increasing 25% of base consumption")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float TwoHandedBluntSwingModifier { get; set; } = 1.25f;

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600014D RID: 333
		// (set) Token: 0x0600014E RID: 334
		[SettingPropertyFloatingInteger("{=ah_polearm_swing}Polearm AH Consumption", 0.8f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_polearm_swing_hint}Control polearm swing AH loss multiplier, 1.15 means increasing 15% of base consumption")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float PolearmSwingModifier { get; set; } = 1.15f;

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600014F RID: 335
		// (set) Token: 0x06000150 RID: 336
		[SettingPropertyFloatingInteger("{=ah_stance_loss_base_multiplier}AH Loss Base Multiplier", 10f, 50f, "0.0", RequireRestart = false, HintText = "{=ah_stance_loss_base_multiplier_hint}Adjust base multiplier of all AH loss. 20 means base loss will be magnified 20 times", Order = 0)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float StanceLossBaseMultiplier { get; set; } = 20f;

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000151 RID: 337
		// (set) Token: 0x06000152 RID: 338
		[SettingPropertyFloatingInteger("{=ah_max_attacker_stance_loss}Max Attacker Stance Loss", 5f, 30f, "0.0", RequireRestart = false, HintText = "{=ah_max_attacker_stance_loss_hint}Max AH loss per single attack by attacker. 15 means max AH loss of 15 points regardless of stacking", Order = 10)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float MaxAttackerStanceLoss { get; set; } = 15f;

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000153 RID: 339
		// (set) Token: 0x06000154 RID: 340
		[SettingPropertyFloatingInteger("{=ah_max_defender_stance_loss}Max Defender Stance Loss", 10f, 50f, "0.0", RequireRestart = false, HintText = "{=ah_max_defender_stance_loss_hint}Max AH loss per single defense by defender. 25 means max AH loss of 25 points regardless of stacking", Order = 11)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float MaxDefenderStanceLoss { get; set; } = 25f;

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000155 RID: 341
		// (set) Token: 0x06000156 RID: 342
		[SettingPropertyFloatingInteger("{=ah_stance_damage_reduction}AH Loss Reduction", 0.5f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_stance_damage_reduction_hint}Reduction of loss. 1.0 means no reduction, 0.5 means half loss", Order = 1)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float StanceDamageReductionFactor { get; set; } = 1f;

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000157 RID: 343
		// (set) Token: 0x06000158 RID: 344
		[SettingPropertyFloatingInteger("{=ah_weapon_tip_hit_stance_loss}Weapon Tip Hit Bonus", 0.7f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_weapon_tip_hit_stance_loss_hint}AH loss bonus when hitting weapon tip. 1.15 means additional 15% loss, because tip hit consumes more physical strength", Order = 2)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float WeaponTipHitStanceLossModifier { get; set; } = 1.08f;

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000159 RID: 345
		// (set) Token: 0x0600015A RID: 346
		[SettingPropertyFloatingInteger("{=ah_weapon_blade_hit_stance_loss}Weapon Blade Hit Bonus", 1f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_weapon_blade_hit_stance_loss_hint}AH loss bonus when hitting weapon blade. 1.05 means additional 5% loss", Order = 3)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float WeaponBladeHitStanceLossModifier { get; set; } = 1.05f;

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600015B RID: 347
		// (set) Token: 0x0600015C RID: 348
		[SettingPropertyFloatingInteger("{=ah_large_shield_defense}Large Shield Defense Reduction", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_large_shield_defense_hint}AH loss reduction when using large shield. 0.7 means only suffering 70% of AH loss", Order = 4)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float LargeShieldDefenseModifier { get; set; } = 0.7f;

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600015D RID: 349
		// (set) Token: 0x0600015E RID: 350
		[SettingPropertyFloatingInteger("{=ah_small_shield_defense}Small Shield Defense Reduction", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_small_shield_defense_hint}AH loss reduction when using small shield. 0.9 means suffering 90% of AH loss", Order = 5)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float SmallShieldDefenseModifier { get; set; } = 0.9f;

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600015F RID: 351
		// (set) Token: 0x06000160 RID: 352
		[SettingPropertyFloatingInteger("{=ah_perfect_shield_block}Perfect Shield Block Reduction", 0.1f, 0.8f, "0.00", RequireRestart = false, HintText = "{=ah_perfect_shield_block_hint}AH loss reduction when using perfect shield. 0.3 means only suffering 30% of AH loss, reward accurate block", Order = 6)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float PerfectShieldBlockModifier { get; set; } = 0.3f;

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000161 RID: 353
		// (set) Token: 0x06000162 RID: 354
		[SettingPropertyFloatingInteger("{=ah_correct_side_shield_block}Correct Shield Block Reduction", 0.1f, 0.8f, "0.00", RequireRestart = false, HintText = "{=ah_correct_side_shield_block_hint}Correct direction shield block AH loss reduction. 0.3 means only suffering 30% of AH loss", Order = 7)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float CorrectSideShieldBlockModifier { get; set; } = 0.4f;

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000163 RID: 355
		// (set) Token: 0x06000164 RID: 356
		[SettingPropertyFloatingInteger("{=ah_wrong_side_shield_block}Wrong Shield Block Penalty", 0.1f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_wrong_side_shield_block_hint}AH loss bonus for wrong direction shield block. 1.0 means no AH loss reduction", Order = 8)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float WrongSideShieldBlockModifier { get; set; } = 1.1f;

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000165 RID: 357
		// (set) Token: 0x06000166 RID: 358
		[SettingPropertyFloatingInteger("{=ah_hand_hit_weapon_drop_base}Hand Hit Weapon Drop Base Probability", 0.01f, 0.3f, "0.00", RequireRestart = false, HintText = "{=ah_hand_hit_weapon_drop_base_hint}Base drop probability when attacking hits hand. 0.15 means 15% base chance, will be adjusted by other factors", Order = 0)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float HandHitWeaponDropBaseChance { get; set; } = 0.1f;

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000167 RID: 359
		// (set) Token: 0x06000168 RID: 360
		[SettingPropertyFloatingInteger("{=ah_stance_weapon_drop}AH Value Weapon Drop Influence Factor", 0.5f, 3f, "0.00", RequireRestart = false, HintText = "{=ah_stance_weapon_drop_hint}AH value influence factor on weapon drop. 1.5 means each 10% loss increases drop probability by 15%", Order = 1)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float StanceWeaponDropModifier { get; set; } = 1.5f;

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000169 RID: 361
		// (set) Token: 0x0600016A RID: 362
		[SettingPropertyFloatingInteger("{=ah_skill_weapon_drop}Skill Weapon Drop Influence Factor", 10f, 50f, "0.0", RequireRestart = false, HintText = "{=ah_skill_weapon_drop_hint}Skill influence factor on weapon drop. 20 means each 20 skill reduces drop probability by 1%", Order = 2)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float SkillWeaponDropDivisor { get; set; } = 30f;

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600016B RID: 363
		// (set) Token: 0x0600016C RID: 364
		[SettingPropertyFloatingInteger("{=ah_min_weapon_drop}Weapon Drop Probability Minimum Value", 0.01f, 0.2f, "0.00", RequireRestart = false, HintText = "{=ah_min_weapon_drop_hint}Drop probability will not be lower than this regardless of skill. 0.05 means at least 5% drop probability", Order = 3)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MinWeaponDropChance { get; set; } = 0.03f;

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600016D RID: 365
		// (set) Token: 0x0600016E RID: 366
		[SettingPropertyFloatingInteger("{=ah_max_weapon_drop}Weapon Drop Probability Maximum Value", 0.2f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_weapon_drop_hint}Drop probability will not exceed this regardless of other factors. 0.75 means up to 75% drop probability", Order = 4)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MaxWeaponDropChance { get; set; } = 0.3f;

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600016F RID: 367
		// (set) Token: 0x06000170 RID: 368
		[SettingPropertyFloatingInteger("{=ah_exhausted_both_drop}Exhausted Both Drop Probability", 0.1f, 0.8f, "0.00", RequireRestart = false, HintText = "{=ah_exhausted_both_drop_hint}Exhausted AH drop weapon and shield probability when hit. 0.5 means 50% chance two equipment drop", Order = 5)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float ExhaustedBothDropBaseChance { get; set; } = 0.3f;

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000171 RID: 369
		// (set) Token: 0x06000172 RID: 370
		[SettingPropertyFloatingInteger("{=ah_exhausted_weapon_drop}Exhausted Weapon Drop Probability", 0.1f, 0.9f, "0.00", RequireRestart = false, HintText = "{=ah_exhausted_weapon_drop_hint}Exhausted weapon drop probability when not triggering double drop", Order = 7)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float ExhaustedWeaponDropChance { get; set; } = 0.6f;

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000173 RID: 371
		// (set) Token: 0x06000174 RID: 372
		[SettingPropertyFloatingInteger("{=ah_mounted_drop_resistance}Mounted Weapon Drop Resistance", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_mounted_drop_resistance_hint}Mounted resistance to weapon drop. 0.4 means 40% of original drop probability", Order = 8)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MountedDropResistance { get; set; } = 0.4f;

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000175 RID: 373
		// (set) Token: 0x06000176 RID: 374
		[SettingPropertyFloatingInteger("{=ah_mounted_max_drop}Mounted Weapon Drop Maximum Probability", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_mounted_max_drop_hint}Mounted weapon drop maximum probability.", Order = 9)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MountedMaxDropChance { get; set; } = 0.4f;

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000177 RID: 375
		// (set) Token: 0x06000178 RID: 376
		[SettingPropertyFloatingInteger("{=ah_max_shield_block_exhausted_drop}Max Shield Block Exhausted Drop Chance", 0.01f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_shield_block_exhausted_drop_hint}Max shield block exhausted drop chance.", Order = 10)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MaxShieldBlockExhaustedDropChance { get; set; } = 0.08f;

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000179 RID: 377
		// (set) Token: 0x0600017A RID: 378
		[SettingPropertyFloatingInteger("{=ah_max_weapon_block_exhausted_drop}Max Weapon Block Exhausted Drop Chance", 0.01f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_weapon_block_exhausted_drop_hint}Max weapon block exhausted drop chance.", Order = 11)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MaxWeaponBlockExhaustedDropChance { get; set; } = 0.1f;

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600017B RID: 379
		// (set) Token: 0x0600017C RID: 380
		[SettingPropertyFloatingInteger("{=ah_max_strike_exhausted_drop}Max Strike Exhausted Drop Chance", 0.01f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_strike_exhausted_drop_hint}Max strike exhausted drop chance.", Order = 12)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MaxStrikeExhaustedDropChance { get; set; } = 0.13f;

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600017D RID: 381
		// (set) Token: 0x0600017E RID: 382
		[SettingPropertyFloatingInteger("{=ah_normal_state_regen}Normal State Regeneration Speed", 0.1f, 5f, "0.0", RequireRestart = false, HintText = "{=ah_normal_state_regen_hint}Regeneration speed when AH≥75%. 1.2 means faster than base recovery by 20%, encourage maintaining good state", Order = 10)]
		[SettingPropertyGroup("{=ah_regen_config}Regeneration Configuration (State)", GroupOrder = 11)]
		public float NormalRegenModifier { get; set; } = 1.2f;

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600017F RID: 383
		// (set) Token: 0x06000180 RID: 384
		[SettingPropertyFloatingInteger("{=ah_weak_state_regen}Weak State Regeneration Speed", 0.1f, 5f, "0.0", RequireRestart = false, HintText = "{=ah_weak_state_regen_hint}Regeneration speed when AH is 50-75%. 1.0 means equal to base recovery speed", Order = 11)]
		[SettingPropertyGroup("{=ah_regen_config}Regeneration Configuration (State)", GroupOrder = 11)]
		public float WeakRegenModifier { get; set; } = 1f;

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000181 RID: 385
		// (set) Token: 0x06000182 RID: 386
		[SettingPropertyFloatingInteger("{=ah_tired_state_regen}Tired State Regeneration Speed", 0.1f, 5f, "0.0", RequireRestart = false, HintText = "{=ah_tired_state_regen_hint}Regeneration speed when AH is 25-50%. 0.8 means slower than base recovery by 20%, reflect physical exhaustion state", Order = 12)]
		[SettingPropertyGroup("{=ah_regen_config}Regeneration Configuration (State)", GroupOrder = 11)]
		public float TiredRegenModifier { get; set; } = 0.8f;

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000183 RID: 387
		// (set) Token: 0x06000184 RID: 388
		[SettingPropertyFloatingInteger("{=ah_powerless_state_regen}Powerless State Regeneration Speed", 0.1f, 5f, "0.0", RequireRestart = false, HintText = "{=ah_powerless_state_regen_hint}Regeneration speed when AH is below 25%. 0.5 means slower than base recovery by 50%, reflect extremely tired state", Order = 13)]
		[SettingPropertyGroup("{=ah_regen_config}Regeneration Configuration (State)", GroupOrder = 11)]
		public float PowerlessRegenModifier { get; set; } = 0.5f;

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000185 RID: 389
		// (set) Token: 0x06000186 RID: 390
		[SettingPropertyBool("{=ah_attack_type_loss}Attack Type AH Loss", RequireRestart = false, HintText = "{=ah_attack_type_loss_hint}Control AH loss multiplier of different attack types", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public bool AttackTypeAhLossToggle { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000187 RID: 391
		// (set) Token: 0x06000188 RID: 392
		[SettingPropertyBool("{=ah_loss_advanced_config}Advanced Loss Configuration", RequireRestart = false, HintText = "{=ah_loss_advanced_config_hint}More detailed AH loss parameter adjustment", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public bool AdvancedAhLossToggle { get; set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000189 RID: 393
		// (set) Token: 0x0600018A RID: 394
		[SettingPropertyBool("{=ah_weapon_drop_config}Weapon Drop Configuration", RequireRestart = false, HintText = "{=ah_weapon_drop_config_hint}Control weapon drop related parameters", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public bool WeaponDropToggle { get; set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600018B RID: 395
		// (set) Token: 0x0600018C RID: 396
		[SettingPropertyBool("{=ah_perfect_block_config}Perfect Block Configuration", RequireRestart = false, HintText = "{=ah_perfect_block_config_hint}Control perfect block related parameters", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 14)]
		public bool PerfectBlockToggle { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600018D RID: 397
		// (set) Token: 0x0600018E RID: 398
		[SettingPropertyBool("{=ah_mounted_config}Mounted Related Configuration", RequireRestart = false, HintText = "{=ah_mounted_config_hint}Control mounted related parameters", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public bool MountedConfigToggle { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600018F RID: 399
		// (set) Token: 0x06000190 RID: 400
		[SettingPropertyBool("{=ah_ranged_effect_enabled}Ranged Strike Effects", RequireRestart = false, HintText = "{=ah_ranged_effect_enabled_hint}When enabled, high-speed arrows, bolts, javelins, or throwing axes can cause knockback, knockdown, or dismount (even when blocked). Higher encumbrance increases resistance, making effects less likely to trigger", Order = 0)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged", GroupOrder = 12)]
		public bool MissileEffectEnabled { get; set; } = true;

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000191 RID: 401
		// (set) Token: 0x06000192 RID: 402
		[SettingPropertyBool("{=ah_ranged_loss_enabled}Ranged Loss Enabled", RequireRestart = false, HintText = "{=ah_ranged_loss_enabled_hint}When enabled, arrows and bolts will cause AH loss. Consecutive hits may slow down advance speed (resistance)", Order = 2)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged", GroupOrder = 12)]
		public bool MissileLossEnabled { get; set; } = true;

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000193 RID: 403
		// (set) Token: 0x06000194 RID: 404
		[SettingPropertyFloatingInteger("{=ah_ranged_base_resistance}Base Strike Effect Resistance", 0.1f, 0.9f, "0.0", RequireRestart = false, HintText = "{=ah_ranged_base_resistance_hint}Higher base resistance makes effects less likely to trigger. Final resistance is affected by encumbrance (heavily armored soldiers are less affected)The higher the ride and load, the safer it is. ", Order = 2)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged/{=ah_ranged_resistance}Strike Effect Adjustment", GroupOrder = 12)]
		public float RangedBaseResistance { get; set; } = 0.25f;

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000195 RID: 405
		// (set) Token: 0x06000196 RID: 406
		[SettingPropertyFloatingInteger("{=ah_ranged_max_effect_chance}Maximum Effect Trigger Probability", 0.1f, 0.9f, "0.0", RequireRestart = false, HintText = "{=ah_ranged_max_effect_chance_hint}The maximum probability for strike effects to trigger, a cap that won't be exceeded even if unarmored", Order = 3)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged/{=ah_ranged_resistance}Strike Effect Adjustment", GroupOrder = 12)]
		public float RangedMaxEffectChance { get; set; } = 0.6f;

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000197 RID: 407
		// (set) Token: 0x06000198 RID: 408
		[SettingPropertyFloatingInteger("{=ah_ranged_loss}Ranged Blocked With Shield Base Loss", 1f, 30f, "0.0", RequireRestart = false, HintText = "{=ah_ranged_loss_hint}The base AH loss when a missile hits a shield", Order = 4)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged/{=ah_ranged_resistance}Strike Effect Adjustment", GroupOrder = 12)]
		public float RangedShieldLoss { get; set; } = 8f;

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000199 RID: 409
		// (set) Token: 0x0600019A RID: 410
		[SettingPropertyFloatingInteger("{=ah_ranged_hit_loss}Ranged Hit Base Loss", 1f, 50f, "0.0", RequireRestart = false, HintText = "{=ah_ranged_hit_loss_hint}The base AH loss when a missile hits a target", Order = 5)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged/{=ah_ranged_resistance}Strike Effect Adjustment", GroupOrder = 12)]
		public float RangedHitLoss { get; set; } = 12f;

		// Token: 0x0600019B RID: 411
		public McmSetting()
		{
			this.AhfightEnabled = true;
			this.AhfightGUIEnabled = true;
			this.AhfightTextEnabled = true;
			this.MovementPenaltyEnabled = true;
			this.HitDamagePenaltyEnabled = true;
			this.AdvancedModeEnabled = true;
			this.AttackTypeAhLossToggle = true;
			this.AdvancedAhLossToggle = true;
			this.WeaponDropToggle = true;
			this.PerfectBlockToggle = true;
			this.MountedConfigToggle = true;
			this.ShieldDropEnabled = true;
			this.WeaponDropEnabled = true;
			this.PlayerAhFightBase = 1f;
			this.BaseAhFight = 100f;
			this.BaseAhFightRegen = 0.05f;
			this.AhfightResetModifier = 0.4f;
			this.AthleticBase = 35f;
			this.WeaponSkillBase = 65f;
			this.WeaponSkillModifier = 180f;
			this.WeaponSkillRegenBase = 0.021f;
			this.NormalSpeedModifier = 1f;
			this.WeakSpeedModifier = 0.8f;
			this.TiredSpeedModifier = 0.6f;
			this.PowerlessSpeedModifier = 0.4f;
			this.BaseAhFightDamage = 20f;
			this.AttackerAhFightMultiplier = 0.5f;
			this.DefenderAhFightMultiplier = 1f;
			this.StanceLossModifier = 20f;
			this.ShieldStanceLossModifier = 8f;
			this.HeavyWeaponKnockDownBaseChance = 0.3f;
			this.HeavyWeaponKnockBackBaseChance = 0.4f;
			this.NormalWeaponKnockBackBaseChance = 0.25f;
			this.LowAhFightEffectThreshold = 0.3f;
			this.LowAhFightEffectMultiplier = 2f;
			this.MaxEffectChance = 0.7f;
			this.LegHitKnockDownThreshold = 80f;
			this.BaseDismountChance = 0.4f;
			this.RidingSkillDismountResistance = 0.003f;
			this.MinDismountChance = 0.05f;
			this.BlockDismountChanceModifier = 0.5f;
			this.PolearmDismountModifier = 1f;
			this.HeavyWeaponDismountModifier = 0.8f;
			this.OtherWeaponDismountModifier = 0.4f;
			this.HeadHitDismountModifier = 1.5f;
			this.LegHitDismountModifier = 0.3f;
			this.BodyHitDismountModifier = 1f;
			this.OtherHitDismountModifier = 0.6f;
			this.LowAhFightDismountThreshold = 0.15f;
			this.LowAhFightDismountMultiplier = 1.5f;
			this.MaxDismountChance = 0.7f;
			this.PerfectBlockBaseChance = 0.15f;
			this.PerfectBlockSkillBonusMax = 0.15f;
			this.SideAttackBlockModifier = 0.9f;
			this.OverheadAttackBlockModifier = 0.7f;
			this.ThrustAttackBlockModifier = 0.8f;
			this.TwoHandedHeavyBlockModifier = 0.6f;
			this.OneHandedBluntBlockModifier = 0.7f;
			this.TwoHandedBlockModifier = 0.8f;
			this.WeaponTipBlockModifier = 0.8f;
			this.WeaponBladeBlockModifier = 0.9f;
			this.PerfectBlockStanceBonus = 0.18f;
			this.ShieldPerfectBlockStanceBonus = 0.095f;
			this.ThrustStanceLossModifier = 1.2f;
			this.SwingStanceLossModifier = 0.8f;
			this.OneHandedSwordSwingModifier = 0.85f;
			this.TwoHandedSwordSwingModifier = 1.1f;
			this.OneHandedBluntSwingModifier = 1f;
			this.TwoHandedBluntSwingModifier = 1.25f;
			this.PolearmSwingModifier = 1.15f;
			this.StanceLossBaseMultiplier = 20f;
			this.StanceDamageReductionFactor = 1f;
			this.WeaponTipHitStanceLossModifier = 1.08f;
			this.WeaponBladeHitStanceLossModifier = 1.05f;
			this.LargeShieldDefenseModifier = 0.7f;
			this.SmallShieldDefenseModifier = 0.9f;
			this.PerfectShieldBlockModifier = 0.3f;
			this.CorrectSideShieldBlockModifier = 0.4f;
			this.WrongSideShieldBlockModifier = 1.1f;
			this.MaxAttackerStanceLoss = 15f;
			this.MaxDefenderStanceLoss = 25f;
			this.HandHitWeaponDropBaseChance = 0.1f;
			this.StanceWeaponDropModifier = 1.5f;
			this.SkillWeaponDropDivisor = 30f;
			this.MinWeaponDropChance = 0.03f;
			this.MaxWeaponDropChance = 0.3f;
			this.ExhaustedBothDropBaseChance = 0.3f;
			this.ExhaustedWeaponDropChance = 0.6f;
			this.MountedDropResistance = 0.4f;
			this.MountedMaxDropChance = 0.4f;
			this.MaxShieldBlockExhaustedDropChance = 0.08f;
			this.MaxWeaponBlockExhaustedDropChance = 0.1f;
			this.MaxStrikeExhaustedDropChance = 0.13f;
			this.NormalRegenModifier = 1.2f;
			this.WeakRegenModifier = 1f;
			this.TiredRegenModifier = 0.8f;
			this.PowerlessRegenModifier = 0.5f;
			this.MissileEffectEnabled = true;
			this.MissileLossEnabled = true;
			this.RangedBaseResistance = 0.25f;
			this.RangedMaxEffectChance = 0.6f;
			this.RangedShieldLoss = 8f;
			this.RangedHitLoss = 12f;
			this.NormalStateDropEnabled = false;
			this.WeakStateDropEnabled = true;
			this.TiredStateDropEnabled = true;
			this.PowerlessStateDropEnabled = true;
			this.NormalStateHitDamageModifier = 1f;
			this.WeakStateHitDamageModifier = 0.8f;
			this.TiredStateHitDamageModifier = 0.7f;
			this.PowerlessStateHitDamageModifier = 0.5f;
		}
	}
}
