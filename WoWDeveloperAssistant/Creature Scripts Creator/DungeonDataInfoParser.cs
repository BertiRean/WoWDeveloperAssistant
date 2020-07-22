using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WoWDeveloperAssistant.CombatAI_Creator_Templates;

namespace WoWDeveloperAssistant.DungeonDataInfoParser_Db
{
    public class CreatureScript
    {
        public int NpcEntry;
        public List<CombatAIEventDataEntry> Events;
        /// <summary>
        /// Tuple 1 = List of Init Timers
        /// Tuple 2 = List of Repeat Timers
        /// </summary>
        public Dictionary<int, Tuple< List<int>, List<int>>> SpellTimers;

        public CreatureScript()
        {
            Events = new List<CombatAIEventDataEntry>();
            SpellTimers = new Dictionary<int, Tuple<List<int>, List<int>>>();
        }

        public void AddSpellTimer(string[] spellInfoStr)
        {
            int spellId = Convert.ToInt32(spellInfoStr[0]);

            if (!SpellTimers.ContainsKey(spellId))
                SpellTimers[spellId] = new Tuple<List<int>, List<int>>(new List<int>(), new List<int>());

            Tuple<List<int>, List<int>> timers = SpellTimers[spellId];

            for (int idx = 1; idx < spellInfoStr.Length; ++idx)
            {
                string str = spellInfoStr[idx];
                if (str == "SpellTargets")
                    break;
                else
                {
                    int timer = Convert.ToInt32(str);

                    if (idx == 1) // First Cast Timer
                        timers.Item1.Add(timer);
                    else
                        timers.Item2.Add(timer);
                }
            }


            timers.Item1.Sort();
            timers.Item2.Sort();
        }

        public void AddCreatureCombatEvent(CombatAIEventDataEntry combatEvent)
        {
            CombatAIEventDataEntry result = Events.Find(itr => itr.SpellId == combatEvent.SpellId);

            if (result.NpcEntry == 0)
                Events.Add(combatEvent);
            else
                result = combatEvent;
        }
    };

    public class DungeonDataInfoCreator
    {
        private MainForm mainForm;
        private Dictionary<int, Dictionary<int, CreatureScript>> npcsByMap; // MapId -> Creature Entry -> Events
        private ArrayList maps;

        public DungeonDataInfoCreator(MainForm mainForm)
        {
            this.mainForm   = mainForm;
            this.npcsByMap = new Dictionary<int, Dictionary<int, CreatureScript>>();
            this.maps = new ArrayList();
        }

        public void ClearDungeonScriptData()
        {
            mainForm.textBox_SQLOutput.Clear();
            this.npcsByMap.Clear();
        }

