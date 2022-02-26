using System;
using System.Collections.Generic;
using System.Collections;
using WoWDeveloperAssistant.Misc;
using System.Windows.Forms;

namespace WoWDeveloperAssistant.SpellInfo_Override_DbCreator
{
    enum OverrideFields : int
    {
        SpellAttribute0 = 4,
        SpellAttribute1 = 5,
        SpellAttribute2 = 6,
        SpellAttribute3 = 7,
        SpellAttribute4 = 8,
        SpellAttribute5 = 9,
        SpellAttribute6 = 10,
        SpellAttribute7 = 11,
        SpellAttribute8 = 12,
        SpellAttribute9 = 13,
        SpellAttribute10 = 14,
        SpellAttribute11 = 15,
        SpellAttribute12 = 16,
        SpellAttribute13 = 17,
        TargetType          = 21,
        ProcFlags           = 34,
        InterruptFlags      = 36,
        AuraInterruptFlags  = 37,
        CustomAttributes    = 38,
    };

    public class SpellInfoOverrideCreator
    {
        private MainForm mainForm;
        
        private static OverrideFields[] fieldsWithBitMask =
        {
            OverrideFields.SpellAttribute0,
            OverrideFields.SpellAttribute1,
            OverrideFields.SpellAttribute2,
            OverrideFields.SpellAttribute3,
            OverrideFields.SpellAttribute4,
            OverrideFields.SpellAttribute5,
            OverrideFields.SpellAttribute6,
            OverrideFields.SpellAttribute7,
            OverrideFields.SpellAttribute8,
            OverrideFields.SpellAttribute9,
            OverrideFields.SpellAttribute10,
            OverrideFields.SpellAttribute11,
            OverrideFields.SpellAttribute12,
            OverrideFields.SpellAttribute13,
            OverrideFields.ProcFlags,
            OverrideFields.InterruptFlags,
            OverrideFields.AuraInterruptFlags,
            OverrideFields.CustomAttributes,
        };

        public SpellInfoOverrideCreator(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.spellInfoEntries = new Dictionary<uint, ArrayList>();
        }

        private Dictionary<uint, ArrayList> spellInfoEntries;

