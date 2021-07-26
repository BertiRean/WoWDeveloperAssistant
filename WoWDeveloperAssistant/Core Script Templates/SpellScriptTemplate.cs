using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WoWDeveloperAssistant.Misc;

namespace WoWDeveloperAssistant.Core_Script_Templates
{
    public static class SpellScriptTemplate
    {
        public static readonly Dictionary<string, string> hooksDictionary = new Dictionary<string, string>
        {
            { "OnPrepare",                  "void HandlePrepare()"                                                                  },
            { "OnCheckInterrupt",           "bool HandleCheckInterrupt()"                                                           },
            { "BeforeCast",                 "void HandleBeforeCast()"                                                               },
            { "OnCheckCast",                "SpellCastResult HandleOnCheckCast()"                                                   },
            { "OnTakePowers",               "void HandleTakePowers(Powers p_PowerType, int32& p_PowerCost)"                         },
            { "OnObjectAreaTargetSelect",   "void HandleTargets(std::list<WorldObject*>& p_Targets)"                                },
            { "OnObjectTargetSelect",       "void HandleSingleTarget(WorldObject*& p_Target)"                                       },
            { "OnDestinationTargetSelect",  "void HandleOnDestTargetSelect(SpellDestination& target)"                               },
            { "OnCast",                     "void HandleOnCast()"                                                                   },
            { "AfterCast",                  "void HandleAfterCast()"                                                                },
            { "OnEffectLaunch",             "void HandleEffectLaunch(SpellEffIndex /*p_EffIndex*/)"                                 },
            { "OnEffectLaunchTarget",       "void HandleEffectLaunchTarget(SpellEffIndex /*p_EffIndex*/)"                           },
            { "OnEffectHit",                "void HandleEffectHit(SpellEffIndex /*p_EffIndex*/)"                                    },
            { "BeforeHit",                  "void HandleBeforeHit()"                                                                },
            { "OnEffectHitTarget",          "void HandleEffectHitTarget(SpellEffIndex /*p_EffIndex*/)"                              },
            { "OnHit",                      "void HandleOnHit()"                                                                    },
            { "AfterHit",                   "void HandleAfterHit()"                                                                 },
            { "OnCalculateThreat",          "void HandleCalculateThreat(Unit* p_Target, float& p_Amount)"                           },
            { "OnCalculateChannelDuration", "void HandleCalculateChannelDuration(Unit const* p_Caster, int32& p_ChannelDuration)"   },
            { "OnInterrupt",                "void HandleInterrupt(uint32 p_Time)"                                                   },
        };

        public static readonly Dictionary<string, string> hooksMacrosDictionary = new Dictionary<string, string>
        {
            { "OnPrepare",                  "+= SpellOnPrepareFn({0}::HandlePrepare);"                                                      },
            { "OnCheckInterrupt",           "+= SpellCheckInterruptFn({0}::HandleCheckInterrupt);"                                          },
            { "BeforeCast",                 "+= SpellCastFn({0}::HandleBeforeCast);"                                                        },
            { "OnCheckCast",                "+= SpellCheckCastFn({0}::HandleOnCheckCast);"                                                  },
            { "OnTakePowers",               "+= SpellTakePowersFn({0}::HandleTakePowers);"                                                  },
            { "OnObjectAreaTargetSelect",   "+= SpellObjectAreaTargetSelectFn({0}::HandleTargets, SpellEffIndex::, Targets::);"             },
            { "OnObjectTargetSelect",       "+= SpellObjectTargetSelectFn({0}::HandleSingleTarget, SpellEffIndex::, Targets::);"            },
            { "OnDestinationTargetSelect",  "+= SpellDestinationTargetSelectFn({0}::HandleOnDestTargetSelect, SpellEffIndex::, Targets::);" },
            { "OnCast",                     "+= SpellCastFn({0}::HandleOnCast);"                                                            },
            { "AfterCast",                  "+= SpellCastFn({0}::HandleAfterCast);"                                                         },
            { "OnEffectLaunch",             "+= SpellEffectFn({0}::HandleEffectLaunch, SpellEffIndex::, SpellEffects::);"                   },
            { "OnEffectLaunchTarget",       "+= SpellEffectFn({0}::HandleEffectLaunchTarget, SpellEffIndex::, SpellEffects::);"             },
            { "OnEffectHit",                "+= SpellEffectFn({0}::HandleEffectHit, SpellEffIndex::, SpellEffects::);"                      },
            { "BeforeHit",                  "+= SpellHitFn({0}::HandleBeforeHit);"                                                          },
            { "OnEffectHitTarget",          "+= SpellEffectFn({0}::HandleEffectHitTarget, SpellEffIndex::, SpellEffects::);"                },
            { "OnHit",                      "+= SpellHitFn({0}::HandleOnHit);"                                                              },
            { "AfterHit",                   "+= SpellHitFn({0}::HandleAfterHit);"                                                           },
            { "OnCalculateThreat",          "+= SpellCalculateThreatFn({0}::HandleCalculateThreat);"                                        },
            { "OnCalculateChannelDuration", "+= SpellCalculateChannelDurationFn({0}::HandleCalculateChannelDuration);"                      },
            { "OnInterrupt",                "+= SpellInterruptFn({0}::HandleInterrupt);"                                                    },
        };

