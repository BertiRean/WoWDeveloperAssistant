using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WoWDeveloperAssistant.Misc;

namespace WoWDeveloperAssistant.Core_Script_Templates
{
    public static class CreatureScriptTemplate
    {
        public static Dictionary<string, string> hooksDictionary = new Dictionary<string, string>
        {
            { "IsSummonedBy",      "void IsSummonedBy(Unit* p_Summoner) override"                                                            },
            { "QuestAccept",       "void sQuestAccept(Player* p_Player, Quest const* p_Quest) override"                                      },
            { "QuestReward",       "void sQuestReward(Player* p_Player, Quest const* p_Quest, uint32 /*p_Option) override"                 },
            { "GossipSelect",      "void sGossipSelect(Player* p_Player, uint32 p_Sender, uint32 p_Action) override"                     },
            { "GossipHello",       "void sGossipHello(Player* p_Player) override"                                                            },
            { "MoveInLineOfSight", "void MoveInLineOfSight(Unit* p_Who) override"                                                            },
            { "DoAction",          "void DoAction(int32 const p_Action) override"                                                            },
            { "SetData",           "void SetData(uint64 p_Type, uint32 p_Value) override"                                                },
            { "OnSpellClick",      "void OnSpellClick(Unit* p_Clicker) override"                                                             },
            { "SpellHit",          "void SpellHit(Unit* p_Caster, SpellInfo const* p_Spell) override"                                        },
            { "OnSpellCasted",     "void OnSpellCasted(SpellInfo const* p_SpellInfo) override"                                               },
            { "PassengerBoarded",  "void PassengerBoarded(Unit* p_Passenger, int8 p_SeatID, bool p_Apply) override"                      },
            { "MovementInform",    "void MovementInform(uint32 p_Type, uint64 p_PointId) override"                                       },
            { "Reset",             "void Reset() override"                                                                                   },
            { "EnterCombat",       "void EnterCombat(Unit* p_Victim) override"                                                           },
            { "DamageTaken",       "void DamageTaken(Unit* p_Attacker, uint32& p_Damage, SpellInfo const* p_SpellInfo) override" },
            { "JustDied",          "void JustDied(Unit* p_Killer) override"                                                              },
            { "UpdateAI",          "void UpdateAI(uint32 const p_Diff) override"                                                             }
        };

