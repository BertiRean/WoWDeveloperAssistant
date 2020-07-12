using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WoWDeveloperAssistant.Misc;
using WoWDeveloperAssistant.SpellInfo_Override_DbCreator;

namespace WoWDeveloperAssistant.CombatAI_Creator_Templates
{
    public class CombatAICreator
    {
        private MainForm mainForm;

        public CombatAICreator(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.combatAIEntries = new Dictionary<uint, ArrayList>();
        }

        private Dictionary<uint, ArrayList> combatAIEntries;

        static private uint[] eventFlagsValues =
        {
            0x1,
            0x2,
            0x4,
            0x8,
            0x10,
            0x20,
            0x40,
            0x80,
            0x100,
            0x200,
            0x400,
            0x800,
            0x1000,
            0x2000,
            0x4000,
            0x8000,
            0x10000,
            0x20000,
            0x40000
        };

        public void ClearCombatScriptData()
        {
            mainForm.textBox_SQLOutput.Clear();
            this.combatAIEntries.Clear();
        }

        private bool ValidateNpcEntry(uint npcEntry)
        {
            string npcName = "";
            string creatureNameQuery = "SELECT `Name1` FROM `creature_template_wdb` WHERE `entry` = " + npcEntry + ";";
            var creatureNameDs = Properties.Settings.Default.UsingDB ? SQLModule.DatabaseSelectQuery(creatureNameQuery) : null;

            if (creatureNameDs != null)
            {
                foreach (DataRow row in creatureNameDs.Tables["table"].Rows)
                    npcName = row[0].ToString();
            }

            if (npcName == "")
                return false;

            return true;
        }

        static private string CreateCombatEntryValues(CombatAIEventDataEntry combatData, uint id)
        {
            string npcName = "";

            string creatureNameQuery = "SELECT `Name1` FROM `creature_template_wdb` WHERE `entry` = " + combatData.NpcEntry + ";";
            var creatureNameDs = Properties.Settings.Default.UsingDB ? SQLModule.DatabaseSelectQuery(creatureNameQuery) : null;

            if (creatureNameDs != null)
            {
                foreach (DataRow row in creatureNameDs.Tables["table"].Rows)
                    npcName = row[0].ToString();
            }

            if (npcName == "")
                return "";

            string spellName = SpellInfoOverrideCreator.GetSpellName(combatData.SpellId);

            string comment = "\"" + npcName + " -- " + spellName + "\"";
            string query = "(" + combatData.NpcEntry + ", " + id + ", " + combatData.StartMin + ", " + combatData.StartMax +
                ", " + combatData.RepeatMin + ", " + combatData.RepeatMax + ", " + combatData.RepeatFail + ", " + combatData.SpellId + ", " +
                combatData.EventCheck + ", " + combatData.EventFlags + ", " + combatData.AttackDist + ", " + combatData.DifficultyMask + ", "
                + comment + ")";

            return query;
        }

        public void GenerateSQL()
        {
            mainForm.textBox_SQLOutput.Clear();

            foreach (var item in combatAIEntries)
            {
                string SQLtext = "";

                if (item.Value.Count > 0)
                {
                    SQLtext += "DELETE FROM `combat_ai_events` WHERE `entry` = " + item.Key + ";\r\n";
                    SQLtext += "INSERT INTO `combat_ai_events` (`entry`, `id`, `start_min`, `start_max`, `repeat_min`, `repeat_max`, `repeat_fail`, `spell_id`, `event_check`, `event_flags`, `attack_dist`, `difficulty_mask`, `comment`) VALUES\r\n";
                }

                uint itr = 0;
                foreach (CombatAIEventDataEntry combatData in item.Value)
                {
                    string query = CombatAICreator.CreateCombatEntryValues(combatData, itr);

                    if (itr + 1 >= item.Value.Count)
                        query += ";\n";
                    else
                        query += ",\n";

                    SQLtext += query;
                    itr++;
                }

                SQLtext += "\n\n";
                mainForm.textBox_SQLOutput.AppendText(SQLtext);
            }

            MessageBox.Show("SQL Queries Generated");
        }

