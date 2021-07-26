using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WoWDeveloperAssistant.Misc;

namespace WoWDeveloperAssistant.Core_Script_Templates
{
    public static class BossScriptTemplate
    {
        public static readonly Dictionary<string, string> hooksDictionary = new Dictionary<string, string>
        {
            { "IsSummonedBy",       "void IsSummonedBy(Unit* p_Summoner) override"                                                              },
            { "MoveInLineOfSight",  "void MoveInLineOfSight(Unit* p_Who) override"                                                              },
            { "DoAction",           "void DoAction(int32 const p_Action) override"                                                              },
            { "SetData",            "void SetData(uint64 p_Type, uint32 p_Value) override"                                                  },
            { "SpellHit",           "void SpellHit(Unit* p_Caster, SpellInfo const* p_Spell) override"                                          },
            { "OnSpellCasted",      "void OnSpellCasted(SpellInfo const* p_Spell) override"                                                     },
            { "OnSpellFinished",    "void OnSpellFinished(SpellInfo const* p_Spell) override"                                                   },
            { "JustSummoned",           "void JustSummoned(Creature* p_Summon) override"                                                        },
            { "SummonedCreatureDies",   "void SummonedCreatureDies(Creature* p_Summon, Unit* p_Killer) override"                                },
            { "SummonedCreatureDespawn","void SummonedCreatureDespawn(Creature* p_Summon) override"                                             },
            { "OnRemoveAura",           "void OnRemoveAura(uint32 p_SpellID, AuraRemoveMode p_RemoveMode) override"                             },
            { "FilterTargets",  "void FilterTargets(std::list<WorldObject*>& p_Targets, Spell const* p_Spell, SpellEffIndex p_EffIndex) override"   },
            { "RegeneratePower", "void RegeneratePower(Powers p_Power, int32& p_Value) override"                                                         },
            { "PowerModified",  "void PowerModified(Powers p_Power, int32 p_Value, bool p_Regen) override"                                      },
            { "PassengerBoarded",   "void PassengerBoarded(Unit* p_Passenger, int8 p_SeatID, bool p_Apply) override"                        },
            { "MovementInform",     "void MovementInform(uint32 p_Type, uint64 p_PointId) override"                                         },
            { "Reset",              "void Reset() override"                                                                                     },
            { "EnterEvadeMode",     "void EnterEvadeMode() override"                                                                            },
            { "EnterCombat",        "void EnterCombat(Unit* p_Victim) override"                                                                 },
            { "DamageTaken",        "void DamageTaken(Unit* p_Attacker, uint32& p_Damage, SpellInfo const* p_SpellInfo) override"   },
            { "JustDied",           "void JustDied(Unit* p_Killer) override"                                                                    },
            { "ExecuteEvent",       "void ExecuteEvent(uint32 const p_EventId) override"                                                        },
            { "UpdateAI",           "void UpdateAI(uint32 const p_Diff) override"                                                               },
            { "AreaTriggerCreated", "void AreaTriggerCreated(AreaTrigger* p_AreaTrigger) override"                                              },
            { "AreaTriggerDespawned", "void AreaTriggerDespawned(AreaTrigger* p_AreaTrigger) override"                                          },
            { "IsInFightArea",      "bool _IsInFightArea()"                                                                                     }
        };

        public static Dictionary<string, Dictionary<string, string>> hookBodiesDictionary = new Dictionary<string, Dictionary<string, string>>
        {
            { "IsSummonedBy",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",     "Player* l_Player = p_Summoner->ToPlayer();" + "\r\n" + Utils.AddSpacesCount(16) + "if (!l_Player)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" },
                    { "SetSummonerGuid", "m_SummonerGuid = p_Summoner->GetObjectGuid();" }
                }
            },

