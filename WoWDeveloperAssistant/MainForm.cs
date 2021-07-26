using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using WoWDeveloperAssistant.Core_Script_Templates;
using WoWDeveloperAssistant.Database_Advisor;
using WoWDeveloperAssistant.Waypoints_Creator;
using WoWDeveloperAssistant.Achievements;
using WoWDeveloperAssistant.Creature_Scripts_Creator;
using WoWDeveloperAssistant.Spell_Aura_Script_DbCreator;
using WoWDeveloperAssistant.SpellInfo_Override_DbCreator;
using WoWDeveloperAssistant.CombatAI_Creator_Templates;
using WoWDeveloperAssistant.ObjectTemplateDB_Helper;
using WoWDeveloperAssistant.JournalLootCreator_DB;
using WoWDeveloperAssistant.DungeonDataInfoParser_Db;
using WoWDeveloperAssistant.AreaTriggerActionCreatorDB;
using WoWDeveloperAssistant.Conditions_Creator;

namespace WoWDeveloperAssistant
{
    public partial class MainForm : Form
    {
        public bool importSuccessful = false;

        private CreatureScriptsCreator creatureScriptsCreator;
        private WaypointsCreator waypointsCreator;
        private CoreScriptTemplates coreScriptTemplate;
        private static Dictionary<uint, string> creatureNamesDict;
        private SpellAuraScriptDbCreator spellAuraScriptCreatorDB;
        private SpellInfoOverrideCreator spellDBCOverrideCreatorDB;
        private CombatAICreator combatAIScriptsCreatorDB;
        private ObjectTemplateHelper objectTemplateHelperDB;
        private JournalLootCreator journalLootCreatorDB;
        private DungeonDataInfoCreator dungeonDataParser;
        private AreaTriggerActionCreator areaTriggerActionCreator;
        private ConditionsCreator conditionsCreator;

        public MainForm()
        {
            InitializeComponent();

            creatureScriptsCreator = new CreatureScriptsCreator(this);
            waypointsCreator = new WaypointsCreator(this);
            coreScriptTemplate = new CoreScriptTemplates(this);
            spellAuraScriptCreatorDB = new SpellAuraScriptDbCreator(this);
            creatureNamesDict = new Dictionary<uint, string>();
            spellDBCOverrideCreatorDB = new SpellInfoOverrideCreator(this);
            combatAIScriptsCreatorDB = new CombatAICreator(this);
            objectTemplateHelperDB = new ObjectTemplateHelper(this);
            journalLootCreatorDB = new JournalLootCreator(this);
            dungeonDataParser = new DungeonDataInfoCreator(this);
            areaTriggerActionCreator = new AreaTriggerActionCreator(this);
            conditionsCreator = new ConditionsCreator(this);

            if (Properties.Settings.Default.UsingDB)
            {
                creatureNamesDict = GetCreatureNamesFromDB();
            }
            else
            {
                checkBox_DatabaseConsidering.Enabled = false;
            }
        }

        private Dictionary<uint, string> GetCreatureNamesFromDB()
        {
            Dictionary<uint, string> namesDict = new Dictionary<uint, string>();

            string creatureNameQuery = "SELECT `entry`, `Name1` FROM `creature_template_wdb`;";
            var creatureNameDs = Properties.Settings.Default.UsingDB ? SQLModule.DatabaseSelectQuery(creatureNameQuery) : null;

            if (creatureNameDs != null)
            {
                foreach (DataRow row in creatureNameDs.Tables["table"].Rows)
                {
                    namesDict.Add((uint)row[0], row[1].ToString());
                }
            }

            return namesDict;
        }

        public static string GetCreatureNameByEntry(uint creatureEntry)
        {
            if (creatureNamesDict.ContainsKey(creatureEntry))
                return creatureNamesDict[creatureEntry];

            return "Unknown";
        }