        public void AddCombatAIData()
        {
            uint NpcEntry = uint.Parse(mainForm.CombatAI_NpcEntry_TextBox.Text);

            if (!ValidateNpcEntry(NpcEntry))
            {
                String msg = String.Format("The Creature with Entry: {0} doesn't exist in world DB",
                         NpcEntry);

                MessageBox.Show(msg);
                return;
            }

            uint InitMin = 0;
            if (mainForm.CombatAI_InitMin_TextBox.Text.Length > 0)
                InitMin = uint.Parse(mainForm.CombatAI_InitMin_TextBox.Text);

            uint InitMax = 0;
            if (mainForm.CombatAI_InitMax_TextBox.Text.Length > 0)
                InitMax = uint.Parse(mainForm.CombatAI_InitMax_TextBox.Text);

            uint RepeatMin = 0;
            if (mainForm.CombatAI_RepeatMin_TextBox.Text.Length > 0)
                RepeatMin = uint.Parse(mainForm.CombatAI_RepeatMin_TextBox.Text);

            uint RepeatMax = 0;
            if (mainForm.CombatAI_RepeatMax_TextBox.Text.Length > 0)
                RepeatMax = uint.Parse(mainForm.CombatAI_RepeatMax_TextBox.Text);

            uint EventType = 0;
            if (mainForm.CombatAI_EventType_ComboBox.SelectedIndex != -1)
                EventType = Convert.ToUInt32(mainForm.CombatAI_EventType_ComboBox.SelectedIndex);

            uint EventFlags = 0;

            for (int idx = 0; idx < mainForm.CombatAI_EventFlags_CheckedBox.Items.Count; ++idx)
            {
                var option = mainForm.CombatAI_EventFlags_CheckedBox.Items[idx];

                if (mainForm.CombatAI_EventFlags_CheckedBox.GetItemChecked(idx))
                    EventFlags |= eventFlagsValues[idx];
            }

            float AttackDist = 0.0f;
            if (mainForm.CombatAI_AttackDist_TextBox.Text.Length > 0)
                AttackDist = float.Parse(mainForm.CombatAI_AttackDist_TextBox.Text);

            uint SpellId = 0;
            if (mainForm.CombatAI_Spell_Id_TextBox.Text.Length > 0)
                SpellId = uint.Parse(mainForm.CombatAI_Spell_Id_TextBox.Text);

            if (DBC.DBC.IsLoaded() && !DBC.DBC.SpellName.ContainsKey((int)SpellId))
            {
                String msg = String.Format("The Spell Id: {0} doesn't exist in DBC",
                         SpellId);

                MessageBox.Show(msg);
                return;
            }

            CombatAIEventDataEntry combatData = new CombatAIEventDataEntry(NpcEntry, InitMin, InitMax, RepeatMin, RepeatMax, SpellId, AttackDist, EventType, EventFlags);

            if (!combatAIEntries.ContainsKey(NpcEntry))
                combatAIEntries.Add(NpcEntry, new ArrayList());

            combatAIEntries[NpcEntry].Add(combatData);
            MessageBox.Show("Combat Script Info added to Npc: " + NpcEntry);
        }

        public void EnableLockedItems(bool enabled)
        {
            /// Disable Items
            mainForm.CombatAI_InitMin_TextBox.Enabled = enabled;
            mainForm.CombatAI_InitMax_TextBox.Enabled = enabled;
            mainForm.CombatAI_RepeatMin_TextBox.Enabled = enabled;
            mainForm.CombatAI_RepeatMax_TextBox.Enabled = enabled;
            mainForm.CombatAI_EventType_ComboBox.Enabled = enabled;
            mainForm.CombatAI_EventFlags_CheckedBox.Enabled = enabled;
            mainForm.CombatAI_AttackDist_TextBox.Enabled = enabled;
            mainForm.CombatAI_Spell_Id_TextBox.Enabled = enabled;
            mainForm.CombatAI_Add_ScriptData_Button.Enabled = enabled;
        }

        public void SearchCreatureScript()
        {
            DataSet combatAiDs;
            string creatureEntry = this.mainForm.CombatAI_NpcEntry_TextBox.Text;
            string combatAIQuery = "SELECT `entry`, `start_min`, `start_max`, `repeat_min`, `repeat_max`, `repeat_fail`, `spell_id`, `event_check`, `event_flags`, `attack_dist` FROM `combat_ai_events` WHERE `entry` = " + creatureEntry + ";";

            combatAiDs = SQLModule.DatabaseSelectQuery(combatAIQuery);

            if (combatAiDs == null || combatAiDs.Tables["table"].Rows.Count == 0)
            {
                MessageBox.Show("Creature doens't have script in Combat AI Table");
                return;
            }

            this.mainForm.CombatAI_SpellGrid_DataGrid.Enabled = true;
            this.mainForm.CombatAI_SpellGrid_DataGrid.Rows.Clear();

            foreach(DataRow row in combatAiDs.Tables["table"].Rows)
                this.mainForm.CombatAI_SpellGrid_DataGrid.Rows.Add(row.ItemArray);
        }

        public void CombatRowSelected(int rowIndex, bool fromDB = true)
        {
            if (!fromDB)
                return;

            DataGridView scriptGrid = this.mainForm.CombatAI_SpellGrid_DataGrid;
            this.mainForm.CombatAI_NpcEntry_TextBox.Text = scriptGrid[0, rowIndex].Value.ToString();
            this.mainForm.CombatAI_InitMin_TextBox.Text = scriptGrid[1, rowIndex].Value.ToString();
            this.mainForm.CombatAI_InitMax_TextBox.Text = scriptGrid[2, rowIndex].Value.ToString();
            this.mainForm.CombatAI_RepeatMin_TextBox.Text = scriptGrid[3, rowIndex].Value.ToString();
            this.mainForm.CombatAI_RepeatMax_TextBox.Text = scriptGrid[4, rowIndex].Value.ToString();
            this.mainForm.CombatAI_Spell_Id_TextBox.Text = scriptGrid[6, rowIndex].Value.ToString();
            this.mainForm.CombatAI_EventType_ComboBox.SelectedIndex = Convert.ToInt32(scriptGrid[7, rowIndex].Value.ToString());

            long flags = Convert.ToInt64(scriptGrid[8, rowIndex].Value.ToString());

            CheckedListBox eventFlags = this.mainForm.CombatAI_EventFlags_CheckedBox;

            for (int idx = 0; idx < eventFlags.Items.Count; ++idx)
            {
                eventFlags.SetItemChecked(idx, false);

                if ((flags & 1 << idx) != 0)
                    eventFlags.SetItemChecked(idx, true);
            }

            this.mainForm.CombatAI_AttackDist_TextBox.Text = scriptGrid[9, rowIndex].Value.ToString();
        }
    }
}
