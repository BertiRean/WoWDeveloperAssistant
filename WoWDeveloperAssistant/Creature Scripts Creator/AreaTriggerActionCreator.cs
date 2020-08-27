using System;
using System.Collections.Generic;
using System.Collections;
using WoWDeveloperAssistant.Misc;
using System.Windows.Forms;
using System.Data;

namespace WoWDeveloperAssistant.AreaTriggerActionCreatorDB
{
    public struct AreaTriggerTemplateInfo
    {
        public int Entry;
        public int SpellId;
        public int CustomEntry;

        public AreaTriggerTemplateInfo(int entry = -1, int spellId = -1, int customEntry =-1)
        {
            this.Entry = entry;
            this.SpellId = spellId;
            this.CustomEntry = customEntry;
        }

        public bool IsValidTemplate() { return this.Entry != -1; }
    };
    public struct AreaTriggerAction
    {
        public uint ActionType;
        public int TargetFlags;
        public int Moment;
        public uint ActionSpellId;
        public uint ChargeRestoreTimer;
        public uint MaxCharges;
        public uint HasAura;
        public uint MaxTargetHitted;
        public uint DespawnAfterAction;
    };

    public class AreaTriggerActionCreator
    {
        private MainForm mainForm;

        public AreaTriggerActionCreator(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.areaTriggerActionEntries = new Dictionary<uint, ArrayList>();

            if (!DBC.DBC.IsLoaded())
                DBC.DBC.Load();
        }

        private Dictionary<uint, ArrayList> areaTriggerActionEntries;

        public void CheckAreaTriggerInfo()
        {
            uint spellId = ParseText(mainForm.AreaTrigger_SpellId_TextBox.Text);

            AreaTriggerTemplateInfo template = GetAreaTriggerTemplateInfo(spellId);

            if (!template.IsValidTemplate())
            {
                String msg = String.Format("The AreaTrigger with SpellId: {0} doesn't exist in DB",
                         spellId);

                MessageBox.Show(msg);
                EnableLockedItems(false);
            }
            else
                EnableLockedItems(true);
        }

        static private string CreateAreaTriggerInsertValue(AreaTriggerAction action, AreaTriggerTemplateInfo template, int id)
        {
            string query = "(" + template.Entry + ", " + template.SpellId + ", " + template.CustomEntry + ", "
                + id + ", " + action.Moment + ", " + action.ActionType + ", " + action.TargetFlags + ", " + action.ActionSpellId + ", " + action.MaxCharges + ", " +
                action.HasAura + ", " + action.ChargeRestoreTimer + ", " + action.MaxTargetHitted + ", " + action.DespawnAfterAction + ',' + "\'\'" + ")";
            return query;
        }

        static public string GetSpellName(uint spellId)
        {
            string comment = "";
            if (DBC.DBC.IsLoaded() && DBC.DBC.SpellName.ContainsKey((int)spellId))
                comment = DBC.DBC.SpellName[(int)spellId].Name;

            return comment;
        }

        public void ClearActionsData()
        {
            mainForm.AreaTrigger_SQLOutput_RichTextBox.Clear();
            this.areaTriggerActionEntries.Clear();
        }

        public AreaTriggerTemplateInfo GetAreaTriggerTemplateInfo(uint spellId)
        {
            DataSet areaTriggerInfo;
            string areaTriggerTemplateInfoQuery = "SELECT `entry`, `spellId`, `customEntry` FROM `areatrigger_template` where `spellId` = " + spellId + ";";
            areaTriggerInfo = SQLModule.DatabaseSelectQuery(areaTriggerTemplateInfoQuery);

            if (areaTriggerInfo.Tables["table"].Rows.Count == 0 || areaTriggerInfo.Tables["table"].Rows.Count == 0)
            {
                MessageBox.Show("AreaTrigger Template doesn't exists in your database!");
                return new AreaTriggerTemplateInfo(-1);
            }

            AreaTriggerTemplateInfo template = new AreaTriggerTemplateInfo();
            template.Entry = Convert.ToInt32(areaTriggerInfo.Tables["table"].Rows[0][0].ToString());
            template.SpellId = Convert.ToInt32(areaTriggerInfo.Tables["table"].Rows[0][1].ToString());
            template.CustomEntry = Convert.ToInt32(areaTriggerInfo.Tables["table"].Rows[0][2].ToString());

            return template;
        }