        private static readonly Dictionary<OverrideFields, ArrayList> overrideValuesDictionary = new Dictionary<OverrideFields, ArrayList>
        {
            { OverrideFields.SpellAttribute0, new ArrayList
                {
                    "SPELL_ATTR0_PROC_FAILURE_BURN_CHARGE                     ",
                    "SPELL_ATTR0_USES_RANGED_SLOT                             ",
                    "SPELL_ATTR0_ON_NEXT_SWING_NO_DMG                         ",
                    "SPELL_ATTR0_DO_NOT_LOG_IMMUNE_MISSES                     ",
                    "SPELL_ATTR0_IS_ABILITY                                   ",
                    "SPELL_ATTR0_IS_TRADESPELL                                ",
                    "SPELL_ATTR0_PASSIVE                                      ",
                    "SPELL_ATTR0_DO_NOT_DISPLAY_SPELLBOOK_AURA_ICON_COMBAT_LOG",
                    "SPELL_ATTR0_DO_NOT_LOG                                   ",
                    "SPELL_ATTR0_HELD_ITEM_ONLY                               ",
                    "SPELL_ATTR0_ON_NEXT_SWING                                ",
                    "SPELL_ATTR0_WEARER_CASTS_PROC_TRIGGER                    ",
                    "SPELL_ATTR0_SERVER_ONLY                                  ",
                    "SPELL_ATTR0_ALLOW_ITEM_SPELL_IN_PVP                      ",
                    "SPELL_ATTR0_ONLY_INDOORS                                 ",
                    "SPELL_ATTR0_ONLY_OUTDOORS                                ",
                    "SPELL_ATTR0_NOT_SHAPESHIFTED                             ",
                    "SPELL_ATTR0_ONLY_STEALTHED                               ",
                    "SPELL_ATTR0_DO_NOT_SHEATH                                ",
                    "SPELL_ATTR0_SCALE_WITH_CREATURE_LEVEL                    ",
                    "SPELL_ATTR0_CANCELS_AUTO_ATTACK_COMBAT                   ",
                    "SPELL_ATTR0_NO_ACTIVE_DEFENSE                            ",
                    "SPELL_ATTR0_TRACK_TARGET_IN_CAST_PLAYER_ONLY             ",
                    "SPELL_ATTR0_ALLOW_CAST_WHILE_DEAD                        ",
                    "SPELL_ATTR0_ALLOW_WHILE_MOUNTED                          ",
                    "SPELL_ATTR0_COOLDOWN_ON_EVENT                            ",
                    "SPELL_ATTR0_AURA_IS_DEBUFF                               ",
                    "SPELL_ATTR0_ALLOW_WHILE_SITTING                          ",
                    "SPELL_ATTR0_NOT_IN_COMBAT_ONLY_PEACEFUL                  ",
                    "SPELL_ATTR0_NO_IMMUNITIES                                ",
                    "SPELL_ATTR0_HEARTBEAT_RESIST                             ",
                    "SPELL_ATTR0_NO_AURA_CANCEL                               ",
                }
            },

            { OverrideFields.SpellAttribute1, new ArrayList
                {
                    "SPELL_ATTR1_DISMISS_PET_FIRST                       ",
                    "SPELL_ATTR1_USE_ALL_MANA                            ",
                    "SPELL_ATTR1_IS_CHANNELED                            ",
                    "SPELL_ATTR1_NO_REDIRECTION                          ",
                    "SPELL_ATTR1_NO_SKILL_INCREASE                       ",
                    "SPELL_ATTR1_ALLOW_WITH_STEALTHED                    ",
                    "SPELL_ATTR1_IS_SELF_CHANNELED                       ",
                    "SPELL_ATTR1_NO_REFECTION                            ",
                    "SPELL_ATTR1_ONLY_PEACEFUL_TARGETS                   ",
                    "SPELL_ATTR1_INITIATES_COMBAT_ENABLE_AUTO_ATTACK     ",
                    "SPELL_ATTR1_NO_THREAT                               ",
                    "SPELL_ATTR1_AURA_UNIQUE                             ",
                    "SPELL_ATTR1_FAILURE_BREAKS_STEALTH                  ",
                    "SPELL_ATTR1_TOGGLE_FAR_SIGHT                        ",
                    "SPELL_ATTR1_TRACK_TARGET_IN_CHANNEL                 ",
                    "SPELL_ATTR1_IMMUNITY_PURGES_EFFECT                  ",
                    "SPELL_ATTR1_IMMUNITY_TO_HOSTILE_AND_FRIENDLY_EFFECTS",
                    "SPELL_ATTR1_NO_AUTOCAST_AI                          ",
                    "SPELL_ATTR1_PREVENT_ANIM                            ",
                    "SPELL_ATTR1_EXCLUDE_CASTER                          ",
                    "SPELL_ATTR1_FINISHING_MOVE_DAMAGE                   ",
                    "SPELL_ATTR1_THREAT_ONLY_ON_MISS                     ",
                    "SPELL_ATTR1_FINISHING_MOVE_DURATION                 ",
                    "SPELL_ATTR1_IGNORE_OWNERS_DEATH                     ",
                    "SPELL_ATTR1_SPECIAL_SKILLUP                         ",
                    "SPELL_ATTR1_AURA_STAYS_AFTER_COMBAT                 ",
                    "SPELL_ATTR1_REQUIRE_ALL_TARGETS                     ",
                    "SPELL_ATTR1_DISCOUNT_POWER_ON_MISS                  ",
                    "SPELL_ATTR1_NO_AURA_ICON                            ",
                    "SPELL_ATTR1_NAME_IN_CHANNEL_BAR                     ",
                    "SPELL_ATTR1_COMBO_ON_BLOCK_MAINLINE_DISPEL_ALL_STACK",
                    "SPELL_ATTR1_CAST_WHEN_LEARNED                       ",

                }
            },

            { OverrideFields.SpellAttribute2, new ArrayList
                {
                    "SPELL_ATTR2_ALLOW_DEAD_TARGET                            ",
                    "SPELL_ATTR2_NO_SHAPESHIFT_UI                             ",
                    "SPELL_ATTR2_IGNORE_LINE_OF_SIGHT                         ",
                    "SPELL_ATTR2_ALLOW_LOW_LEVEL_BUFF                         ",
                    "SPELL_ATTR2_USE_SHAPESHIFT_BAR                           ",
                    "SPELL_ATTR2_AUTO_REPEAT                                  ",
                    "SPELL_ATTR2_CANNOT_CAST_ON_TAPPED                        ",
                    "SPELL_ATTR2_DO_NOT_REPORT_SPELL_FAILURE                  ",
                    "SPELL_ATTR2_INCLUDE_IN_ADVANCED_COMBAT_LOG               ",
                    "SPELL_ATTR2_ALWAYS_CAST_AS_UNIT                          ",
                    "SPELL_ATTR2_SPECIAL_TAMING_FLAG                          ",
                    "SPELL_ATTR2_NO_TARGET_PER_SECOND_COST                    ",
                    "SPELL_ATTR2_CHAIN_FROM_CASTER                            ",
                    "SPELL_ATTR2_ENCHANT_OWN_ITEM_ONLY                        ",
                    "SPELL_ATTR2_ALLOW_WHILE_INVISIBLE                        ",
                    "SPELL_ATTR2_DO_NOT_CONSUME_IF_GAINED_DURING_CAST         ",
                    "SPELL_ATTR2_NO_ACTIVE_PETS                               ",
                    "SPELL_ATTR2_DO_NOT_RESET_COMBAT_TIMERS                   ",
                    "SPELL_ATTR2_NO_JUMP_WHILE_CAST_PENDING                   ",
                    "SPELL_ATTR2_ALLOW_WHILE_NOT_SHAPESHIFTED_CASTER_FORM     ",
                    "SPELL_ATTR2_INITIATE_COMBAT_POST_CAST_ENABLES_AUTO_ATTACK",
                    "SPELL_ATTR2_FAIL_ON_ALL_TAGETS_IMMUNE                    ",
                    "SPELL_ATTR2_NO_INITIAL_THREAT                            ",
                    "SPELL_ATTR2_PROC_COOLDOWN_ON_FAILURE                     ",
                    "SPELL_ATTR2_ITEM_CAST_WITH_OWNER_SKILL                   ",
                    "SPELL_ATTR2_ITEM_DONT_BLOCK_MANA_REGEN                   ",
                    "SPELL_ATTR2_NO_SCHOOL_IMMUNITIES                         ",
                    "SPELL_ATTR2_IGNORE_WEAPON_SKILL                          ",
                    "SPELL_ATTR2_IGNORE_ACTION_AURA_INTERRUPT_FLAGS           ",
                    "SPELL_ATTR2_CANT_CRIT                                    ",
                    "SPELL_ATTR2_ACTIVE_THREAT                                ",
                    "SPELL_ATTR2_RETAIN_ITEM_CAST                             ",

                }
            },

            { OverrideFields.SpellAttribute3, new ArrayList
                {
                    "SPELL_ATTR3_PVP_ENABLING                                                  ",
                    "SPELL_ATTR3_NO_PROC_EQUIP_REQUIREMENT                                     ",
                    "SPELL_ATTR3_NO_CASTING_BAR_TEXT                                           ",
                    "SPELL_ATTR3_COMPLETELY_BLOCKED                                            ",
                    "SPELL_ATTR3_NO_RES_TIMER                                                  ",
                    "SPELL_ATTR3_NO_DURABILITY_LOSS                                            ",
                    "SPELL_ATTR3_NO_AVOIDANCE                                                  ",
                    "SPELL_ATTR3_DOT_STACKING_RULE                                             ",
                    "SPELL_ATTR3_ONLY_ON_PLAYER                                                ",
                    "SPELL_ATTR3_NOT_A_PROC                                                    ",
                    "SPELL_ATTR3_REQUIRE_MAIN_HAND_WEAPON                                      ",
                    "SPELL_ATTR3_ONLY_IN_BATTLEGROUNDS                                         ",
                    "SPELL_ATTR3_ONLY_ON_GHOSTS                                                ",
                    "SPELL_ATTR3_HIDE_CHANNEL_BAR                                              ",
                    "SPELL_ATTR3_HIDE_IN_RAID_FILTER                                           ",
                    "SPELL_ATTR3_NORMAL_RANGED_ATTACK                                          ",
                    "SPELL_ATTR3_SUPPRESS_CASTER_PROCS                                         ",
                    "SPELL_ATTR3_SUPPRESS_TARGET_PROCS                                         ",
                    "SPELL_ATTR3_ALWAYS_HIT                                                    ",
                    "SPELL_ATTR3_INSTANT_TARGET_PROCS                                          ",
                    "SPELL_ATTR3_ALLOW_AURA_WHILE_DEAD                                         ",
                    "SPELL_ATTR3_ONLY_PROC_OUTDOORS                                            ",
                    "SPELL_ATTR3_CASTING_CANCEL_AUTOREPEAT_MAINLINE_DO_NOT_TRIGGER_TARGET_STAND",
                    "SPELL_ATTR3_NO_DAMAGE_HISTORY                                             ",
                    "SPELL_ATTR3_REQUIRE_OFF_HAND_WEAPON                                       ",
                    "SPELL_ATTR3_TREAT_AS_PERIODIC                                             ",
                    "SPELL_ATTR3_CAN_PROC_FROM_PROCS                                           ",
                    "SPELL_ATTR3_ONLY_PROC_ON_CASTER                                           ",
                    "SPELL_ATTR3_IGNORE_CASTER_AND_TARGET_RESTRICTIONS                         ",
                    "SPELL_ATTR3_IGNORE_CASTER_MODIFIERS                                       ",
                    "SPELL_ATTR3_DO_NOT_DISPLAY_RANGE                                          ",
                    "SPELL_ATTR3_NOT_ON_AOE_IMMUNE                                             ",

                }
            },

            { OverrideFields.SpellAttribute4, new ArrayList
                {
                    "SPELL_ATTR4_NO_CAST_LOG                        ",
                    "SPELL_ATTR4_CLASS_TRIGGER_ONLY_ON_TARGET       ",
                    "SPELL_ATTR4_AURA_EXPIRES_OFFLINE               ",
                    "SPELL_ATTR4_NO_HELPFUL_THREAT                  ",
                    "SPELL_ATTR4_NO_HARMFUL_THREAT                  ",
                    "SPELL_ATTR4_ALLOW_CLIENT_TARGETING             ",
                    "SPELL_ATTR4_CANNOT_BE_STOLEN                   ",
                    "SPELL_ATTR4_ALLOW_CAST_WHILE_CASTING           ",
                    "SPELL_ATTR4_IGNORE_DAMAGE_TAKEN_MODIFIERS      ",
                    "SPELL_ATTR4_COMBAT_FEEDBACK_WHEN_USABLE        ",
                    "SPELL_ATTR4_WEAPON_SPEED_COST_SCALING          ",
                    "SPELL_ATTR4_NO_PARTIAL_IMMUNITY                ",
                    "SPELL_ATTR4_AURA_IS_BUFF                       ",
                    "SPELL_ATTR4_DO_NOT_LOG_CASTER                  ",
                    "SPELL_ATTR4_REACTIVE_DAMAGE_PROC               ",
                    "SPELL_ATTR4_NOT_IN_SPELLBOOK                   ",
                    "SPELL_ATTR4_NOT_IN_ARENA_OR_RATED_BATTLEGROUND ",
                    "SPELL_ATTR4_IGNORE_DEFAULT_ARENA_RESTRICTIONS  ",
                    "SPELL_ATTR4_BOUNCY_CHAIN_MISSILES              ",
                    "SPELL_ATTR4_ALLOW_PROC_WHILE_SITTING           ",
                    "SPELL_ATTR4_AURA_NEVER_BOUNCES                 ",
                    "SPELL_ATTR4_ALLOW_ENTERING_ARENA               ",
                    "SPELL_ATTR4_PROC_SUPPRESS_SWING_ANIM           ",
                    "SPELL_ATTR4_SUPPRESS_WEAPON_PROCS              ",
                    "SPELL_ATTR4_AUTO_RANGED_COMBAT                 ",
                    "SPELL_ATTR4_OWNER_POWER_SCALING                ",
                    "SPELL_ATTR4_ONLY_FLYING_AREAS                  ",
                    "SPELL_ATTR4_FORCE_DISPLAY_CASTBAR              ",
                    "SPELL_ATTR4_IGNORE_COMBAT_TIMER                ",
                    "SPELL_ATTR4_AURA_BOUNCE_FAILS_SPELL            ",
                    "SPELL_ATTR4_OBSOLETE                           ",
                    "SPELL_ATTR4_USE_FACING_FROM_SPELL              ",

                }
            },

            { OverrideFields.SpellAttribute5, new ArrayList
                {
                    "SPELL_ATTR5_ALLOW_ACTIONS_DURING_CHANNEL                  ",
                    "SPELL_ATTR5_NO_REAGENT_COST_WITH_AURA                     ",
                    "SPELL_ATTR5_REMOVE_ENTERING_ARENA                         ",
                    "SPELL_ATTR5_ALLOW_WHILE_STUNNED                           ",
                    "SPELL_ATTR5_TRIGGERS_CHANNELING                           ",
                    "SPELL_ATTR5_LIMIT_N                                       ",
                    "SPELL_ATTR5_IGNORE_AREA_EFFECT_PVP_CHECK                  ",
                    "SPELL_ATTR5_NOT_ON_PLAYER                                 ",
                    "SPELL_ATTR5_NOT_ON_PLAYER_CONTROLLED_NPC                  ",
                    "SPELL_ATTR5_EXTRA_INITIAL_PERIOD                          ",
                    "SPELL_ATTR5_DO_NOT_DISPLAY_DURATION                       ",
                    "SPELL_ATTR5_IMPLIED_TARGETING                             ",
                    "SPELL_ATTR5_MELEE_CHAIN_TARGETING                         ",
                    "SPELL_ATTR5_SPELL_HASTE_AFFECTS_PERIODIC                  ",
                    "SPELL_ATTR5_NOT_AVAILABLE_WHILE_CHARMED                   ",
                    "SPELL_ATTR5_TREAT_AS_AREA_EFFECT                          ",
                    "SPELL_ATTR5_AURA_AFFECTS_NOT_JUST_REQ_EQUIPPED_ITEM       ",
                    "SPELL_ATTR5_ALLOW_WHILE_FLEEING                           ",
                    "SPELL_ATTR5_ALLOW_WHILE_CONFUSED                          ",
                    "SPELL_ATTR5_AI_DOESNT_FACE_TARGET                         ",
                    "SPELL_ATTR5_DO_NOT_ATTEMPT_A_PET_RESUMMON_WHEN_DISMOUNTING",
                    "SPELL_ATTR5_IGNORE_TARGET_REQUIREMENTS                    ",
                    "SPELL_ATTR5_NOT_ON_TRIVIAL                                ",
                    "SPELL_ATTR5_NO_PARTIAL_RESISTS                            ",
                    "SPELL_ATTR5_IGNORE_CASTER_REQUIREMENTS                    ",
                    "SPELL_ATTR5_ALWAYS_LINE_OF_SIGHT                          ",
                    "SPELL_ATTR5_ALWAYS_AOE_LINE_OF_SIGHT                      ",
                    "SPELL_ATTR5_NO_CASTER_AURA_ICON                           ",
                    "SPELL_ATTR5_NO_TARGET_AURA_ICON                           ",
                    "SPELL_ATTR5_AURA_UNIQUE_PER_CASTER                        ",
                    "SPELL_ATTR5_ALWAYS_SHOW_GROUND_TEXTURE                    ",
                    "SPELL_ATTR5_ADD_MELEE_HIT_RATING                          ",
                }
            },

            { OverrideFields.SpellAttribute6, new ArrayList
                {
                    "SPELL_ATTR6_NO_COOLDOWN_ON_TOOLTIP                         ",
                    "SPELL_ATTR6_DO_NOT_RESET_COOLDOWN_IN_ARENA                 ",
                    "SPELL_ATTR6_NOT_AN_ATTACK                                  ",
                    "SPELL_ATTR6_CAN_ASSIST_IMMUNE_PC                           ",
                    "SPELL_ATTR6_IGNORE_FOR_MOD_TIME_RATE                       ",
                    "SPELL_ATTR6_DO_NOT_CONSUME_RESOURCES                       ",
                    "SPELL_ATTR6_FLOATING_COMBAT_TEXT_ON_CAST                   ",
                    "SPELL_ATTR6_AURA_IS_WEAPON_PROC                            ",
                    "SPELL_ATTR6_DO_NOT_CHAIN_TO_CROWDCONTROLLED_TARGETS        ",
                    "SPELL_ATTR6_ALLOW_ON_CHARMED_TARGETS                       ",
                    "SPELL_ATTR6_NO_AURA_LOG                                    ",
                    "SPELL_ATTR6_NOT_IN_RAID_INSTANCES                          ",
                    "SPELL_ATTR6_ALLOW_WHILE_RIDING_VEHICLE                     ",
                    "SPELL_ATTR6_IGNORE_PHASE_SHIFT                             ",
                    "SPELL_ATTR6_AI_PRIMARY_RANGED_ATTACK                       ",
                    "SPELL_ATTR6_NO_PUSHBACK                                    ",
                    "SPELL_ATTR6_NO_JUMP_PATHING                                ",
                    "SPELL_ATTR6_ALLOW_EQUIP_WHILE_CASTING                      ",
                    "SPELL_ATTR6_ORIGINATE_FROM_CONTROLLER                      ",
                    "SPELL_ATTR6_DELAY_COMBAT_TIMER_DURING_CAST                 ",
                    "SPELL_ATTR6_AURA_ICON_ONLY_FOR_CASTER_LIMIT_10             ",
                    "SPELL_ATTR6_SHOW_MECHANIC_AS_COMBAT_TEXT                   ",
                    "SPELL_ATTR6_ABSORB_CANNOT_BE_IGNORE                        ",
                    "SPELL_ATTR6_TAPS_IMMEDIATELY                               ",
                    "SPELL_ATTR6_CAN_TARGET_UNTARGETABLE                        ",
                    "SPELL_ATTR6_DOESNT_RESET_SWING_TIMER_IF_INSTANT            ",
                    "SPELL_ATTR6_VEHICLE_IMMUNITY_CATEGORY                      ",
                    "SPELL_ATTR6_IGNORE_HEALING_MODIFIERS                       ",
                    "SPELL_ATTR6_DO_NOT_AUTO_SELECT_TARGET_WITH_INITIATES_COMBAT",
                    "SPELL_ATTR6_IGNORE_CASTER_DAMAGE_MODIFIERS                 ",
                    "SPELL_ATTR6_DISABLE_TIED_EFFECT_POINTS                     ",
                    "SPELL_ATTR6_NO_CATEGORY_COOLDOWN_MODS                      ",

                }
            },

            { OverrideFields.SpellAttribute7, new ArrayList
                {
                    "SPELL_ATTR7_ALLOW_SPELL_REFLECTION                       ",
                    "SPELL_ATTR7_NO_TARGET_DURATION_MOD                       ",
                    "SPELL_ATTR7_DISABLE_AURA_WHILE_DEAD                      ",
                    "SPELL_ATTR7_DEBUG_SPELL                                  ",
                    "SPELL_ATTR7_TREAT_AS_RAID_BUFF                           ",
                    "SPELL_ATTR7_CAN_BE_MULTI_CAST                            ",
                    "SPELL_ATTR7_DONT_CAUSE_SPELL_PUSHBACK                    ",
                    "SPELL_ATTR7_PREPARE_FOR_VEHICLE_CONTROL_END              ",
                    "SPELL_ATTR7_HORDE_SPECIFIC_SPELL                         ",
                    "SPELL_ATTR7_ALLIANCE_SPECIFIC_SPELL                      ",
                    "SPELL_ATTR7_DISPEL_REMOVES_CHARGES                       ",
                    "SPELL_ATTR7_CAN_CAUSE_INTERRUPT                          ",
                    "SPELL_ATTR7_CAN_CAUSE_SILENCE                            ",
                    "SPELL_ATTR7_NO_UI_NOT_INTERRUPTIBLE                      ",
                    "SPELL_ATTR7_RECAST_ON_RESUMMON                           ",
                    "SPELL_ATTR7_RESET_SWING_TIMER_AT_SPELL_START             ",
                    "SPELL_ATTR7_ONLY_IN_SPELLBOOK_UNTIL_LEARNED              ",
                    "SPELL_ATTR7_DO_NOT_LOG_PVP_KILL                          ",
                    "SPELL_ATTR7_ATTACK_ON_CHARGE_TO_UNIT                     ",
                    "SPELL_ATTR7_REPORT_SPELL_FAILURE_TO_UNIT_TARGET          ",
                    "SPELL_ATTR7_NO_CLIENT_FAIL_WHILE_STUNNED_FLEEING_CONFUSED",
                    "SPELL_ATTR7_RETAIN_COOLDOWN_THROUGH_LOAD                 ",
                    "SPELL_ATTR7_IGNORES_COLD_WEATHER_FLYING_REQUIREMENT      ",
                    "SPELL_ATTR7_NO_ATTACK_DODGE                              ",
                    "SPELL_ATTR7_NO_ATTACK_PARRY                              ",
                    "SPELL_ATTR7_NO_ATTACK_MISS                               ",
                    "SPELL_ATTR7_TREAT_AS_NPC_AOE                             ",
                    "SPELL_ATTR7_BYPASS_NO_RESURRECT_AURA                     ",
                    "SPELL_ATTR7_DO_NOT_COUNT_FOR_PVP_SCOREBOARD              ",
                    "SPELL_ATTR7_REFLECTION_ONLY_DEFENDS                      ",
                    "SPELL_ATTR7_CAN_PROC_FROM_SUPPRESSED_TARGET_PROCS        ",
                    "SPELL_ATTR7_ALWAYS_CAST_LOG                              ",

                }
            },

            { OverrideFields.SpellAttribute8, new ArrayList
                {
                    "SPELL_ATTR8_NO_ATTACK_BLOCK                                         ",
                    "SPELL_ATTR8_IGNORE_DYNAMIC_OBJECT_CASTER                            ",
                    "SPELL_ATTR8_REMOVE_OUTSIDE_DUNGEONS_AND_RAIDS                       ",
                    "SPELL_ATTR8_ONLY_TARGET_IF_SAME_CREATOR                             ",
                    "SPELL_ATTR8_CAN_HIT_AOE_UNTARGETABLE                                ",
                    "SPELL_ATTR8_ALLOW_WHILE_CHARMED                                     ",
                    "SPELL_ATTR8_AURA_REQUIRED_BY_CLIENT                                 ",
                    "SPELL_ATTR8_IGNORE_SANCTUARY                                        ",
                    "SPELL_ATTR8_USE_TARGETS_LEVEL_FOR_SPELL_SCALING                     ",
                    "SPELL_ATTR8_PERIODIC_CAN_CRIT                                       ",
                    "SPELL_ATTR8_MIRROR_CREATURE_NAME                                    ",
                    "SPELL_ATTR8_ONLY_PLAYERS_CAN_CAST_THIS_SPELL                        ",
                    "SPELL_ATTR8_AURA_POINTS_ON_CLIENT                                   ",
                    "SPELL_ATTR8_NOT_IN_SPELLBOOK_UNTIL_LEARNED                          ",
                    "SPELL_ATTR8_TARGET_PROCS_ON_CASTER                                  ",
                    "SPELL_ATTR8_REQUIRES_LOCATION_TO_BE_ON_LIQUID_SURFACE               ",
                    "SPELL_ATTR8_ONLY_TARGET_OWN_SUMMONS                                 ",
                    "SPELL_ATTR8_HASTE_AFFECTS_DURATION                                  ",
                    "SPELL_ATTR8_IGNORE_SPELLCAST_OVERRIDE_COST                          ",
                    "SPELL_ATTR8_ALLOW_TARGETS_HIDDEN_BY_SPAWN_TRACKING                  ",
                    "SPELL_ATTR8_REQUIRES_EQUIPPED_INV_TYPES                             ",
                    "SPELL_ATTR8_NO_SUMMON_DEST_FROM_CLIENT_TARGETING_PATHING_REQUIREMENT",
                    "SPELL_ATTR8_MELEE_HASTE_AFFECTS_PERIODIC                            ",
                    "SPELL_ATTR8_ENFORCE_IN_COMBAT_RESSURECTION_LIMIT                    ",
                    "SPELL_ATTR8_HEAL_PREDICTION                                         ",
                    "SPELL_ATTR8_NO_LEVEL_UP_TOAST                                       ",
                    "SPELL_ATTR8_SKIP_IS_KNOWN_CHECK                                     ",
                    "SPELL_ATTR8_AI_FACE_TARGET                                          ",
                    "SPELL_ATTR8_NOT_IN_BATTLEGROUND                                     ",
                    "SPELL_ATTR8_MASTERY_AFFECTS_POINTS                                  ",
                    "SPELL_ATTR8_DISPLAY_LARGE_AURA_ICON_ON_UNIT_FRAMES_BOSS_AURA        ",
                    "SPELL_ATTR8_CAN_ATTACK_IMMUNEPC                                     ",

                }
            },

            { OverrideFields.SpellAttribute9, new ArrayList
                {
                    "SPELL_ATTR9_FORCE_DEST_LOCATION                                ",
                    "SPELL_ATTR9_MOD_INVIS_INCLUDES_PARTY                           ",
                    "SPELL_ATTR9_ONLY_WHEN_ILLEGALLY_MOUNTED                        ",
                    "SPELL_ATTR9_DO_NOT_LOG_AURA_REFRESH                            ",
                    "SPELL_ATTR9_MISSILE_SPEED_IS_DELAY_IN_SEC                      ",
                    "SPELL_ATTR9_IGNORE_TOTEM_REQUIREMENTS_FOR_CASTING              ",
                    "SPELL_ATTR9_ITEM_CAST_GRANTS_SKILL_GAIN                        ",
                    "SPELL_ATTR9_DO_NOT_ADD_TO_UNLEARN_LIST                         ",
                    "SPELL_ATTR9_COOLDOWN_IGNORES_RANGED_WEAPON                     ",
                    "SPELL_ATTR9_NOT_IN_ARENA                                       ",
                    "SPELL_ATTR9_TARGET_MUST_BE_GROUNDED                            ",
                    "SPELL_ATTR9_ALLOW_WHILE_BANISHED_AURA_STATE                    ",
                    "SPELL_ATTR9_FACE_UNIT_TARGET_UPON_COMPLETION_OF_JUMP_CHARGE    ",
                    "SPELL_ATTR9_HASTE_AFFECTS_MELEE_ABILITY_CASTTIME               ",
                    "SPELL_ATTR9_IGNORE_DEFAULT_RATED_BATTLEGROUND_RESTRICTIONS     ",
                    "SPELL_ATTR9_DO_NOT_DISPLAY_POWER_COST                          ",
                    "SPELL_ATTR9_NEXT_MODAL_SPELL_REQUIRES_SAME_UNIT_TARGET         ",
                    "SPELL_ATTR9_AUTOCAST_OFF_BY_DEFAULT                            ",
                    "SPELL_ATTR9_IGNORE_SCHOOL_LOCKOUT                              ",
                    "SPELL_ATTR9_ALLOW_DARK_SIMULACRUM                              ",
                    "SPELL_ATTR9_ALLOW_CAST_WHILE_CHANNELING                        ",
                    "SPELL_ATTR9_SUPPRESS_VISUAL_KIT_ERRORS                         ",
                    "SPELL_ATTR9_SPELLCAST_OVERRIDE_IN_SPELLBOOK                    ",
                    "SPELL_ATTR9_JUMPCHARGE_NO_FACING_CONTROL                       ",
                    "SPELL_ATTR9_IGNORE_CASTER_HEALING_MODIFIERS                    ",
                    "SPELL_ATTR9_PROGRAMMER_ONLY_DONT_CONSUME_CHARGE_IF_ITEM_DELETED",
                    "SPELL_ATTR9_ITEM_PASSIVE_ON_CLIENT                             ",
                    "SPELL_ATTR9_FORCE_CORPSE_TARGET                                ",
                    "SPELL_ATTR9_CANNOT_KILL_TARGET                                 ",
                    "SPELL_ATTR9_LOG_PASSIVE                                        ",
                    "SPELL_ATTR9_NO_MOVEMENT_RADIUS_BONUS                           ",
                    "SPELL_ATTR9_CHANNEL_PERSISTS_ON_PET_FOLLOW                     ",

                }
            },

            { OverrideFields.SpellAttribute10, new ArrayList
                {
                    "SPELL_ATTR10_BYPASS_VISIBILITY_CHECK                        ",
                    "SPELL_ATTR10_IGNORE_POSITIVE_DAMAGE_TAKEN_MODIFIERS         ",
                    "SPELL_ATTR10_USES_RANGED_SLOT_COSMETIC_ONLY                 ",
                    "SPELL_ATTR10_DO_NOT_LOG_FULL_OVERHEAL                       ",
                    "SPELL_ATTR10_NPC_KNOCKBACK_IGNORE_DOORS                     ",
                    "SPELL_ATTR10_FORCE_NONBINARY_RESISTANCE                     ",
                    "SPELL_ATTR10_NO_SUMMON_LOG                                  ",
                    "SPELL_ATTR10_IGNORE_INSTANCE_LOCK_AND_FARM_LIMIT_ON_TELEPORT",
                    "SPELL_ATTR10_AREA_EFFECTS_USE_TARGET_RADIUS                 ",
                    "SPELL_ATTR10_CHARGE_JUMP_CHARGE_USE_ABSOLUTE_SPEED          ",
                    "SPELL_ATTR10_PROC_COOLDOWN_ON_A_PER_TARGET_BASIS            ",
                    "SPELL_ATTR10_LOCK_CHEST_AT_PRECAST                          ",
                    "SPELL_ATTR10_USE_SPELL_BASE_LEVEL_FOR_SCALING               ",
                    "SPELL_ATTR10_RESET_COOLDOWN_UPON_ENDING_AN_ENCOUNTER        ",
                    "SPELL_ATTR10_ROLLING_PERIODIC                               ",
                    "SPELL_ATTR10_SPELLBOOK_HIDDEN_UNTIL_OVERRIDDEN              ",
                    "SPELL_ATTR10_DEFEND_AGAINST_FRIENDLY_CAST                   ",
                    "SPELL_ATTR10_ALLOW_DEFENSE_WHILE_CASTING                    ",
                    "SPELL_ATTR10_ALLOW_DEFENSE_WHILE_CHANNELING                 ",
                    "SPELL_ATTR10_ALLOW_FATAL_DUEL_DAMAGE                        ",
                    "SPELL_ATTR10_MULTICLICK_GROUND_TARGETING                    ",
                    "SPELL_ATTR10_AOE_CAN_HIT_SUMMONED_INVIS                     ",
                    "SPELL_ATTR10_ALLOW_WHILE_STUNNED_BY_HORROR_MECHANIC         ",
                    "SPELL_ATTR10_VISIBLE_ONLY_TO_CASTER_CONVERSATIONS_ONLY      ",
                    "SPELL_ATTR10_UPDATE_PASSIVES_ON_APPLYREMOVE                 ",
                    "SPELL_ATTR10_NORMAL_MELEE_ATTACK                            ",
                    "SPELL_ATTR10_IGNORE_FEIGN_DEATH                             ",
                    "SPELL_ATTR10_CASTER_DEATH_CANCELS_PERSISTENT_AREA_AURAS     ",
                    "SPELL_ATTR10_DO_NOT_LOG_ABSORB                              ",
                    "SPELL_ATTR10_THIS_MOUNT_IS_NOT_AT_THE_ACCOUNT_LEVEL         ",
                    "SPELL_ATTR10_PREVENT_CLIENT_CAST_CANCEL                     ",
                    "SPELL_ATTR10_ENFORCE_FACING_ON_PRIMARY_TARGET_ONLY          ",

                }
            },

            { OverrideFields.SpellAttribute11, new ArrayList
                {
                    "SPELL_ATTR11_LOCK_CASTER_MOVEMENT_AND_FACING_WHILE_CASTING    ",
                    "SPELL_ATTR11_DONT_CANCEL_WHEN_ALL_EFFECTS_ARE_DISABLED        ",
                    "SPELL_ATTR11_SCALES_WITH_CASTING_ITEMS_LEVEL                  ",
                    "SPELL_ATTR11_DO_NOT_LOG_ON_LEARN                              ",
                    "SPELL_ATTR11_HIDE_SHAPESHIFT_REQUIREMENTS                     ",
                    "SPELL_ATTR11_ABSORB_FALLING_DAMAGE                            ",
                    "SPELL_ATTR11_UNBREAKABLE_CHANNEL                              ",
                    "SPELL_ATTR11_IGNORE_CASTERS_SPELL_LEVEL                       ",
                    "SPELL_ATTR11_TRANSFER_MOUNT_SPELL                             ",
                    "SPELL_ATTR11_IGNORE_SPELLCAST_OVERRIDE_SHAPESHIFT_REQUIREMENTS",
                    "SPELL_ATTR11_NEWEST_EXCLUSIVE_COMPLETE                        ",
                    "SPELL_ATTR11_NOT_IN_INSTANCES                                 ",
                    "SPELL_ATTR11_OBSOLETE                                         ",
                    "SPELL_ATTR11_IGNORE_PVP_POWER                                 ",
                    "SPELL_ATTR11_CAN_ASSIST_UNINTERACTIBLE                        ",
                    "SPELL_ATTR11_CAST_WHEN_INITIAL_LOGGING_IN                     ",
                    "SPELL_ATTR11_NOT_IN_MYTHIC_MODE_CHALLENGE_MODE                ",
                    "SPELL_ATTR11_CHEAPER_NPC_KNOCKBACK                            ",
                    "SPELL_ATTR11_IGNORE_CASTER_ABSORB_MODIFIERS                   ",
                    "SPELL_ATTR11_IGNORE_TARGET_ABSORB_MODIFIERS                   ",
                    "SPELL_ATTR11_HIDE_LOSS_OF_CONTROL_UI                          ",
                    "SPELL_ATTR11_ALLOW_HARMFUL_ON_FRIENDLY                        ",
                    "SPELL_ATTR11_CHEAP_MISSILE_AOI                                ",
                    "SPELL_ATTR11_EXPENSIVE_MISSILE_AOI                            ",
                    "SPELL_ATTR11_NO_CLIENT_FAIL_ON_NO_PET                         ",
                    "SPELL_ATTR11_AI_ATTEMPT_CAST_ON_IMMUNE_PLAYER                 ",
                    "SPELL_ATTR11_ALLOW_WHILE_STUNNED_BY_STUN_MECHANIC             ",
                    "SPELL_ATTR11_DONT_CLOSE_LOOT_WINDOW                           ",
                    "SPELL_ATTR11_HIDE_DAMAGE_ABSORB_UI                            ",
                    "SPELL_ATTR11_DO_NOT_TREAT_AS_AREA_EFFECT                      ",
                    "SPELL_ATTR11_CHECK_REQUIRED_TARGET_AURA_BY_CASTER             ",
                    "SPELL_ATTR11_APPLY_ZONE_AURA_SPELL_TO_PETS                    ",

                }
            },

            { OverrideFields.SpellAttribute12, new ArrayList
                {
                    "SPELL_ATTR12_ENABLE_PROCS_FROM_SUPPRESSED_CASTER_PROCS                    ",
                    "SPELL_ATTR12_CAN_PROC_FROM_SUPPRESSED_CASTER_PROCS                        ",
                    "SPELL_ATTR12_SHOW_COOLDOWN_AS_CHARGE_UP                                   ",
                    "SPELL_ATTR12_NO_PVP_BATTLE_FATIGUE                                        ",
                    "SPELL_ATTR12_TREAT_SELF_CAST_AS_REFLECT                                   ",
                    "SPELL_ATTR12_DO_NOT_CANCEL_AREA_AURA_ON_SPEC_SWITCH                       ",
                    "SPELL_ATTR12_COOLDOWN_ON_AURA_CANCEL_UNTIL_COMBAT_ENDS                    ",
                    "SPELL_ATTR12_DO_NOT_REAPPLY_AREA_AURA_IF_IT_PERSISTS_THROUGH_UPDATE       ",
                    "SPELL_ATTR12_DISPLAY_TOAST_MESSAGE                                        ",
                    "SPELL_ATTR12_ACTIVE_PASSIVE                                               ",
                    "SPELL_ATTR12_IGNORE_DAMAGE_CANCELS_AURA_INTERRUPT                         ",
                    "SPELL_ATTR12_FACE_DESTINATION                                             ",
                    "SPELL_ATTR12_IMMUNITY_PURGES_SPELL                                        ",
                    "SPELL_ATTR12_DO_NOT_LOG_SPELL_MISS                                        ",
                    "SPELL_ATTR12_IGNORE_DISTANCE_CHECK_ON_CHARGEJUMP_CHARGE_DONE_TRIGGER_SPELL",
                    "SPELL_ATTR12_DISABLE_KNOWN_SPELLS_WHILE_CHARMED                           ",
                    "SPELL_ATTR12_IGNORE_DAMAGE_ABSORB                                         ",
                    "SPELL_ATTR12_NOT_IN_PROVING_GROUNDS                                       ",
                    "SPELL_ATTR12_OVERRIDE_DEFAULT_SPELLCLICK_RANGE                            ",
                    "SPELL_ATTR12_IS_INGAME_STORE_EFFECT                                       ",
                    "SPELL_ATTR12_ALLOW_DURING_SPELL_OVERRIDE                                  ",
                    "SPELL_ATTR12_USE_FLOAT_VALUES_FOR_SCALING_AMOUNTS                         ",
                    "SPELL_ATTR12_SUPPRESS_TOASTS_ON_ITEM_PUSH                                 ",
                    "SPELL_ATTR12_TRIGGER_COOLDOWN_ON_SPELL_START                              ",
                    "SPELL_ATTR12_NEVER_LEARN                                                  ",
                    "SPELL_ATTR12_NO_DEFLECT                                                   ",
                    "SPELL_ATTR12_DEPRECATED_USE_STARTOFCAST_LOCATION_FOR_SPELL_DEST           ",
                    "SPELL_ATTR12_RECOMPUTE_AURA_ON_MERCENARY_MODE                             ",
                    "SPELL_ATTR12_USE_WEIGHTED_RANDOM_FOR_FLEX_MAX_TARGETS                     ",
                    "SPELL_ATTR12_IGNORE_RESILIENCE                                            ",
                    "SPELL_ATTR12_APPLY_RESILIENCE_TO_SELF_DAMAGE                              ",
                    "SPELL_ATTR12_ONLY_PROC_FROM_CLASS_ABILITIES                               ",

                }
            },

            { OverrideFields.SpellAttribute13, new ArrayList
                {
                    "SPELL_ATTR13_ALLOW_CLASS_ABILITY_PROCS                      ",
                    "SPELL_ATTR13_ALLOW_WHILE_FEARED_BY_FEAR_MECHANIC            ",
                    "SPELL_ATTR13_COOLDOWN_SHARED_WITH_AI_GROUP                  ",
                    "SPELL_ATTR13_INTERRUPTS_CURRENT_CAST                        ",
                    "SPELL_ATTR13_PERIODIC_SCRIPT_RUNS_LATE                      ",
                    "SPELL_ATTR13_RECIPE_HIDDEN_UNTIL_KNOWN                      ",
                    "SPELL_ATTR13_CAN_PROC_FROM_LIFESTEAL                        ",
                    "SPELL_ATTR13_NAMEPLATE_PERSONAL_BUFFSDEBUFFS                ",
                    "SPELL_ATTR13_CANNOT_LIFESTEALLEECH                          ",
                    "SPELL_ATTR13_GLOBAL_AURA                                    ",
                    "SPELL_ATTR13_NAMEPLATE_ENEMY_DEBUFFS                        ",
                    "SPELL_ATTR13_ALWAYS_ALLOW_PVP_FLAGGED_TARGET                ",
                    "SPELL_ATTR13_DO_NOT_CONSUME_AURA_STACK_ON_PROC              ",
                    "SPELL_ATTR13_DO_NOT_PVP_FLAG_CASTER                         ",
                    "SPELL_ATTR13_ALWAYS_REQUIRE_PVP_TARGET_MATCH                ",
                    "SPELL_ATTR13_DO_NOT_FAIL_IF_NO_TARGET                       ",
                    "SPELL_ATTR13_DISPLAYED_OUTSIDE_OF_SPELLBOOK                 ",
                    "SPELL_ATTR13_CHECK_PHASE_ON_STRING_ID_RESULTS               ",
                    "SPELL_ATTR13_DO_NOT_ENFORCE_SHAPESHIFT_REQUIREMENTS         ",
                    "SPELL_ATTR13_AURA_PERSISTS_THROUGH_TAME_PET                 ",
                    "SPELL_ATTR13_PERIODIC_REFRESH_EXTENDS_DURATION              ",
                    "SPELL_ATTR13_USE_SKILL_RANK_AS_SPELL_LEVEL                  ",
                    "SPELL_ATTR13_AURA_ALWAYS_SHOWN                              ",
                    "SPELL_ATTR13_USE_SPELL_LEVEL_FOR_ITEM_SQUISH_COMPENSATION   ",
                    "SPELL_ATTR13_CHAIN_BY_MOST_HIT                              ",
                    "SPELL_ATTR13_DO_NOT_DISPLAY_CAST_TIME                       ",
                    "SPELL_ATTR13_ALWAYS_ALLOW_NEGATIVE_HEALING_PERCENT_MODIFIERS",
                    "SPELL_ATTR13_DO_NOT_ALLOW_DISABLE_MOVEMENT_INTERRUPT        ",
                    "SPELL_ATTR13_ALLOW_AURA_ON_LEVEL_SCALE                      ",
                    "SPELL_ATTR13_REMOVE_AURA_ON_LEVEL_SCALE                     ",
                    "SPELL_ATTR13_RECOMPUTE_AURA_ON_LEVEL_SCALE                  ",
                    "SPELL_ATTR13_UPDATE_FALL_SPEED_AFTER_AURA_REMOVAL           ",

                }
            },

            { OverrideFields.TargetType, new ArrayList
                {
                    ("TARGET_UNIT_CASTER                 ",   1),
                    ("TARGET_UNIT_NEARBY_ENEMY           ",   2),
                    ("TARGET_UNIT_NEARBY_PARTY           ",   3),
                    ("TARGET_UNIT_NEARBY_ALLY            ",   4),
                    ("TARGET_UNIT_PET                    ",   5),
                    ("TARGET_UNIT_TARGET_ENEMY           ",   6),
                    ("TARGET_UNIT_SRC_AREA_ENTRY         ",   7),
                    ("TARGET_UNIT_DEST_AREA_ENTRY        ",   8),
                    ("TARGET_DEST_HOME                   ",   9),
                    ("TARGET_UNIT_SRC_AREA_UNK_11        ",   11),
                    ("TARGET_UNIT_SRC_AREA_ENEMY         ",   15),
                    ("TARGET_UNIT_DEST_AREA_ENEMY        ",   16),
                    ("TARGET_DEST_DB                     ",   17),
                    ("TARGET_DEST_CASTER                 ",   18),
                    ("TARGET_UNIT_CASTER_AREA_PARTY      ",   20),
                    ("TARGET_UNIT_TARGET_ALLY            ",   21),
                    ("TARGET_SRC_CASTER                  ",   22),
                    ("TARGET_GAMEOBJECT_TARGET           ",   23),
                    ("TARGET_UNIT_CONE_ENEMY_24          ",   24),
                    ("TARGET_UNIT_TARGET_ANY             ",   25),
                    ("TARGET_GAMEOBJECT_ITEM_TARGET      ",   26),
                    ("TARGET_UNIT_MASTER                 ",   27),
                    ("TARGET_DEST_DYNOBJ_ENEMY           ",   28),
                    ("TARGET_DEST_DYNOBJ_ALLY            ",   29),
                    ("TARGET_UNIT_SRC_AREA_ALLY          ",   30),
                    ("TARGET_UNIT_DEST_AREA_ALLY         ",   31),
                    ("TARGET_DEST_CASTER_SUMMON          ",   32),
                    ("TARGET_UNIT_SRC_AREA_PARTY         ",   33),
                    ("TARGET_UNIT_DEST_AREA_PARTY        ",   34),
                    ("TARGET_UNIT_TARGET_PARTY           ",   35),
                    ("TARGET_DEST_CASTER_UNK_36          ",   36),
                    ("TARGET_UNIT_LASTTARGET_AREA_PARTY  ",   37),
                    ("TARGET_UNIT_NEARBY_ENTRY           ",   38),
                    ("TARGET_DEST_CASTER_FISHING         ",   39),
                    ("TARGET_GAMEOBJECT_NEARBY_ENTRY     ",   40),
                    ("TARGET_DEST_CASTER_FRONT_RIGHT     ",   41),
                    ("TARGET_DEST_CASTER_BACK_RIGHT      ",   42),
                    ("TARGET_DEST_CASTER_BACK_LEFT       ",   43),
                    ("TARGET_DEST_CASTER_FRONT_LEFT      ",   44),
                    ("TARGET_UNIT_TARGET_CHAINHEAL_ALLY  ",   45),
                    ("TARGET_DEST_NEARBY_ENTRY           ",   46),
                    ("TARGET_DEST_CASTER_FRONT           ",   47),
                    ("TARGET_DEST_CASTER_BACK            ",   48),
                    ("TARGET_DEST_CASTER_RIGHT           ",   49),
                    ("TARGET_DEST_CASTER_LEFT            ",   50),
                    ("TARGET_GAMEOBJECT_SRC_AREA         ",   51),
                    ("TARGET_GAMEOBJECT_DEST_AREA        ",   52),
                    ("TARGET_DEST_TARGET_ENEMY           ",   53),
                    ("TARGET_UNIT_CONE_ENEMY_54          ",   54),
                    ("TARGET_DEST_CASTER_FRONT_LEAP      ",   55),
                    ("TARGET_UNIT_CASTER_AREA_RAID       ",   56),
                    ("TARGET_UNIT_TARGET_RAID            ",   57),
                    ("TARGET_UNIT_NEARBY_RAID            ",   58),
                    ("TARGET_UNIT_CONE_ALLY              ",   59),
                    ("TARGET_UNIT_CONE_ENTRY             ",   60),
                    ("TARGET_UNIT_TARGET_AREA_RAID_CLASS ",   61),
                    ("TARGET_DEST_DEST_UNK_62            ",   62),
                    ("TARGET_DEST_TARGET_ANY             ",   63),
                    ("TARGET_DEST_TARGET_FRONT           ",   64),
                    ("TARGET_DEST_TARGET_BACK            ",   65),
                    ("TARGET_DEST_TARGET_RIGHT           ",   66),
                    ("TARGET_DEST_TARGET_LEFT            ",   67),
                    ("TARGET_DEST_TARGET_FRONT_RIGHT     ",   68),
                    ("TARGET_DEST_TARGET_BACK_RIGHT      ",   69),
                    ("TARGET_DEST_TARGET_BACK_LEFT       ",   70),
                    ("TARGET_DEST_TARGET_FRONT_LEFT      ",   71),
                    ("TARGET_DEST_CASTER_RANDOM          ",   72),
                    ("TARGET_DEST_CASTER_RADIUS          ",   73),
                    ("TARGET_DEST_TARGET_RANDOM          ",   74),
                    ("TARGET_DEST_TARGET_RADIUS          ",   75),
                    ("TARGET_DEST_CHANNEL_TARGET         ",   76),
                    ("TARGET_UNIT_CHANNEL_TARGET         ",   77),
                    ("TARGET_DEST_DEST_FRONT             ",   78),
                    ("TARGET_DEST_DEST_BACK              ",   79),
                    ("TARGET_DEST_DEST_RIGHT             ",   80),
                    ("TARGET_DEST_DEST_LEFT              ",   81),
                    ("TARGET_DEST_DEST_FRONT_RIGHT       ",   82),
                    ("TARGET_DEST_DEST_BACK_RIGHT        ",   83),
                    ("TARGET_DEST_DEST_BACK_LEFT         ",   84),
                    ("TARGET_DEST_DEST_FRONT_LEFT        ",   85),
                    ("TARGET_DEST_DEST_RANDOM            ",   86),
                    ("TARGET_DEST_DEST                   ",   87),
                    ("TARGET_DEST_DYNOBJ_NONE            ",   88),
                    ("TARGET_DEST_TRAJ                   ",   89),
                    ("TARGET_UNIT_TARGET_MINIPET         ",   90),
                    ("TARGET_DEST_DEST_RADIUS            ",   91),
                    ("TARGET_UNIT_SUMMONER               ",   92),
                    ("TARGET_CORPSE_SRC_AREA_ENEMY       ",   93),
                    ("TARGET_UNIT_VEHICLE                ",   94),
                    ("TARGET_UNIT_TARGET_PASSENGER       ",   95),
                    ("TARGET_UNIT_PASSENGER_0            ",   96),
                    ("TARGET_UNIT_PASSENGER_1            ",   97),
                    ("TARGET_UNIT_PASSENGER_2            ",   98),
                    ("TARGET_UNIT_PASSENGER_3            ",   99),
                    ("TARGET_UNIT_PASSENGER_4            ",   100),
                    ("TARGET_UNIT_PASSENGER_5            ",   101),
                    ("TARGET_UNIT_PASSENGER_6            ",   102),
                    ("TARGET_UNIT_PASSENGER_7            ",   103),
                    ("TARGET_UNIT_CONE_ENEMY_104         ",   104),
                    ("TARGET_UNIT_UNK_105                ",   105),
                    ("TARGET_DEST_CHANNEL_CASTER         ",   106),
                    ("TARGET_DEST_EXTRA_TARGETS          ",   107),
                    ("TARGET_GAMEOBJECT_CONE             ",   108),
                    ("TARGET_UNIT_BETWEEN_DEST           ",   109),
                    ("TARGET_UNIT_CONE_ENEMY_110         ",   110),
                    ("TARGET_UNK_111                     ",   111),
                    ("TARGET_UNK_112                     ",   112),
                    ("TARGET_UNK_113                     ",   113),
                    ("TARGET_UNK_114                     ",   114),
                    ("TARGET_UNK_115                     ",   115),
                    ("TARGET_UNK_116                     ",   116),
                    ("TARGET_UNK_117                     ",   117),
                    ("TARGET_UNIT_ALLY_OR_RAID           ",   118),
                    ("TARGET_MASS_RESSURECTION           ",   119),
                    ("TARGET_UNIT_CASTER_AREA_SUMMON     ",   120),
                    ("TARGET_UNIT_RESURRECT              ",   121),
                    ("TARGET_UNIT_TARGET_SELECT2         ",   122),
                    ("TARGET_UNIT_THREAD_PLAYER          ",   123),
                    ("TARGET_UNK_124                     ",   124),
                    ("TARGET_DEST_CASTER_2               ",   125),
                    ("TARGET_UNK_126                     ",   126),
                    ("TARGET_UNK_127                     ",   127),
                    ("TARGET_UNK_128                     ",   128),
                    ("TARGET_UNIT_ENEMY_BETWEEN_DEST     ",   129),
                    ("TARGET_UNIT_ENEMY_BETWEEN_DEST_2   ",   130),
                    ("TARGET_DEST_RANDOM_CASTER_FRONT    ",   131),
                    ("TARGET_DEST_TARGET_FRIEND          ",   132),
                    ("TARGET_UNK_133                     ",   133),
                    ("TARGET_ENNEMIES_IN_CYLINDER        ",   134),
                    ("TARGET_UNK_135                     ",   135),
                    ("TARGET_UNIT_ALLY_CONE_CASTER       ",   136),
                    ("TARGET_DEST_CASTER_DIRECTION       ",   137),
                    ("TARGET_DEST_TARGET_SELECT          ",   138),
                    ("TARGET_UNK_139                     ",   139),
                    ("TARGET_UNK_140                     ",   140),
                    ("TARGET_UNK_141                     ",   141),
                    ("TARGET_UNK_142                     ",   142),
                    ("TARGET_ENNEMIES_AROUND_CASTER      ",   143),
                    ("TARGET_UNK_144                     ",   144),
                    ("TARGET_UNK_145                     ",   145),
                    ("TARGET_UNK_146                     ",   146),
                    ("TARGET_UNK_147                     ",   147),
                    ("TARGET_DEST_TARGET_DEST            ",   148),
                    ("TARGET_UNK_149                     ",   149),
                    ("TARGET_UNIT_OWN_CRITTER            ",   150)
                }
            },

            // ProcFlags
            { OverrideFields.ProcFlags, new ArrayList
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
            { OverrideFields.AuraInterruptFlags, new ArrayList
                {
                    "None",
                    "HostileActionReceived",
                    "Damage",
                    "Action",
                    "Moving",
                    "Turning",
                    "Anim",
                    "Dismount",
                    "UnderWater",
                    "AboveWater",
                    "Sheathing",
                    "Interacting",
                    "Looting",
                    "Attacking",
                    "ItemUse",
                    "DamageChannelDuration",
                    "Shapeshifting",
                    "ActionDelayed",
                    "Mount",
                    "Standing",
                    "LeaveWorld",
                    "StealthOrInvis",
                    "InvulnerabilityBuff",
                    "EnterWorld",
                    "PvPActive",
                    "NonPeriodicDamage",
                    "LandingOrFlight",
                    "Release",
                    "DamageCancelsScript",
                    "EnteringCombat",
                    "Login",
                    "Summon",
                    "LeavingCombat",
                }
            },

            // Interrupt Flags
            { OverrideFields.InterruptFlags, new ArrayList
                {
                    "None",
                    "Movement",
                    "DamagePushbackPlayerOnly",
                    "Stun",
                    "Combat",
                    "DamageCancelsPlayerOnly",
                    "MeleeCombat",
                    "Immunity",
                    "DamageAbsorb",
                    "ZeroDamageCancels",
                    "DamagePushback",
                    "DamageCancels",
                }
            },

            // Custom Attributes
            { OverrideFields.CustomAttributes, new ArrayList
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
            if (!overrideValuesDictionary.ContainsKey((OverrideFields)overrideField))
                return false;

            return true;
        }

        int GetMaskOfSelectedValuesInCheckBox(uint overrideField)
        {
            int retVal = 0;

            OverrideFields fieldIdx = (OverrideFields)overrideField;

            for (int idx = 0; idx < mainForm.SpellInfoOverride_Values_CheckListBox.Items.Count; ++idx)
            {
                if (mainForm.SpellInfoOverride_Values_CheckListBox.GetItemChecked(idx))
                {
                    bool isBitField = false;

                    foreach (var field in fieldsWithBitMask)
                    {
                        if (field == fieldIdx)
                        {
                            isBitField = true;
                            break;
                        }
                    }

                    if (isBitField)
                        retVal |= (1 << idx);
                    else if (fieldIdx == OverrideFields.TargetType) // Target Fields
                    {
                        ValueTuple<string, int> targetInfo = (ValueTuple<string, int>)overrideValuesDictionary[fieldIdx][idx];
                        retVal = targetInfo.Item2;
                    }
                    else
                        retVal = idx;
                }
            }

            if (mainForm.SpellInfo_RemoveCheckBox.Checked)
                return -retVal;

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
            mainForm.SpellInfo_RemoveCheckBox.Enabled = enabled;
        }

        public void UpdateSpellNameLabel(uint spellId)
        {
            string name = GetSpellName(spellId);
            mainForm.SpellNameLabelDescriptionLabel.Text = name;
        }

        public void FillValuesOptionListBox(int field)
        {
            OverrideFields fieldIdx = (OverrideFields)field;
            mainForm.SpellInfoOverride_Values_CheckListBox.Items.Clear();

            if (!overrideValuesDictionary.ContainsKey(fieldIdx))
            {
                mainForm.SpellInfo_Value_TextBox.Enabled = true;
                return;
            }

            mainForm.SpellInfo_Value_TextBox.Enabled = false;
            foreach (var value in overrideValuesDictionary[fieldIdx])
            {
                if (fieldIdx == OverrideFields.TargetType) // Target Field
                {
                    ValueTuple<string, int> targetInfo = (ValueTuple<string, int>)value;
                    mainForm.SpellInfoOverride_Values_CheckListBox.Items.Add(targetInfo.Item1, false);
                }
                else
                    mainForm.SpellInfoOverride_Values_CheckListBox.Items.Add(value, false);
            }
        }
    }
}
