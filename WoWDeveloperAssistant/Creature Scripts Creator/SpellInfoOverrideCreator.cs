using System;
using System.Collections.Generic;
using System.Collections;
using WoWDeveloperAssistant.Misc;
using System.Windows.Forms;

namespace WoWDeveloperAssistant.SpellInfo_Override_DbCreator
{
    public class SpellInfoOverrideCreator
    {
        private MainForm mainForm;

        public SpellInfoOverrideCreator(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.spellInfoEntries = new Dictionary<uint, ArrayList>();
        }

        private Dictionary<uint, ArrayList> spellInfoEntries;

        private static readonly Dictionary<int, ArrayList> overrideValuesDictionary = new Dictionary<int, ArrayList>
        {
            { 4, new ArrayList
                {
                    "SPELL_ATTR0_UNK0",
                    "SPELL_ATTR0_REQ_AMMO",
                    "SPELL_ATTR0_ON_NEXT_SWING",
                    "SPELL_ATTR0_IS_REPLENISHMENT",
                    "SPELL_ATTR0_ABILITY",
                    "SPELL_ATTR0_TRADESPELL",
                    "SPELL_ATTR0_PASSIVE",
                    "SPELL_ATTR0_HIDDEN_CLIENTSIDE",
                    "SPELL_ATTR0_HIDE_IN_COMBAT_LOG",
                    "SPELL_ATTR0_TARGET_MAINHAND_ITEM",
                    "SPELL_ATTR0_ON_NEXT_SWING_2",
                    "SPELL_ATTR0_UNK11",
                    "SPELL_ATTR0_DAYTIME_ONLY",
                    "SPELL_ATTR0_NIGHT_ONLY",
                    "SPELL_ATTR0_INDOORS_ONLY",
                    "SPELL_ATTR0_OUTDOORS_ONLY",
                    "SPELL_ATTR0_NOT_SHAPESHIFT",
                    "SPELL_ATTR0_ONLY_STEALTHED",
                    "SPELL_ATTR0_DONT_AFFECT_SHEATH_STATE",
                    "SPELL_ATTR0_LEVEL_DAMAGE_CALCULATION",
                    "SPELL_ATTR0_STOP_ATTACK_TARGET",
                    "SPELL_ATTR0_IMPOSSIBLE_DODGE_PARRY_BLOCK",
                    "SPELL_ATTR0_CAST_TRACK_TARGET",
                    "SPELL_ATTR0_CASTABLE_WHILE_DEAD",
                    "SPELL_ATTR0_CASTABLE_WHILE_MOUNTED",
                    "SPELL_ATTR0_DISABLED_WHILE_ACTIVE",
                    "SPELL_ATTR0_DEBUFF",
                    "SPELL_ATTR0_CASTABLE_WHILE_SITTING",
                    "SPELL_ATTR0_CANT_USED_IN_COMBAT",
                    "SPELL_ATTR0_UNAFFECTED_BY_INVULNERABILITY",
                    "SPELL_ATTR0_BREAKABLE_BY_DAMAGE",
                    "SPELL_ATTR0_CANT_CANCEL",
                }
            },

            { 5, new ArrayList
                {
                    "SPELL_ATTR1_DISMISS_PET",
                    "SPELL_ATTR1_DRAIN_ALL_POWER",
                    "SPELL_ATTR1_CHANNELED_1",
                    "SPELL_ATTR1_CANT_BE_REDIRECTED",
                    "SPELL_ATTR1_UNK4",
                    "SPELL_ATTR1_NOT_BREAK_STEALTH",
                    "SPELL_ATTR1_CHANNELED_2",
                    "SPELL_ATTR1_CANT_BE_REFLECTED",
                    "SPELL_ATTR1_CANT_TARGET_IN_COMBAT",
                    "SPELL_ATTR1_MELEE_COMBAT_START",
                    "SPELL_ATTR1_NO_THREAT",
                    "SPELL_ATTR1_UNK11",
                    "SPELL_ATTR1_IS_PICKPOCKET",
                    "SPELL_ATTR1_FARSIGHT",
                    "SPELL_ATTR1_CHANNEL_TRACK_TARGET",
                    "SPELL_ATTR1_DISPEL_AURAS_ON_IMMUNITY",
                    "SPELL_ATTR1_UNAFFECTED_BY_SCHOOL_IMMUNE",
                    "SPELL_ATTR1_UNAUTOCASTABLE_BY_PET",
                    "SPELL_ATTR1_UNK18",
                    "SPELL_ATTR1_CANT_TARGET_SELF",
                    "SPELL_ATTR1_REQ_COMBO_POINTS1",
                    "SPELL_ATTR1_UNK21",
                    "SPELL_ATTR1_REQ_COMBO_POINTS2",
                    "SPELL_ATTR1_UNK23",
                    "SPELL_ATTR1_IS_FISHING",
                    "SPELL_ATTR1_UNK25",
                    "SPELL_ATTR1_UNK26",
                    "SPELL_ATTR1_UNK27",
                    "SPELL_ATTR1_DONT_DISPLAY_IN_AURA_BAR",
                    "SPELL_ATTR1_CHANNEL_DISPLAY_SPELL_NAME",
                    "SPELL_ATTR1_ENABLE_AT_DODGE",
                    "SPELL_ATTR1_UNK31"
                }
            },

            { 6, new ArrayList
                {
                    "SPELL_ATTR2_CAN_TARGET_DEAD",
                    "SPELL_ATTR2_UNK1",
                    "SPELL_ATTR2_CAN_TARGET_NOT_IN_LOS",
                    "SPELL_ATTR2_UNK3",
                    "SPELL_ATTR2_DISPLAY_IN_STANCE_BAR",
                    "SPELL_ATTR2_AUTOREPEAT_FLAG",
                    "SPELL_ATTR2_CANT_TARGET_TAPPED",
                    "SPELL_ATTR2_UNK7",
                    "SPELL_ATTR2_UNK8",
                    "SPELL_ATTR2_UNK9",
                    "SPELL_ATTR2_UNK10",
                    "SPELL_ATTR2_HEALTH_FUNNEL",
                    "SPELL_ATTR2_UNK12",
                    "SPELL_ATTR2_PRESERVE_ENCHANT_IN_ARENA",
                    "SPELL_ATTR2_UNK14",
                    "SPELL_ATTR2_UNK15",
                    "SPELL_ATTR2_TAME_BEAST",
                    "SPELL_ATTR2_NOT_RESET_AUTO_ACTIONS",
                    "SPELL_ATTR2_REQ_DEAD_PET",
                    "SPELL_ATTR2_NOT_NEED_SHAPESHIFT",
                    "SPELL_ATTR2_UNK20",
                    "SPELL_ATTR2_DAMAGE_REDUCED_SHIELD",
                    "SPELL_ATTR2_UNK22",
                    "SPELL_ATTR2_IS_ARCANE_CONCENTRATION",
                    "SPELL_ATTR2_UNK24",
                    "SPELL_ATTR2_UNK25",
                    "SPELL_ATTR2_UNK26",
                    "SPELL_ATTR2_UNK27",
                    "SPELL_ATTR2_UNK28",
                    "SPELL_ATTR2_CANT_CRIT",
                    "SPELL_ATTR2_TRIGGERED_CAN_TRIGGER_PROC",
                    "SPELL_ATTR2_FOOD_BUFF"
                }
            },

            { 7, new ArrayList
                {
                    "SPELL_ATTR3_UNK0",
                    "SPELL_ATTR3_UNK1",
                    "SPELL_ATTR3_UNK2",
                    "SPELL_ATTR3_BLOCKABLE_SPELL",
                    "SPELL_ATTR3_IGNORE_RESURRECTION_TIMER",
                    "SPELL_ATTR3_UNK5",
                    "SPELL_ATTR3_UNK6",
                    "SPELL_ATTR3_STACK_FOR_DIFF_CASTERS",
                    "SPELL_ATTR3_ONLY_TARGET_PLAYERS",
                    "SPELL_ATTR3_TRIGGERED_CAN_TRIGGER_PROC_2",
                    "SPELL_ATTR3_MAIN_HAND",
                    "SPELL_ATTR3_BATTLEGROUND",
                    "SPELL_ATTR3_ONLY_TARGET_GHOSTS",
                    "SPELL_ATTR3_DONT_DISPLAY_CHANNEL_BAR",
                    "SPELL_ATTR3_IS_HONORLESS_TARGET",
                    "SPELL_ATTR3_UNK15",
                    "SPELL_ATTR3_CANT_TRIGGER_PROC",
                    "SPELL_ATTR3_NO_INITIAL_AGGRO",
                    "SPELL_ATTR3_IGNORE_HIT_RESULT",
                    "SPELL_ATTR3_DISABLE_PROC",
                    "SPELL_ATTR3_DEATH_PERSISTENT",
                    "SPELL_ATTR3_UNK21",
                    "SPELL_ATTR3_REQ_WAND",
                    "SPELL_ATTR3_UNK23",
                    "SPELL_ATTR3_REQ_OFFHAND",
                    "SPELL_ATTR3_TREAT_AS_PERIODIC",
                    "SPELL_ATTR3_CAN_PROC_WITH_TRIGGERED",
                    "SPELL_ATTR3_DRAIN_SOUL",
                    "SPELL_ATTR3_UNK28",
                    "SPELL_ATTR3_NO_DONE_BONUS",
                    "SPELL_ATTR3_DONT_DISPLAY_RANGE",
                    "SPELL_ATTR3_UNK31"
                }
            },

            { 8, new ArrayList
                {
                    "SPELL_ATTR4_IGNORE_RESISTANCES",
                    "SPELL_ATTR4_PROC_ONLY_ON_CASTER",
                    "SPELL_ATTR4_CONTINUE_AFTER_LOGOUT",
                    "SPELL_ATTR4_UNK3",
                    "SPELL_ATTR4_HAS_DELAY",
                    "SPELL_ATTR4_UNK5",
                    "SPELL_ATTR4_NOT_STEALABLE",
                    "SPELL_ATTR4_CAN_CAST_WHILE_CASTING",
                    "SPELL_ATTR4_FIXED_DAMAGE",
                    "SPELL_ATTR4_TRIGGER_ACTIVATE",
                    "SPELL_ATTR4_SPELL_VS_EXTEND_COST",
                    "SPELL_ATTR4_UNK11",
                    "SPELL_ATTR4_UNK12",
                    "SPELL_ATTR4_COMBAT_LOG_NO_CASTER",
                    "SPELL_ATTR4_DAMAGE_DOESNT_BREAK_AURAS",
                    "SPELL_ATTR4_UNK15",
                    "SPELL_ATTR4_NOT_USABLE_IN_ARENA_OR_RATED_BG",
                    "SPELL_ATTR4_USABLE_IN_ARENA",
                    "SPELL_ATTR4_AREA_TARGET_CHAIN",
                    "SPELL_ATTR4_UNK19",
                    "SPELL_ATTR4_NOT_CHECK_SELFCAST_POWER",
                    "SPELL_ATTR4_UNK21",
                    "SPELL_ATTR4_UNK22",
                    "SPELL_ATTR4_UNK23",
                    "SPELL_ATTR4_UNK24",
                    "SPELL_ATTR4_IS_PET_SCALING",
                    "SPELL_ATTR4_CAST_ONLY_IN_OUTLAND",
                    "SPELL_ATTR4_UNK27",
                    "SPELL_ATTR4_UNK28",
                    "SPELL_ATTR4_UNK29",
                    "SPELL_ATTR4_UNK30",
                    "SPELL_ATTR4_UNK31"
                }
            },

            { 9, new ArrayList
                {
                    "SPELL_ATTR5_USABLE_WHILE_MOVING",
                    "SPELL_ATTR5_NO_REAGENT_WHILE_PREP",
                    "SPELL_ATTR5_UNK2",
                    "SPELL_ATTR5_USABLE_WHILE_STUNNED",
                    "SPELL_ATTR5_UNK4",
                    "SPELL_ATTR5_SINGLE_TARGET_SPELL",
                    "SPELL_ATTR5_UNK6",
                    "SPELL_ATTR5_UNK7",
                    "SPELL_ATTR5_UNK8",
                    "SPELL_ATTR5_START_PERIODIC_AT_APPLY",
                    "SPELL_ATTR5_HIDE_DURATION",
                    "SPELL_ATTR5_ALLOW_TARGET_OF_TARGET_AS_TARGET",
                    "SPELL_ATTR5_UNK12",
                    "SPELL_ATTR5_HASTE_AFFECT_DURATION",
                    "SPELL_ATTR5_UNK14",
                    "SPELL_ATTR5_CANT_IMMUNITY_SPELL",
                    "SPELL_ATTR5_SPECIAL_ITEM_CLASS_CHECK",
                    "SPELL_ATTR5_USABLE_WHILE_FEARED",
                    "SPELL_ATTR5_USABLE_WHILE_CONFUSED",
                    "SPELL_ATTR5_DONT_TURN_DURING_CAST",
                    "SPELL_ATTR5_UNK20",
                    "SPELL_ATTR5_UNK21",
                    "SPELL_ATTR5_UNK22",
                    "SPELL_ATTR5_UNK23",
                    "SPELL_ATTR5_UNK24",
                    "SPELL_ATTR5_UNK25",
                    "SPELL_ATTR5_UNK26",
                    "SPELL_ATTR5_DONT_SHOW_AURA_IF_SELF_CAST",
                    "SPELL_ATTR5_DONT_SHOW_AURA_IF_NOT_SELF_CAST",
                    "SPELL_ATTR5_UNK29",
                    "SPELL_ATTR5_UNK30",
                    "SPELL_ATTR5_UNK31"
                }
            },

            { 10, new ArrayList
                {
                    "SPELL_ATTR6_DONT_DISPLAY_COOLDOWN",
                    "SPELL_ATTR6_ONLY_IN_ARENA",
                    "SPELL_ATTR6_IGNORE_CASTER_AURAS",
                    "SPELL_ATTR6_ASSIST_IGNORE_IMMUNE_FLAG",
                    "SPELL_ATTR6_UNK4",
                    "SPELL_ATTR6_UNK5",
                    "SPELL_ATTR6_USE_SPELL_CAST_EVENT",
                    "SPELL_ATTR6_UNK7",
                    "SPELL_ATTR6_CANT_TARGET_CROWD_CONTROLLED",
                    "SPELL_ATTR6_UNK9",
                    "SPELL_ATTR6_CAN_TARGET_POSSESSED_FRIENDS",
                    "SPELL_ATTR6_NOT_IN_RAID_INSTANCE",
                    "SPELL_ATTR6_CASTABLE_WHILE_ON_VEHICLE",
                    "SPELL_ATTR6_CAN_TARGET_INVISIBLE",
                    "SPELL_ATTR6_UNK14",
                    "SPELL_ATTR6_UNK15",
                    "SPELL_ATTR6_UNK16",
                    "SPELL_ATTR6_CANT_PROC",
                    "SPELL_ATTR6_CAST_BY_CHARMER",
                    "SPELL_ATTR6_UNK19",
                    "SPELL_ATTR6_ONLY_VISIBLE_TO_CASTER",
                    "SPELL_ATTR6_CLIENT_UI_TARGET_EFFECTS",
                    "SPELL_ATTR6_NOT_LIMIT_ABSORB",
                    "SPELL_ATTR6_UNK23",
                    "SPELL_ATTR6_CAN_TARGET_UNTARGETABLE",
                    "SPELL_ATTR6_NOT_RESET_SWING_IF_INSTANT",
                    "SPELL_ATTR6_UNK26",
                    "SPELL_ATTR6_UNK27",
                    "SPELL_ATTR6_UNK28",
                    "SPELL_ATTR6_NO_DONE_PCT_DAMAGE_MODS",
                    "SPELL_ATTR6_UNK30",
                    "SPELL_ATTR6_IGNORE_CATEGORY_COOLDOWN_MODS"
                }
            },

            { 11, new ArrayList
                {
                    "SPELL_ATTR7_UNK0",
                    "SPELL_ATTR7_IGNORE_DURATION_MODS",
                    "SPELL_ATTR7_REACTIVATE_AT_RESURRECT",
                    "SPELL_ATTR7_IS_CHEAT_SPELL",
                    "SPELL_ATTR7_UNK4",
                    "SPELL_ATTR7_SUMMON_TOTEM",
                    "SPELL_ATTR7_NO_PUSHBACK_ON_DAMAGE",
                    "SPELL_ATTR7_UNK7",
                    "SPELL_ATTR7_HORDE_ONLY",
                    "SPELL_ATTR7_ALLIANCE_ONLY",
                    "SPELL_ATTR7_DISPEL_CHARGES",
                    "SPELL_ATTR7_INTERRUPT_ONLY_NONPLAYER",
                    "SPELL_ATTR7_SILENCE_ONLY_NONPLAYER",
                    "SPELL_ATTR7_UNK13",
                    "SPELL_ATTR7_UNK14",
                    "SPELL_ATTR7_UNK15",
                    "SPELL_ATTR7_CAN_RESTORE_SECONDARY_POWER",
                    "SPELL_ATTR7_UNK17",
                    "SPELL_ATTR7_HAS_CHARGE_EFFECT",
                    "SPELL_ATTR7_ZONE_TELEPORT",
                    "SPELL_ATTR7_UNK20",
                    "SPELL_ATTR7_UNK21",
                    "SPELL_ATTR7_UNK22",
                    "SPELL_ATTR7_UNK23",
                    "SPELL_ATTR7_UNK24",
                    "SPELL_ATTR7_UNK25",
                    "SPELL_ATTR7_UNK26",
                    "SPELL_ATTR7_UNK27",
                    "SPELL_ATTR7_CONSOLIDATED_RAID_BUFF",
                    "SPELL_ATTR7_UNK29",
                    "SPELL_ATTR7_UNK30",
                    "SPELL_ATTR7_SEND_CAST_LOG_DATA"
                }
            },

            { 12, new ArrayList
                {
                    "SPELL_ATTR8_CANT_MISS",
                    "SPELL_ATTR8_UNK1",
                    "SPELL_ATTR8_UNK2",
                    "SPELL_ATTR8_UNK3",
                    "SPELL_ATTR8_UNK4",
                    "SPELL_ATTR8_UNK5",
                    "SPELL_ATTR8_UNK6",
                    "SPELL_ATTR8_UNK7",
                    "SPELL_ATTR8_AFFECT_PARTY_AND_RAID",
                    "SPELL_ATTR8_DONT_RESET_PERIODIC_TIMER",
                    "SPELL_ATTR8_NAME_CHANGED_DURING_TRANSFORM",
                    "SPELL_ATTR8_UNK11",
                    "SPELL_ATTR8_AURA_SEND_AMOUNT",
                    "SPELL_ATTR8_UNK13",
                    "SPELL_ATTR8_UNK14",
                    "SPELL_ATTR8_WATER_MOUNT",
                    "SPELL_ATTR8_UNK16",
                    "SPELL_ATTR8_HASTE_AFFECT_DURATION_RECOVERY",
                    "SPELL_ATTR8_REMEMBER_SPELLS",
                    "SPELL_ATTR8_USE_COMBO_POINTS_ON_ANY_TARGET",
                    "SPELL_ATTR8_ARMOR_SPECIALIZATION",
                    "SPELL_ATTR8_UNK21",
                    "SPELL_ATTR8_HASTE_AFFECT_DURATION",
                    "SPELL_ATTR8_BATTLE_RESURRECTION",
                    "SPELL_ATTR8_HEALING_SPELL",
                    "SPELL_ATTR8_USABLE_WHILE_SILENCED",
                    "SPELL_ATTR8_RAID_MARKER",
                    "SPELL_ATTR8_UNK27",
                    "SPELL_ATTR8_NOT_IN_BG_OR_ARENA",
                    "SPELL_ATTR8_MASTERY_SPECIALIZATION",
                    "SPELL_ATTR8_IS_BOSS_DEBUFF",
                    "SPELL_ATTR8_ATTACK_IGNORE_IMMUNE_TO_PC_FLAG",
                }
            },

            { 13, new ArrayList
                {
                    "SPELL_ATTR9_UNK0",
                    "SPELL_ATTR9_UNK1",
                    "SPELL_ATTR9_RESTRICTED_FLIGHT_AREA",
                    "SPELL_ATTR9_UNK3",
                    "SPELL_ATTR9_SPECIAL_DELAY_CALCULATION",
                    "SPELL_ATTR9_SUMMON_PLAYER_TOTEM",
                    "SPELL_ATTR9_UNK6",
                    "SPELL_ATTR9_UNK7",
                    "SPELL_ATTR9_AIMED_SHOT",
                    "SPELL_ATTR9_NOT_USABLE_IN_ARENA",
                    "SPELL_ATTR9_UNK10",
                    "SPELL_ATTR9_UNK11",
                    "SPELL_ATTR9_UNK12",
                    "SPELL_ATTR9_SLAM",
                    "SPELL_ATTR9_USABLE_IN_RATED_BATTLEGROUNDS",
                    "SPELL_ATTR9_UNK15",
                    "SPELL_ATTR9_CAN_BE_CAST_WHILE_MOVING",
                    "SPELL_ATTR9_UNK17",
                    "SPELL_ATTR9_UNK18",
                    "SPELL_ATTR9_UNK19",
                    "SPELL_ATTR9_CASTABLE_WHILE_CAST_IN_PROGRESS",
                    "SPELL_ATTR9_UNK21",
                    "SPELL_ATTR9_AFFECTED_BY_SPELLSWAP",
                    "SPELL_ATTR9_UNK23",
                    "SPELL_ATTR9_UNK24",
                    "SPELL_ATTR9_UNK25",
                    "SPELL_ATTR9_UNK26",
                    "SPELL_ATTR9_UNK27",
                    "SPELL_ATTR9_UNK28",
                    "SPELL_ATTR9_UNK29",
                    "SPELL_ATTR9_UNK30",
                    "SPELL_ATTR9_UNK31",
                }
            },

            { 14, new ArrayList
                {
                    "SPELL_ATTR10_UNK0",
                    "SPELL_ATTR10_UNK1",
                    "SPELL_ATTR10_UNK2",
                    "SPELL_ATTR10_UNK3",
                    "SPELL_ATTR10_WATER_SPOUT",
                    "SPELL_ATTR10_UNK5",
                    "SPELL_ATTR10_UNK6",
                    "SPELL_ATTR10_TELEPORT_PLAYER",
                    "SPELL_ATTR10_UNK8",
                    "SPELL_ATTR10_UNK9",
                    "SPELL_ATTR10_UNK10",
                    "SPELL_ATTR10_HERB_GATHERING_MINING",
                    "SPELL_ATTR10_USE_SPELL_BASE_LEVEL_FOR_SCALING",
                    "SPELL_ATTR10_UNK13",
                    "SPELL_ATTR10_STACK_DAMAGE_OR_HEAL",
                    "SPELL_ATTR10_UNK15",
                    "SPELL_ATTR10_UNK16",
                    "SPELL_ATTR10_CAN_DODGE_ON_CAST",
                    "SPELL_ATTR10_CAN_PARRY_BLOCK_ON_CAST",
                    "SPELL_ATTR10_UNK19",
                    "SPELL_ATTR10_TARGETING_SPELL",
                    "SPELL_ATTR10_UNK21",
                    "SPELL_ATTR10_UNK22",
                    "SPELL_ATTR10_UNK23",
                    "SPELL_ATTR10_COOLDOWN_MARKER",
                    "SPELL_ATTR10_UNK25",
                    "SPELL_ATTR10_UNK26",
                    "SPELL_ATTR10_UNK27",
                    "SPELL_ATTR10_UNK28",
                    "SPELL_ATTR10_MOUNT_IS_NOT_ACCOUNT_WIDE",
                    "SPELL_ATTR10_UNK30",
                    "SPELL_ATTR10_UNK31",
                }
            },

            { 15, new ArrayList
                {
                    "SPELL_ATTR11_UNK0",
                    "SPELL_ATTR11_UNK1",
                    "SPELL_ATTR11_SCALES_WITH_ITEM_LEVEL",
                    "SPELL_ATTR11_UNK3",
                    "SPELL_ATTR11_UNK4",
                    "SPELL_ATTR11_ABSORB_FALL_DAMAGE",
                    "SPELL_ATTR11_UNK6",
                    "SPELL_ATTR11_RANK_IGNORES_CASTER_LEVEL",
                    "SPELL_ATTR11_UNK8",
                    "SPELL_ATTR11_UNK9",
                    "SPELL_ATTR11_UNK10",
                    "SPELL_ATTR11_UNK11",
                    "SPELL_ATTR11_USABLE_IN_GROUP_ONLY",
                    "SPELL_ATTR11_UNK13",
                    "SPELL_ATTR11_UNK14",
                    "SPELL_ATTR11_UNK15",
                    "SPELL_ATTR11_NOT_USABLE_IN_CHALLENGE_MODE",
                    "SPELL_ATTR11_UNK17",
                    "SPELL_ATTR11_UNK18",
                    "SPELL_ATTR11_UNK19",
                    "SPELL_ATTR11_UNK20",
                    "SPELL_ATTR11_UNK21",
                    "SPELL_ATTR11_UNK22",
                    "SPELL_ATTR11_UNK23",
                    "SPELL_ATTR11_UNK24",
                    "SPELL_ATTR11_UNK25",
                    "SPELL_ATTR11_UNK26",
                    "SPELL_ATTR11_UNK27",
                    "SPELL_ATTR11_UNK28",
                    "SPELL_ATTR11_UNK29",
                    "SPELL_ATTR11_UNK30",
                    "SPELL_ATTR11_UNK31",
                }
            },

            { 16, new ArrayList
                {
                    "SPELL_ATTR12_UNK0",
                    "SPELL_ATTR12_UNK1",
                    "SPELL_ATTR12_UNK2",
                    "SPELL_ATTR12_UNK3",
                    "SPELL_ATTR12_UNK4",
                    "SPELL_ATTR12_UNK5",
                    "SPELL_ATTR12_UNK6",
                    "SPELL_ATTR12_UNK7",
                    "SPELL_ATTR12_UNK8",
                    "SPELL_ATTR12_UNK9",
                    "SPELL_ATTR12_UNK10",
                    "SPELL_ATTR12_UNK11",
                    "SPELL_ATTR12_UNK12",
                    "SPELL_ATTR12_UNK13",
                    "SPELL_ATTR12_UNK14",
                    "SPELL_ATTR12_UNK15",
                    "SPELL_ATTR12_UNK16",
                    "SPELL_ATTR12_UNK17",
                    "SPELL_ATTR12_UNK18",
                    "SPELL_ATTR12_UNK19",
                    "SPELL_ATTR12_UNK20",
                    "SPELL_ATTR12_UNK21",
                    "SPELL_ATTR12_UNK22",
                    "SPELL_ATTR12_UNK23",
                    "SPELL_ATTR12_IS_GARRISON_BUFF",
                    "SPELL_ATTR12_UNK25",
                    "SPELL_ATTR12_UNK26",
                    "SPELL_ATTR12_IS_READINESS_SPELL",
                    "SPELL_ATTR12_UNK28",
                    "SPELL_ATTR12_UNK29",
                    "SPELL_ATTR12_UNK30",
                    "SPELL_ATTR12_UNK31",
                }
            },

            { 17, new ArrayList
                {
                    "SPELL_ATTR13_IS_PLAYER_SPELL",
                    "SPELL_ATTR13_UNK1",
                    "SPELL_ATTR13_UNK2",
                    "SPELL_ATTR13_CANCEL_CURRENT_CAST",
                    "SPELL_ATTR13_UNK4",
                    "SPELL_ATTR13_UNK5",
                    "SPELL_ATTR13_UNK6",
                    "SPELL_ATTR13_NAMEPLATE_SHOW_PERSONAL",
                    "SPELL_ATTR13_UNK8",
                    "SPELL_ATTR13_UNK9",
                    "SPELL_ATTR13_NAMEPLATE_SHOW_ALL",
                    "SPELL_ATTR13_UNK11",
                    "SPELL_ATTR13_UNK12",
                    "SPELL_ATTR13_UNK13",
                    "SPELL_ATTR13_UNK14",
                    "SPELL_ATTR13_UNK15",
                    "SPELL_ATTR13_UNK16",
                    "SPELL_ATTR13_UNK17",
                    "SPELL_ATTR13_ACTIVATES_REQUIRED_SHAPESHIFT",
                    "SPELL_ATTR13_UNK19",
                    "SPELL_ATTR13_UNK20",
                    "SPELL_ATTR13_UNK21",
                    "SPELL_ATTR13_IS_ALWAYS_SHOWN",
                    "SPELL_ATTR13_UNK23",
                    "SPELL_ATTR13_UNK24",
                    "SPELL_ATTR13_UNK25",
                    "SPELL_ATTR13_UNK26",
                    "SPELL_ATTR13_UNK27",
                    "SPELL_ATTR13_UNK28",
                    "SPELL_ATTR13_UNK29",
                    "SPELL_ATTR13_UNK30",
                    "SPELL_ATTR13_UNK31",
                }
            },

            { 21, new ArrayList
                {
                    "TARGET_NONE",
                    "TARGET_UNIT_CASTER",
                    "TARGET_UNIT_NEARBY_ENEMY",
                    "TARGET_UNIT_NEARBY_PARTY",
                    "TARGET_UNIT_NEARBY_ALLY",
                    "TARGET_UNIT_PET",
                    "TARGET_UNIT_TARGET_ENEMY",
                    "TARGET_UNIT_SRC_AREA_ENTRY",
                    "TARGET_UNIT_DEST_AREA_ENTRY",
                    "TARGET_DEST_HOME",
                    "TARGET_UNIT_SRC_AREA_UNK_11",
                    "TARGET_UNIT_SRC_AREA_ENEMY",
                    "TARGET_UNIT_DEST_AREA_ENEMY",
                    "TARGET_DEST_DB",
                    "TARGET_DEST_CASTER",
                    "TARGET_UNIT_CASTER_AREA_PARTY",
                    "TARGET_UNIT_TARGET_ALLY",
                    "TARGET_SRC_CASTER",
                    "TARGET_GAMEOBJECT_TARGET",
                    "TARGET_UNIT_CONE_ENEMY_24",
                    "TARGET_UNIT_TARGET_ANY",
                    "TARGET_GAMEOBJECT_ITEM_TARGET",
                    "TARGET_UNIT_MASTER",
                    "TARGET_DEST_DYNOBJ_ENEMY",
                    "TARGET_DEST_DYNOBJ_ALLY",
                    "TARGET_UNIT_SRC_AREA_ALLY",
                    "TARGET_UNIT_DEST_AREA_ALLY",
                    "TARGET_DEST_CASTER_SUMMON",
                    "TARGET_UNIT_SRC_AREA_PARTY",
                    "TARGET_UNIT_DEST_AREA_PARTY",
                    "TARGET_UNIT_TARGET_PARTY",
                    "TARGET_DEST_CASTER_UNK_36",
                    "TARGET_UNIT_LASTTARGET_AREA_PARTY",
                    "TARGET_UNIT_NEARBY_ENTRY",
                    "TARGET_DEST_CASTER_FISHING",
                    "TARGET_GAMEOBJECT_NEARBY_ENTRY",
                    "TARGET_DEST_CASTER_FRONT_RIGHT",
                    "TARGET_DEST_CASTER_BACK_RIGHT",
                    "TARGET_DEST_CASTER_BACK_LEFT",
                    "TARGET_DEST_CASTER_FRONT_LEFT",
                    "TARGET_UNIT_TARGET_CHAINHEAL_ALLY",
                    "TARGET_DEST_NEARBY_ENTRY",
                    "TARGET_DEST_CASTER_FRONT",
                    "TARGET_DEST_CASTER_BACK",
                    "TARGET_DEST_CASTER_RIGHT",
                    "TARGET_DEST_CASTER_LEFT",
                    "TARGET_GAMEOBJECT_SRC_AREA",
                    "TARGET_GAMEOBJECT_DEST_AREA",
                    "TARGET_DEST_TARGET_ENEMY",
                    "TARGET_UNIT_CONE_ENEMY_54",
                    "TARGET_DEST_CASTER_FRONT_LEAP",
                    "TARGET_UNIT_CASTER_AREA_RAID",
                    "TARGET_UNIT_TARGET_RAID",
                    "TARGET_UNIT_NEARBY_RAID",
                    "TARGET_UNIT_CONE_ALLY",
                    "TARGET_UNIT_CONE_ENTRY",
                    "TARGET_UNIT_TARGET_AREA_RAID_CLASS",
                    "TARGET_DEST_DEST_UNK_62",
                    "TARGET_DEST_TARGET_ANY",
                    "TARGET_DEST_TARGET_FRONT",
                    "TARGET_DEST_TARGET_BACK",
                    "TARGET_DEST_TARGET_RIGHT",
                    "TARGET_DEST_TARGET_LEFT",
                    "TARGET_DEST_TARGET_FRONT_RIGHT",
                    "TARGET_DEST_TARGET_BACK_RIGHT",
                    "TARGET_DEST_TARGET_BACK_LEFT",
                    "TARGET_DEST_TARGET_FRONT_LEFT",
                    "TARGET_DEST_CASTER_RANDOM",
                    "TARGET_DEST_CASTER_RADIUS",
                    "TARGET_DEST_TARGET_RANDOM",
                    "TARGET_DEST_TARGET_RADIUS",
                    "TARGET_DEST_CHANNEL_TARGET",
                    "TARGET_UNIT_CHANNEL_TARGET",
                    "TARGET_DEST_DEST_FRONT",
                    "TARGET_DEST_DEST_BACK",
                    "TARGET_DEST_DEST_RIGHT",
                    "TARGET_DEST_DEST_LEFT",
                    "TARGET_DEST_DEST_FRONT_RIGHT",
                    "TARGET_DEST_DEST_BACK_RIGHT",
                    "TARGET_DEST_DEST_BACK_LEFT",
                    "TARGET_DEST_DEST_FRONT_LEFT",
                    "TARGET_DEST_DEST_RANDOM",
                    "TARGET_DEST_DEST",
                    "TARGET_DEST_DYNOBJ_NONE",
                    "TARGET_DEST_TRAJ",
                    "TARGET_UNIT_TARGET_MINIPET",
                    "TARGET_DEST_DEST_RADIUS",
                    "TARGET_UNIT_SUMMONER",
                    "TARGET_CORPSE_SRC_AREA_ENEMY",
                    "TARGET_UNIT_VEHICLE",
                    "TARGET_UNIT_TARGET_PASSENGER",
                    "TARGET_UNIT_PASSENGER_0",
                    "TARGET_UNIT_PASSENGER_1",
                    "TARGET_UNIT_PASSENGER_2",
                    "TARGET_UNIT_PASSENGER_3",
                    "TARGET_UNIT_PASSENGER_4",
                    "TARGET_UNIT_PASSENGER_5",
                    "TARGET_UNIT_PASSENGER_6",
                    "TARGET_UNIT_PASSENGER_7",
                    "TARGET_UNIT_CONE_ENEMY_104",
                    "TARGET_UNIT_UNK_105",
                    "TARGET_DEST_CHANNEL_CASTER",
                    "TARGET_DEST_EXTRA_TARGETS",
                    "TARGET_GAMEOBJECT_CONE",
                    "TARGET_UNIT_BETWEEN_DEST",
                    "TARGET_UNIT_CONE_ENEMY_110",
                    "TARGET_UNK_111",
                    "TARGET_UNK_112",
                    "TARGET_UNK_113",
                    "TARGET_UNK_114",
                    "TARGET_UNK_115",
                    "TARGET_UNK_116",
                    "TARGET_UNK_117",
                    "TARGET_UNIT_ALLY_OR_RAID",
                    "TARGET_MASS_RESSURECTION",
                    "TARGET_UNIT_CASTER_AREA_SUMMON",
                    "TARGET_UNIT_RESURRECT",
                    "TARGET_UNIT_TARGET_SELECT2",
                    "TARGET_UNIT_THREAD_PLAYER",
                    "TARGET_UNK_124",
                    "TARGET_DEST_CASTER_2",
                    "TARGET_UNK_126",
                    "TARGET_UNK_127",
                    "TARGET_UNK_128",
                    "TARGET_UNIT_ENEMY_BETWEEN_DEST",
                    "TARGET_UNIT_ENEMY_BETWEEN_DEST_2",
                    "TARGET_DEST_RANDOM_CASTER_FRONT",
                    "TARGET_DEST_TARGET_FRIEND",
                    "TARGET_UNK_133",
                    "TARGET_ENNEMIES_IN_CYLINDER",
                    "TARGET_UNK_135",
                    "TARGET_UNIT_ALLY_CONE_CASTER",
                    "TARGET_DEST_CASTER_DIRECTION",
                    "TARGET_DEST_TARGET_SELECT",
                    "TARGET_UNK_139",
                    "TARGET_UNK_140",
                    "TARGET_UNK_141",
                    "TARGET_UNK_142",
                    "TARGET_ENNEMIES_AROUND_CASTER",
                    "TARGET_UNK_144",
                    "TARGET_UNK_145",
                    "TARGET_UNK_146",
                    "TARGET_UNK_147",
                    "TARGET_DEST_TARGET_DEST",
                    "TARGET_UNK_149",
                    "TARGET_UNIT_OWN_CRITTER",
                }
            },

            // ProcFlags
            { 34, new ArrayList
                {
                    "PROC_FLAG_KILLED",
                    "PROC_FLAG_KILL",
                    "PROC_FLAG_DONE_MELEE_AUTO_ATTACK",
                    "PROC_FLAG_TAKEN_MELEE_AUTO_ATTACK",
                    "PROC_FLAG_DONE_SPELL_MELEE_DMG_CLASS",
                    "PROC_FLAG_TAKEN_SPELL_MELEE_DMG_CLASS",
                    "PROC_FLAG_DONE_RANGED_AUTO_ATTACK",
                    "PROC_FLAG_TAKEN_RANGED_AUTO_ATTACK",
                    "PROC_FLAG_DONE_SPELL_RANGED_DMG_CLASS",
                    "PROC_FLAG_TAKEN_SPELL_RANGED_DMG_CLASS",
                    "PROC_FLAG_DONE_SPELL_NONE_DMG_CLASS_POS",
                    "PROC_FLAG_TAKEN_SPELL_NONE_DMG_CLASS_POS",
                    "PROC_FLAG_DONE_SPELL_NONE_DMG_CLASS_NEG",
                    "PROC_FLAG_TAKEN_SPELL_NONE_DMG_CLASS_NEG",
                    "PROC_FLAG_DONE_SPELL_MAGIC_DMG_CLASS_POS",
                    "PROC_FLAG_TAKEN_SPELL_MAGIC_DMG_CLASS_POS",
                    "PROC_FLAG_DONE_SPELL_MAGIC_DMG_CLASS_NEG",
                    "PROC_FLAG_TAKEN_SPELL_MAGIC_DMG_CLASS_NEG",
                    "PROC_FLAG_DONE_PERIODIC",
                    "PROC_FLAG_TAKEN_PERIODIC",
                    "PROC_FLAG_TAKEN_DAMAGE",
                    "PROC_FLAG_DONE_TRAP_ACTIVATION",
                    "PROC_FLAG_DONE_MAINHAND_ATTACK",
                    "PROC_FLAG_DONE_OFFHAND_ATTACK",
                    "PROC_FLAG_DEATH",
                    "PROC_FLAG_JUMP",
                }
            },

            // AuraInterrupt Flags
            { 37, new ArrayList
                {
                    "AURA_INTERRUPT_FLAG_HITBYSPELL",
                    "AURA_INTERRUPT_FLAG_TAKE_DAMAGE",
                    "AURA_INTERRUPT_FLAG_CAST",
                    "AURA_INTERRUPT_FLAG_MOVE",
                    "AURA_INTERRUPT_FLAG_TURNING",
                    "AURA_INTERRUPT_FLAG_JUMP",
                    "AURA_INTERRUPT_FLAG_NOT_MOUNTED",
                    "AURA_INTERRUPT_FLAG_NOT_ABOVEWATER",
                    "AURA_INTERRUPT_FLAG_NOT_UNDERWATER",
                    "AURA_INTERRUPT_FLAG_NOT_SHEATHED",
                    "AURA_INTERRUPT_FLAG_TALK",
                    "AURA_INTERRUPT_FLAG_USE",
                    "AURA_INTERRUPT_FLAG_MELEE_ATTACK",
                    "AURA_INTERRUPT_FLAG_SPELL_ATTACK",
                    "AURA_INTERRUPT_FLAG_UNK14",
                    "AURA_INTERRUPT_FLAG_TRANSFORM",
                    "AURA_INTERRUPT_FLAG_UNK16",
                    "AURA_INTERRUPT_FLAG_MOUNT",
                    "AURA_INTERRUPT_FLAG_NOT_SEATED",
                    "AURA_INTERRUPT_FLAG_CHANGE_MAP",
                    "AURA_INTERRUPT_FLAG_IMMUNE_OR_LOST_SELECTION",
                    "AURA_INTERRUPT_FLAG_UNK21",
                    "AURA_INTERRUPT_FLAG_TELEPORTED",
                    "AURA_INTERRUPT_FLAG_ENTER_PVP_COMBAT",
                    "AURA_INTERRUPT_FLAG_DIRECT_DAMAGE",
                    "AURA_INTERRUPT_FLAG_LANDING",
                    "AURA_INTERRUPT_FLAG_UNK25",
                    "AURA_INTERRUPT_FLAG_TAKE_DAMAGE_AMOUNT",
                    "AURA_INTERRUPT_FLAG_ENTER_COMBAT",
                    "AURA_INTERRUPT_FLAG_UNK29",
                    "AURA_INTERRUPT_FLAG_UNK30",
                    "AURA_INTERRUPT_FLAG_LEAVE_COMBAT",
                    "AURA_INTERRUPT_FLAG_UNK32",
                    "AURA_INTERRUPT_FLAG_UNK33",
                    "AURA_INTERRUPT_FLAG_UNK34",
                    "AURA_INTERRUPT_FLAG_FALL_LAND",
                }
            },

            // Interrupt Flags
            { 36, new ArrayList
                {
                    "SPELL_INTERRUPT_FLAG_MOVEMENT",
                    "SPELL_INTERRUPT_FLAG_PUSH_BACK",
                    "SPELL_INTERRUPT_FLAG_UNK3",
                    "SPELL_INTERRUPT_FLAG_INTERRUPT",
                    "SPELL_INTERRUPT_FLAG_ABORT_ON_DMG",
                }
            },

            // Custom Attributes
            { 38, new ArrayList
                {
                    "SPELL_ATTR0_CU_ENCHANT_STACK",
                    "SPELL_ATTR0_CU_CONE_BACK",
                    "SPELL_ATTR0_CU_CONE_LINE",
                    "SPELL_ATTR0_CU_SHARE_DAMAGE",
                    "SPELL_ATTR0_CU_NO_INITIAL_THREAT",
                    "SPELL_ATTR0_CU_CANT_TARGET_PLAYERS",
                    "SPELL_ATTR0_CU_AURA_CC",
                    "SPELL_ATTR0_CU_IMPOSSIBLE_TO_DODGE_PARRY",
                    "SPELL_ATTR0_CU_DIRECT_DAMAGE",
                    "SPELL_ATTR0_CU_CHARGE",
                    "SPELL_ATTR0_CU_PICKPOCKET",
                    "SPELL_ATTR0_CU_IGNORE_TARGET_SIZE",
                    "SPELL_ATTR0_CU_NEGATIVE_EFF0",
                    "SPELL_ATTR0_CU_NEGATIVE_EFF1",
                    "SPELL_ATTR0_CU_NEGATIVE_EFF2",
                    "SPELL_ATTR0_CU_IGNORE_ARMOR",
                    "SPELL_ATTR0_CU_REQ_TARGET_FACING_CASTER",
                    "SPELL_ATTR0_CU_REQ_CASTER_BEHIND_TARGET",
                    "SPELL_ATTR0_CU_ALLOW_INFLIGHT_TARGET",
                    "SPELL_ATTR0_CU_DONT_RESET_PERIODIC_TIMER",
                    "SPELL_ATTR0_CU_ENABLE_REFLECT_IN_AREATRIGGER",
                    "SPELL_ATTR0_CU_TRIGGERED_IGNORE_RESILENCE",
                    "SPELL_ATTR0_CU_BINARY",
                    "SPELL_ATTR0_CU_ALWAYS_ACTIVE",
                    "SPELL_ATTR0_CU_IS_CUSTOM_AOE_SPELL",
                    "SPELL_ATTR0_CU_CAN_BE_CASTED_ON_ALLIES",
                    "SPELL_ATTR0_CU_SHARE_PLAYER_DAMAGE",
                    "SPELL_ATTR0_CU_ALLOW_INDOOR_MOUNT",
                    "SPELL_ATTR0_CU_NEGATIVE_AREATRIGGER",
                    "SPELL_ATTR0_CU_AREATRIGGER_BIG_OBJ",
                    "SPELL_ATTR0_CU_ALWAYS_CRITS",
                    "SPELL_ATTR0_CU_DISPLAY_GRAY_BAR",
                }
            }
        };

