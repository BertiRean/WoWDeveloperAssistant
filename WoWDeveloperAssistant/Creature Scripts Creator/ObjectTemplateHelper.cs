using System;
using System.Collections.Generic;
using System.Collections;
using WoWDeveloperAssistant.Misc;
using System.Windows.Forms;
using System.Data;

namespace WoWDeveloperAssistant.ObjectTemplateDB_Helper
{
    public struct CreatureInfo
    {
        public long NpcEntry;
        public long[] Flags;
        public string NpcName;

        public CreatureInfo(long npcEntry, long unitFlags = 0, long unitFlags2 = 0, long unitFlags3 = 0, long npcFlags = 0, long npcFlags2 = 0, long creatureFlagsExtra = 0,
            long mechanicImmunneMask = 0, string npcName = "")
        {
            this.NpcEntry = npcEntry;
            this.NpcName = npcName;

            Flags = new long[]
            {
                unitFlags,
                unitFlags2,
                unitFlags3,
                npcFlags,
                npcFlags2,
                creatureFlagsExtra,
                mechanicImmunneMask,
            };
        }

        public long GetFieldFlags(int field)
        {
            return Flags[field];
        }

        public bool HasFlag(int field, long flag)
        {
            return (Flags[field] & flag) != 0;
        }
    };

    public class ObjectTemplateHelper
    {
        private MainForm mainForm;

        public ObjectTemplateHelper(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.creatureEntries = new Dictionary<long, CreatureInfo>();
            this.gameobjectEntries = new Dictionary<uint, ArrayList>();
        }

        private Dictionary<long, CreatureInfo> creatureEntries;
        private Dictionary<uint, ArrayList> gameobjectEntries;

        private static readonly Dictionary<int, ArrayList> gameObjectFieldValues = new Dictionary<int, ArrayList>
        {
            { 0, new ArrayList
                {
                    "GO_FLAG_IN_USE",
                    "GO_FLAG_LOCKED",
                    "GO_FLAG_INTERACT_COND",
                    "GO_FLAG_TRANSPORT",
                    "GO_FLAG_NOT_SELECTABLE",
                    "GO_FLAG_NODESPAWN",
                    "GO_FLAG_AI_OBSTACLE",
                    "GO_FLAG_FREEZE_ANIMATION",
                    "GO_FLAG_ACTIVATED",
                    "GO_FLAG_DAMAGED",
                    "GO_FLAG_DESTROYED",
                    "GO_FLAG_UNK11",
                    "GO_FLAG_UNK12",
                    "GO_FLAG_UNK13",
                    "GO_FLAG_UNK14",
                    "GO_FLAG_LUMBER",
                    "GO_FLAG_PERSONAL_USE",
                    "GO_FLAG_INTERACT_DISTANCE_USES_TEMPLATE_MODEL",
                    "GO_FLAG_MAP_OBJECT",
                    "GO_FLAG_UNK21",
                }
            },
        };

