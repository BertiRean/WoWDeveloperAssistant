using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWDeveloperAssistant.Misc;
using WoWDeveloperAssistant.SpellInfo_Override_DbCreator;

namespace WoWDeveloperAssistant.CombatAI_Creator_Templates
{
    public struct CombatAIEventDataEntry
    {
        public uint NpcEntry;

        public uint StartMin;
        public uint StartMax;
        public uint RepeatMin;
        public uint RepeatMax;
        public uint RepeatFail;

        public uint SpellId;
        public float AttackDist;

        public uint EventCheck;
        public uint EventFlags;

        public uint DifficultyMask;

        public CombatAIEventDataEntry(uint npcEntry, uint startMin, uint startMax, uint repeatMin, uint repeatMax, uint spellId, float attackDist, uint eventCheck, uint eventFlags, uint diffMask = 0)
        {
            this.NpcEntry = npcEntry;
            this.StartMin = startMin;
            this.StartMax = startMax;
            this.RepeatMin = repeatMin;
            this.RepeatMax = repeatMax;
            this.RepeatFail = 1000;
            this.SpellId = spellId;
            this.AttackDist = attackDist;
            this.EventCheck = eventCheck;
            this.EventFlags = eventFlags;
            this.DifficultyMask = diffMask;
        }

        public CombatAIEventDataEntry(object[] values)
        {
            int idx = 0;
            this.NpcEntry = (uint)values[idx++];
            this.StartMin = (uint)values[idx++];
            this.StartMax = (uint)values[idx++];
            this.RepeatMin = (uint)values[idx++];
            this.RepeatMax = (uint)values[idx++];
            this.RepeatFail = (uint)values[idx++];
            this.SpellId = (uint)values[idx++];
            this.EventCheck = (uint)values[idx++];
            this.EventFlags = (uint)values[idx++];
            this.AttackDist = (float)values[idx++];
            this.DifficultyMask = 0;
        }

        public object[] GetFieldArray()
        {
            object[] fields = new object[] { this.NpcEntry, this.StartMin, this.StartMax, this.RepeatMin, this.RepeatMax, this.RepeatFail, this.SpellId, this.EventCheck, this.EventFlags, this.AttackDist };
            return fields;
        }
    };

    public class CombatAICreator
    {
        private MainForm mainForm;

        public CombatAICreator(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.combatAIEntries = new Dictionary<uint, ArrayList>();
            this.scriptsParsedFromAddon = new Dictionary<int, Dictionary<uint, ArrayList>>();
        }

        private Dictionary<uint, ArrayList> combatAIEntries;
        private Dictionary<int, Dictionary<uint, ArrayList>> scriptsParsedFromAddon;

        static public uint[] eventFlagsValues =
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

        static public string CreateCombatEntryValues(CombatAIEventDataEntry combatData, uint id)
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
                        query += ";\r\n";
                    else
                        query += ",\r\n";

                    SQLtext += query;
                    itr++;
                }

