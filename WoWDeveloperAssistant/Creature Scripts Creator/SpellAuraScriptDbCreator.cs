using System;
using System.Collections.Generic;
using System.Collections;
using WoWDeveloperAssistant.Misc;
using System.Windows.Forms;
using WoWDeveloperAssistant.SpellInfo_Override_DbCreator;

namespace WoWDeveloperAssistant.Spell_Aura_Script_DbCreator
{
    public class SpellAuraScriptDbCreator
    {
        private MainForm mainForm;

        public SpellAuraScriptDbCreator(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.spellScriptsEntries = new Dictionary<uint, ArrayList>();
            this.auraScriptsEntries = new Dictionary<uint, ArrayList>();
        }

        private Dictionary<uint, ArrayList> spellScriptsEntries;
        private Dictionary<uint, ArrayList> auraScriptsEntries;

        private enum ScriptTypes
        {
            SpellScript = 1,
            AuraScript  = 2,
            Unknown     = 10
        };

        public void FillBoxWithHooks()
        {
            mainForm.SpellAuraScript_Hooks_ComboBox.Items.Clear();
            mainForm.SpellAuraScript_Hooks_ComboBox.ResetText();
            mainForm.SpellAuraScript_ActionComboBox.Items.Clear();
            mainForm.SpellAuraScript_ActionComboBox.ResetText();

            EnableLockedItems(false);

            switch (GetScriptType(mainForm.SpellAuraScriptType_ComboBox.SelectedIndex))
            {
                case ScriptTypes.SpellScript:
                {
                    foreach (string key in SpellScriptDB.hooksList)
                        mainForm.SpellAuraScript_Hooks_ComboBox.Items.Add(key);

                    foreach (string key in SpellScriptDB.actionsList)
                        mainForm.SpellAuraScript_ActionComboBox.Items.Add(key);

                    break;
                }

                case ScriptTypes.AuraScript:
                {
                    foreach (string key in AuraScriptDB.hooksList)
                        mainForm.SpellAuraScript_Hooks_ComboBox.Items.Add(key);

                    foreach (string key in AuraScriptDB.actionsList)
                        mainForm.SpellAuraScript_ActionComboBox.Items.Add(key);
                    break;
                }
            }
        }
        private static ScriptTypes GetScriptType(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    return ScriptTypes.SpellScript;
                case 1:
                    return ScriptTypes.AuraScript;
                default:
                    return ScriptTypes.Unknown;
            }
        }

        public void GenerateSQL()
        {
            mainForm.SpellAuraScript_SQL_Out_RichTextBox.Clear();

            foreach (var item in spellScriptsEntries)
            {
                var SQLtext = "-- " + SpellInfoOverrideCreator.GetSpellName(item.Key) + " \r\n";
                SQLtext += "DELETE FROM `spell_scripting` WHERE `SpellId` = " + item.Key + ";\r\n";
                SQLtext += "INSERT INTO `spell_scripting` (`SpellId`, `Id`, `Hook`, `EffectId`, `Action`, `ActionSpellId`, `ActionCaster`, `OriginalCaster`, `ActionTarget`, `Triggered`, " +
                    "`Calculation`, `DataSource`, `ActionSpellList`, `TargetSpellId`, `TargetEffectId`, `DataEffectId`, `Comment`) VALUES\r\n";

                uint itr = 0;
                foreach(SpellScriptEntry script in item.Value)
                {
                    string query = SpellScriptDB.CreateSqlQuery(script, itr);

                    if (itr + 1 >= item.Value.Count)
                        query += ";\n";
                    else
                        query += ",\n";

                    SQLtext += query;
                    itr++;
                }

                SQLtext += "\n\n";
                mainForm.SpellAuraScript_SQL_Out_RichTextBox.AppendText(SQLtext);
            }

            foreach (var item in auraScriptsEntries)
            {
                var SQLtext = "-- " + SpellInfoOverrideCreator.GetSpellName(item.Key) + " \r\n";
                SQLtext += "DELETE FROM `aura_scripts` WHERE `SpellId` = " + item.Key + ";\r\n";
                SQLtext += "insert into `aura_scripts` (`SpellId`, `Id`, `Hook`, `EffectId`, `Action`, `ActionSpellId`, `ActionCaster`, `OriginalCaster`, `ActionTarget`, `Triggered`, " +
                    "`Calculation`, `DataSource`, `ActionSpellList`, `Comment`) VALUES\r\n";

                uint itr = 0;
                foreach (AuraScriptEntry script in item.Value)
                {
                    string query = AuraScriptDB.CreateSqlQuery(script, itr);

                    if (itr + 1 >= item.Value.Count)
                        query += ";\n";
                    else
                        query += ",\n";

                    SQLtext += query;
                    itr++;
                }

                SQLtext += "\n\n";
                mainForm.SpellAuraScript_SQL_Out_RichTextBox.AppendText(SQLtext);
            }

            MessageBox.Show("SQL Queries Generated");
        }

