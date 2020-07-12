using System;
using System.Collections.Generic;
using System.Collections;
using WoWDeveloperAssistant.Misc;
using System.Windows.Forms;
using System.Data;

namespace WoWDeveloperAssistant.JournalLootCreator_DB
{
    public struct JournalEncounterInfo
    {
        public string BossName;
        public ArrayList Loot;

        public JournalEncounterInfo(string bossName = "")
        {
            this.BossName = bossName;
            this.Loot = new ArrayList();
        }
    };

    public class JournalLootCreator
    {
        private MainForm mainForm;
        private List<uint> instanceIds;

        public JournalLootCreator(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.instanceIds = new List<uint>();
        }

        public void ClearObjectData()
        {
            mainForm.JournalLoot_SQL_RichTextBox.Clear();
        }

        private List<DBC.Structures.JournalEncounterEntry> GetEncounters(uint journalInstanceId)
        {
            List<DBC.Structures.JournalEncounterEntry> encounters = new List<DBC.Structures.JournalEncounterEntry>();

            foreach (var encounter in DBC.DBC.JournalEncounters.Values)
            {
                if (encounter.JournalInstanceID == journalInstanceId)
                    encounters.Add(encounter);
            }

            return encounters;
        }

        public void GenerateSQL()
        {
            this.mainForm.JournalLoot_SQL_RichTextBox.Clear();
            int selectedEncounter = mainForm.JournalLoot_ComboBox.SelectedIndex;

            if (selectedEncounter == -1)
                return;

            var encounters = GetEncounters(this.instanceIds[selectedEncounter]);

            foreach(var encounter in encounters)
            {
                string query = "";
                uint count = 0;
                var loot = GetItemsAssociatedToCreature(encounter.ID);
                string constantName = encounter.Name.Replace(',', ' ').Replace(' ', '_').ToUpper();

                if (loot.Count > 0)
                {
                    query += "SET @" + constantName + " := ;\n\n";
                    query += "DELETE FROM `creature_loot_template` WHERE `entry` = @" + constantName + ";\n";
                    query += "INSERT INTO `creature_loot_template` (`entry`, `item`, `ChanceOrQuestChance`, `groupId`, `lootmode`, `mincountOrRef`, `maxcount`, `difficultyMask`) VALUES\n";
                }

                foreach (Tuple<uint, long> item in loot)
                {
                    count++;
                    query += String.Format("(@ {0}, {1}, 100, 1, 1, 1, 1, {2})", constantName, item.Item1, item.Item2);

                    if (count + 1 > loot.Count)
                        query += ";\n\n";
                    else
                        query += ",\n";

                }

                this.mainForm.JournalLoot_SQL_RichTextBox.AppendText(query);
            }
        }

        ArrayList GetItemsAssociatedToCreature(uint journalEncounterID)
        {
            var itemsDBC = DBC.DBC.JournalEncounterItems.Values;
            ArrayList encounterLoot = new ArrayList();

            foreach (var item in itemsDBC)
            {
                if (item.JournalEncounterID == journalEncounterID)
                {
                    Tuple<uint, long> key = new Tuple<uint, long>(item.ItemID, item.DifficultyMask);
                    encounterLoot.Add(key);
                }
            }

            return encounterLoot;
        }
        
        public void FillInstanceComboBox()
        {
            if (!DBC.DBC.IsLoaded())
                DBC.DBC.Load();

            var instances = DBC.DBC.JournalInstances.Values;
            mainForm.JournalLoot_ComboBox.Items.Clear();
            
            foreach(var instanceEntry in instances)
            {
                mainForm.JournalLoot_ComboBox.Items.Add(instanceEntry.Name);
                this.instanceIds.Add(instanceEntry.ID);
            }
        }

        public void EnableLockedItems(bool enabled)
        {
            /// Disable Items
            mainForm.ObjectTemplateHelper_GenerateSQL_Button.Enabled = enabled;
            mainForm.ObjectTemplate_ObjectField_ComboBox.Enabled  = enabled;
            mainForm.ObjectTemplateHelper_UpdateField_Button.Enabled = enabled;
        }
    }
}