        public static Dictionary<string, Dictionary<string, string>> hookBodiesDictionary = new Dictionary<string, Dictionary<string, string>>
        {
            { "IsSummonedBy",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",     "Player* l_Player = p_Summoner->ToPlayer();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Player)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "return;" },
                    { "SetSummonerGuid", "m_SummonerGuid = p_Summoner->GetObjectGuid();" }
                }
            },

            { "QuestAccept",
                new Dictionary<string, string>
                {
                    { "QuestIdSwitch", "switch (p_Quest->GetQuestId())" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "case eQuests::QuestName:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "}" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "default:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "QuestReward",
                new Dictionary<string, string>
                {
                    { "QuestIdSwitch", "switch (p_Quest->GetQuestId())" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "case eQuests::QuestName:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "}" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "default:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "GossipSelect",
                new Dictionary<string, string>
                {
                    { "GloseGossipWindow",    "p_Player->PlayerTalkClass->SendCloseGossip();" },
                    { "GossipOptionIdSwitch", "switch (p_Action)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "case 0:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "}" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "default:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "MoveInLineOfSight",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",   "Player* l_Player = p_Who->ToPlayer();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Player)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "return;" },
                    { "DistanceCheck", "if (me->GetExactDist2d(p_Who) <= 10.0f)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "DoAction",
                new Dictionary<string, string>
                {
                    { "DoActionIdSwitch", "switch (p_Action)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "case eActions::ActionName:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "}" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "default:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "SetData",
                new Dictionary<string, string>
                {
                    { "SetDataIdSwitch", "switch (p_Value)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "case eDatas::DataName:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "}" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "default:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "OnSpellClick",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",   "Player* l_Player = p_Clicker->ToPlayer();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Player)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "return;" },
                }
            },

            { "SpellHit",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",   "Player* l_Player = p_Caster->ToPlayer();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Player)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "return;" },
                    { "SpellIdSwitch", "switch (p_Spell->Id)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "case eSpells::SpellName:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "}" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "default:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "OnSpellCasted",
                new Dictionary<string, string>
                {
                    { "SpellIdSwitch", "switch (p_SpellInfo->Id)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "case eSpells::SpellName:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "}" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "default:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "PassengerBoarded",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",   "Player* l_Player = p_Passenger->ToPlayer();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Player)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "return;" },
                }
            },

            { "MovementInform",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",   "Player* l_Player = ObjectAccessor::GetPlayer(*me, m_SummonerGuid);" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Player)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "return;" },
                    { "PointIdSwitch", "switch (p_PointId)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "case ePoints::PointName:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "}" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "default:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" }
                }
            },

            { "Reset",
                new Dictionary<string, string>
                {
                    { "EventReset",   "m_Events.Reset();" },
                }
            },

            { "EnterCombat",
                new Dictionary<string, string>
                {
                    { "ScheduleEvent", "m_Events.ScheduleEvent(eEvents::EventName, 10000);" },
                }
            },

            { "UpdateAI",
                new Dictionary<string, string>
                {
                    { "PlayerCheck",   "Player* l_Player = ObjectAccessor::GetPlayer(*me, m_SummonerGuid);" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Player || !l_Player->IsInWorld() || !l_Player->HasQuest(eQuests::QuestName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" +  "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "me->DespawnOrUnsummon();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "return;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "CombatChecks",  "if (!UpdateVictim())" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "return;" + "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "m_Events.Update(p_Diff);" + "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (me->HasUnitState(UNIT_STATE_CASTING))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "return;" },
                    { "EventsSwitch",  "switch (m_Events.ExecuteEvent())" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "case eEvents::EventName:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "m_Events.ScheduleEvent(eEvents::Eventname, 10000);" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "}" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FOUR_TABS) + "default:" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.FIVE_TABS) + "break;" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
                    { "DoMeleeAttack", "DoMeleeAttackIfReady();" }
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

            scriptName = "npc_" + defaultName.Replace(" ", "_").ToLower().Replace("'", "") + "_" + objectEntry;

            scriptBody = "/// " + defaultName + " - " + objectEntry + "\r\n";
            scriptBody += "struct " + scriptName + " : public " + (IsVehicleScript(hooksListBox) ? "VehicleAI" : "ScriptedAI") + "\r\n";
            scriptBody += "{" + "\r\n";
            scriptBody += Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "explicit " + scriptName + "(Creature* p_Creature) : " + (IsVehicleScript(hooksListBox) ? "VehicleAI" : "ScriptedAI") + "(p_Creature) { }";
            scriptBody += GetEnumsBody(hookBodiesTreeView);
            scriptBody += GetVariablesBody(hookBodiesTreeView);
            scriptBody += GetHooksBody(hooksListBox, hookBodiesTreeView);
            scriptBody += "\r\n" + "};" + "\r\n\r\n";

            Clipboard.SetText(scriptBody);
            MessageBox.Show("Template has been successfully builded and copied on your clipboard!");
        }

        private static bool IsVehicleScript(ListBox listBox)
        {
            return listBox.SelectedItems.Cast<object>().Any(item => item.ToString() == "PassengerBoarded");
        }

        private static string GetEnumsBody(TreeView hookBodiesTreeView)
        {
            string body = "";

            if (IsHookBodiesContainItem("SpellIdSwitch", hookBodiesTreeView) ||
                IsHookBodiesContainItem("EventsSwitch", hookBodiesTreeView))
            {
                body += "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "enum eSpells" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "};";
            }

            if (IsHookBodiesContainItem("PointIdSwitch", hookBodiesTreeView))
            {
                body += "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "enum ePoints" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "};";
            }

            if (IsHookBodiesContainItem("EventsSwitch", hookBodiesTreeView))
            {
                body += "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "enum eEvents" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "};";
            }

            return body;
        }

        private static string GetVariablesBody(TreeView hookBodiesTreeView)
        {
            string body = "";
            uint variablesCount = 0;

            if (IsHookBodiesContainItem("SetSummonerGuid", hookBodiesTreeView))
            {
                if (variablesCount == 0)
                {
                    body += "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "ObjectGuid m_SummonerGuid;";
                }
                else
                {
                    body += "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "ObjectGuid m_SummonerGuid;";
                }

                variablesCount++;
            }

            if (IsHookBodiesContainItem("EventsSwitch", hookBodiesTreeView))
            {
                if (variablesCount == 0)
                {
                    body += "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "EventMap m_Events;";
                }
                else
                {
                    body += "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "EventMap m_Events;";
                }

                variablesCount++;
            }

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
    }
}
