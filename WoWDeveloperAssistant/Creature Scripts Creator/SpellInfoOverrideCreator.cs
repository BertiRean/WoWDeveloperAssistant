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
            int OverrideValue = Convert.ToInt32(mainForm.SpellInfo_Value_TextBox.Text);

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
        }
    }
}