        public void GenerateSQL()
        {
            mainForm.AreaTrigger_SQLOutput_RichTextBox.Clear();

            foreach (var item in areaTriggerActionEntries)
            {
                string SQLtext = "";

                if (item.Value.Count > 0)
                {
                    SQLtext = "-- " + GetSpellName(item.Key) +  " \r\n";
                    SQLtext += "DELETE FROM `areatrigger_actions` WHERE `summon_spellId` = " + item.Key + ";\r\n";
                    SQLtext += "INSERT INTO `areatrigger_actions` (`entry`, `summon_spellId`, `customEntry`, `id`, `moment`, `actionType`, `targetFlags`, `spellId`, `maxCharges`, " +
                        "`aura`, `chargeRecoveryTime`, `hitMaxCount`, `onDespawn`, `comment`) VALUES\r\n";
                }

                uint itr = 0;

                AreaTriggerTemplateInfo template = GetAreaTriggerTemplateInfo(item.Key);

                if (!template.IsValidTemplate())
                    continue;

                foreach (AreaTriggerAction spellDbc in item.Value)
                {
                    string query = AreaTriggerActionCreator.CreateAreaTriggerInsertValue(spellDbc, template, (int)itr);

                    if (itr + 1 >= item.Value.Count)
                        query += ";\n";
                    else
                        query += ",\n";

                    SQLtext += query;
                    itr++;
                }

                SQLtext += "\n\n";
                mainForm.AreaTrigger_SQLOutput_RichTextBox.AppendText(SQLtext);
            }

            MessageBox.Show("SQL Queries Generated");
        }

        int GetMaskOfSelectedValuesInCheckBox(CheckedListBox checkBox)
        {
            int retVal = 0;

            int[] bitFields =
            {
                4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 34, 36, 37, 38
            };

            for (int idx = 0; idx < checkBox.Items.Count; ++idx)
            {
                if (checkBox.GetItemChecked(idx))
                    retVal |= (1 << idx);
            }

            return retVal;
        }

        public void AddActionEntry()
        {
            uint SpellId = ParseText(mainForm.AreaTrigger_SpellId_TextBox.Text);

            AreaTriggerAction action = new AreaTriggerAction();

            action.ActionType = mainForm.AreaTrigger_AreaAction_ListBox.SelectedIndex != -1 ? (uint)mainForm.AreaTrigger_AreaAction_ListBox.SelectedIndex : 0;
            action.TargetFlags = GetMaskOfSelectedValuesInCheckBox(mainForm.AreaTrigger_TargetFlags_CheckBox);
            action.Moment = GetMaskOfSelectedValuesInCheckBox(mainForm.AreaTrigger_Moment_CheckBox);
            action.ActionSpellId = ParseText(mainForm.AreaTrigger_ActionSpellId_TextBox.Text);
            action.ChargeRestoreTimer = ParseText(mainForm.AreaTrigger_ChargeRestoreTimer_TextBox.Text);
            action.MaxCharges = (uint)mainForm.AreaTrigger_MaxCharges_NumericUpDown.Value;
            action.HasAura = ParseText(mainForm.AreaTrigger_HasAura_TextBox.Text);
            action.MaxTargetHitted = (uint)mainForm.AreaTrigger_MaxTargetHitted_NumericUpDown.Value;
            action.DespawnAfterAction = mainForm.AreaTriggerDespawn_RadioButton.Checked ? 1u : 0;

            if (DBC.DBC.IsLoaded() && !DBC.DBC.SpellName.ContainsKey((int)action.ActionSpellId))
            {
                String msg = String.Format("The Action Spell Id: {0} doesn't exist in DBC",
                         SpellId);

                MessageBox.Show(msg);
                return;
            }

            if (!areaTriggerActionEntries.ContainsKey(SpellId))
            {
                areaTriggerActionEntries.Add(SpellId, new ArrayList());
                areaTriggerActionEntries[SpellId].Add(action);
            }
            else
                areaTriggerActionEntries[SpellId].Add(action);


            MessageBox.Show("Action added correctly to AreaTrigger with Spell Id: " + SpellId);

            UpdateAreaTriggerActionsListView();
        }

        private void UpdateAreaTriggerActionsListView()
        {
            this.mainForm.AreaTrigger_CurrentActions_ListView.Items.Clear();

            foreach (var item in areaTriggerActionEntries)
            {
                string areaName = GetSpellName(item.Key) + "--" + item.Key;
                this.mainForm.AreaTrigger_CurrentActions_ListView.Items.Add(areaName);
            }
        }

        public static uint ParseText(string text)
        {
            return text.Length > 0 ? uint.Parse(text) : 0;
        }

        public void EnableLockedItems(bool enabled)
        {
            /// Disable Items
            mainForm.AreaTrigger_AreaAction_ListBox.Enabled = enabled;
            mainForm.AreaTrigger_TargetFlags_CheckBox.Enabled = enabled;
            mainForm.AreaTrigger_Moment_CheckBox.Enabled = enabled;
            mainForm.AreaTrigger_ActionSpellId_TextBox.Enabled = enabled;
            mainForm.AreaTrigger_ChargeRestoreTimer_TextBox.Enabled = enabled;
            mainForm.AreaTrigger_MaxCharges_NumericUpDown.Enabled = enabled;
            mainForm.AreaTrigger_HasAura_TextBox.Enabled = enabled;
            mainForm.AreaTrigger_MaxTargetHitted_NumericUpDown.Enabled = enabled;
            mainForm.AreaTriggerDespawn_RadioButton.Enabled  = enabled;
        }
    }
}