        private bool ValidateSpellId(uint SpellId)
        {
            if (DBC.DBC.IsLoaded() && !DBC.DBC.SpellName.ContainsKey((int)SpellId))
            {
                String msg = String.Format("The Spell Id: {0} doesn't exist in DBC",
                         SpellId);

                MessageBox.Show(msg);
                return false;
            }

            return true;
        }

        public void AddScript()
        {
            switch (GetScriptType(mainForm.SpellAuraScriptType_ComboBox.SelectedIndex))
            {
                case ScriptTypes.SpellScript:
                {
                    uint SpellId = uint.Parse(mainForm.SpellAuraScript_SpellID_TextBox.Text);
                    
                    if (!ValidateSpellId(SpellId))
                        return;
                        
                    uint Hook = Convert.ToUInt32(mainForm.SpellAuraScript_Hooks_ComboBox.SelectedIndex);
                    int EffIdx = mainForm.SpellAuraScript_EffIndex_ComboBox.SelectedIndex;

                    uint ActionSpellId = Convert.ToUInt32(mainForm.SpellAuraScripts_ActionSpellId_TextBox.Text.Length > 1 ? mainForm.SpellAuraScripts_ActionSpellId_TextBox.Text : "0");
                    bool Triggered = mainForm.SpellAuraScript_Triggered_ComboBox.SelectedIndex > 1;

                    uint Action                 = Convert.ToUInt32(mainForm.SpellAuraScript_ActionComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScript_ActionComboBox.SelectedIndex : 0);
                    uint ActionCaster           = Convert.ToUInt32(mainForm.SpellAuraScripts_ActionCaster_ComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScripts_ActionCaster_ComboBox.SelectedIndex : 0);
                    uint ActionTarget           = Convert.ToUInt32(mainForm.SpellAuraScripts_ActionTarget_ComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScripts_ActionTarget_ComboBox.SelectedIndex : 0);
                    uint ActionOriginalCaster   = Convert.ToUInt32(mainForm.SpellAuraScripts_ActionOrgCaster_ComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScripts_ActionOrgCaster_ComboBox.SelectedIndex : 0);

                    uint CalcType = Convert.ToUInt32(mainForm.SpellAuraScript_CalcType_ComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScript_CalcType_ComboBox.SelectedIndex : 0);
                    uint Source = Convert.ToUInt32(mainForm.SpellAuraScriptSources_ComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScriptSources_ComboBox.SelectedIndex : 0);
                    string ActionSpellList = mainForm.SpellAuraScripts_ActionSpellList_TextBox.Text;

                    uint TargetSpellId  = Convert.ToUInt32(mainForm.SpellAuraScripts_TargetSpellId_TextBox.Text.Length > 1 ? mainForm.SpellAuraScripts_TargetSpellId_TextBox.Text : "0");
                    int  DataEffIdx     = mainForm.SpellAuraScripts_DataEffIdx_ComboBox.SelectedIndex;
                    int TargetEffIdx    = mainForm.SpellAuraScripts_TargetEffIdx_ComboBox.SelectedIndex;

                    SpellScriptEntry spell = new SpellScriptEntry(SpellId, Hook, EffIdx, Action, ActionSpellId, ActionCaster, ActionTarget, Triggered, ActionSpellList, ActionOriginalCaster,
                    Source, CalcType, TargetSpellId, TargetEffIdx, DataEffIdx);

                    if (!spellScriptsEntries.ContainsKey(spell.SpellId))
                        spellScriptsEntries.Add(spell.SpellId, new ArrayList());

                    spellScriptsEntries[spell.SpellId].Add(spell);
                    MessageBox.Show("Information added correctly to SpellId");
                    break;
                }

                case ScriptTypes.AuraScript:
                {
                    uint SpellId = uint.Parse(mainForm.SpellAuraScript_SpellID_TextBox.Text);

                    if (!ValidateSpellId(SpellId))
                        return;

                    uint Hook = Convert.ToUInt32(mainForm.SpellAuraScript_Hooks_ComboBox.SelectedIndex);
                    int EffIdx = mainForm.SpellAuraScript_EffIndex_ComboBox.SelectedIndex;

                    uint ActionSpellId = Convert.ToUInt32(mainForm.SpellAuraScripts_ActionSpellId_TextBox.Text.Length > 1 ? mainForm.SpellAuraScripts_ActionSpellId_TextBox.Text : "0");
                    bool Triggered = mainForm.SpellAuraScript_Triggered_ComboBox.SelectedIndex > 1;

                    uint Action = Convert.ToUInt32(mainForm.SpellAuraScript_ActionComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScript_ActionComboBox.SelectedIndex : 0);
                    uint ActionCaster = Convert.ToUInt32(mainForm.SpellAuraScripts_ActionCaster_ComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScripts_ActionCaster_ComboBox.SelectedIndex : 0);
                    uint ActionTarget = Convert.ToUInt32(mainForm.SpellAuraScripts_ActionTarget_ComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScripts_ActionTarget_ComboBox.SelectedIndex : 0);
                    uint ActionOriginalCaster = Convert.ToUInt32(mainForm.SpellAuraScripts_ActionOrgCaster_ComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScripts_ActionOrgCaster_ComboBox.SelectedIndex : 0);

                    uint CalcType = Convert.ToUInt32(mainForm.SpellAuraScript_CalcType_ComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScript_CalcType_ComboBox.SelectedIndex : 0);
                    uint Source = Convert.ToUInt32(mainForm.SpellAuraScriptSources_ComboBox.SelectedIndex != -1 ? mainForm.SpellAuraScriptSources_ComboBox.SelectedIndex : 0);
                    string ActionSpellList = mainForm.SpellAuraScripts_ActionSpellList_TextBox.Text;

                    uint TargetSpellId = Convert.ToUInt32(mainForm.SpellAuraScripts_TargetSpellId_TextBox.Text.Length > 1 ? mainForm.SpellAuraScripts_TargetSpellId_TextBox.Text : "0");
                    int DataEffIdx = mainForm.SpellAuraScripts_DataEffIdx_ComboBox.SelectedIndex;
                    int TargetEffIdx = mainForm.SpellAuraScripts_TargetEffIdx_ComboBox.SelectedIndex;

                    AuraScriptEntry auraScript = new AuraScriptEntry(SpellId, Hook, EffIdx, Action, ActionSpellId, ActionCaster, ActionTarget, Triggered, ActionSpellList, ActionOriginalCaster,
                    Source, CalcType, TargetSpellId, TargetEffIdx, DataEffIdx);

                    if (!auraScriptsEntries.ContainsKey(auraScript.SpellId))
                        auraScriptsEntries.Add(auraScript.SpellId, new ArrayList());

                    auraScriptsEntries[auraScript.SpellId].Add(auraScript);
                    MessageBox.Show("Information added correctly to SpellId");
                    break;
                }
            }
        }

