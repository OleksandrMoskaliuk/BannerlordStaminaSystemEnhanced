﻿using System;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;
using TaleWorlds.Localization;

namespace AhFight.Settings
{
	// Token: 0x02000015 RID: 21
	public class McmSetting : AttributeGlobalSettings<McmSetting>
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002E05 File Offset: 0x00001005
		public override string Id
		{
			get
			{
				return "AhFight_b1";
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002E0C File Offset: 0x0000100C
		public override string DisplayName
		{
			get
			{
				return new TextObject("AhFight", null).ToString();
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002E1E File Offset: 0x0000101E
		public override string FolderName
		{
			get
			{
				return "AhFight";
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002E25 File Offset: 0x00001025
		public override string FormatType
		{
			get
			{
				return "json";
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002E2C File Offset: 0x0000102C
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002E34 File Offset: 0x00001034
		[SettingPropertyBool("{=ah_advanced_settings}Advanced Settings", RequireRestart = false, HintText = "{=ah_advanced_settings_hint}Caution! Advanced parameter settings, please modify with care!", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings", GroupOrder = 100)]
		public bool AdvancedModeEnabled { get; set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002E3D File Offset: 0x0000103D
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002E45 File Offset: 0x00001045
		[SettingPropertyBool("{=ah_main_enabled}Enable MOD Features", RequireRestart = true, HintText = "{=ah_main_enabled_hint}Master Switch", Order = 0)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool AhfightEnabled { get; set; } = true;

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002E4E File Offset: 0x0000104E
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002E56 File Offset: 0x00001056
		[SettingPropertyBool("{=ah_gui_enabled}Enable UI", RequireRestart = false, HintText = "{=ah_gui_enabled_hint}When enabled, displays AH interface on screen", Order = 1)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool AhfightGUIEnabled { get; set; } = true;

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002E5F File Offset: 0x0000105F
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002E67 File Offset: 0x00001067
		[SettingPropertyBool("{=ah_text_enabled}Show Specific Numbers", RequireRestart = false, HintText = "{=ah_text_enabled_hint}Enable or disable the display of specific AH numbers", Order = 2)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool AhfightTextEnabled { get; set; } = true;

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002E70 File Offset: 0x00001070
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002E78 File Offset: 0x00001078
		[SettingPropertyBool("{=ah_movement_penalty_enabled}Enable Movement Speed Penalty", RequireRestart = false, HintText = "{=ah_movement_penalty_enabled_hint}Enable or disable movement speed penalties based on AH status", Order = 3)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool MovementPenaltyEnabled { get; set; } = true;

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002E81 File Offset: 0x00001081
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002E89 File Offset: 0x00001089
		[SettingPropertyBool("{=ah_hit_damage_penalty_enabled}Enable Damage Penalty", RequireRestart = false, HintText = "{=ah_hit_damage_penalty_enabled_hint}When Enable, there are different melee hit damage penalties for different states. The penalty multiplier can be adjusted and even increased .lol", Order = 4)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool HitDamagePenaltyEnabled { get; set; } = true;

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002E92 File Offset: 0x00001092
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002E9A File Offset: 0x0000109A
		[SettingPropertyBool("{=ah_weapon_drop_enabled}Enable Weapon Drop", RequireRestart = false, HintText = "{=ah_weapon_drop_enabled_hint}Weapon drop mechanism total switch, disable will not cause weapon drop in any case", Order = 5)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool WeaponDropEnabled { get; set; } = true;

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002EA3 File Offset: 0x000010A3
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002EAB File Offset: 0x000010AB
		[SettingPropertyBool("{=ah_shield_drop_enabled}Enable Shield Drop", RequireRestart = false, HintText = "{=ah_shield_drop_enabled_hint}Shield drop mechanism total switch, disable will not cause shield drop in any case", Order = 6)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings", GroupOrder = 0)]
		public bool ShieldDropEnabled { get; set; } = true;

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002EB4 File Offset: 0x000010B4
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002EBC File Offset: 0x000010BC
		[SettingPropertyBool("{=ah_normal_state_drop_enabled}Enable weapon drops in Normal state", RequireRestart = false, HintText = "{=ah_normal_state_drop_enabled_hint}When unchecked, weapons won't drop in Normal state. Unchecked by default", Order = 7)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings/{=ah_state_drop_settings}States that can trigger drops", GroupOrder = 0)]
		public bool NormalStateDropEnabled { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00002EC5 File Offset: 0x000010C5
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002ECD File Offset: 0x000010CD
		[SettingPropertyBool("{=ah_weak_state_drop_enabled}Enable weapon drops in Weak state", RequireRestart = false, HintText = "{=ah_weak_state_drop_enabled_hint}When unchecked, weapons won't drop in Weak state", Order = 8)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings/{=ah_state_drop_settings}States that can trigger drops", GroupOrder = 0)]
		public bool WeakStateDropEnabled { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002ED6 File Offset: 0x000010D6
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002EDE File Offset: 0x000010DE
		[SettingPropertyBool("{=ah_tired_state_drop_enabled}Enable weapon drops in Tired state", RequireRestart = false, HintText = "{=ah_tired_state_drop_enabled_hint}When unchecked, weapons won't drop in Tired state", Order = 9)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings/{=ah_state_drop_settings}States that can trigger drops", GroupOrder = 0)]
		public bool TiredStateDropEnabled { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002EE7 File Offset: 0x000010E7
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002EEF File Offset: 0x000010EF
		[SettingPropertyBool("{=ah_powerless_state_drop_enabled}Enable weapon drops in Powerless state", RequireRestart = false, HintText = "{=ah_powerless_state_drop_enabled_hint}When unchecked, weapons won't drop in Powerless state", Order = 10)]
		[SettingPropertyGroup("{=ah_basic_settings}Basic Settings/{=ah_state_drop_settings}States that can trigger drops", GroupOrder = 0)]
		public bool PowerlessStateDropEnabled { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002EF8 File Offset: 0x000010F8
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002F00 File Offset: 0x00001100
		[SettingPropertyFloatingInteger("{=ah_player_ah_multiplier}Player AH Multiplier", 0.1f, 3f, "0.0", RequireRestart = false, HintText = "{=ah_player_ah_multiplier_hint}Player AH multiplier, greater than 1 enhances player, less than 1削弱玩家", Order = 0)]
		[SettingPropertyGroup("{=ah_player_settings}Player Settings", GroupOrder = 1)]
		public float PlayerAhFightBase { get; set; } = 1f;

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002F09 File Offset: 0x00001109
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002F11 File Offset: 0x00001111
		[SettingPropertyFloatingInteger("{=ah_player_ah_regen_multiplier}Player AH Regeneration Multiplier", 0.1f, 5f, "0.0", RequireRestart = false, HintText = "{=ah_player_ah_regen_multiplier_hint}Player AH regeneration multiplier, greater than 1 recovers faster, less than 1 recovers slower. For example: 1.5 means the player recovers twice as fast as NPC", Order = 1)]
		[SettingPropertyGroup("{=ah_player_settings}Player Settings", GroupOrder = 1)]
		public float PlayerAhFightRegenBase { get; set; } = 1f;

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002F1A File Offset: 0x0000111A
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002F22 File Offset: 0x00001122
		[SettingPropertyFloatingInteger("{=ah_base_ah}Base AH", 50f, 300f, "0.0", RequireRestart = false, HintText = "{=ah_base_ah_hint}Base without any bonus reduction", Order = 0)]
		[SettingPropertyGroup("{=ah_base_config}Base Configuration", GroupOrder = 2)]
		public float BaseAhFight { get; set; } = 100f;

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002F2B File Offset: 0x0000112B
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002F33 File Offset: 0x00001133
		[SettingPropertyFloatingInteger("{=ah_base_regen_speed}Base Regeneration Speed", 0.01f, 0.5f, "0.000", RequireRestart = false, HintText = "{=ah_base_regen_speed_hint}Base regeneration speed without any bonus reduction", Order = 1)]
		[SettingPropertyGroup("{=ah_base_config}Base Configuration", GroupOrder = 2)]
		public float BaseAhFightRegen { get; set; } = 0.05f;

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002F3C File Offset: 0x0000113C
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002F44 File Offset: 0x00001144
		[SettingPropertyFloatingInteger("{=ah_exhausted_reset_ratio}Exhausted Regeneration Ratio", 0f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_exhausted_reset_ratio_hint}AH drops to 0 will recover to this ratio. For example: 0.6 means recovery to 60% of the base value,0 means recovery to 0", Order = 2)]
		[SettingPropertyGroup("{=ah_base_config}Base Configuration", GroupOrder = 2)]
		public float AhfightResetModifier { get; set; } = 0.4f;

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00002F4D File Offset: 0x0000114D
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002F55 File Offset: 0x00001155
		[SettingPropertyFloatingInteger("{=ah_base_athletic_skill}Base Athletic Skill", 10f, 150f, "0.0", RequireRestart = false, HintText = "{=ah_base_athletic_skill_hint}Base athletic skill value, every character has a base athletic skill value", Order = 0)]
		[SettingPropertyGroup("{=ah_skill_effects}Skill Effects", GroupOrder = 3)]
		public float AthleticBase { get; set; } = 35f;

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00002F5E File Offset: 0x0000115E
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002F66 File Offset: 0x00001166
		[SettingPropertyFloatingInteger("{=ah_base_weapon_skill}Base Weapon Skill", 20f, 200f, "0.0", RequireRestart = false, HintText = "{=ah_base_weapon_skill_hint}Base weapon skill value, every character has a corresponding weapon base weapon skill value", Order = 1)]
		[SettingPropertyGroup("{=ah_skill_effects}Skill Effects", GroupOrder = 3)]
		public float WeaponSkillBase { get; set; } = 65f;

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002F6F File Offset: 0x0000116F
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002F77 File Offset: 0x00001177
		[SettingPropertyFloatingInteger("{=ah_weapon_skill_effect_strength}Weapon Skill Effect Strength", 100f, 800f, "0.0", RequireRestart = false, HintText = "{=ah_weapon_skill_effect_strength_hint}Determines the degree of influence of weapon skill on AH. Larger will bring more obvious advantages from skill level differences", Order = 2)]
		[SettingPropertyGroup("{=ah_skill_effects}Skill Effects", GroupOrder = 3)]
		public float WeaponSkillModifier { get; set; } = 200f;

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002F80 File Offset: 0x00001180
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002F88 File Offset: 0x00001188
		[SettingPropertyFloatingInteger("{=ah_weapon_skill_regen_bonus}Weapon Skill Regeneration Bonus", 0.01f, 0.2f, "0.000", RequireRestart = false, HintText = "{=ah_weapon_skill_regen_bonus_hint}Weapon skill's influence on AH regeneration speed. 0.03 means each weapon skill increases 3% of the regeneration speed", Order = 3)]
		[SettingPropertyGroup("{=ah_skill_effects}Skill Effects", GroupOrder = 3)]
		public float WeaponSkillRegenBase { get; set; } = 0.021f;

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00002FB3 File Offset: 0x000011B3
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002FBB File Offset: 0x000011BB
		[SettingPropertyFloatingInteger("Minimum Movement Speed Multiplier", 0.1f, 1f, "0.0", RequireRestart = false, HintText = "Minimum movement speed when AH is low. Default: 0.45", Order = 2)]
		[SettingPropertyGroup("{=ah_movement_speed_penalty}Movement Speed Penalty", GroupOrder = 4)]
		public float MinMovementPenaltyMultiplier { get; set; } = 0.45f;

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00002FC4 File Offset: 0x000011C4
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002FCC File Offset: 0x000011CC
		[SettingPropertyFloatingInteger("AH Threshold For Applying Movement Penalty", 0.1f, 1.0f, "0.0", RequireRestart = false, HintText = "Threshold for movement speed penalty when AH is low. Default: 0.8", Order = 3)]
		[SettingPropertyGroup("{=ah_movement_speed_penalty}Movement Speed Penalty", GroupOrder = 4)]
		public float MovementPenaltyAHThreshold { get; set; } = 0.8f;

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002FF7 File Offset: 0x000011F7
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002FFF File Offset: 0x000011FF
		[SettingPropertyFloatingInteger("Minimum Damage Multiplier", 0.1f, 1.0f, "0.0", RequireRestart = false, HintText = "Minimum damage multiplier when AH is low. Default: 0.1", Order = 2)]
		[SettingPropertyGroup("{=ah_damage_penalty}Damage Penalty(Only melee)", GroupOrder = 5)]
		public float MinDamageMultiplier { get; set; } = 0.1f;

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00003008 File Offset: 0x00001208
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00003010 File Offset: 0x00001210
		[SettingPropertyFloatingInteger("Damage Reduction AH Threshold", 0.0f, 1.0f, "0.0", RequireRestart = false, HintText = "Stamina threshold for applying damage reduction. Default: 0.8", Order = 3)]
		[SettingPropertyGroup("{=ah_damage_penalty}Damage Penalty(Only melee)", GroupOrder = 5)]
		public float DamageReductionThreshold { get; set; } = 0.8f;

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00003019 File Offset: 0x00001219
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00003021 File Offset: 0x00001221
		[SettingPropertyFloatingInteger("{=ah_base_ah_loss}Base AH Loss", 10f, 50f, "0.0", RequireRestart = false, HintText = "{=ah_base_ah_loss_hint}Base AH loss per attack or defense, final loss amount adjusted by other factors", Order = 0)]
		[SettingPropertyGroup("{=ah_ah_loss}AH Loss", GroupOrder = 6)]
		public float BaseAhFightDamage { get; set; } = 20f;

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000302A File Offset: 0x0000122A
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00003032 File Offset: 0x00001232
		[SettingPropertyFloatingInteger("{=ah_attacker_hit_ah_loss}Attacker Hit AH Loss Multiplier", 0.1f, 0.7f, "0.00", RequireRestart = false, HintText = "{=ah_attacker_hit_ah_loss_hint}Attacker AH loss multiplier when attacking hits, relative to base AH loss multiplier. 0.5 means reducing 50% loss (successful hit on enemy, loss reduction)", Order = 1)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 6)]
		public float AttackerAhFightMultiplier { get; set; } = 0.5f;

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000303B File Offset: 0x0000123B
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00003043 File Offset: 0x00001243
		[SettingPropertyFloatingInteger("{=ah_defender_hit_ah_loss}Defender Hit AH Loss Multiplier", 0.1f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_defender_hit_ah_loss_hint}Defender AH loss multiplier when attacked hits, relative to base AH loss multiplier", Order = 2)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 6)]
		public float DefenderAhFightMultiplier { get; set; } = 1f;

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000304C File Offset: 0x0000124C
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00003054 File Offset: 0x00001254
		[SettingPropertyFloatingInteger("{=ah_ah_loss_base_modifier}AH Loss Base Adjustment Factor", 15f, 40f, "0.0", RequireRestart = false, HintText = "{=ah_ah_loss_base_modifier_hint}Adjusts the base multiplier of all AH loss. The larger the value, the more AH loss per hit or block", Order = 3)]
		[SettingPropertyGroup("{=ah_ah_loss}AH Loss/{=ah_loss_modifier_config}Loss Modifier Configuration", GroupOrder = 6)]
		public float StanceLossModifier { get; set; } = 20f;

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000305D File Offset: 0x0000125D
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00003065 File Offset: 0x00001265
		[SettingPropertyFloatingInteger("{=ah_shield_block_ah_loss}Shield Block AH Loss Adjustment Factor", 5f, 20f, "0.0", RequireRestart = false, HintText = "{=ah_shield_block_ah_loss_hint}Weapon block AH loss multiplier when using shield, the smaller the value, the more advantageous shield blocking is", Order = 4)]
		[SettingPropertyGroup("{=ah_ah_loss}AH Loss/{=ah_loss_modifier_config}Loss Modifier Configuration", GroupOrder = 6)]
		public float ShieldStanceLossModifier { get; set; } = 8f;

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000306E File Offset: 0x0000126E
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00003076 File Offset: 0x00001276
		[SettingPropertyFloatingInteger("{=ah_heavy_weapon_knockdown_chance}Heavy Weapon Base Knockdown Chance", 0f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_heavy_weapon_knockdown_chance_hint}Base knockdown chance of heavy weapon", Order = 7)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float HeavyWeaponKnockDownBaseChance { get; set; } = 0.3f;

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000307F File Offset: 0x0000127F
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00003087 File Offset: 0x00001287
		[SettingPropertyFloatingInteger("{=ah_heavy_weapon_knockback_chance}Heavy Weapon Base Knockback Chance", 0f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_heavy_weapon_knockback_chance_hint}Base knockback chance of heavy weapon", Order = 6)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float HeavyWeaponKnockBackBaseChance { get; set; } = 0.4f;

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00003090 File Offset: 0x00001290
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00003098 File Offset: 0x00001298
		[SettingPropertyFloatingInteger("{=ah_normal_weapon_knockback_chance}Normal Weapon Base Knockback Chance", 0f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_normal_weapon_knockback_chance_hint}Set base knockback chance of normal weapon", Order = 5)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float NormalWeaponKnockBackBaseChance { get; set; } = 0.25f;

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000030A1 File Offset: 0x000012A1
		// (set) Token: 0x06000116 RID: 278 RVA: 0x000030A9 File Offset: 0x000012A9
		[SettingPropertyFloatingInteger("{=ah_low_ah_effect_threshold}Low AH Additional Effect Probability Threshold", 0.1f, 0.9f, "0.00", RequireRestart = false, HintText = "{=ah_low_ah_effect_threshold_hint}When AH value is below this value, additional effect probability begins to increase", Order = 3)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float LowAhFightEffectThreshold { get; set; } = 0.3f;

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000030B2 File Offset: 0x000012B2
		// (set) Token: 0x06000118 RID: 280 RVA: 0x000030BA File Offset: 0x000012BA
		[SettingPropertyFloatingInteger("{=ah_low_ah_effect_multiplier}Low AH Additional Effect Probability Multiplier", 0.5f, 10f, "0.00", RequireRestart = false, HintText = "{=ah_low_ah_effect_multiplier_hint}Actual increase probability = (Threshold - Current AH Percentage) * This Multiplier", Order = 4)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float LowAhFightEffectMultiplier { get; set; } = 2f;

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000030C3 File Offset: 0x000012C3
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000030CB File Offset: 0x000012CB
		[SettingPropertyFloatingInteger("{=ah_max_effect_chance}Effect Probability Upper Limit", 0.5f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_effect_chance_hint}Maximum trigger probability of knockdown/knockback effect. 0.8 means 80% chance to trigger effect regardless of stacking", Order = 2)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float MaxEffectChance { get; set; } = 0.7f;

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000030D4 File Offset: 0x000012D4
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000030DC File Offset: 0x000012DC
		[SettingPropertyFloatingInteger("{=ah_leg_hit_knockdown_threshold}Leg Hit Knockdown AH Threshold", 20f, 300f, "0.00", RequireRestart = false, HintText = "{=ah_leg_hit_knockdown_threshold_hint}Target AH below this value when using heavy weapon horizontally attacks hit leg, there will be a probability of knockdown", Order = 1)]
		[SettingPropertyGroup("{=ah_knockdown_and_knockback}Knockdown and Knockback", GroupOrder = 7)]
		public float LegHitKnockDownThreshold { get; set; } = 80f;

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000030E5 File Offset: 0x000012E5
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000030ED File Offset: 0x000012ED
		[SettingPropertyFloatingInteger("{=ah_base_dismount_chance}Base Dismount Chance", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_base_dismount_chance_hint}Set base dismount probability without any bonus", Order = 0)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float BaseDismountChance { get; set; } = 0.4f;

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000030F6 File Offset: 0x000012F6
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000030FE File Offset: 0x000012FE
		[SettingPropertyFloatingInteger("{=ah_riding_skill_dismount_resistance}Riding Skill Dismount Resistance Influence Factor", 0.001f, 0.02f, "0.000", RequireRestart = false, HintText = "{=ah_riding_skill_dismount_resistance_hint}Actual reduction = Riding Skill (with decay) * This Factor. For example, when 0.03, 150 Riding Skill can reduce about 45% Dismount Probability", Order = 1)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float RidingSkillDismountResistance { get; set; } = 0.003f;

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00003107 File Offset: 0x00001307
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000310F File Offset: 0x0000130F
		[SettingPropertyFloatingInteger("{=ah_min_dismount_chance}Minimum Dismount Chance", 0.01f, 0.5f, "0.00", RequireRestart = false, HintText = "{=ah_min_dismount_chance_hint}Even if riding skill is high, it cannot be lower than this value to prevent riding skill from completely immune dismount", Order = 2)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float MinDismountChance { get; set; } = 0.01f;

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00003118 File Offset: 0x00001318
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00003120 File Offset: 0x00001320
		[SettingPropertyFloatingInteger("{=ah_block_dismount_chance_modifier}Normal Block Dismount Chance Reduction Factor", 0f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_block_dismount_chance_modifier_hint}Normal block successful dismount probability reduction percentage", Order = 3)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float BlockDismountChanceModifier { get; set; } = 0.5f;

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00003129 File Offset: 0x00001329
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00003131 File Offset: 0x00001331
		[SettingPropertyFloatingInteger("{=ah_polearm_dismount_modifier}Polearm Dismount Probability Correction", 0.5f, 3f, "0.00", RequireRestart = false, HintText = "{=ah_polearm_dismount_modifier_hint}Polearm weapon attack dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 4)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float PolearmDismountModifier { get; set; } = 1f;

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000313A File Offset: 0x0000133A
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00003142 File Offset: 0x00001342
		[SettingPropertyFloatingInteger("{=ah_heavy_weapon_dismount_modifier}Heavy Weapon Dismount Probability Correction", 0.5f, 3f, "0.00", RequireRestart = false, HintText = "{=ah_heavy_weapon_dismount_modifier_hint}Heavy weapon dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 5)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float HeavyWeaponDismountModifier { get; set; } = 0.8f;

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000314B File Offset: 0x0000134B
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00003153 File Offset: 0x00001353
		[SettingPropertyFloatingInteger("{=ah_other_weapon_dismount_modifier}Other Weapon Dismount Probability Correction", 0.1f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_other_weapon_dismount_modifier_hint}Other weapon dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 6)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float OtherWeaponDismountModifier { get; set; } = 0.4f;

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000315C File Offset: 0x0000135C
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00003164 File Offset: 0x00001364
		[SettingPropertyFloatingInteger("{=ah_head_hit_dismount_modifier}Head Hit Dismount Probability Correction", 0.5f, 5f, "0.00", RequireRestart = false, HintText = "{=ah_head_hit_dismount_modifier_hint}Head hit dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 7)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float HeadHitDismountModifier { get; set; } = 1.5f;

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000316D File Offset: 0x0000136D
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00003175 File Offset: 0x00001375
		[SettingPropertyFloatingInteger("{=ah_leg_hit_dismount_modifier}Leg Hit Dismount Probability Correction", 0.1f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_leg_hit_dismount_modifier_hint}Leg hit dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 8)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float LegHitDismountModifier { get; set; } = 0.3f;

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000317E File Offset: 0x0000137E
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00003186 File Offset: 0x00001386
		[SettingPropertyFloatingInteger("{=ah_body_hit_dismount_modifier}Body Hit Dismount Probability Correction", 0.1f, 3f, "0.00", RequireRestart = false, HintText = "{=ah_body_hit_dismount_modifier_hint}Body hit dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 9)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float BodyHitDismountModifier { get; set; } = 1f;

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000318F File Offset: 0x0000138F
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00003197 File Offset: 0x00001397
		[SettingPropertyFloatingInteger("{=ah_other_hit_dismount_modifier}Other Part Hit Dismount Probability Correction", 0.1f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_other_hit_dismount_modifier_hint}Other part hit dismount probability correction. 1.0 means no correction, greater than 1 increases dismount probability, less than 1 reduces dismount probability", Order = 10)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float OtherHitDismountModifier { get; set; } = 0.6f;

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000031A0 File Offset: 0x000013A0
		// (set) Token: 0x06000134 RID: 308 RVA: 0x000031A8 File Offset: 0x000013A8
		[SettingPropertyFloatingInteger("{=ah_low_ah_dismount_threshold}Low AH Additional Dismount Probability Threshold", 0.1f, 0.8f, "0.00", RequireRestart = false, HintText = "{=ah_low_ah_dismount_threshold_hint}When rider AH is below this time, additional dismount probability will increase. 0.3 means starting to increase when AH is below 30%", Order = 11)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float LowAhFightDismountThreshold { get; set; } = 0.15f;

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000031B1 File Offset: 0x000013B1
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000031B9 File Offset: 0x000013B9
		[SettingPropertyFloatingInteger("{=ah_low_ah_dismount_multiplier}Low AH Additional Dismount Probability Multiplier", 0.5f, 10f, "0.00", RequireRestart = false, HintText = "{=ah_low_ah_dismount_multiplier_hint}Low additional dismount probability multiplier when below additional dismount probability threshold 2.0 means increasing 1x probability", Order = 12)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public float LowAhFightDismountMultiplier { get; set; } = 1.5f;

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000031C2 File Offset: 0x000013C2
		// (set) Token: 0x06000138 RID: 312 RVA: 0x000031CA File Offset: 0x000013CA
		[SettingPropertyFloatingInteger("{=ah_max_dismount_chance}Dismount Probability Upper Limit", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_dismount_chance_hint}Dismount probability will not exceed this value to prevent dismount probability from being too high", Order = 3)]
		[SettingPropertyGroup("{=ah_mounted_related}Mounted Related", GroupOrder = 8)]
		public float MaxDismountChance { get; set; } = 0.7f;

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000031D3 File Offset: 0x000013D3
		// (set) Token: 0x0600013A RID: 314 RVA: 0x000031DB File Offset: 0x000013DB
		[SettingPropertyFloatingInteger("{=ah_perfect_block_base_chance}Base Shield Perfect Block Probability", 0.1f, 0.3f, "0.00", RequireRestart = false, HintText = "{=ah_perfect_block_base_chance_hint}Base trigger probability of shield perfect block. 0.15 means 15% base chance, will be adjusted by other factors", Order = 0)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float PerfectBlockBaseChance { get; set; } = 0.15f;

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000031E4 File Offset: 0x000013E4
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000031EC File Offset: 0x000013EC
		[SettingPropertyFloatingInteger("{=ah_perfect_block_skill_bonus_max}Skill Maximum Bonus", 0.05f, 0.25f, "0.00", RequireRestart = false, HintText = "{=ah_perfect_block_skill_bonus_max_hint}Skill level can provide maximum shield perfect block bonus. 0.15 means up to 15% trigger probability increase", Order = 1)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float PerfectBlockSkillBonusMax { get; set; } = 0.15f;

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000031F5 File Offset: 0x000013F5
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000031FD File Offset: 0x000013FD
		[SettingPropertyFloatingInteger("{=ah_side_attack_block_modifier}Side Attack Perfect Block Correction", 0.5f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_side_attack_block_modifier_hint}Side attack perfect block trigger probability correction. 0.9 means reducing 10%", Order = 2)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float SideAttackBlockModifier { get; set; } = 0.9f;

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00003206 File Offset: 0x00001406
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000320E File Offset: 0x0000140E
		[SettingPropertyFloatingInteger("{=ah_overhead_attack_block_modifier}Overhead Attack Perfect Block Correction", 0.3f, 1.2f, "0.00", RequireRestart = false, HintText = "{=ah_overhead_attack_block_modifier_hint}Overhead attack shield perfect block trigger probability correction. 0.7 means reducing 30%", Order = 3)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float OverheadAttackBlockModifier { get; set; } = 0.7f;

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00003217 File Offset: 0x00001417
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000321F File Offset: 0x0000141F
		[SettingPropertyFloatingInteger("{=ah_thrust_attack_block_modifier}Thrust Attack Perfect Block Correction", 0.4f, 1.3f, "0.00", RequireRestart = false, HintText = "{=ah_thrust_attack_block_modifier_hint}Thrust attack shield perfect block trigger probability correction. 0.8 means reducing 20%", Order = 4)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float ThrustAttackBlockModifier { get; set; } = 0.8f;

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00003228 File Offset: 0x00001428
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00003230 File Offset: 0x00001430
		[SettingPropertyFloatingInteger("{=ah_two_handed_heavy_block_modifier}Two Handed Heavy Weapon Block Correction", 0.3f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_two_handed_heavy_block_modifier_hint}Two handed heavy weapon shield perfect block trigger probability correction. 0.6 means reducing 40%")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 10)]
		public float TwoHandedHeavyBlockModifier { get; set; } = 0.6f;

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00003239 File Offset: 0x00001439
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00003241 File Offset: 0x00001441
		[SettingPropertyFloatingInteger("{=ah_one_handed_blunt_block_modifier}One Handed Blunt Block Correction", 0.4f, 1.1f, "0.00", RequireRestart = false, HintText = "{=ah_one_handed_blunt_block_modifier_hint}One handed blunt block trigger probability correction. 0.7 means reducing 30%")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 10)]
		public float OneHandedBluntBlockModifier { get; set; } = 0.7f;

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000324A File Offset: 0x0000144A
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00003252 File Offset: 0x00001452
		[SettingPropertyFloatingInteger("{=ah_two_handed_block_modifier}Two Handed Sword Block Correction", 0.5f, 1.2f, "0.00", RequireRestart = false, HintText = "{=ah_two_handed_block_modifier_hint}Two handed sword shield perfect block trigger probability correction. 0.8 means reducing 20%")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 10)]
		public float TwoHandedBlockModifier { get; set; } = 0.8f;

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000325B File Offset: 0x0000145B
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00003263 File Offset: 0x00001463
		[SettingPropertyFloatingInteger("{=ah_weapon_tip_block_modifier}Weapon Tip Block Correction", 0.5f, 1.2f, "0.00", RequireRestart = false, HintText = "{=ah_weapon_tip_block_modifier_hint}Weapon tip shield perfect block trigger probability correction. 0.8 means reducing 20%")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 10)]
		public float WeaponTipBlockModifier { get; set; } = 0.8f;

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000326C File Offset: 0x0000146C
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00003274 File Offset: 0x00001474
		[SettingPropertyFloatingInteger("{=ah_weapon_blade_block_modifier}Weapon Blade Block Correction", 0.6f, 1.3f, "0.00", RequireRestart = false, HintText = "{=ah_weapon_blade_block_modifier_hint}Weapon blade shield perfect block trigger probability correction. 0.9 means reducing 10%")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 10)]
		public float WeaponBladeBlockModifier { get; set; } = 0.9f;

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000327D File Offset: 0x0000147D
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00003285 File Offset: 0x00001485
		[SettingPropertyFloatingInteger("{=ah_perfect_block_stance_bonus}Perfect Block AH Reward (Non Shield)", 0.05f, 0.5f, "0.000", RequireRestart = false, HintText = "{=ah_perfect_block_stance_bonus_hint}AH reward for successful perfect block using weapon. 0.15 means recovering 15% of max AH, reward high risk high return block", Order = 10)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float PerfectBlockStanceBonus { get; set; } = 0.18f;

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000328E File Offset: 0x0000148E
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00003296 File Offset: 0x00001496
		[SettingPropertyFloatingInteger("{=ah_shield_perfect_block_stance_bonus}Perfect Block AH Reward (Shield)", 0.025f, 0.25f, "0.000", RequireRestart = false, HintText = "{=ah_shield_perfect_block_stance_bonus_hint}AH reward for successful perfect block using shield. 0.075 means recovering 7.5% of max AH, lower weapon block because risk is lower", Order = 11)]
		[SettingPropertyGroup("{=ah_perfect_block}Perfect Block", GroupOrder = 9)]
		public float ShieldPerfectBlockStanceBonus { get; set; } = 0.095f;

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000329F File Offset: 0x0000149F
		// (set) Token: 0x06000152 RID: 338 RVA: 0x000032A7 File Offset: 0x000014A7
		[SettingPropertyFloatingInteger("{=ah_thrust_stance_loss}Thrust Stance Loss Factor", 0.7f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_thrust_stance_loss_hint}Control thrust attack AH loss multiplier, value越大刺击造成的AH损失越高")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float ThrustStanceLossModifier { get; set; } = 1.2f;

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000032B0 File Offset: 0x000014B0
		// (set) Token: 0x06000154 RID: 340 RVA: 0x000032B8 File Offset: 0x000014B8
		[SettingPropertyFloatingInteger("{=ah_swing_stance_loss}Swing Stance Loss Factor", 0.5f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_swing_stance_loss_hint}Control swing attack AH loss multiplier, value越大挥砍造成的AH损失越高")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float SwingStanceLossModifier { get; set; } = 0.8f;

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000032C1 File Offset: 0x000014C1
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000032C9 File Offset: 0x000014C9
		[SettingPropertyFloatingInteger("{=ah_one_handed_sword_swing}One Handed Sword AH Consumption", 0.7f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_one_handed_sword_swing_hint}Control one handed sword and dagger swing AH loss multiplier, 0.85 means reducing 15% of base consumption")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float OneHandedSwordSwingModifier { get; set; } = 0.85f;

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000032D2 File Offset: 0x000014D2
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000032DA File Offset: 0x000014DA
		[SettingPropertyFloatingInteger("{=ah_two_handed_sword_swing}Two Handed Sword AH Consumption", 0.7f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_two_handed_sword_swing_hint}Control two handed sword swing AH loss multiplier, 1.1 means increasing 10% of base consumption")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float TwoHandedSwordSwingModifier { get; set; } = 1.1f;

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000032E3 File Offset: 0x000014E3
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000032EB File Offset: 0x000014EB
		[SettingPropertyFloatingInteger("{=ah_one_handed_blunt_swing}One Handed Blunt AH Consumption", 0.7f, 1.3f, "0.00", RequireRestart = false, HintText = "{=ah_one_handed_blunt_swing_hint}Control one handed axe and blunt swing AH loss multiplier, 1.0 means equal to base consumption")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float OneHandedBluntSwingModifier { get; set; } = 1f;

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000032F4 File Offset: 0x000014F4
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000032FC File Offset: 0x000014FC
		[SettingPropertyFloatingInteger("{=ah_two_handed_blunt_swing}Two Handed Blunt AH Consumption", 0.7f, 1.6f, "0.00", RequireRestart = false, HintText = "{=ah_two_handed_blunt_swing_hint}Control two handed axe and heavy blunt swing AH loss multiplier, 1.25 means increasing 25% of base consumption")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float TwoHandedBluntSwingModifier { get; set; } = 1.25f;

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00003305 File Offset: 0x00001505
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000330D File Offset: 0x0000150D
		[SettingPropertyFloatingInteger("{=ah_polearm_swing}Polearm AH Consumption", 0.8f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_polearm_swing_hint}Control polearm swing AH loss multiplier, 1.15 means increasing 15% of base consumption")]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public float PolearmSwingModifier { get; set; } = 1.15f;

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00003316 File Offset: 0x00001516
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000331E File Offset: 0x0000151E
		[SettingPropertyFloatingInteger("{=ah_stance_loss_base_multiplier}AH Loss Base Multiplier", 10f, 50f, "0.0", RequireRestart = false, HintText = "{=ah_stance_loss_base_multiplier_hint}Adjust base multiplier of all AH loss. 20 means base loss will be magnified 20 times", Order = 0)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float StanceLossBaseMultiplier { get; set; } = 20f;

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00003327 File Offset: 0x00001527
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0000332F File Offset: 0x0000152F
		[SettingPropertyFloatingInteger("{=ah_max_attacker_stance_loss}Max Attacker Stance Loss", 5f, 30f, "0.0", RequireRestart = false, HintText = "{=ah_max_attacker_stance_loss_hint}Max AH loss per single attack by attacker. 15 means max AH loss of 15 points regardless of stacking", Order = 10)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float MaxAttackerStanceLoss { get; set; } = 15f;

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00003338 File Offset: 0x00001538
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00003340 File Offset: 0x00001540
		[SettingPropertyFloatingInteger("{=ah_max_defender_stance_loss}Max Defender Stance Loss", 10f, 50f, "0.0", RequireRestart = false, HintText = "{=ah_max_defender_stance_loss_hint}Max AH loss per single defense by defender. 25 means max AH loss of 25 points regardless of stacking", Order = 11)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float MaxDefenderStanceLoss { get; set; } = 25f;

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00003349 File Offset: 0x00001549
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00003351 File Offset: 0x00001551
		[SettingPropertyFloatingInteger("{=ah_stance_damage_reduction}AH Loss Reduction", 0.5f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_stance_damage_reduction_hint}Reduction of loss. 1.0 means no reduction, 0.5 means half loss", Order = 1)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float StanceDamageReductionFactor { get; set; } = 1f;

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000335A File Offset: 0x0000155A
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00003362 File Offset: 0x00001562
		[SettingPropertyFloatingInteger("{=ah_weapon_tip_hit_stance_loss}Weapon Tip Hit Bonus", 0.7f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_weapon_tip_hit_stance_loss_hint}AH loss bonus when hitting weapon tip. 1.15 means additional 15% loss, because tip hit consumes more physical strength", Order = 2)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float WeaponTipHitStanceLossModifier { get; set; } = 1.08f;

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000336B File Offset: 0x0000156B
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00003373 File Offset: 0x00001573
		[SettingPropertyFloatingInteger("{=ah_weapon_blade_hit_stance_loss}Weapon Blade Hit Bonus", 1f, 1.5f, "0.00", RequireRestart = false, HintText = "{=ah_weapon_blade_hit_stance_loss_hint}AH loss bonus when hitting weapon blade. 1.05 means additional 5% loss", Order = 3)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float WeaponBladeHitStanceLossModifier { get; set; } = 1.05f;

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00003384 File Offset: 0x00001584
		[SettingPropertyFloatingInteger("{=ah_large_shield_defense}Large Shield Defense Reduction", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_large_shield_defense_hint}AH loss reduction when using large shield. 0.7 means only suffering 70% of AH loss", Order = 4)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float LargeShieldDefenseModifier { get; set; } = 0.7f;

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000338D File Offset: 0x0000158D
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00003395 File Offset: 0x00001595
		[SettingPropertyFloatingInteger("{=ah_small_shield_defense}Small Shield Defense Reduction", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_small_shield_defense_hint}AH loss reduction when using small shield. 0.9 means suffering 90% of AH loss", Order = 5)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float SmallShieldDefenseModifier { get; set; } = 0.9f;

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000339E File Offset: 0x0000159E
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000033A6 File Offset: 0x000015A6
		[SettingPropertyFloatingInteger("{=ah_perfect_shield_block}Perfect Shield Block Reduction", 0.1f, 0.8f, "0.00", RequireRestart = false, HintText = "{=ah_perfect_shield_block_hint}AH loss reduction when using perfect shield. 0.3 means only suffering 30% of AH loss, reward accurate block", Order = 6)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float PerfectShieldBlockModifier { get; set; } = 0.3f;

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000033AF File Offset: 0x000015AF
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000033B7 File Offset: 0x000015B7
		[SettingPropertyFloatingInteger("{=ah_correct_side_shield_block}Correct Shield Block Reduction", 0.1f, 0.8f, "0.00", RequireRestart = false, HintText = "{=ah_correct_side_shield_block_hint}Correct direction shield block AH loss reduction. 0.3 means only suffering 30% of AH loss", Order = 7)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float CorrectSideShieldBlockModifier { get; set; } = 0.4f;

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000033C0 File Offset: 0x000015C0
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000033C8 File Offset: 0x000015C8
		[SettingPropertyFloatingInteger("{=ah_wrong_side_shield_block}Wrong Shield Block Penalty", 0.1f, 2f, "0.00", RequireRestart = false, HintText = "{=ah_wrong_side_shield_block_hint}AH loss bonus for wrong direction shield block. 1.0 means no AH loss reduction", Order = 8)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public float WrongSideShieldBlockModifier { get; set; } = 1.1f;

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000033D1 File Offset: 0x000015D1
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000033D9 File Offset: 0x000015D9
		[SettingPropertyFloatingInteger("{=ah_hand_hit_weapon_drop_base}Hand Hit Weapon Drop Base Probability", 0.01f, 0.3f, "0.00", RequireRestart = false, HintText = "{=ah_hand_hit_weapon_drop_base_hint}Base drop probability when attacking hits hand. 0.15 means 15% base chance, will be adjusted by other factors", Order = 0)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float HandHitWeaponDropBaseChance { get; set; } = 0.1f;

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000033E2 File Offset: 0x000015E2
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000033EA File Offset: 0x000015EA
		[SettingPropertyFloatingInteger("{=ah_stance_weapon_drop}AH Value Weapon Drop Influence Factor", 0.5f, 3f, "0.00", RequireRestart = false, HintText = "{=ah_stance_weapon_drop_hint}AH value influence factor on weapon drop. 1.5 means each 10% loss increases drop probability by 15%", Order = 1)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float StanceWeaponDropModifier { get; set; } = 1.5f;

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000033F3 File Offset: 0x000015F3
		// (set) Token: 0x0600017A RID: 378 RVA: 0x000033FB File Offset: 0x000015FB
		[SettingPropertyFloatingInteger("{=ah_skill_weapon_drop}Skill Weapon Drop Influence Factor", 10f, 50f, "0.0", RequireRestart = false, HintText = "{=ah_skill_weapon_drop_hint}Skill influence factor on weapon drop. 20 means each 20 skill reduces drop probability by 1%", Order = 2)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float SkillWeaponDropDivisor { get; set; } = 30f;

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00003404 File Offset: 0x00001604
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000340C File Offset: 0x0000160C
		[SettingPropertyFloatingInteger("{=ah_min_weapon_drop}Weapon Drop Probability Minimum Value", 0.01f, 0.2f, "0.00", RequireRestart = false, HintText = "{=ah_min_weapon_drop_hint}Drop probability will not be lower than this regardless of skill. 0.05 means at least 5% drop probability", Order = 3)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MinWeaponDropChance { get; set; } = 0.03f;

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00003415 File Offset: 0x00001615
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0000341D File Offset: 0x0000161D
		[SettingPropertyFloatingInteger("{=ah_max_weapon_drop}Weapon Drop Probability Maximum Value", 0.2f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_weapon_drop_hint}Drop probability will not exceed this regardless of other factors. 0.75 means up to 75% drop probability", Order = 4)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MaxWeaponDropChance { get; set; } = 0.3f;

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00003426 File Offset: 0x00001626
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000342E File Offset: 0x0000162E
		[SettingPropertyFloatingInteger("{=ah_exhausted_both_drop}Exhausted Both Drop Probability", 0.1f, 0.8f, "0.00", RequireRestart = false, HintText = "{=ah_exhausted_both_drop_hint}Exhausted AH drop weapon and shield probability when hit. 0.5 means 50% chance two equipment drop", Order = 5)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float ExhaustedBothDropBaseChance { get; set; } = 0.3f;

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00003437 File Offset: 0x00001637
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000343F File Offset: 0x0000163F
		[SettingPropertyFloatingInteger("{=ah_exhausted_weapon_drop}Exhausted Weapon Drop Probability", 0.1f, 0.9f, "0.00", RequireRestart = false, HintText = "{=ah_exhausted_weapon_drop_hint}Exhausted weapon drop probability when not triggering double drop", Order = 7)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float ExhaustedWeaponDropChance { get; set; } = 0.6f;

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00003448 File Offset: 0x00001648
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00003450 File Offset: 0x00001650
		[SettingPropertyFloatingInteger("{=ah_mounted_drop_resistance}Mounted Weapon Drop Resistance", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_mounted_drop_resistance_hint}Mounted resistance to weapon drop. 0.4 means 40% of original drop probability", Order = 8)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MountedDropResistance { get; set; } = 0.4f;

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00003459 File Offset: 0x00001659
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00003461 File Offset: 0x00001661
		[SettingPropertyFloatingInteger("{=ah_mounted_max_drop}Mounted Weapon Drop Maximum Probability", 0.1f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_mounted_max_drop_hint}Mounted weapon drop maximum probability.", Order = 9)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MountedMaxDropChance { get; set; } = 0.4f;

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000346A File Offset: 0x0000166A
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00003472 File Offset: 0x00001672
		[SettingPropertyFloatingInteger("{=ah_max_shield_block_exhausted_drop}Max Shield Block Exhausted Drop Chance", 0.01f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_shield_block_exhausted_drop_hint}Max shield block exhausted drop chance.", Order = 10)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MaxShieldBlockExhaustedDropChance { get; set; } = 0.08f;

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000347B File Offset: 0x0000167B
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00003483 File Offset: 0x00001683
		[SettingPropertyFloatingInteger("{=ah_max_weapon_block_exhausted_drop}Max Weapon Block Exhausted Drop Chance", 0.01f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_weapon_block_exhausted_drop_hint}Max weapon block exhausted drop chance.", Order = 11)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MaxWeaponBlockExhaustedDropChance { get; set; } = 0.1f;

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000348C File Offset: 0x0000168C
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00003494 File Offset: 0x00001694
		[SettingPropertyFloatingInteger("{=ah_max_strike_exhausted_drop}Max Strike Exhausted Drop Chance", 0.01f, 1f, "0.00", RequireRestart = false, HintText = "{=ah_max_strike_exhausted_drop_hint}Max strike exhausted drop chance.", Order = 12)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public float MaxStrikeExhaustedDropChance { get; set; } = 0.13f;

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000349D File Offset: 0x0000169D
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000034A5 File Offset: 0x000016A5
		[SettingPropertyFloatingInteger("{=ah_normal_state_regen}Normal State Regeneration Speed", 0.1f, 5f, "0.0", RequireRestart = false, HintText = "{=ah_normal_state_regen_hint}Regeneration speed when AH≥75%. 1.2 means faster than base recovery by 20%, encourage maintaining good state", Order = 10)]
		[SettingPropertyGroup("{=ah_regen_config}Regeneration Configuration (State)", GroupOrder = 11)]
		public float NormalRegenModifier { get; set; } = 1.2f;

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000034AE File Offset: 0x000016AE
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000034B6 File Offset: 0x000016B6
		[SettingPropertyFloatingInteger("{=ah_weak_state_regen}Weak State Regeneration Speed", 0.1f, 5f, "0.0", RequireRestart = false, HintText = "{=ah_weak_state_regen_hint}Regeneration speed when AH is 50-75%. 1.0 means equal to base recovery speed", Order = 11)]
		[SettingPropertyGroup("{=ah_regen_config}Regeneration Configuration (State)", GroupOrder = 11)]
		public float WeakRegenModifier { get; set; } = 1f;

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000034BF File Offset: 0x000016BF
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000034C7 File Offset: 0x000016C7
		[SettingPropertyFloatingInteger("{=ah_tired_state_regen}Tired State Regeneration Speed", 0.1f, 5f, "0.0", RequireRestart = false, HintText = "{=ah_tired_state_regen_hint}Regeneration speed when AH is 25-50%. 0.8 means slower than base recovery by 20%, reflect physical exhaustion state", Order = 12)]
		[SettingPropertyGroup("{=ah_regen_config}Regeneration Configuration (State)", GroupOrder = 11)]
		public float TiredRegenModifier { get; set; } = 0.8f;

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000034D0 File Offset: 0x000016D0
		// (set) Token: 0x06000194 RID: 404 RVA: 0x000034D8 File Offset: 0x000016D8
		[SettingPropertyFloatingInteger("{=ah_powerless_state_regen}Powerless State Regeneration Speed", 0.1f, 5f, "0.0", RequireRestart = false, HintText = "{=ah_powerless_state_regen_hint}Regeneration speed when AH is below 25%. 0.5 means slower than base recovery by 50%, reflect extremely tired state", Order = 13)]
		[SettingPropertyGroup("{=ah_regen_config}Regeneration Configuration (State)", GroupOrder = 11)]
		public float PowerlessRegenModifier { get; set; } = 0.5f;

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000034E1 File Offset: 0x000016E1
		// (set) Token: 0x06000196 RID: 406 RVA: 0x000034E9 File Offset: 0x000016E9
		[SettingPropertyBool("{=ah_attack_type_loss}Attack Type AH Loss", RequireRestart = false, HintText = "{=ah_attack_type_loss_hint}Control AH loss multiplier of different attack types", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_attack_type_loss}Attack Type AH Loss", GroupOrder = 10)]
		public bool AttackTypeAhLossToggle { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000034F2 File Offset: 0x000016F2
		// (set) Token: 0x06000198 RID: 408 RVA: 0x000034FA File Offset: 0x000016FA
		[SettingPropertyBool("{=ah_loss_advanced_config}Advanced Loss Configuration", RequireRestart = false, HintText = "{=ah_loss_advanced_config_hint}More detailed AH loss parameter adjustment", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_loss_advanced_config}Advanced Loss Configuration", GroupOrder = 12)]
		public bool AdvancedAhLossToggle { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00003503 File Offset: 0x00001703
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0000350B File Offset: 0x0000170B
		[SettingPropertyBool("{=ah_weapon_drop_config}Weapon Drop Configuration", RequireRestart = false, HintText = "{=ah_weapon_drop_config_hint}Control weapon drop related parameters", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_weapon_drop_config}Weapon Drop Configuration", GroupOrder = 13)]
		public bool WeaponDropToggle { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00003514 File Offset: 0x00001714
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0000351C File Offset: 0x0000171C
		[SettingPropertyBool("{=ah_perfect_block_config}Perfect Block Configuration", RequireRestart = false, HintText = "{=ah_perfect_block_config_hint}Control perfect block related parameters", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_perfect_block_config}Perfect Block Configuration", GroupOrder = 14)]
		public bool PerfectBlockToggle { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00003525 File Offset: 0x00001725
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0000352D File Offset: 0x0000172D
		[SettingPropertyBool("{=ah_mounted_config}Mounted Related Configuration", RequireRestart = false, HintText = "{=ah_mounted_config_hint}Control mounted related parameters", Order = 0, IsToggle = true)]
		[SettingPropertyGroup("{=ah_advanced_settings}Advanced Settings/{=ah_mounted_config}Mounted Related Configuration", GroupOrder = 15)]
		public bool MountedConfigToggle { get; set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00003536 File Offset: 0x00001736
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000353E File Offset: 0x0000173E
		[SettingPropertyBool("{=ah_ranged_effect_enabled}Ranged Strike Effects", RequireRestart = false, HintText = "{=ah_ranged_effect_enabled_hint}When enabled, high-speed arrows, bolts, javelins, or throwing axes can cause knockback, knockdown, or dismount (even when blocked). Higher encumbrance increases resistance, making effects less likely to trigger", Order = 0)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged", GroupOrder = 12)]
		public bool MissileEffectEnabled { get; set; } = true;

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00003547 File Offset: 0x00001747
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000354F File Offset: 0x0000174F
		[SettingPropertyBool("{=ah_ranged_loss_enabled}Ranged Loss Enabled", RequireRestart = false, HintText = "{=ah_ranged_loss_enabled_hint}When enabled, arrows and bolts will cause AH loss. Consecutive hits may slow down advance speed (resistance)", Order = 2)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged", GroupOrder = 12)]
		public bool MissileLossEnabled { get; set; } = true;

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00003558 File Offset: 0x00001758
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00003560 File Offset: 0x00001760
		[SettingPropertyFloatingInteger("{=ah_ranged_base_resistance}Base Strike Effect Resistance", 0.1f, 0.9f, "0.0", RequireRestart = false, HintText = "{=ah_ranged_base_resistance_hint}Higher base resistance makes effects less likely to trigger. Final resistance is affected by encumbrance (heavily armored soldiers are less affected)The higher the ride and load, the safer it is. ", Order = 2)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged/{=ah_ranged_resistance}Strike Effect Adjustment", GroupOrder = 12)]
		public float RangedBaseResistance { get; set; } = 0.25f;

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00003569 File Offset: 0x00001769
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00003571 File Offset: 0x00001771
		[SettingPropertyFloatingInteger("{=ah_ranged_max_effect_chance}Maximum Effect Trigger Probability", 0.1f, 0.9f, "0.0", RequireRestart = false, HintText = "{=ah_ranged_max_effect_chance_hint}The maximum probability for strike effects to trigger, a cap that won't be exceeded even if unarmored", Order = 3)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged/{=ah_ranged_resistance}Strike Effect Adjustment", GroupOrder = 12)]
		public float RangedMaxEffectChance { get; set; } = 0.6f;

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000357A File Offset: 0x0000177A
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00003582 File Offset: 0x00001782
		[SettingPropertyFloatingInteger("{=ah_ranged_loss}Ranged Blocked With Shield Base Loss", 1f, 30f, "0.0", RequireRestart = false, HintText = "{=ah_ranged_loss_hint}The base AH loss when a missile hits a shield", Order = 4)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged/{=ah_ranged_resistance}Strike Effect Adjustment", GroupOrder = 12)]
		public float RangedShieldLoss { get; set; } = 8f;

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000358B File Offset: 0x0000178B
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00003593 File Offset: 0x00001793
		[SettingPropertyFloatingInteger("{=ah_ranged_hit_loss}Ranged Hit Base Loss", 1f, 50f, "0.0", RequireRestart = false, HintText = "{=ah_ranged_hit_loss_hint}The base AH loss when a missile hits a target", Order = 5)]
		[SettingPropertyGroup("{=ah_ranged_settings}Ranged/{=ah_ranged_resistance}Strike Effect Adjustment", GroupOrder = 12)]
		public float RangedHitLoss { get; set; } = 12f;

        /// <summary>
        /// Crush Through Block
        /// </summary>
        [SettingPropertyFloatingInteger("Crush Through Block AH Threshold", 0.1f, 0.99f, "0.0 %", Order = 4, RequireRestart = false, HintText = "Crush Through Block if AH lower than threshold. Default: 45.0 percent")]
        [SettingPropertyGroup("Crush Through Block", GroupOrder = 13)]
        public float CrushThroughBlockThreshold { get; set; } = 0.45f;

        [SettingPropertyFloatingInteger("Stamina Damage Amount on Block Multiplier", 0.1f, 0.99f, "0.0 %", Order = 4, RequireRestart = false, HintText = "Damage to AH when player or ai blocking attacks. Based on weapon damage, player combat skills, ahtletics, riding, HP, age and attack energy. Default: 0.65")]
        [SettingPropertyGroup("Crush Through Block", GroupOrder = 13)]
        public float StaminaDamageAmountOnBlock { get; set; } = 0.65f;

        /// <summary>
        /// Performance Penalties
        /// Reduce player attack speed
        /// </summary>

        [SettingPropertyBool("Enable Performance Penalties", RequireRestart = false, HintText = "Enable or disable attack speed penalties based on AH")]
        [SettingPropertyGroup("Performance Penalties", GroupOrder = 14)]
        public bool AttackSpeedPenaltyEnabled { get; set; } = true;

        [SettingPropertyFloatingInteger("Minimum Attack Speed Multiplier", 0.1f, 1f, "0.0", Order = 0, RequireRestart = false, HintText = "Minimum speed multiplier when stamina is depleted. Default: 0.3")]
        [SettingPropertyGroup("Performance Penalties", GroupOrder = 14)]
        public float MinAttackSpeedMultiplier { get; set; } = 0.3f;

        [SettingPropertyFloatingInteger("Minimum Attack Speed Multiplier Stamina Threshold", 0.1f, 0.99f, "0.0", Order = 1, RequireRestart = false, HintText = "Stamina threshold for applying penalties. Default: 0.8")]
        [SettingPropertyGroup("Performance Penalties", GroupOrder = 14)]
        public float LowStaminaAttackSpeedThreshold { get; set; } = 0.8f;

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
			this.MinMovementPenaltyMultiplier = 0.45f;
			this.MovementPenaltyAHThreshold = 0.8f;
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
			this.MinDamageMultiplier = 0.1f;
			this.DamageReductionThreshold = 0.8f;
            this.StaminaDamageAmountOnBlock  = 0.65f;
            this.CrushThroughBlockThreshold  = 0.45f;
			this.AttackSpeedPenaltyEnabled = true;
            this.MinAttackSpeedMultiplier = 0.3f;
			this.LowStaminaAttackSpeedThreshold = 0.8f;
        }
	}
}