        private static readonly Dictionary<int, ArrayList> creatureFieldValues = new Dictionary<int, ArrayList>
        {
            { 0, new ArrayList
                {
                    "UNIT_FLAG_SERVER_CONTROLLED",
                    "UNIT_FLAG_NON_ATTACKABLE",
                    "UNIT_FLAG_REMOVE_CLIENT_CONTROL",
                    "UNIT_FLAG_PVP_ATTACKABLE",
                    "UNIT_FLAG_RENAME",
                    "UNIT_FLAG_PREPARATION",
                    "UNIT_FLAG_UNK_6",
                    "UNIT_FLAG_NOT_ATTACKABLE_1",
                    "UNIT_FLAG_IMMUNE_TO_PC",
                    "UNIT_FLAG_IMMUNE_TO_NPC",
                    "UNIT_FLAG_LOOTING",
                    "UNIT_FLAG_PET_IN_COMBAT",
                    "UNIT_FLAG_PVP",
                    "UNIT_FLAG_SILENCED",
                    "UNIT_FLAG_CANNOT_SWIM",
                    "UNIT_FLAG_CAN_USE_SWIM_ANIMATION",
                    "UNIT_FLAG_NON_ATTACKABLE_2",
                    "UNIT_FLAG_PACIFIED",
                    "UNIT_FLAG_STUNNED",
                    "UNIT_FLAG_IN_COMBAT",
                    "UNIT_FLAG_TAXI_FLIGHT",
                    "UNIT_FLAG_DISARMED",
                    "UNIT_FLAG_CONFUSED",
                    "UNIT_FLAG_FLEEING",
                    "UNIT_FLAG_PLAYER_CONTROLLED",
                    "UNIT_FLAG_NOT_SELECTABLE",
                    "UNIT_FLAG_SKINNABLE",
                    "UNIT_FLAG_MOUNT",
                    "UNIT_FLAG_UNK_28",
                    "UNIT_FLAG_UNK_29",
                    "UNIT_FLAG_SHEATHE",
                    "UNIT_FLAG_IMMUNE",
                }
            },

            { 1, new ArrayList
                {
                    "UNIT_FLAG2_FEIGN_DEATH",
                    "UNIT_FLAG2_UNK1",
                    "UNIT_FLAG2_IGNORE_REPUTATION",
                    "UNIT_FLAG2_COMPREHEND_LANG",
                    "UNIT_FLAG2_MIRROR_IMAGE",
                    "UNIT_FLAG2_INSTANTLY_APPEAR_MODEL",
                    "UNIT_FLAG2_FORCE_MOVEMENT",
                    "UNIT_FLAG2_DISARM_OFFHAND",
                    "UNIT_FLAG2_DISABLE_PRED_STATS",
                    "UNIT_FLAG2_ALLOW_CHANGING_TALENTS",
                    "UNIT_FLAG2_DISARM_RANGED",
                    "UNIT_FLAG2_REGENERATE_POWER",
                    "UNIT_FLAG2_RESTRICT_PARTY_INTERACTION",
                    "UNIT_FLAG2_PREVENT_SPELL_CLICK",
                    "UNIT_FLAG2_ALLOW_ENEMY_INTERACT",
                    "UNIT_FLAG2_DISABLE_TURN",
                    "UNIT_FLAG2_UNK2",
                    "UNIT_FLAG2_PLAY_DEATH_ANIM",
                    "UNIT_FLAG2_ALLOW_CHEAT_SPELLS",
                    "UNIT_FLAG2_NO_ACTIONS",
                    "UNIT_FLAG2_UNK4",
                    "UNIT_FLAG2_UNK5",
                    "UNIT_FLAG2_UNK6",
                    "UNIT_FLAG2_UNK7",
                    "UNIT_FLAG2_UNK8",
                    "UNIT_FLAG2_UPDATE_REACTION",
                    "UNIT_FLAG2_SELECTION_DISABLED",
                    "UNIT_FLAG2_UNK11",
                    "UNIT_FLAG2_UNK12",
                    "UNIT_FLAG2_UNK13",
                    "UNIT_FLAG2_UNK14",
                    "UNIT_FLAG2_UNK15",
                }
            },

            { 2, new ArrayList
                {
                    "UNIT_FLAG3_PASSIVE_AI",
                    "UNIT_FLAG3_UNK2",
                    "UNIT_FLAG3_CAN_FIGHT_WITHOUT_DISMOUNT",
                    "UNIT_FLAG3_UNK4",
                    "UNIT_FLAG3_UNK5",
                    "UNIT_FLAG3_UNK6",
                    "UNIT_FLAG3_UNK7",
                    "UNIT_FLAG3_UNK8",
                    "UNIT_FLAG3_UNK9",
                    "UNIT_FLAG3_UNK10",
                    "UNIT_FLAG3_UNK11",
                    "UNIT_FLAG3_UNK12",
                    "UNIT_FLAG3_UNK13",
                    "UNIT_FLAG3_DISPLAY_AS_CORPSE",
                    "UNIT_FLAG3_UNK15",
                    "UNIT_FLAG3_UNK16",
                    "UNIT_FLAG3_UNK17",
                    "UNIT_FLAG3_ALREADY_MINED_OR_SKINNED",
                    "UNIT_FLAG3_UNK19",
                    "UNIT_FLAG3_UNK20",
                    "UNIT_FLAG3_UNK21",
                    "UNIT_FLAG3_UNK22",
                    "UNIT_FLAG3_UNK23",
                    "UNIT_FLAG3_UNK24",
                    "UNIT_FLAG3_UNK25",
                    "UNIT_FLAG3_UNK26",
                    "UNIT_FLAG3_UNK27",
                    "UNIT_FLAG3_UNK28",
                    "UNIT_FLAG3_UNK29",
                    "UNIT_FLAG3_UNK30",
                    "UNIT_FLAG3_UNK31",
                    "UNIT_FLAG3_UNK32",
                }
            },

            { 3, new ArrayList
                {
                    "UNIT_NPC_FLAG_GOSSIP",
                    "UNIT_NPC_FLAG_QUESTGIVER",
                    "UNIT_NPC_FLAG_UNK1",
                    "UNIT_NPC_FLAG_UNK2",
                    "UNIT_NPC_FLAG_TRAINER",
                    "UNIT_NPC_FLAG_TRAINER_CLASS",
                    "UNIT_NPC_FLAG_TRAINER_PROFESSION",
                    "UNIT_NPC_FLAG_VENDOR",
                    "UNIT_NPC_FLAG_VENDOR_AMMO",
                    "UNIT_NPC_FLAG_VENDOR_FOOD",
                    "UNIT_NPC_FLAG_VENDOR_POISON",
                    "UNIT_NPC_FLAG_VENDOR_REAGENT",
                    "UNIT_NPC_FLAG_REPAIR",
                    "UNIT_NPC_FLAG_FLIGHTMASTER",
                    "UNIT_NPC_FLAG_SPIRITHEALER",
                    "UNIT_NPC_FLAG_SPIRITGUIDE",
                    "UNIT_NPC_FLAG_INNKEEPER",
                    "UNIT_NPC_FLAG_BANKER",
                    "UNIT_NPC_FLAG_PETITIONER",
                    "UNIT_NPC_FLAG_TABARDDESIGNER",
                    "UNIT_NPC_FLAG_BATTLEMASTER",
                    "UNIT_NPC_FLAG_AUCTIONEER",
                    "UNIT_NPC_FLAG_STABLEMASTER",
                    "UNIT_NPC_FLAG_GUILD_BANKER",
                    "UNIT_NPC_FLAG_SPELLCLICK",
                    "UNIT_NPC_FLAG_PLAYER_VEHICLE",
                    "UNIT_NPC_FLAG_MAILBOX",
                    "UNIT_NPC_FLAG_ARTIFACT_POWER_RESPEC",
                    "UNIT_NPC_FLAG_TRANSMOGRIFIER",
                    "UNIT_NPC_FLAG_VAULTKEEPER",
                    "UNIT_NPC_FLAG_PETBATTLE",
                    "UNIT_NPC_FLAG_BLACK_MARKET",
                }
            },

            { 4, new ArrayList
                {
                    "UNIT_NPC_FLAG2_ITEM_UPGRADE",
                    "UNIT_NPC_FLAG2_GARRISON_ARCHITECT",
                    "UNIT_NPC_FLAG2_AI_OBSTACLE",
                    "UNIT_NPC_FLAG2_STEERING",
                    "UNIT_NPC_FLAG2_GARRISON_SHIPMENT_CRAFTER",
                    "UNIT_NPC_FLAG2_GARRISON_MISSION_NPC",
                    "UNIT_NPC_FLAG2_TRADESKILL_NPC",
                    "UNIT_NPC_FLAG2_BLACK_MARKET_VIEW",
                    "UNIT_NPC_FLAG2_CONTRIBUTION_COLLECTOR",
                }
            },

            { 5, new ArrayList
                {
                    "CREATURE_FLAG_EXTRA_INSTANCE_BIND",
                    "CREATURE_FLAG_EXTRA_CIVILIAN",
                    "CREATURE_FLAG_EXTRA_NO_PARRY",
                    "CREATURE_FLAG_EXTRA_NO_PARRY_HASTEN",
                    "CREATURE_FLAG_EXTRA_NO_BLOCK",
                    "CREATURE_FLAG_EXTRA_NO_CRUSH",
                    "CREATURE_FLAG_EXTRA_NO_XP_AT_KILL",
                    "CREATURE_FLAG_EXTRA_TRIGGER",
                    "CREATURE_FLAG_EXTRA_NO_TAUNT",
                    "CREATURE_FLAG_EXTRA_PERSONAL_LOOT",
                    "CREATURE_FLAG_EXTRA_STAY_AT_KNOCKBACK_POS",
                    "CREATURE_FLAG_EXTRA_WORLDEVENT",
                    "CREATURE_FLAG_EXTRA_GUARD",
                    "CREATURE_FLAG_EXTRA_NO_CRIT",
                    "CREATURE_FLAG_EXTRA_NO_SKILLGAIN",
                    "CREATURE_FLAG_EXTRA_TAUNT_DIMINISH",
                    "CREATURE_FLAG_EXTRA_ALL_DIMINISH",
                    "CREATURE_FLAG_EXTRA_LOG_GROUP_DMG",
                    "CREATURE_FLAG_EXTRA_IMMUNITY_KNOCKBACK",
                    "CREATURE_FLAG_EXTRA_DUNGEON_BOSS",
                    "CREATURE_FLAG_EXTRA_IGNORE_PATHFINDING",
                    "CREATURE_FLAG_EXTRA_DUNGEON_END_BOSS",
                    "CREATURE_FLAG_EXTRA_NO_MOVE_FLAGS_UPDATE",
                }
            },

            { 6, new ArrayList
                {
                    "MECHANIC_NONE",
                    "MECHANIC_CHARM",
                    "MECHANIC_DISORIENTED",
                    "MECHANIC_DISARM",
                    "MECHANIC_DISTRACT",
                    "MECHANIC_FEAR",
                    "MECHANIC_GRIP",
                    "MECHANIC_ROOT",
                    "MECHANIC_SLOW_ATTACK",
                    "MECHANIC_SILENCE",
                    "MECHANIC_SLEEP",
                    "MECHANIC_SNARE",
                    "MECHANIC_STUN",
                    "MECHANIC_FREEZE",
                    "MECHANIC_KNOCKOUT",
                    "MECHANIC_BLEED",
                    "MECHANIC_BANDAGE",
                    "MECHANIC_POLYMORPH",
                    "MECHANIC_BANISH",
                    "MECHANIC_SHIELD",
                    "MECHANIC_SHACKLE",
                    "MECHANIC_MOUNT",
                    "MECHANIC_INFECTED",
                    "MECHANIC_TURN",
                    "MECHANIC_HORROR",
                    "MECHANIC_INVULNERABILITY",
                    "MECHANIC_INTERRUPT",
                    "MECHANIC_DAZE",
                    "MECHANIC_DISCOVERY",
                    "MECHANIC_IMMUNE_SHIELD",
                    "MECHANIC_SAPPED",
                    "MECHANIC_ENRAGED",
                    "MECHANIC_WOUNDED",
                    "MECHANIC_UNK_33",
                    "MECHANIC_UNK_34",
                    "MECHANIC_UNK_35",
                }
            },
        };