        static private string CreateSpellInfoInsertValues(SpellInfoOverrideEntry spellDBC)
        {
            string query = "(" + spellDBC.spellId + ", " + spellDBC.effectID + ", " + spellDBC.overrideField + ", " + spellDBC.overrideValue + ")";
            return query;
        }

        static public string GetSpellName(uint spellId)
        {
            string comment = "";
            if (DBC.DBC.IsLoaded() && DBC.DBC.SpellName.ContainsKey((int)spellId))
                comment = DBC.DBC.SpellName[(int)spellId].Name;

            return comment;
        }

        public void ClearSpellData()
        {
            mainForm.SpellInfo_Override_RichBox.Clear();
            this.spellInfoEntries.Clear();
        }

        public void GenerateSQL()
        {
            mainForm.SpellInfo_Override_RichBox.Clear();

            foreach (var item in spellInfoEntries)
            {
                string SQLtext = "";

                if (item.Value.Count > 0)
                {
                    SQLtext = "-- " + GetSpellName(item.Key) +  " \r\n";
                    SQLtext += "DELETE FROM `spellinfo_override` WHERE `SpellID` = " + item.Key + ";\r\n";
                    SQLtext += "INSERT INTO `spellinfo_override` (`SpellID`, `EffectIndex`, `Field`, `Value`) VALUES\r\n";
                }

                uint itr = 0;
                foreach (SpellInfoOverrideEntry spellDbc in item.Value)
                {
                    string query = SpellInfoOverrideCreator.CreateSpellInfoInsertValues(spellDbc);

                    if (itr + 1 >= item.Value.Count)
                        query += ";\n";
                    else
                        query += ",\n";

                    SQLtext += query;
                    itr++;
                }

                SQLtext += "\n\n";
                mainForm.SpellInfo_Override_RichBox.AppendText(SQLtext);
            }

            MessageBox.Show("SQL Queries Generated");
        }