        private static bool IsTxtFileValidForParse(string fileName)
        {
            StreamReader file = new StreamReader(fileName);
            var line = file.ReadLine();
            file.Close();

            if (line == "# TrinityCore - WowPacketParser")
            {
                return true;
            }

            MessageBox.Show(fileName + " is not a valid TrinityCore parsed sniff file.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            return false;
        }

        private void createSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_CreatureScriptsCreator_Spells.Rows.Count > 0)
            {
                creatureScriptsCreator.FillSQLOutput();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_CreatureScriptsCreator_Spells.SelectedRows)
            {
                dataGridView_CreatureScriptsCreator_Spells.Rows.Remove(row);
            }
        }

        private void toolStripButton_ImportSniff_Click(object sender, EventArgs e)
        {
            creatureScriptsCreator.OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                creatureScriptsCreator.ImportStarted();

                if (IsTxtFileValidForParse(openFileDialog.FileName) &&
                    creatureScriptsCreator.GetDataFromSniffFile(openFileDialog.FileName))
                {
                    creatureScriptsCreator.ImportSuccessful();
                }
                else
                {
                    toolStripStatusLabel_CurrentAction.Text = "";
                    toolStripStatusLabel_FileStatus.Text = "No File Loaded";
                    toolStripButton_CSC_ImportSniff.Enabled = true;
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void toolStripButton_Search_Click(object sender, EventArgs e)
        {
            creatureScriptsCreator.FillListBoxWithGuids();
        }

        private void toolStripTextBox_CSC_CreatureEntrySearch_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            creatureScriptsCreator.FillListBoxWithGuids();
        }

        private void listBox_CreatureGuids_SelectedIndexChanged(object sender, EventArgs e)
        {
            creatureScriptsCreator.FillSpellsGrid();
        }

        private void textBox_CreatureFlags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreatureFlagsAdvisor.GetCreatureFlags(textBox_CreatureFlags.Text);
            }
        }

        private void textBox_QuestFlags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QuestFlagsAdvisor.GetQuestFlags(textBox_QuestFlags.Text);
            }
        }

        private void button_ImportFile_Click(object sender, EventArgs e)
        {
            DoubleSpawnsRemover.OpenFileDialog(openFileDialog);

            this.Cursor = Cursors.WaitCursor;
            button_ImportFileForRemoving.Enabled = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DoubleSpawnsRemover.RemoveDoubleSpawnsFromFile(openFileDialog.FileName, label_CreaturesRemoved, label_GameobjectsRemoved, checkBox_CreaturesRemover.Checked, checkBox_GameobjectsRemover.Checked, checkBox_DatabaseConsidering.Checked);
                button_ImportFileForRemoving.Enabled = true;
                this.Cursor = Cursors.Default;
            }
            else
            {
                label_CreaturesRemoved.Text = "No creatures removed";
                label_GameobjectsRemoved.Text = "No gameobjects removed";
            }

            button_ImportFileForRemoving.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void checkBox_CreaturesRemover_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CreaturesRemover.Checked)
            {
                button_ImportFileForRemoving.Enabled = true;
            }
            else if (!checkBox_CreaturesRemover.Checked && !checkBox_GameobjectsRemover.Checked)
            {
                button_ImportFileForRemoving.Enabled = false;
            }
        }

        private void checkBox_GameobjectsRemover_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_GameobjectsRemover.Checked)
            {
                button_ImportFileForRemoving.Enabled = true;
            }
            else if (!checkBox_GameobjectsRemover.Checked && !checkBox_CreaturesRemover.Checked)
            {
                button_ImportFileForRemoving.Enabled = false;
            }
        }

        private void textBoxAreatriggerSplines_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AreatriggerSplineCreator.OpenFileDialog(openFileDialog);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AreatriggerSplineCreator.ParseSplinesForAreatrigger(openFileDialog.FileName, textBoxAreatriggerSplines.Text);
                }
            }
        }

        private void toolStripButton_WCLoadSniff_Click(object sender, EventArgs e)
        {
            waypointsCreator.OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                waypointsCreator.ImportStarted();

                if (IsTxtFileValidForParse(openFileDialog.FileName) &&
                    waypointsCreator.GetDataFromSniffFile(openFileDialog.FileName))
                {
                    waypointsCreator.ImportSuccessful();
                }
                else
                {
                    toolStripStatusLabel_CurrentAction.Text = "";
                    toolStripStatusLabel_FileStatus.Text = "No File Loaded";
                    toolStripButton_WC_LoadSniff.Enabled = true;
                    Cursor = Cursors.Default;
                }
            }
        }

        private void toolStripButton_WCSettings_Click(object sender, EventArgs e)
        {
            Form settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void toolStripButton_WCSearch_Click(object sender, EventArgs e)
        {
            waypointsCreator.FillListBoxWithGuids();
        }

        private void toolStripTextBox_WCSearch_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            waypointsCreator.FillListBoxWithGuids();
        }

        private void listBox_WCCreatureGuids_SelectedIndexChanged(object sender, EventArgs e)
        {
            waypointsCreator.FillWaypointsGrid();
        }

        private void createSQLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            waypointsCreator.CreateSQL();
        }

        private void removeExcessPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waypointsCreator.RemoveNearestPoints();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            waypointsCreator.CutFromGrid();
        }

        private void removeDuplicatePointsToolStripMenuItem_WC_Click(object sender, EventArgs e)
        {
            waypointsCreator.RemoveDuplicatePoints();
        }

        private void createReturnPathToolStripMenuItem_WC_Click(object sender, EventArgs e)
        {
            waypointsCreator.CreateReturnPath();
        }

        public void SetCurrentStatus(string status)
        {
            toolStripStatusLabel_CurrentAction.Text = "Current Status: " + status;
            Update();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            coreScriptTemplate.FillBoxWithHooks();
        }

        private void ListBox_CoreScriptTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_CoreScriptTemplates_Entry.Enabled = true;
            coreScriptTemplate.FillTreeWithHookBodies();
        }

        private void TextBox_CoreScriptTemplates_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (textBox_CoreScriptTemplates_Entry.Text == "" || textBox_CoreScriptTemplates_Entry.Text == "0")
                return;

            coreScriptTemplate.CreateTemplate();
        }

        private void TextBoxAchievements_Id_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (textBoxAchievements_Id.Text == "" || textBoxAchievements_Id.Text == "0")
                return;

            treeView_Achievements_ChildNodes.Nodes.Clear();
            treeView_Achievements_Criterias.Nodes.Clear();
            treeView_Achievements_ModifierTrees.Nodes.Clear();
            treeView_Achievements_ModifierTreeChildNodes.Nodes.Clear();
            AchievementsHandler.ShowAchievementRequirements(this);
        }

        private void TreeView_Achievements_ChildNodes_AfterExpand(object sender, TreeViewEventArgs e)
        {
            uint expandedNodesCount = 0;

            foreach (TreeNode node in treeView_Achievements_ChildNodes.Nodes)
            {
                if (node.IsExpanded)
                {
                    expandedNodesCount++;
                }
            }

            treeView_Achievements_Criterias.Nodes.Clear();
            AchievementsHandler.FillTreeWithCriterias(Convert.ToUInt32(e.Node.Text), treeView_Achievements_Criterias, expandedNodesCount > 1);
        }

        private void TreeView_Achievements_ChildNodes_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            treeView_Achievements_Criterias.Nodes.Clear();
            treeView_Achievements_ModifierTrees.Nodes.Clear();
            treeView_Achievements_ModifierTreeChildNodes.Nodes.Clear();
        }

        private void TreeView_Achievements_Criterias_AfterExpand(object sender, TreeViewEventArgs e)
        {
            uint expandedNodesCount = 0;

            foreach (TreeNode node in treeView_Achievements_Criterias.Nodes)
            {
                if (node.IsExpanded)
                {
                    expandedNodesCount++;
                }
            }

            treeView_Achievements_ModifierTrees.Nodes.Clear();
            AchievementsHandler.FillTreeWithModifiers(Convert.ToUInt32(e.Node.Text), treeView_Achievements_ModifierTrees, expandedNodesCount > 1);
        }

        private void TreeView_Achievements_Criterias_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            treeView_Achievements_ModifierTrees.Nodes.Clear();
            treeView_Achievements_ModifierTreeChildNodes.Nodes.Clear();
        }

        private void TreeView_Achievements_ModifierTrees_AfterExpand(object sender, TreeViewEventArgs e)
        {
            treeView_Achievements_ModifierTreeChildNodes.Nodes.Clear();
            AchievementsHandler.FillTreeWithModifiersChildNodes(Convert.ToUInt32(e.Node.Text), treeView_Achievements_ModifierTreeChildNodes);
        }

        private void TreeView_Achievements_ModifierTrees_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            treeView_Achievements_ModifierTreeChildNodes.Nodes.Clear();
        }

        private void SpellAuraScriptType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            spellAuraScriptCreatorDB.FillBoxWithHooks();
        }

        private void SpellAuraScript_ActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            spellAuraScriptCreatorDB.EnableLockedItems(true);
        }

        private void SpellAuraScript_Button_Add_Click(object sender, EventArgs e)
        {
            spellAuraScriptCreatorDB.AddScript();
        }

        private void SpellAuraScripts_GenerateSQL_Click(object sender, EventArgs e)
        {
            spellAuraScriptCreatorDB.GenerateSQL();
        }

        private void SpellInfo_Spell_Id_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                spellDBCOverrideCreatorDB.EnableLockedItems(false);
            }
        }

        private void SpellInfo_Value_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' && e.KeyChar != '-'))
                e.Handled = true;

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
                e.Handled = true;
        }

        private void SpellInfo_Spell_Id_TextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.SpellInfo_Spell_Id_TextBox.Text;
            bool isNumber = true;

            foreach (char c in text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }

            if (text.Length < 1)
                isNumber = false;

            this.spellDBCOverrideCreatorDB.EnableLockedItems(isNumber);
        }

        private void SpellIInfo_AddSpellOverride_Button_Click(object sender, EventArgs e)
        {
            if (!DBC.DBC.IsLoaded())
                DBC.DBC.Load();

            this.spellDBCOverrideCreatorDB.AddSpellInfoEntry();
        }

        private void SpellInfo_GenerateQuery_Button_Click(object sender, EventArgs e)
        {
            this.spellDBCOverrideCreatorDB.GenerateSQL();
        }

        private void SpellInfo_ClearSpellData_Button_Click(object sender, EventArgs e)
        {
            this.spellDBCOverrideCreatorDB.ClearSpellData();
        }

        private void SpellAuraScript_Clear_Button_Click(object sender, EventArgs e)
        {
            this.spellAuraScriptCreatorDB.ClearScriptData();
        }

        private void CombatAI_NpcEntry_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                this.combatAIScriptsCreatorDB.EnableLockedItems(false);
            }
        }

        private void CombatAI_GenerateSQL_Button_Click(object sender, EventArgs e)
        {
            this.combatAIScriptsCreatorDB.GenerateSQL();
        }

        private void CombatAI_NpcEntry_TextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.CombatAI_NpcEntry_TextBox.Text;
            bool isNumber = true;

            foreach (char c in text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }

            if (text.Length < 1)
                isNumber = false;

            this.combatAIScriptsCreatorDB.EnableLockedItems(isNumber);
        }

        private void CombatAI_Add_ScriptData_Button_Click(object sender, EventArgs e)
        {
            if (!DBC.DBC.IsLoaded())
                DBC.DBC.Load();

            this.combatAIScriptsCreatorDB.AddCombatAIData();
        }

        private void CombatAI_AttackDist_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void CombatAI_ClearData_Button_Click(object sender, EventArgs e)
        {
            this.combatAIScriptsCreatorDB.ClearCombatScriptData();
        }

        private void SpellAuraScript_SpellID_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                this.spellAuraScriptCreatorDB.EnableLockedItems(false);
            }
        }

        private void SpellInfo_Field_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spellDBCOverrideCreatorDB.FillValuesOptionListBox(this.SpellInfo_Field_ComboBox.SelectedIndex);
        }

        private void ObjectTemplateHelper_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ObjectTemplate_ObjectField_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.objectTemplateHelperDB.FillValuesOptionListBox(this.ObjectTemplate_ObjectField_ComboBox.SelectedIndex);
        }

        private void ObjectTemplateHelper_CheckInfo_Button_Click(object sender, EventArgs e)
        {
            this.objectTemplateHelperDB.CheckObjectInfo();
        }

        private void ObjectTemplateHelper_ObjEntry_TextBox_TextChanged(object sender, EventArgs e)
        {
            this.objectTemplateHelperDB.EnableLockedItems(false);
        }

        private void ObjectTemplateHelper_GenerateSQL_Button_Click(object sender, EventArgs e)
        {
            this.objectTemplateHelperDB.GenerateSQL();
        }

        private void ObjectTemplateHelper_UpdateField_Button_Click(object sender, EventArgs e)
        {
            this.objectTemplateHelperDB.UpdateObjFieldsFromList();
        }

        private void ObjectTemplateHelper_ObjType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.objectTemplateHelperDB.EnableLockedItems(false);
        }

        private void ObjectTemplate_Helper_ClearButton_Click(object sender, EventArgs e)
        {
            this.objectTemplateHelperDB.ClearObjectData();
        }

        private void JournalLoot_GenerateSQL_Click(object sender, EventArgs e)
        {
            this.journalLootCreatorDB.GenerateSQL();
        }

        private void tabJournalLootCreator_Enter(object sender, EventArgs e)
        {
            this.journalLootCreatorDB.FillInstanceComboBox();
        }

        private void CombatAI_SearchData_DB_Button_Click(object sender, EventArgs e)
        {
            this.combatAIScriptsCreatorDB.SearchCreatureScript();
        }

        private void CombatAI_SpellGrid_DataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.combatAIScriptsCreatorDB.CombatRowSelected(e.RowIndex);
        }

        private void CombatAI_UpdateRow_Button_Click(object sender, EventArgs e)
        {
            this.combatAIScriptsCreatorDB.UpdateRowSelected();
        }

        private void DungeonDataInfo_ImportFile_Button_Click(object sender, EventArgs e)
        {
            this.dungeonDataParser.OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dungeonDataParser.ImportAddonData(openFileDialog.FileName);
            }
        }

        private void DungeonDataInfo_Map_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dungeonDataParser.FillCreatureListBox(DungeonDataInfo_Map_ComboBox.SelectedIndex);
        }

        private void DungeonDataInfo_SpellTimer_Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.dungeonDataParser.SpellGridSelected(e.RowIndex);
        }

        private void DungeonDataInfo_Npc_CheckListBox_ItemCheck(object sender, EventArgs e)
        {
            this.dungeonDataParser.FillSpellGrid(DungeonDataInfo_Npc_CheckListBox.SelectedIndex);
        }

        private void DungeonDataInfo_CalcTimers_Button_Click(object sender, EventArgs e)
        {
            int rowIndex = DungeonDataInfo_SpellTimer_Grid.SelectedRows.Count > 0 ? DungeonDataInfo_SpellTimer_Grid.SelectedRows[0].Index : -1;
        }

        private void DungeonDataInfo_Add_Script_Button_Click(object sender, EventArgs e)
        {
            int rowIndex = DungeonDataInfo_SpellTimer_Grid.SelectedRows.Count > 0 ? DungeonDataInfo_SpellTimer_Grid.SelectedRows[0].Index : -1;
            this.dungeonDataParser.UpdateCombatEventEntry(rowIndex);
        }

        private void DungeonDataInfo_GenerateQueries_Button_Click(object sender, EventArgs e)
        {
            this.dungeonDataParser.GenerateSQL();
        }

        private void AreaTrigger_SpellId_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.areaTriggerActionCreator.EnableLockedItems(false);
            }
        }

        private void AreaTrigger_ClearData_Button_Click(object sender, EventArgs e)
        {
            this.areaTriggerActionCreator.ClearActionsData();
        }

        private void AreaTrigger_CreateAction_Button_Click(object sender, EventArgs e)
        {
            this.areaTriggerActionCreator.AddActionEntry();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.areaTriggerActionCreator.GenerateSQL();
        }

        private void AreaTriggerCreator_CheckTemplate_Button_Click(object sender, EventArgs e)
        {
            this.areaTriggerActionCreator.CheckAreaTriggerInfo();
        }

        private void JournalLoot_GenerateUpdateItemsDifficulty_Click(object sender, EventArgs e)
        {
            this.journalLootCreatorDB.GenerateUpdateItemQueries();
        }

        private void button_ClearConditions_Click(object sender, EventArgs e)
        {
            conditionsCreator.ClearConditions();
        }

        private void button_AddCondition_Click(object sender, EventArgs e)
        {
            if (comboBox_ConditionsCreator_ConditionSourceType.SelectedItem == null || comboBox_ConditionsCreator_ConditionType.SelectedItem == null)
                return;

            conditionsCreator.CreateCondition();
            textBox_ConditionsCreator_Output.Enabled = true;
        }

        private void comboBox_ConditionType_DropDown(object sender, EventArgs e)
        {
            if (comboBox_ConditionsCreator_ConditionType.Items.Count == 0)
            {
                comboBox_ConditionsCreator_ConditionType.Items.AddRange(Enum.GetNames(typeof(Conditions.ConditionTypes)));
            }
        }

        private void comboBox_ConditionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ConditionsCreator_ConditionSourceType.SelectedItem == null)
                return;

            conditionsCreator.ChangeTextBoxAccessibility(comboBox_ConditionsCreator_ConditionType.SelectedItem.ToString(), textBox_ConditionsCreator_ConditionValue1);
            conditionsCreator.ChangeTextBoxAccessibility(comboBox_ConditionsCreator_ConditionType.SelectedItem.ToString(), textBox_ConditionsCreator_ConditionValue2);
            conditionsCreator.ChangeTextBoxAccessibility(comboBox_ConditionsCreator_ConditionType.SelectedItem.ToString(), textBox_ConditionsCreator_ConditionValue3);
            conditionsCreator.ChangeTextBoxAccessibility(comboBox_ConditionsCreator_ConditionSourceType.SelectedItem.ToString(), textBox_ConditionsCreator_ConditionTarget);
            textBox_ConditionsCreator_NegativeCondition.Enabled = true;
            textBox_ConditionsCreator_ScriptName.Enabled = true;
            button_ConditionsCreator_AddCondition.Enabled = true;
            button_ConditionsCreator_ClearConditions.Enabled = true;
        }

        private void comboBox_ConditionSourceType_DropDown(object sender, EventArgs e)
        {
            if (comboBox_ConditionsCreator_ConditionSourceType.Items.Count == 0)
            {
                comboBox_ConditionsCreator_ConditionSourceType.Items.AddRange(Enum.GetNames(typeof(Conditions.ConditionSourceTypes)));
            }
        }

        private void comboBox_ConditionSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            conditionsCreator.ClearConditions();
            conditionsCreator.ChangeTextBoxAccessibility(comboBox_ConditionsCreator_ConditionSourceType.SelectedItem.ToString(), textBox_ConditionsCreator_SourceGroup);
            conditionsCreator.ChangeTextBoxAccessibility(comboBox_ConditionsCreator_ConditionSourceType.SelectedItem.ToString(), textBox_ConditionsCreator_SourceEntry);
            conditionsCreator.ChangeTextBoxAccessibility(comboBox_ConditionsCreator_ConditionSourceType.SelectedItem.ToString(), textBox_ConditionsCreator_SourceId);

            if (comboBox_ConditionsCreator_ConditionType.SelectedItem != null)
            {
                conditionsCreator.ChangeTextBoxAccessibility(comboBox_ConditionsCreator_ConditionSourceType.SelectedItem.ToString(), textBox_ConditionsCreator_ConditionTarget);
            }

            textBox_ConditionsCreator_ElseGroup.Enabled = true;
            comboBox_ConditionsCreator_ConditionType.Enabled = true;
        }
    }
}