        public static readonly Dictionary<string, Dictionary<string, string>> hookBodiesDictionary = new Dictionary<string, Dictionary<string, string>>
        {
            { "OnPrepare",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }

            },

            { "OnCheckInterrupt",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return false;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return false;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }

            },

            { "BeforeCast",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "OnCheckCast",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return SPELL_FAILED_SUCCESS;" },
                    { "TargetCheck",    "Unit* l_Target = GetExplTargetUnit();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Target)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return SPELL_FAILED_NO_VALID_TARGETS;" },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return SPELL_FAILED_SUCCESS;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "TargetAuraCheck","if (l_Target->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "OnTakePowers",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "OnObjectAreaTargetSelect",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "TargetListEmptyCheck", "if (p_Targets.empty())" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;" },
                    { "TargetListRemoveIf","p_Targets.remove_if([] (WorldObject* p_Itr) -> bool" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "});" },
                    { "TargetListSizeCheck","if (p_Targets.size() > DESIRED_SIZE)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "OnObjectTargetSelect",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "TargetCheck","if (p_Target == nullptr)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;" },
                    { "TargetAuraCheck","if (p_Target->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "OnDestinationTargetSelect",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "OnCast",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "AfterCast",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "OnEffectLaunch",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "UnitHitCheck",   "Unit* l_Target = GetHitUnit();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Target)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "UnitHitAuraCheck","if (l_Target->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "OnEffectLaunchTarget",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "UnitHitCheck",   "Unit* l_Target = GetHitUnit();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Target)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "UnitHitAuraCheck","if (l_Target->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "OnEffectHit",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "UnitHitCheck",   "Unit* l_Target = GetHitUnit();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Target)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "UnitHitAuraCheck","if (l_Target->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "BeforeHit",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "UnitHitCheck",   "Unit* l_Target = GetHitUnit();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Target)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "UnitHitAuraCheck","if (l_Target->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "OnEffectHitTarget",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "UnitHitCheck",   "Unit* l_Target = GetHitUnit();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Target)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "UnitHitAuraCheck","if (l_Target->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "OnHit",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "UnitHitCheck",   "Unit* l_Target = GetHitUnit();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Target)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "UnitHitAuraCheck","if (l_Target->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "AfterHit",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "UnitHitCheck",   "Unit* l_Target = GetHitUnit();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Target)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"                  },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "UnitHitAuraCheck","if (l_Target->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "OnCalculateThreat",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;" },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "TargetCheck","if (p_Target == nullptr)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;" },
                    { "TargetAuraCheck","if (p_Target->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "OnCalculateChannelDuration",
                new Dictionary<string, string>
                {
                    { "CasterCheck","if (p_Caster == nullptr)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;" },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (p_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            },

            { "OnInterrupt",
                new Dictionary<string, string>
                {
                    { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;" },
                    { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
                    { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                }
            }
        };

        public static void CreateTemplate(uint spellId, ListBox hooksListBox, TreeView hookBodiesTreeView)
        {
            string scriptBody = "";
            string defaultName = "";
            string scriptName = "";

            if (!DBC.DBC.IsLoaded())
                DBC.DBC.Load();
            
            if (DBC.DBC.IsLoaded() && DBC.DBC.SpellName.ContainsKey((int)spellId))
                defaultName = DBC.DBC.SpellName[(int)spellId].Name;

            if (defaultName == "")
                defaultName = "unknow_spell";

            scriptName = "spell_" + defaultName.Replace(" ", "_").ToLower().Replace("'", "") + "_" + spellId;

            scriptBody = "/// " + defaultName + " - " + spellId + "\r\n";
            scriptBody += "class " + scriptName  + " : public SpellScript" + "\r\n";
            scriptBody += "{" + "\r\n";
            scriptBody += GetEnumsBody(hookBodiesTreeView) + "\r\n\r\n";
            scriptBody += Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "PrepareSpellScript(" + scriptName + "_SpellScript" + ");" + "\r\n";
            scriptBody += GetHooksBody(hooksListBox, hookBodiesTreeView) + "\r\n\r\n";
            scriptBody += Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "void Register() override" + "\r\n";
            scriptBody += Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "{" + "\r\n";
            scriptBody += GetHooksMacrosBody(hooksListBox, hookBodiesTreeView, scriptName) + "\r\n";
            scriptBody += Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "}" + "\r\n";
            scriptBody += "};";

            Clipboard.SetText(scriptBody);
            MessageBox.Show("Template has been successfully builded and copied on your clipboard!");
        }

        private static string GetGettersBody(string scriptName)
        {
            string body = "";

            body += Utils.AddSpacesCount(8) + "SpellScript* GetSpellScript() const override" + "\r\n";
            body += Utils.AddSpacesCount(8) + "{" + "\r\n";
            body += Utils.AddSpacesCount(12) + "return new " + scriptName + "_SpellScript();" + "\r\n";
            body += Utils.AddSpacesCount(8) + "}";

            return body;
        }

        private static string GetEnumsBody(TreeView hookBodiesTreeView)
        {
            string body = "";

            body += "\r\n" + Utils.AddSpacesCount(8) + "enum eSpells" + "\r\n" + Utils.AddSpacesCount(8) + "{" + "\r\n" + Utils.AddSpacesCount(12) + "\r\n" + Utils.AddSpacesCount(8) + "};";

            return body;
        }

        private static bool IsHookBodiesContainItem(string itemName, TreeView hookBodiesTreeView)
        {
            return hookBodiesTreeView.Nodes.Cast<TreeNode>().Any(parentNode => parentNode.Nodes.Cast<TreeNode>().Any(childNode => childNode.Checked && childNode.Text == itemName));
        }

        private static string GetHooksBody(ListBox hooksListBox, TreeView hookBodiesTreeView)
        {
            string body = "";

            foreach (var hook in hooksListBox.SelectedItems)
            {
                body += "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + hooksDictionary[hook.ToString()];
                body += "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB);

                foreach (TreeNode parentNode in hookBodiesTreeView.Nodes)
                {
                    if (parentNode.Text != hook.ToString())
                        continue;

                    bool moreThanOne = false;

                    foreach (TreeNode childNode in parentNode.Nodes)
                    {
                        if (childNode.Checked)
                        {
                            if (moreThanOne)
                            {
                                body += "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB);
                            }

                            body += hookBodiesDictionary[hook.ToString()][childNode.Text];

                            if (!moreThanOne)
                            {
                                moreThanOne = true;
                            }
                        }
                    }
                }

                body += "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "}";
            }

            return body;
        }

        private static string GetHooksMacrosBody(ListBox hooksListBox, TreeView hookBodiesTreeView, string scriptName)
        {
            string body = "";
            int counter = 1;

            foreach (var hook in hooksListBox.SelectedItems)
            {
                string hookStr = hook.ToString();

                body += Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + hookStr;
                body += ' ' + String.Format(hooksMacrosDictionary[hookStr], scriptName, hookStr);
                
                if (counter < hooksListBox.SelectedItems.Count)
                    body += "\r\n";

                counter++;
            }

            return body;
        }
    }
}