        private bool FieldRequireGetSelectValues(uint overrideField)
        {
            if (!overrideValuesDictionary.ContainsKey((int)overrideField))
                return false;

            return true;
        }

        int GetMaskOfSelectedValuesInCheckBox(uint overrideField)
        {
            int retVal = 0;

            int[] bitFields =
            {
                4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 34, 36, 37, 38
            };

            for (int idx = 0; idx < mainForm.SpellInfoOverride_Values_CheckListBox.Items.Count; ++idx)
            {
                if (mainForm.SpellInfoOverride_Values_CheckListBox.GetItemChecked(idx))
                {
                    bool isBitField = false;

                    foreach (var field in bitFields)
                    {
                        if (field == overrideField)
                        {
                            isBitField = true;
                            break;
                        }
                    }

                    if (isBitField)
                        retVal |= (1 << idx);
                    else
                        retVal = idx;
                }
            }

            return retVal;
        }

        public void AddSpellInfoEntry()
        {
            uint SpellId = uint.Parse(mainForm.SpellInfo_Spell_Id_TextBox.Text);

            if (DBC.DBC.IsLoaded() && !DBC.DBC.SpellName.ContainsKey((int)SpellId))
            {
                String msg = String.Format("The Spell Id: {0} doesn't exist in DBC",
                         SpellId);

                MessageBox.Show(msg);
                return;
            }

            uint EffIdx = Convert.ToUInt32(mainForm.SpellInfo_EffIdx_ComboBox.SelectedIndex);
            uint OverrideField = Convert.ToUInt32(mainForm.SpellInfo_Field_ComboBox.SelectedIndex);
            string OverrideValText = mainForm.SpellInfo_Value_TextBox.Text;
            int OverrideValue = Convert.ToInt32(OverrideValText.Length > 0 ? OverrideValText : "0");

            if (this.FieldRequireGetSelectValues(OverrideField))
                OverrideValue = GetMaskOfSelectedValuesInCheckBox(OverrideField);

            SpellInfoOverrideEntry spellDBC_Override = new SpellInfoOverrideEntry(SpellId, EffIdx, OverrideField, OverrideValue);

            if (!spellInfoEntries.ContainsKey(spellDBC_Override.spellId))
                spellInfoEntries.Add(spellDBC_Override.spellId, new ArrayList());

            spellInfoEntries[spellDBC_Override.spellId].Add(spellDBC_Override);
            MessageBox.Show("Information added correctly to Spell: " + SpellId);
        }

        public void EnableLockedItems(bool enabled)
        {
            /// Disable Items
            mainForm.SpellInfo_EffIdx_ComboBox.Enabled  = enabled;
            mainForm.SpellInfo_Field_ComboBox.Enabled = enabled;
            mainForm.SpellInfo_Value_TextBox.Enabled  = enabled;
            mainForm.SpellIInfo_AddSpellOverride_Button.Enabled    = enabled;
            mainForm.SpellInfo_Value_TextBox.Enabled     = enabled;
            mainForm.SpellInfo_GenerateQuery_Button.Enabled = enabled;
            mainForm.SpellInfoOverride_Values_CheckListBox.Enabled = enabled;
        }

        public void FillValuesOptionListBox(int field)
        {
            mainForm.SpellInfoOverride_Values_CheckListBox.Items.Clear();

            if (!overrideValuesDictionary.ContainsKey(field))
            {
                mainForm.SpellInfo_Value_TextBox.Enabled = true;
                return;
            }

            mainForm.SpellInfo_Value_TextBox.Enabled = false;
            foreach (var value in overrideValuesDictionary[field])
                mainForm.SpellInfoOverride_Values_CheckListBox.Items.Add(value, false);
        }
    }
}