        public void EnableLockedItems(bool enabled)
        {
            /// Disable Items
            mainForm.SpellAuraScript_EffIndex_ComboBox.Enabled  = enabled;
            mainForm.SpellAuraScript_Triggered_ComboBox.Enabled = enabled;
            mainForm.SpellAuraScript_CalcType_ComboBox.Enabled  = enabled;
            mainForm.SpellAuraScriptSources_ComboBox.Enabled    = enabled;
            mainForm.SpellAuraScripts_ActionCaster_ComboBox.Enabled     = enabled;
            mainForm.SpellAuraScripts_ActionTarget_ComboBox.Enabled = enabled;
            mainForm.SpellAuraScripts_ActionOrgCaster_ComboBox.Enabled = enabled;
            mainForm.SpellAuraScriptSources_ComboBox.Enabled    = enabled;
            mainForm.SpellAuraScripts_ActionSpellId_TextBox.Enabled = enabled;
            mainForm.SpellAuraScripts_ActionSpellList_TextBox.Enabled = enabled;
            mainForm.SpellAuraScript_Button_Add.Enabled = enabled;
            mainForm.SpellAuraScripts_TargetSpellId_TextBox.Enabled = enabled;
            mainForm.SpellAuraScripts_DataEffIdx_ComboBox.Enabled = enabled;
            mainForm.SpellAuraScripts_TargetEffIdx_ComboBox.Enabled = enabled;
        }

        public void ClearScriptData()
        {
            mainForm.SpellAuraScript_SQL_Out_RichTextBox.Clear();
            this.spellScriptsEntries.Clear();
            this.auraScriptsEntries.Clear();
        }
    }
}