            { "MoveInLineOfSight",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",   "Player* l_Player = p_Who->ToPlayer();" + "\r\n" + Utils.AddSpacesCount(16) + "if (!l_Player)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" },
                    { "DistanceCheck", "if (me->GetExactDist2d(p_Who) <= 10.0f)" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "DoAction",
                new Dictionary<string, string>
                {
                    { "DoActionIdSwitch", "switch (p_Action)" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eActions::ActionName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "SetData",
                new Dictionary<string, string>
                {
                    { "SetDataIdSwitch", "switch (p_Value)" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eDatas::DataName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "SpellHit",
                new Dictionary<string, string>
                {
                    { "SpellIdSwitch", "if (!p_Spell || !p_Caster)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" + "\r\n\r\n" + Utils.AddSpacesCount(20) + "switch (p_Spell->Id)" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eSpells::SpellName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "OnSpellCasted",
                new Dictionary<string, string>
                {
                    { "SpellIdSwitch", "if (!p_Spell)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" + "\r\n\r\n" + Utils.AddSpacesCount(16) + "switch (p_Spell->Id)" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eSpells::SpellName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "OnSpellFinished",
                new Dictionary<string, string>
                {
                    { "SpellIdSwitch", "if (!p_Spell)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" + "\r\n\r\n" + Utils.AddSpacesCount(16) + "switch (p_Spell->Id)" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eSpells::SpellName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "AreaTriggerCreated",
                new Dictionary<string, string>
                {
                    { "AreaTriggerSwitch", "if (!p_AreaTrigger)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" + "\r\n\r\n" + Utils.AddSpacesCount(16) + "switch (p_AreaTrigger->GetSpellId())" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eSpells::SpellName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "AreaTriggerDespawned",
                new Dictionary<string, string>
                {
                    { "AreaTriggerSwitch", "if (!p_AreaTrigger)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" + "\r\n\r\n" + Utils.AddSpacesCount(16) + "switch (p_AreaTrigger->GetSpellId())" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eSpells::SpellName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "PassengerBoarded",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",   "Player* l_Player = p_Passenger->ToPlayer();" + "\r\n" + Utils.AddSpacesCount(16) + "if (!l_Player)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" },
                }
            },

            { "MovementInform",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",   "Player* l_Player = ObjectAccessor::GetPlayer(*me, m_SummonerGuid);" + "\r\n" + Utils.AddSpacesCount(16) + "if (!l_Player)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" },
                    { "PointIdSwitch", "switch (p_PointId)" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case ePoints::PointName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "EnterEvadeMode",
                new Dictionary<string, string>
                {
                    { "BossEvadeMode", "BossAI::EnterEvadeMode();" + "\r\n"  + Utils.AddSpacesCount(16) + "Talk(eTalks::Wipe);"},
                }
            },

            { "JustDied",
                new Dictionary<string, string>
                {
                    { "BossJustDied", "BossAI::JustDied(p_Killer);"+ "\r\n"  + Utils.AddSpacesCount(16) + "Talk(eTalks::Dead);"},
                }
            },

            { "JustSummoned",
                new Dictionary<string, string>
                {
                    { "BossJustSummoned", "BossAI::JustSummoned(p_Summon);"},
                    { "SummonEntrySwitch", "if (!p_Summon)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" + "\r\n\r\n" + Utils.AddSpacesCount(16) + "switch (p_Summon->GetEntry())" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eCreatures::CreatureName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "ExecuteEvent",
                new Dictionary<string, string>
                {
                    { "EventSwitch", "switch (p_Summon->GetEntry())" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eEvents::EventName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "SummonedCreatureDies",
                new Dictionary<string, string>
                {
                    { "BossSummonedCreatureDies", "BossAI::SummonedCreatureDies(p_Summon, p_Killer);"},
                    { "SummonEntrySwitch", "if (!p_Summon)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" + "\r\n\r\n" + Utils.AddSpacesCount(16) + "switch (p_Summon->GetEntry())" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eCreatures::CreatureName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "OnRemoveAura",
                new Dictionary<string, string>
                {
                    { "BossOnRemoveAura", "BossAI::OnRemove(p_AuraId, p_RemoveMode);"},
                    { "AuraIDSwitch", "switch (p_AuraId)" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eSpells::SpellName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },


            { "SummonedCreatureDespawn",
                new Dictionary<string, string>
                {
                    { "BossSummonedCreatureDespawn", "BossAI::SummonedCreatureDespawn(p_Summon);"},
                    { "SummonEntrySwitch", "if (!p_Summon)" + "\r\n" + Utils.AddSpacesCount(20) + "return;" + "\r\n\r\n" + Utils.AddSpacesCount(16) + "switch (p_Summon->GetEntry())" + "\r\n" + Utils.AddSpacesCount(16) + "{" + "\r\n" + Utils.AddSpacesCount(20) + "case eCreatures::CreatureName:" + "\r\n" + Utils.AddSpacesCount(20) + "{" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(20) + "}" + "\r\n" + Utils.AddSpacesCount(20) + "default:" + "\r\n" + Utils.AddSpacesCount(24) + "break;" + "\r\n" + Utils.AddSpacesCount(16) + "}" }
                }
            },

            { "Reset",
                new Dictionary<string, string>
                {
                    { "BossReset", "BossAI::Reset()"    },
                }
            },

            { "EnterCombat",
                new Dictionary<string, string>
                {
                    { "BossEnterCombat", "BossAI::EnterCombat(p_Victim);" + "\r\n"  + Utils.AddSpacesCount(16) +  "Talk(eTalks::Aggro);" },
                    { "ScheduleEvent", "events.ScheduleEvent(eEvents::EventName, TIME_EVENT);" },
                }
            },

            { "UpdateAI",
                new Dictionary<string, string>
                {
                    { "UpdateOperations", "UpdateOperations(p_Diff);" },
                    { "CheckFightZone", "if (!_IsInFightZone())" + "\r\n"  + Utils.AddSpacesCount(16) + "{\r\n" + Utils.AddSpacesCount(20) + "EnterEvadeMode();\r\n" + Utils.AddSpacesCount(20) +  "return;\r\n" +  Utils.AddSpacesCount(16) + '}' },
                    { "BossUpdateAI", "BossAI::Update(p_Diff);" },
                }
            },
        };
        public static void CreateTemplate(uint objectEntry, ListBox hooksListBox, TreeView hookBodiesTreeView)
        {
            string scriptBody = "";
            string defaultName = "";
            string scriptName = "";

            string creatureNameQuery = "SELECT `Name1` FROM `creature_template_wdb` WHERE `entry` = " + objectEntry + ";";
            var creatureNameDs = Properties.Settings.Default.UsingDB ? SQLModule.DatabaseSelectQuery(creatureNameQuery) : null;

            if (creatureNameDs != null)
            {
                foreach (DataRow row in creatureNameDs.Tables["table"].Rows)
                {
                    defaultName = row[0].ToString();
                }
            }

            if (defaultName == "")
                return;

            scriptName = "boss_" + defaultName.Replace(" ", "_").ToLower().Replace("'", "") + "_" + objectEntry;
            scriptBody = "/// " + defaultName + " - " + objectEntry + "\r\n";
            scriptBody += Utils.AddSpacesCount(8) + "struct " + scriptName + " : public " + "BossAI" + "\r\n";
            scriptBody += Utils.AddSpacesCount(8) + "{" + "\r\n";
            scriptBody += Utils.AddSpacesCount(12) + "explicit " + scriptName + "(Creature* p_Creature) : " + "BossAI(p_Creature, eData::BOSS_DATA)" + "\r\n" + Utils.AddSpacesCount(12) + "{}";
            scriptBody += GetEnumsBody(hookBodiesTreeView);
            scriptBody += GetHooksBody(hooksListBox, hookBodiesTreeView);
            scriptBody += "\r\n" + Utils.AddSpacesCount(8) + "};" + "\r\n\r\n";

            Clipboard.SetText(scriptBody);
            MessageBox.Show("Template has been successfully builded and copied on your clipboard!");
        }

        private static string GetEnumsBody(TreeView hookBodiesTreeView)
        {
            string body = "";

            body += "\r\n\r\n" + Utils.AddSpacesCount(12) + "enum eSpells" + "\r\n" + Utils.AddSpacesCount(12) + "{" + "\r\n" + Utils.AddSpacesCount(16) + "\r\n" + Utils.AddSpacesCount(12) + "};";

            if (IsHookBodiesContainItem("PointIdSwitch", hookBodiesTreeView))
                body += "\r\n\r\n" + Utils.AddSpacesCount(12) + "enum ePoints" + "\r\n" + Utils.AddSpacesCount(12) + "{" + "\r\n" + Utils.AddSpacesCount(16) + "\r\n" + Utils.AddSpacesCount(12) + "};";

            body += "\r\n\r\n" + Utils.AddSpacesCount(12) + "enum eEvents" + "\r\n" + Utils.AddSpacesCount(12) + "{" + "\r\n" + Utils.AddSpacesCount(16) + "\r\n" + Utils.AddSpacesCount(12) + "};";

            body += "\r\n\r\n" + Utils.AddSpacesCount(12) + "enum eTalks" + "\r\n" + Utils.AddSpacesCount(12) + "{" + "\r\n" + Utils.AddSpacesCount(16) + "\r\n" + Utils.AddSpacesCount(12) + "};";

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
                body += "\r\n\r\n" + Utils.AddSpacesCount(12) + hooksDictionary[hook.ToString()];
                body += "\r\n" + Utils.AddSpacesCount(12) + "{" + "\r\n" + Utils.AddSpacesCount(16);

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
                                body += "\r\n\r\n" + Utils.AddSpacesCount(16);
                            }

                            body += hookBodiesDictionary[hook.ToString()][childNode.Text];

                            if (!moreThanOne)
                            {
                                moreThanOne = true;
                            }
                        }
                    }
                }

                body += "\r\n" + Utils.AddSpacesCount(12) + "}";
            }

            return body;
        }
    }
}