        private string GetCreatureName(int npcEntry)
        {
            string npcName = "";
            string creatureNameQuery = "SELECT `Name1` FROM `creature_template_wdb` WHERE `entry` = " + npcEntry + ";";
            var creatureNameDs = Properties.Settings.Default.UsingDB ? SQLModule.DatabaseSelectQuery(creatureNameQuery) : null;

            if (creatureNameDs != null)
            {
                foreach (DataRow row in creatureNameDs.Tables["table"].Rows)
                    npcName = row[0].ToString();
            }

            return npcName;
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
                    {
                        parsedMaps.Add(DBC.DBC.Map[currentMapId].MapName);
                        this.maps.Add(currentMapId);
                    }

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
                        this.AddCreatureDataFromAddon(currentMapId, currentNpc, spellCasted[0].Groups[1].ToString());
                        continue;
                    }
                    else if (isReadingSpellTimers && Regex.IsMatch(line, Regex.Escape("},")))
                    {
                        isReadingSpellTimers = false;
                        isReadingNpc = false;
                    }
                }
            }

            mainForm.DungeonDataInfo_Map_ComboBox.Enabled = true;
            mainForm.DungeonDataInfo_Map_ComboBox.Items.Clear();

            foreach (var map in parsedMaps)
                mainForm.DungeonDataInfo_Map_ComboBox.Items.Add(map);
        }

        public void AddCreatureDataFromAddon(int mapId, int npcEntry, string spellTimerInfo)
        {
            string[] SpellInfo = spellTimerInfo.Split(',');

            if (!npcsByMap.ContainsKey(mapId))
                npcsByMap[mapId] = new Dictionary<int, CreatureScript>();

            Dictionary<int, CreatureScript> Npcs = npcsByMap[mapId];

            if (!Npcs.ContainsKey(npcEntry))
                Npcs[npcEntry] = new CreatureScript();

            Npcs[npcEntry].AddSpellTimer(SpellInfo);
        }

        public void FillCreatureListBox(int selectedIndex)
        {
            if (selectedIndex == -1)
                return;

            int mapId = (int)this.maps[selectedIndex];

            mainForm.DungeonDataInfo_Npc_CheckListBox.Items.Clear();
            mainForm.DungeonDataInfo_Npc_CheckListBox.Enabled = true;

            foreach (var Npc in npcsByMap[mapId])
            {
                string npcName = GetCreatureName(Npc.Key);

                if (npcName.Length > 0)
                {
                    npcName = Npc.Key + " -- " + npcName;
                    mainForm.DungeonDataInfo_Npc_CheckListBox.Items.Add(npcName, false);
                }
            }
        }
        public void FillSpellGrid(int selectedIndex)
        {
            this.mainForm.DungeonDataInfo_SpellTimer_Grid.Rows.Clear();
            this.mainForm.DungeonDataInfo_SpellTimer_Grid.Enabled = true;

            int mapId = this.mainForm.DungeonDataInfo_Map_ComboBox.SelectedIndex;

            if (mapId == -1)
                return;

            mapId = (int)this.maps[mapId];
            string npcName = this.mainForm.DungeonDataInfo_Npc_CheckListBox.SelectedItem.ToString();

            Match result = Regex.Match(npcName, @"([0-9]+)");

            if (result.Success)
            {
                int npcEntry = Convert.ToInt32(result.Value);
                this.mainForm.DungeonDataInfo_NpcEntry_TextBox.Text = result.Value;

                CreatureScript script = npcsByMap[mapId][npcEntry];

                foreach (var spells in script.SpellTimers)
                {
                    string initTimers = string.Join(" ", spells.Value.Item1);
                    string repeatTimers = string.Join(" ", spells.Value.Item2);
                    bool eventAdded = false;

                    foreach(var combatEvent in script.Events)
                    {
                        if (combatEvent.SpellId == (uint)spells.Key)
                            eventAdded = true;
                    }

                    this.mainForm.DungeonDataInfo_SpellTimer_Grid.Rows.Add(spells.Key, initTimers, repeatTimers, eventAdded.ToString());
                }
            }

        }

        public CombatAIEventDataEntry GenerateScriptData()
        {
            uint NpcEntry = uint.Parse(mainForm.DungeonDataInfo_NpcEntry_TextBox.Text);

            uint InitMin = uint.Parse(mainForm.DungeonDataInfo_InitMin_TextBox.Text);
            uint InitMax = uint.Parse(mainForm.DungeonDataInfo_InitMax_TextBox.Text);
            uint RepeatMin = uint.Parse(mainForm.DungeonDataInfo_RepeatMin_TextBox.Text);
            uint RepeatMax = uint.Parse(mainForm.DungeonDataInfo_RepeatMax_TextBox.Text);

            uint EventType = 0;
            if (mainForm.DungeonDataInfo__EventType_TextBox.SelectedIndex != -1)
                EventType = Convert.ToUInt32(mainForm.DungeonDataInfo__EventType_TextBox.SelectedIndex);

            uint EventFlags = 0;
            for (int idx = 0; idx < mainForm.DungeonDataInfo_EventFlags_TextBox.Items.Count; ++idx)
            {
                var option = mainForm.DungeonDataInfo_EventFlags_TextBox.Items[idx];

                if (mainForm.DungeonDataInfo_EventFlags_TextBox.GetItemChecked(idx))
                    EventFlags |= CombatAICreator.eventFlagsValues[idx];
            }

            float AttackDist = 0.0f;
            if (mainForm.DungeonDataInfo_AttackDist_TextBox.Text.Length > 0)
                AttackDist = float.Parse(mainForm.DungeonDataInfo_AttackDist_TextBox.Text);

            uint SpellId = 0;
            if (mainForm.DungeonDataInfo_SpellId_TextBox.Text.Length > 0)
                SpellId = uint.Parse(mainForm.DungeonDataInfo_SpellId_TextBox.Text);

            return new CombatAIEventDataEntry(NpcEntry, InitMin, InitMax, RepeatMin, RepeatMax, SpellId, AttackDist, EventType, EventFlags);
        }

        public void EnabledCombatScriptFields(bool enable)
        {
            this.mainForm.DungeonDataInfo_InitMin_TextBox.Enabled = enable;
            this.mainForm.DungeonDataInfo_InitMax_TextBox.Enabled = enable;
            this.mainForm.DungeonDataInfo_RepeatMin_TextBox.Enabled = enable;
            this.mainForm.DungeonDataInfo_RepeatMax_TextBox.Enabled = enable;
            this.mainForm.DungeonDataInfo__EventType_TextBox.Enabled = enable;
            this.mainForm.DungeonDataInfo_EventFlags_TextBox.Enabled = enable;
            this.mainForm.DungeonDataInfo_AttackDist_TextBox.Enabled = enable;
            this.mainForm.DungeonDataInfo_SpellId_TextBox.Enabled = enable;
            this.mainForm.DungeonDataInfo_Add_Script_Button.Enabled = enable;
        }

        public void SpellGridSelected(int rowIndex)
        {
            DataGridView spellGrid = this.mainForm.DungeonDataInfo_SpellTimer_Grid;

            this.mainForm.DungeonDataInfo_SpellId_TextBox.Text = spellGrid[0, rowIndex].Value.ToString();

            int[] initTimers = ToIntTimers(spellGrid[1, rowIndex].Value.ToString().Split(' '));
            int[] repeatTimers = ToIntTimers(spellGrid[2, rowIndex].Value.ToString().Split(' '));
            repeatTimers = ComputeDiffTimers(repeatTimers);

            Array.Sort(repeatTimers);

            int initMin = initTimers[0] * 1000;
            int initMax = initTimers[initTimers.Length - 1] * 1000;

            int repMin = repeatTimers[0] * 1000;
            int repMax = repeatTimers[repeatTimers.Length - 1] * 1000;

            this.mainForm.DungeonDataInfo_InitMin_TextBox.Text = initMin.ToString();
            this.mainForm.DungeonDataInfo_InitMax_TextBox.Text = initMax.ToString();
            this.mainForm.DungeonDataInfo_RepeatMin_TextBox.Text = repMin.ToString();
            this.mainForm.DungeonDataInfo_RepeatMax_TextBox.Text = repMax.ToString();

            EnabledCombatScriptFields(true);
        }

        private int[] ComputeDiffTimers(int[] timers)
        {
            int[] diffTimers = new int[timers.Length];
            diffTimers[0] = timers[0];

            for (int idx = 1; idx < timers.Length; ++idx)
            {
                int diff = Math.Abs(timers[idx] - timers[idx - 1]);

                if (diff > 1)
                    diffTimers[idx] = diff;
                else
                    diffTimers[idx] = diffTimers[0];
            }

            return diffTimers;
        }

        private int[] ToIntTimers(string[] strTimers)
        {
            int[] timers = new int[strTimers.Length];

            int idx = 0;
            foreach(string strTimer in strTimers)
            {
                int timer = strTimer != "" ? Convert.ToInt32(strTimer) : 0;
                timers[idx++] = timer;
            }

            return timers;
        }

        public void UpdateCombatEventEntry(int rowIndex)
        {
            DataGridView spellGrid = this.mainForm.DungeonDataInfo_SpellTimer_Grid;
            int spellId = Convert.ToInt32(spellGrid[0, rowIndex].Value.ToString());
            int npcEntry = Convert.ToInt32(this.mainForm.DungeonDataInfo_NpcEntry_TextBox.Text);
            int mapId = this.mainForm.DungeonDataInfo_Map_ComboBox.SelectedIndex;

            if (mapId == -1)
                return;

            mapId = (int)this.maps[mapId];

            npcsByMap[mapId][npcEntry].AddCreatureCombatEvent(GenerateScriptData());
            spellGrid[3, rowIndex].Value = true.ToString();
        }

        public void GenerateSQL()
        {
            mainForm.textBox_SQLOutput.Clear();

            foreach (var npcsInMap in npcsByMap)
            {
                foreach(var npc in npcsInMap.Value)
                {
                    uint itr = 0;
                    string SQLtext = "";
                    bool hasEvents = npc.Value.Events.Count > 0;

                    if (hasEvents)
                    {
                        SQLtext += "-- " + GetCreatureName(npc.Key) + "\r\n";
                        SQLtext += "UPDATE `creature_template` SET `AIName` = \"LegionCombatAI\", `ScriptName` = \"\" WHERE `entry` = " + npc.Key + ";\r\n";
                        SQLtext += "DELETE FROM `combat_ai_events` WHERE `entry` = " + npc.Key + ";\r\n";
                        SQLtext += "INSERT INTO `combat_ai_events` (`entry`, `id`, `start_min`, `start_max`, `repeat_min`, `repeat_max`, `repeat_fail`, `spell_id`, `event_check`, `event_flags`, `attack_dist`, `difficulty_mask`, `comment`) VALUES\r\n";
                    }

                    foreach (CombatAIEventDataEntry combatEntry in npc.Value.Events)
                    {
                        string query = CombatAICreator.CreateCombatEntryValues(combatEntry, itr);

                        if (itr + 1 >= npc.Value.Events.Count)
                            query += ";\r\n";
                        else
                            query += ",\r\n";

                        SQLtext += query;
                        itr++;
                    }

                    if (hasEvents)
                    {
                        SQLtext += "\r\n\n";
                        mainForm.textBox_SQLOutput.AppendText(SQLtext);
                    }
                }
            }

            MessageBox.Show("SQL Queries Generated");

        }

    }
}