                SQLtext += "\n\n";
                mainForm.textBox_SQLOutput.AppendText(SQLtext);
            }

            MessageBox.Show("SQL Queries Generated");
        }

        public CombatAIEventDataEntry GenerateScriptData()
        {
            uint NpcEntry = uint.Parse(mainForm.CombatAI_NpcEntry_TextBox.Text);

            if (!ValidateNpcEntry(NpcEntry))
            {
                String msg = String.Format("The Creature with Entry: {0} doesn't exist in world DB",
                         NpcEntry);

                MessageBox.Show(msg);
                return new CombatAIEventDataEntry();
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
                return new CombatAIEventDataEntry();
            }

            return new CombatAIEventDataEntry(NpcEntry, InitMin, InitMax, RepeatMin, RepeatMax, SpellId, AttackDist, EventType, EventFlags);
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

            uint NpcEntry = Convert.ToUInt32(creatureEntry);

            foreach(DataRow row in combatAiDs.Tables["table"].Rows)
            {
                if (!combatAIEntries.ContainsKey(NpcEntry))
                    combatAIEntries[NpcEntry] = new ArrayList();

                this.mainForm.CombatAI_SpellGrid_DataGrid.Rows.Add(row.ItemArray);
                combatAIEntries[NpcEntry].Add(new CombatAIEventDataEntry(row.ItemArray));
            }
        }

        private void FillCombatFields(CombatAIEventDataEntry script)
        {
            this.mainForm.CombatAI_NpcEntry_TextBox.Text = script.NpcEntry.ToString();
            this.mainForm.CombatAI_InitMin_TextBox.Text = script.StartMin.ToString();
            this.mainForm.CombatAI_InitMax_TextBox.Text = script.StartMax.ToString();
            this.mainForm.CombatAI_RepeatMin_TextBox.Text = script.RepeatMin.ToString();
            this.mainForm.CombatAI_RepeatMax_TextBox.Text = script.RepeatMax.ToString();
            this.mainForm.CombatAI_Spell_Id_TextBox.Text = script.SpellId.ToString();
            this.mainForm.CombatAI_EventType_ComboBox.SelectedIndex = (int)script.EventCheck;

            long flags = (long)script.EventFlags;

            CheckedListBox eventFlags = this.mainForm.CombatAI_EventFlags_CheckedBox;

            for (int idx = 0; idx < eventFlags.Items.Count; ++idx)
            {
                eventFlags.SetItemChecked(idx, false);

                if ((flags & 1 << idx) != 0)
                    eventFlags.SetItemChecked(idx, true);
            }

            this.mainForm.CombatAI_AttackDist_TextBox.Text = script.AttackDist.ToString();
        }

        public void CombatRowSelected(int rowIndex)
        {
            uint npcEntry = Convert.ToUInt32(this.mainForm.CombatAI_SpellGrid_DataGrid[0, rowIndex].Value.ToString());
            uint idx = 0;

            foreach (var script in this.combatAIEntries[npcEntry])
            {
                if (idx++ == rowIndex)
                    this.FillCombatFields((CombatAIEventDataEntry)script);
            }
        }

        public void UpdateCombatGridData(uint npcEntry)
        {
            this.mainForm.CombatAI_SpellGrid_DataGrid.Rows.Clear();

            foreach (CombatAIEventDataEntry script in this.combatAIEntries[npcEntry])
                this.mainForm.CombatAI_SpellGrid_DataGrid.Rows.Add(script.GetFieldArray());
        }

        public void UpdateRowSelected()
        {
            int rowIndex = this.mainForm.CombatAI_SpellGrid_DataGrid.CurrentRow.Index;
            CombatAIEventDataEntry entry = this.GenerateScriptData();

            if (!combatAIEntries.ContainsKey(entry.NpcEntry))
                return;

            for (int idx = 0; idx < this.combatAIEntries[entry.NpcEntry].Count; ++idx)
            {
                if (idx == rowIndex)
                {
                    this.combatAIEntries[entry.NpcEntry][idx] = entry;
                    MessageBox.Show("CombatAI Data Updated");
                    this.UpdateCombatGridData(entry.NpcEntry);
                    return;
                }
            }
        }

        public void OpenFileDialog()
        {
            mainForm.openFileDialog.Title = "Open File";
            mainForm.openFileDialog.Filter = "DungeonDataInfo File (*.lua)|*.lua";
            mainForm.openFileDialog.FileName = "*.lua";
            mainForm.openFileDialog.FilterIndex = 1;
            mainForm.openFileDialog.ShowReadOnly = false;
            mainForm.openFileDialog.Multiselect = false;
            mainForm.openFileDialog.CheckFileExists = true;
        }

        public void ImportAddonData(string fileName)
        {
            if (!DBC.DBC.IsLoaded())
                DBC.DBC.Load();

            var lines = File.ReadAllLines(fileName);

            ArrayList parsedMaps = new ArrayList();
            string mapPattern = Regex.Escape("[\"") + "(\\d*),";
            string npcEntryPattern = Regex.Escape("[") + "([0-9]+)" + Regex.Escape("]");
            string spellPattern = Regex.Escape("(") + "([^)]+)" + Regex.Escape(")");
            ArrayList npcSpellLineIndexes = new ArrayList();

            int currentMapId = 0;
            int currentNpc = 0;
            bool isReadingNpc = false;
            bool isReadingSpellTimers = false;

            foreach(string line in lines)
            {
                MatchCollection maps = Regex.Matches(line, mapPattern);

                if (maps.Count > 0)
                {
                    currentMapId = Convert.ToInt32(maps[0].Groups[1].ToString());
                    
                    if (DBC.DBC.Map.ContainsKey(currentMapId))
                        parsedMaps.Add(DBC.DBC.Map[currentMapId].MapName);

                    continue;
                }

                //Check If Line is a Npc Entry
                if (!isReadingNpc)
                {
                    MatchCollection npcEntries = Regex.Matches(line, npcEntryPattern);
                    if (npcEntries.Count > 0)
                    {
                        isReadingNpc = true;
                        currentNpc = Convert.ToInt32(npcEntries[0].Groups[1].ToString());
                        mainForm.textBox_SQLOutput.AppendText(String.Format("Spells Casted By {0}\r\n", currentNpc));
                        continue;
                    }
                }

                if (!isReadingSpellTimers && Regex.IsMatch(line, "spells"))
                    isReadingSpellTimers = true;

                if (isReadingSpellTimers)
                {
                    /// Check if line is a string with spell information
                    MatchCollection spellCasted = Regex.Matches(line, spellPattern);
                    if (spellCasted.Count > 0)
                    {
                        this.AddCreatureDataFromAddon(currentNpc, spellCasted[0].Groups[1].ToString());
                        continue;
                    }
                    else if (isReadingSpellTimers && Regex.IsMatch(line, Regex.Escape("},")))
                    {
                        isReadingSpellTimers = false;
                        isReadingNpc = false;
                    }
                }
            }
        }

        public class SpellTimerData
        {
            public uint SpellId;
            public ArrayList InitMinTimers;
            public ArrayList InitMaxTimers;
            public ArrayList RepeatMinTimers;
            public ArrayList RepeatMaxTimers;

            public SpellTimerData(uint spellId = 0)
            {
                this.SpellId = spellId;
                this.InitMinTimers = new ArrayList();
                this.InitMaxTimers = new ArrayList();
                this.RepeatMinTimers = new ArrayList();
                this.RepeatMaxTimers = new ArrayList();
            }

            private uint GetAverageTimer(ArrayList timers)
            {
                uint avg = 0;

                foreach (uint timer in timers)
                    avg += timer;

                return avg / (uint)timers.Count;
            }

            uint GetInitMinAverageTimer()
            {
                return GetAverageTimer(this.InitMinTimers);
            }

            uint GetInitMaxAverageTimer()
            {
                return GetAverageTimer(this.InitMaxTimers);
            }

            uint GetRepeatMinAverageTimer()
            {
                return GetAverageTimer(this.RepeatMinTimers);
            }

            uint GetRepeatMaxAverageTimer()
            {
                return GetAverageTimer(this.RepeatMaxTimers);
            }
        };

        public void AddCreatureDataFromAddon(int npcEntry, string spellTimerInfo)
        {
            string[] SpellInfo = spellTimerInfo.Split(',');

            uint SpellId = Convert.ToUInt32(SpellInfo[0]);
            uint InitMin = Convert.ToUInt32(SpellInfo[1]);
            uint InitMax = Convert.ToUInt32(SpellInfo[2]);
            uint RepeatMin = Convert.ToUInt32(SpellInfo[3]);
            uint RepeatMax = Convert.ToUInt32(SpellInfo[4]);

            SpellTimerData SpellTimer = new SpellTimerData(SpellId);

            SpellTimer.InitMinTimers.Add(InitMin);
            SpellTimer.InitMaxTimers.Add(InitMax);
            SpellTimer.RepeatMinTimers.Add(RepeatMin);
            SpellTimer.RepeatMaxTimers.Add(RepeatMax);

            if (!this.scriptsParsedFromAddon.ContainsKey(npcEntry))
                this.scriptsParsedFromAddon[npcEntry] = new Dictionary<uint, ArrayList>();

            var spellsCastedByNpc = scriptsParsedFromAddon[npcEntry];

            if (!spellsCastedByNpc.ContainsKey(SpellId))
                spellsCastedByNpc[SpellId] = new ArrayList();

            spellsCastedByNpc[SpellId].Add(SpellTimer);

            mainForm.textBox_SQLOutput.AppendText(String.Format("Creature Entry: {0} -> CastSpell: {1} \r\n", npcEntry, spellTimerInfo));
        }
    }
}