        public void ClearObjectData()
        {
            mainForm.ObjectTempalte_SQLResult_RichTextBox.Clear();
            this.creatureEntries.Clear();
        }

        public void GenerateSQL()
        {
            mainForm.ObjectTempalte_SQLResult_RichTextBox.Clear();

            int objType = mainForm.ObjectTemplateHelper_ObjType_ComboBox.SelectedIndex;
            string SQLText = "";

            switch (objType)
            {
                case 0:
                {
                    CreatureInfo creature = GetCreatureInfo(mainForm.ObjectTemplateHelper_ObjEntry_TextBox.Text);

                    if (creature.NpcEntry == -1)
                        return;

                    foreach(var npc in creatureEntries)
                    {
                        string query = "-- " + npc.Value.NpcName + "\r\n";
                        object[] fields = { npc.Value.Flags[0], npc.Value.Flags[1], npc.Value.Flags[2], npc.Value.Flags[3], npc.Value.Flags[4], npc.Value.Flags[5],
                            npc.Value.Flags[6]};

                        query += String.Format("UPDATE `creature_template` set `unit_flags` = {0}, `unit_flags2` = {1}," +
                            "unit_flags3` = {2}, `npcFlags` = {3}, `npcFlags2` = {4}, `flags_extra` = {5}, `mechanic_immune_mask` = {6} ", fields);

                        query += " WHERE `entry` = " + npc.Key.ToString() + "; \n\n";

                        SQLText += query;
                    }
                    break;
                }
            }

            mainForm.ObjectTempalte_SQLResult_RichTextBox.AppendText(SQLText);

            MessageBox.Show("SQL Queries Generated");
        }

        long GetMaskOfSelectedValuesInCheckBox(CheckedListBox listBox)
        {
            long retVal = 0;

            for (int idx = 0; idx < listBox.Items.Count; ++idx)
            {
                if (listBox.GetItemChecked(idx))
                    retVal |= 1 << idx;
            }

            return retVal;
        }

        public void EnableLockedItems(bool enabled)
        {
            /// Disable Items
            mainForm.ObjectTemplateHelper_GenerateSQL_Button.Enabled = enabled;
            mainForm.ObjectTemplate_ObjectField_ComboBox.Enabled  = enabled;
            mainForm.ObjectTemplateHelper_UpdateField_Button.Enabled = enabled;
        }

        public CreatureInfo GetCreatureInfo(string creatureEntry)
        {
            DataSet unitFlagsDs;
            DataSet creatureNameDs;
            string unitFlagsSqlQuery = "SELECT `npcflag`, `npcflag2`, `unit_flags`, `unit_flags2`, `unit_flags3`, `mechanic_immune_mask`, `flags_extra` FROM `creature_template` WHERE `entry` = " + creatureEntry + ";";
            string creatureNameQuery = "SELECT `Name1` FROM `creature_template_wdb` WHERE `entry` = " + creatureEntry + ";";
            unitFlagsDs = SQLModule.DatabaseSelectQuery(unitFlagsSqlQuery);
            creatureNameDs = SQLModule.DatabaseSelectQuery(creatureNameQuery);

            if (unitFlagsDs.Tables["table"].Rows.Count == 0 || creatureNameDs.Tables["table"].Rows.Count == 0)
            {
                MessageBox.Show("Creature doesn't exists in your database!");
                return new CreatureInfo(-1);
            }

            long npcFlags = Convert.ToInt64(unitFlagsDs.Tables["table"].Rows[0][0].ToString());
            long npcFlags2 = Convert.ToInt64(unitFlagsDs.Tables["table"].Rows[0][1].ToString());
            long unitFlags = Convert.ToInt64(unitFlagsDs.Tables["table"].Rows[0][2].ToString());
            long unitFlags2 = Convert.ToInt64(unitFlagsDs.Tables["table"].Rows[0][3].ToString());
            long unitFlags3 = Convert.ToInt64(unitFlagsDs.Tables["table"].Rows[0][4].ToString());
            long mechanicMask = Convert.ToInt64(unitFlagsDs.Tables["table"].Rows[0][5].ToString());
            long extraFlags = Convert.ToInt64(unitFlagsDs.Tables["table"].Rows[0][6].ToString());
            string npcName = creatureNameDs.Tables["table"].Rows[0][0].ToString();

            CreatureInfo creatureInfo = new CreatureInfo(long.Parse(creatureEntry), unitFlags, unitFlags2, unitFlags3, npcFlags, npcFlags2, extraFlags, mechanicMask, npcName);
            return creatureInfo;
        }

        public void CheckObjectInfo()
        {
            int objType = mainForm.ObjectTemplateHelper_ObjType_ComboBox.SelectedIndex;

            mainForm.ObjectTypeHelper_Fields_ListBox.Items.Clear();

            switch (objType)
            {
                case 0:
                {
                    CreatureInfo creature = GetCreatureInfo(mainForm.ObjectTemplateHelper_ObjEntry_TextBox.Text);
                    EnableLockedItems(creature.NpcEntry != -1);

                    if (creature.NpcEntry == -1)
                        return;

                    FillObjectFieldsComboxBox(objType);

                    if (!creatureEntries.ContainsKey(creature.NpcEntry))
                        creatureEntries.Add(creature.NpcEntry, creature);

                    break;
                }

                case 1:
                {
                    
                    break;
                }

                default: break;
            }
        }
        
        private void AddFlagsSelectedToCreature(int field)
        {
            var fieldListBox = mainForm.ObjectTypeHelper_Fields_ListBox;
            long npcEntry = long.Parse(mainForm.ObjectTemplateHelper_ObjEntry_TextBox.Text);

            if (!creatureEntries.ContainsKey(npcEntry))
                return;

            if (!creatureFieldValues.ContainsKey(field))
                return;

            if (fieldListBox.Items.Count > 0)
            {
                CreatureInfo currentCreature = creatureEntries[npcEntry];
                long flags = GetMaskOfSelectedValuesInCheckBox(fieldListBox);

                if (currentCreature.Flags[field] != flags)
                    currentCreature.Flags[field] = flags;
            }
        }

        public void UpdateObjFieldsFromList()
        {
            switch (mainForm.ObjectTemplateHelper_ObjType_ComboBox.SelectedIndex)
            {
                case 0:
                {
                    AddFlagsSelectedToCreature(mainForm.ObjectTemplate_ObjectField_ComboBox.SelectedIndex);
                    break;
                }

                case 1:
                {
                    break;
                }

                default:
                    break;
            }
        }

        public void FillValuesOptionListBox(int field)
        {
            var fieldListBox = mainForm.ObjectTypeHelper_Fields_ListBox;
            long npcEntry = long.Parse(mainForm.ObjectTemplateHelper_ObjEntry_TextBox.Text);

            switch (mainForm.ObjectTemplateHelper_ObjType_ComboBox.SelectedIndex)
            {
                case 0:
                {
                    fieldListBox.Items.Clear();

                    CreatureInfo creature = creatureEntries[npcEntry];
                    int idx = 0;

                    if (creature.NpcEntry == -1)
                        return;

                    foreach (var value in creatureFieldValues[field])
                    {
                        long flag = 1 << idx;

                        if (field == 6 && idx != 0)
                            flag = 1 << idx - 1;

                        idx++;
                        fieldListBox.Items.Add(value, creature.HasFlag(field, flag));
                    }
                    
                    break;
                }

                case 1:
                {
                    fieldListBox.Items.Clear();
                    foreach (var value in gameObjectFieldValues[field])
                        mainForm.ObjectTypeHelper_Fields_ListBox.Items.Add(value, false);

                    break;
                }

                default:
                    fieldListBox.Items.Clear();
                    break;
            }
        }

        public void FillObjectFieldsComboxBox(int objType)
        {
            mainForm.ObjectTemplate_ObjectField_ComboBox.Items.Clear();
            mainForm.ObjectTemplate_ObjectField_ComboBox.ResetText();

            switch (objType)
            {
                case 0:
                {
                    mainForm.ObjectTemplate_ObjectField_ComboBox.Items.Add("Unit Flags");
                    mainForm.ObjectTemplate_ObjectField_ComboBox.Items.Add("Unit Flags 2");
                    mainForm.ObjectTemplate_ObjectField_ComboBox.Items.Add("Unit Flags 3");
                    mainForm.ObjectTemplate_ObjectField_ComboBox.Items.Add("Npc Flags");
                    mainForm.ObjectTemplate_ObjectField_ComboBox.Items.Add("Npc Flags 2");
                    mainForm.ObjectTemplate_ObjectField_ComboBox.Items.Add("Creature Flags Extra");
                    mainForm.ObjectTemplate_ObjectField_ComboBox.Items.Add("Mechanic Immune Mask");
                    break;
                }

                case 1:
                {
                    mainForm.ObjectTemplate_ObjectField_ComboBox.Items.Add("GameObject Flags");
                    break;
                }

                default:
                    break;
            }
        }
    }
}
