namespace WoWDeveloperAssistant
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SpellInfo_Tab = new System.Windows.Forms.TabControl();
            this.tabPage_CreatureScriptsCreator = new System.Windows.Forms.TabPage();
            this.checkBox_OnlyCombatSpells = new System.Windows.Forms.CheckBox();
            this.dataGridView_Spells = new System.Windows.Forms.DataGridView();
            this.SpellId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CastTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinCastStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxCastStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinCastRepeatTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxCastRepeatTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CastsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceSpell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_CSC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.createSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_CreatureGuids = new System.Windows.Forms.ListBox();
            this.toolStrip_CSC = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_CSC_ImportSniff = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_CSC_Search = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox_CSC_CreatureEntry = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel_CSC_CreatureEntry = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator_CSC = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage_WaypointsCreator = new System.Windows.Forms.TabPage();
            this.grid_WC_Waypoints = new System.Windows.Forms.DataGridView();
            this.gridColumn_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_PosX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_PosY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_PosZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_Orientation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_WCTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_WCDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_HasScript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaypointSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_WC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem_WC = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNearestPointsToolStripMenuItem_WC = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDuplicatePointsToolStripMenuItem_WC = new System.Windows.Forms.ToolStripMenuItem();
            this.createReturnPathToolStripMenuItem_WC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_WC = new System.Windows.Forms.ToolStripSeparator();
            this.createSQLToolStripMenuItem_WC = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_WC_CreatureGuids = new System.Windows.Forms.ListBox();
            this.chart_WC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip_WC = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_WC_Search = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox_WC_Entry = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel_WC_Entry = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_WC_Settings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_WC_LoadSniff = new System.Windows.Forms.ToolStripButton();
            this.tabPage_Output = new System.Windows.Forms.TabPage();
            this.textBox_SQLOutput = new System.Windows.Forms.TextBox();
            this.tabPage_DatabaseAdvisor = new System.Windows.Forms.TabPage();
            this.textBoxAreatriggerSplines = new System.Windows.Forms.TextBox();
            this.label_AreatriggerSplines = new System.Windows.Forms.Label();
            this.textBox_QuestFlags = new System.Windows.Forms.TextBox();
            this.label_QuestFlags = new System.Windows.Forms.Label();
            this.textBox_CreatureFlags = new System.Windows.Forms.TextBox();
            this.label_CreatureFlags = new System.Windows.Forms.Label();
            this.tabPage_DoubleSpawnsRemover = new System.Windows.Forms.TabPage();
            this.checkBox_DatabaseConsidering = new System.Windows.Forms.CheckBox();
            this.label_GameobjectsRemoved = new System.Windows.Forms.Label();
            this.checkBox_GameobjectsRemover = new System.Windows.Forms.CheckBox();
            this.checkBox_CreaturesRemover = new System.Windows.Forms.CheckBox();
            this.label_CreaturesRemoved = new System.Windows.Forms.Label();
            this.button_ImportFileForRemoving = new System.Windows.Forms.Button();
            this.coreScriptTemplates = new System.Windows.Forms.TabPage();
            this.treeView_CoreScriptTemplates_HookBodies = new System.Windows.Forms.TreeView();
            this.label_CoreScriptTemplates_ScriptType = new System.Windows.Forms.Label();
            this.comboBox_CoreScriptTemplates_ScriptType = new System.Windows.Forms.ComboBox();
            this.label_CoreScriptTemplates_Entry = new System.Windows.Forms.Label();
            this.textBox_CoreScriptTemplates_Entry = new System.Windows.Forms.TextBox();
            this.listBox_CoreScriptTemplates_Hooks = new System.Windows.Forms.ListBox();
            this.tabPage_Achievements = new System.Windows.Forms.TabPage();
            this.label_Achievements_ModifierTreeChildNodes = new System.Windows.Forms.Label();
            this.treeView_Achievements_ModifierTreeChildNodes = new System.Windows.Forms.TreeView();
            this.label_Achievements_ModifierTrees = new System.Windows.Forms.Label();
            this.treeView_Achievements_ModifierTrees = new System.Windows.Forms.TreeView();
            this.label_Achievements_Criterias = new System.Windows.Forms.Label();
            this.treeView_Achievements_Criterias = new System.Windows.Forms.TreeView();
            this.label_Achievements_CriteriaTree_Amount = new System.Windows.Forms.Label();
            this.label_Achievements_CreteriaThreeChilds = new System.Windows.Forms.Label();
            this.label_Achievement_CriteriaTree_Operator = new System.Windows.Forms.Label();
            this.label_Achievements_CriteriaTreeName = new System.Windows.Forms.Label();
            this.label_Achievements_CriteriaTreeId = new System.Windows.Forms.Label();
            this.label_Achievements_Flags = new System.Windows.Forms.Label();
            this.label_Achievements_Faction = new System.Windows.Forms.Label();
            this.treeView_Achievements_ChildNodes = new System.Windows.Forms.TreeView();
            this.label_Achievement_Name = new System.Windows.Forms.Label();
            this.textBoxAchievements_Id = new System.Windows.Forms.TextBox();
            this.label_Achievements_Id = new System.Windows.Forms.Label();
            this.tabAuraSpell_Creator = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ScriptType_Label = new System.Windows.Forms.Label();
            this.SpellAuraScripts_ActionTarget_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScript_Hooks_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScriptType_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScripts_GenerateSQL = new System.Windows.Forms.Button();
            this.SpellAuraScript_ActionComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScripts_ActionOrgCaster_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScripts_ActionCaster_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScript_Hook_Label = new System.Windows.Forms.Label();
            this.SpellAuraScript_SpellID_TextBox = new System.Windows.Forms.TextBox();
            this.SpellAura_ActionLabel = new System.Windows.Forms.Label();
            this.SpellAuraScriptSources_ComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SpellAuraScript_CalcType_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScript_EffIndex_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScript_SpellId_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SpellAuraScript_Button_Add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CalculationType_Label = new System.Windows.Forms.Label();
            this.SpellAuraScripts_ActionSpellId_TextBox = new System.Windows.Forms.TextBox();
            this.SpellAuraScript_Triggered_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpellAuraScripts_ActionSpellList_TextBox = new System.Windows.Forms.TextBox();
            this.ScriptHookAuraSpell_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SpellAuraScript_Clear_Button = new System.Windows.Forms.Button();
            this.SpellAuraScript_SQL_Out_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabSpellDBC_OverrideCreator = new System.Windows.Forms.TabPage();
            this.SpellInfo_Override_RichBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SpellInfo_ClearSpellData_Button = new System.Windows.Forms.Button();
            this.SpellInfo_EffIdx_Label = new System.Windows.Forms.Label();
            this.SpellInfo_Check_Data_Button = new System.Windows.Forms.Button();
            this.SpellInfo_Spell_Id_Field_Label = new System.Windows.Forms.Label();
            this.SpellInfo_Field_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellInfo_Spell_Id_Label = new System.Windows.Forms.Label();
            this.SpellInfo_Value_Label = new System.Windows.Forms.Label();
            this.SpellInfo_EffIdx_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellInfo_Value_TextBox = new System.Windows.Forms.TextBox();
            this.SpellInfo_Spell_Id_TextBox = new System.Windows.Forms.TextBox();
            this.SpellIInfo_AddSpellOverride_Button = new System.Windows.Forms.Button();
            this.SpellInfo_GenerateQuery_Button = new System.Windows.Forms.Button();
            this.tabCombatAI_Creator = new System.Windows.Forms.TabPage();
            this.CombatAICreatorSQL_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CombatAI_NpcEntry_TextBox = new System.Windows.Forms.TextBox();
            this.CombatAI_NpcEntry_Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CombatAI_InitMin_TextBox = new System.Windows.Forms.TextBox();
            this.CombatAI_InitMax_TextBox = new System.Windows.Forms.TextBox();
            this.CombatAI_RepeatMin_TextBox = new System.Windows.Forms.TextBox();
            this.CombatAI_RepeatMax_TextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CombatAI_RepeatMax_Label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CombatAI_EventType_ComboBox = new System.Windows.Forms.ComboBox();
            this.CombatAI_AttackDist_TextBox = new System.Windows.Forms.TextBox();
            this.CombatAI_Spell_Id_TextBox = new System.Windows.Forms.TextBox();
            this.CombatAI_Add_ScriptData_Button = new System.Windows.Forms.Button();
            this.CombatAI_GenerateSQL_Button = new System.Windows.Forms.Button();
            this.CombatAI_ClearData_Button = new System.Windows.Forms.Button();
            this.statusStrip_LoadedFile = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_FileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_CurrentAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CombatAI_EventFlags_CheckedBox = new System.Windows.Forms.CheckedListBox();
            this.SpellInfo_Tab.SuspendLayout();
            this.tabPage_CreatureScriptsCreator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spells)).BeginInit();
            this.contextMenuStrip_CSC.SuspendLayout();
            this.toolStrip_CSC.SuspendLayout();
            this.tabPage_WaypointsCreator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_WC_Waypoints)).BeginInit();
            this.contextMenuStrip_WC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_WC)).BeginInit();
            this.toolStrip_WC.SuspendLayout();
            this.tabPage_Output.SuspendLayout();
            this.tabPage_DatabaseAdvisor.SuspendLayout();
            this.tabPage_DoubleSpawnsRemover.SuspendLayout();
            this.coreScriptTemplates.SuspendLayout();
            this.tabPage_Achievements.SuspendLayout();
            this.tabAuraSpell_Creator.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabSpellDBC_OverrideCreator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabCombatAI_Creator.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.statusStrip_LoadedFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpellInfo_Tab
            // 
            this.SpellInfo_Tab.Controls.Add(this.tabPage_CreatureScriptsCreator);
            this.SpellInfo_Tab.Controls.Add(this.tabPage_WaypointsCreator);
            this.SpellInfo_Tab.Controls.Add(this.tabPage_Output);
            this.SpellInfo_Tab.Controls.Add(this.tabPage_DatabaseAdvisor);
            this.SpellInfo_Tab.Controls.Add(this.tabPage_DoubleSpawnsRemover);
            this.SpellInfo_Tab.Controls.Add(this.coreScriptTemplates);
            this.SpellInfo_Tab.Controls.Add(this.tabPage_Achievements);
            this.SpellInfo_Tab.Controls.Add(this.tabAuraSpell_Creator);
            this.SpellInfo_Tab.Controls.Add(this.tabSpellDBC_OverrideCreator);
            this.SpellInfo_Tab.Controls.Add(this.tabCombatAI_Creator);
            this.SpellInfo_Tab.Location = new System.Drawing.Point(2, 2);
            this.SpellInfo_Tab.Margin = new System.Windows.Forms.Padding(2);
            this.SpellInfo_Tab.Name = "SpellInfo_Tab";
            this.SpellInfo_Tab.SelectedIndex = 0;
            this.SpellInfo_Tab.Size = new System.Drawing.Size(1365, 642);
            this.SpellInfo_Tab.TabIndex = 1;
            // 
            // tabPage_CreatureScriptsCreator
            // 
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.checkBox_OnlyCombatSpells);
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.dataGridView_Spells);
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.listBox_CreatureGuids);
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.toolStrip_CSC);
            this.tabPage_CreatureScriptsCreator.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CreatureScriptsCreator.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_CreatureScriptsCreator.Name = "tabPage_CreatureScriptsCreator";
            this.tabPage_CreatureScriptsCreator.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_CreatureScriptsCreator.Size = new System.Drawing.Size(1357, 616);
            this.tabPage_CreatureScriptsCreator.TabIndex = 0;
            this.tabPage_CreatureScriptsCreator.Text = "Creature Scripts Creator";
            this.tabPage_CreatureScriptsCreator.UseVisualStyleBackColor = true;
            // 
            // checkBox_OnlyCombatSpells
            // 
            this.checkBox_OnlyCombatSpells.AutoSize = true;
            this.checkBox_OnlyCombatSpells.BackColor = System.Drawing.Color.LightGray;
            this.checkBox_OnlyCombatSpells.Checked = true;
            this.checkBox_OnlyCombatSpells.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_OnlyCombatSpells.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_OnlyCombatSpells.Location = new System.Drawing.Point(967, 5);
            this.checkBox_OnlyCombatSpells.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_OnlyCombatSpells.Name = "checkBox_OnlyCombatSpells";
            this.checkBox_OnlyCombatSpells.Size = new System.Drawing.Size(130, 19);
            this.checkBox_OnlyCombatSpells.TabIndex = 4;
            this.checkBox_OnlyCombatSpells.Text = "Only Combat Spells";
            this.checkBox_OnlyCombatSpells.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Spells
            // 
            this.dataGridView_Spells.AllowUserToAddRows = false;
            this.dataGridView_Spells.AllowUserToDeleteRows = false;
            this.dataGridView_Spells.AllowUserToOrderColumns = true;
            this.dataGridView_Spells.AllowUserToResizeColumns = false;
            this.dataGridView_Spells.AllowUserToResizeRows = false;
            this.dataGridView_Spells.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Spells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Spells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpellId,
            this.SpellName,
            this.CastTime,
            this.MinCastStartTime,
            this.MaxCastStartTime,
            this.MinCastRepeatTime,
            this.MaxCastRepeatTime,
            this.CastsCount,
            this.SourceSpell});
            this.dataGridView_Spells.ContextMenuStrip = this.contextMenuStrip_CSC;
            this.dataGridView_Spells.Enabled = false;
            this.dataGridView_Spells.Location = new System.Drawing.Point(507, 32);
            this.dataGridView_Spells.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Spells.Name = "dataGridView_Spells";
            this.dataGridView_Spells.RowHeadersWidth = 62;
            this.dataGridView_Spells.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Spells.RowTemplate.Height = 28;
            this.dataGridView_Spells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Spells.Size = new System.Drawing.Size(846, 576);
            this.dataGridView_Spells.TabIndex = 3;
            // 
            // SpellId
            // 
            this.SpellId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SpellId.DefaultCellStyle = dataGridViewCellStyle9;
            this.SpellId.HeaderText = "SpellId";
            this.SpellId.MaxInputLength = 10;
            this.SpellId.MinimumWidth = 8;
            this.SpellId.Name = "SpellId";
            this.SpellId.ReadOnly = true;
            this.SpellId.Width = 64;
            // 
            // SpellName
            // 
            this.SpellName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SpellName.DefaultCellStyle = dataGridViewCellStyle10;
            this.SpellName.HeaderText = "SpellName";
            this.SpellName.MaxInputLength = 50;
            this.SpellName.MinimumWidth = 8;
            this.SpellName.Name = "SpellName";
            this.SpellName.ReadOnly = true;
            this.SpellName.Width = 83;
            // 
            // CastTime
            // 
            this.CastTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CastTime.DefaultCellStyle = dataGridViewCellStyle19;
            this.CastTime.HeaderText = "CastTime";
            this.CastTime.MaxInputLength = 10;
            this.CastTime.MinimumWidth = 8;
            this.CastTime.Name = "CastTime";
            this.CastTime.ReadOnly = true;
            this.CastTime.Width = 76;
            // 
            // MinCastStartTime
            // 
            this.MinCastStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MinCastStartTime.DefaultCellStyle = dataGridViewCellStyle20;
            this.MinCastStartTime.HeaderText = "MinCastStartTime";
            this.MinCastStartTime.MaxInputLength = 10;
            this.MinCastStartTime.MinimumWidth = 8;
            this.MinCastStartTime.Name = "MinCastStartTime";
            this.MinCastStartTime.ReadOnly = true;
            this.MinCastStartTime.Width = 115;
            // 
            // MaxCastStartTime
            // 
            this.MaxCastStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxCastStartTime.DefaultCellStyle = dataGridViewCellStyle41;
            this.MaxCastStartTime.HeaderText = "MaxCastStartTime";
            this.MaxCastStartTime.MaxInputLength = 10;
            this.MaxCastStartTime.MinimumWidth = 8;
            this.MaxCastStartTime.Name = "MaxCastStartTime";
            this.MaxCastStartTime.ReadOnly = true;
            this.MaxCastStartTime.Width = 118;
            // 
            // MinCastRepeatTime
            // 
            this.MinCastRepeatTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MinCastRepeatTime.DefaultCellStyle = dataGridViewCellStyle42;
            this.MinCastRepeatTime.HeaderText = "MinCastRepeatTime";
            this.MinCastRepeatTime.MaxInputLength = 10;
            this.MinCastRepeatTime.MinimumWidth = 8;
            this.MinCastRepeatTime.Name = "MinCastRepeatTime";
            this.MinCastRepeatTime.ReadOnly = true;
            this.MinCastRepeatTime.Width = 128;
            // 
            // MaxCastRepeatTime
            // 
            this.MaxCastRepeatTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxCastRepeatTime.DefaultCellStyle = dataGridViewCellStyle43;
            this.MaxCastRepeatTime.HeaderText = "MaxCastRepeatTime";
            this.MaxCastRepeatTime.MaxInputLength = 10;
            this.MaxCastRepeatTime.MinimumWidth = 8;
            this.MaxCastRepeatTime.Name = "MaxCastRepeatTime";
            this.MaxCastRepeatTime.ReadOnly = true;
            this.MaxCastRepeatTime.Width = 131;
            // 
            // CastsCount
            // 
            this.CastsCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CastsCount.DefaultCellStyle = dataGridViewCellStyle44;
            this.CastsCount.HeaderText = "CastsCount";
            this.CastsCount.MaxInputLength = 4;
            this.CastsCount.MinimumWidth = 8;
            this.CastsCount.Name = "CastsCount";
            this.CastsCount.ReadOnly = true;
            this.CastsCount.Width = 86;
            // 
            // SourceSpell
            // 
            this.SourceSpell.HeaderText = "SourceSpell";
            this.SourceSpell.MinimumWidth = 8;
            this.SourceSpell.Name = "SourceSpell";
            this.SourceSpell.Visible = false;
            this.SourceSpell.Width = 150;
            // 
            // contextMenuStrip_CSC
            // 
            this.contextMenuStrip_CSC.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_CSC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.toolStripSeparator,
            this.createSQLToolStripMenuItem});
            this.contextMenuStrip_CSC.Name = "contextMenuStrip1";
            this.contextMenuStrip_CSC.Size = new System.Drawing.Size(133, 54);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(129, 6);
            // 
            // createSQLToolStripMenuItem
            // 
            this.createSQLToolStripMenuItem.Name = "createSQLToolStripMenuItem";
            this.createSQLToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.createSQLToolStripMenuItem.Text = "Create SQL";
            this.createSQLToolStripMenuItem.Click += new System.EventHandler(this.createSQLToolStripMenuItem_Click);
            // 
            // listBox_CreatureGuids
            // 
            this.listBox_CreatureGuids.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_CreatureGuids.Enabled = false;
            this.listBox_CreatureGuids.FormattingEnabled = true;
            this.listBox_CreatureGuids.Location = new System.Drawing.Point(5, 32);
            this.listBox_CreatureGuids.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_CreatureGuids.Name = "listBox_CreatureGuids";
            this.listBox_CreatureGuids.Size = new System.Drawing.Size(486, 576);
            this.listBox_CreatureGuids.TabIndex = 2;
            this.listBox_CreatureGuids.SelectedIndexChanged += new System.EventHandler(this.listBox_CreatureGuids_SelectedIndexChanged);
            // 
            // toolStrip_CSC
            // 
            this.toolStrip_CSC.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip_CSC.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_CSC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_CSC_ImportSniff,
            this.toolStripButton_CSC_Search,
            this.toolStripTextBox_CSC_CreatureEntry,
            this.toolStripLabel_CSC_CreatureEntry,
            this.toolStripSeparator_CSC});
            this.toolStrip_CSC.Location = new System.Drawing.Point(2, 2);
            this.toolStrip_CSC.Name = "toolStrip_CSC";
            this.toolStrip_CSC.Size = new System.Drawing.Size(1353, 27);
            this.toolStrip_CSC.TabIndex = 1;
            this.toolStrip_CSC.Text = "toolStrip_CreatureScriptsCreator";
            // 
            // toolStripButton_CSC_ImportSniff
            // 
            this.toolStripButton_CSC_ImportSniff.Image = global::WoWDeveloperAssistant.Properties.Resources.PIC_Import;
            this.toolStripButton_CSC_ImportSniff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CSC_ImportSniff.Name = "toolStripButton_CSC_ImportSniff";
            this.toolStripButton_CSC_ImportSniff.Size = new System.Drawing.Size(94, 24);
            this.toolStripButton_CSC_ImportSniff.Text = "Import Sniff";
            this.toolStripButton_CSC_ImportSniff.Click += new System.EventHandler(this.toolStripButton_ImportSniff_Click);
            // 
            // toolStripButton_CSC_Search
            // 
            this.toolStripButton_CSC_Search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_CSC_Search.Enabled = false;
            this.toolStripButton_CSC_Search.Image = global::WoWDeveloperAssistant.Properties.Resources.PIC_Search;
            this.toolStripButton_CSC_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CSC_Search.Name = "toolStripButton_CSC_Search";
            this.toolStripButton_CSC_Search.Size = new System.Drawing.Size(66, 24);
            this.toolStripButton_CSC_Search.Text = "Search";
            this.toolStripButton_CSC_Search.Click += new System.EventHandler(this.toolStripButton_Search_Click);
            // 
            // toolStripTextBox_CSC_CreatureEntry
            // 
            this.toolStripTextBox_CSC_CreatureEntry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox_CSC_CreatureEntry.Enabled = false;
            this.toolStripTextBox_CSC_CreatureEntry.MaxLength = 40;
            this.toolStripTextBox_CSC_CreatureEntry.Name = "toolStripTextBox_CSC_CreatureEntry";
            this.toolStripTextBox_CSC_CreatureEntry.Size = new System.Drawing.Size(68, 27);
            this.toolStripTextBox_CSC_CreatureEntry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_CSC_CreatureEntrySearch_Enter);
            // 
            // toolStripLabel_CSC_CreatureEntry
            // 
            this.toolStripLabel_CSC_CreatureEntry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_CSC_CreatureEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_CSC_CreatureEntry.Name = "toolStripLabel_CSC_CreatureEntry";
            this.toolStripLabel_CSC_CreatureEntry.Size = new System.Drawing.Size(123, 24);
            this.toolStripLabel_CSC_CreatureEntry.Text = "Creature EntryOrGuid:";
            // 
            // toolStripSeparator_CSC
            // 
            this.toolStripSeparator_CSC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator_CSC.Name = "toolStripSeparator_CSC";
            this.toolStripSeparator_CSC.Size = new System.Drawing.Size(6, 27);
            // 
            // tabPage_WaypointsCreator
            // 
            this.tabPage_WaypointsCreator.Controls.Add(this.grid_WC_Waypoints);
            this.tabPage_WaypointsCreator.Controls.Add(this.listBox_WC_CreatureGuids);
            this.tabPage_WaypointsCreator.Controls.Add(this.chart_WC);
            this.tabPage_WaypointsCreator.Controls.Add(this.toolStrip_WC);
            this.tabPage_WaypointsCreator.Location = new System.Drawing.Point(4, 22);
            this.tabPage_WaypointsCreator.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_WaypointsCreator.Name = "tabPage_WaypointsCreator";
            this.tabPage_WaypointsCreator.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_WaypointsCreator.Size = new System.Drawing.Size(1357, 616);
            this.tabPage_WaypointsCreator.TabIndex = 4;
            this.tabPage_WaypointsCreator.Text = "Waypoints Creator";
            this.tabPage_WaypointsCreator.UseVisualStyleBackColor = true;
            // 
            // grid_WC_Waypoints
            // 
            this.grid_WC_Waypoints.AllowUserToAddRows = false;
            this.grid_WC_Waypoints.AllowUserToDeleteRows = false;
            this.grid_WC_Waypoints.AllowUserToResizeColumns = false;
            this.grid_WC_Waypoints.AllowUserToResizeRows = false;
            dataGridViewCellStyle45.NullValue = null;
            this.grid_WC_Waypoints.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.grid_WC_Waypoints.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.NullValue = null;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_WC_Waypoints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.grid_WC_Waypoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_WC_Waypoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumn_Id,
            this.gridColumn_PosX,
            this.gridColumn_PosY,
            this.gridColumn_PosZ,
            this.gridColumn_Orientation,
            this.gridColumn_WCTime,
            this.gridColumn_WCDelay,
            this.gridColumn_HasScript,
            this.WaypointSource});
            this.grid_WC_Waypoints.ContextMenuStrip = this.contextMenuStrip_WC;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle55.NullValue = null;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_WC_Waypoints.DefaultCellStyle = dataGridViewCellStyle55;
            this.grid_WC_Waypoints.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_WC_Waypoints.Enabled = false;
            this.grid_WC_Waypoints.Location = new System.Drawing.Point(849, 32);
            this.grid_WC_Waypoints.Name = "grid_WC_Waypoints";
            this.grid_WC_Waypoints.RowHeadersWidth = 62;
            this.grid_WC_Waypoints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_WC_Waypoints.RowsDefaultCellStyle = dataGridViewCellStyle56;
            this.grid_WC_Waypoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_WC_Waypoints.Size = new System.Drawing.Size(506, 576);
            this.grid_WC_Waypoints.TabIndex = 28;
            this.grid_WC_Waypoints.TabStop = false;
            // 
            // gridColumn_Id
            // 
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_Id.DefaultCellStyle = dataGridViewCellStyle47;
            this.gridColumn_Id.HeaderText = "Id";
            this.gridColumn_Id.MinimumWidth = 8;
            this.gridColumn_Id.Name = "gridColumn_Id";
            this.gridColumn_Id.ReadOnly = true;
            this.gridColumn_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gridColumn_Id.Width = 35;
            // 
            // gridColumn_PosX
            // 
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle48.NullValue = null;
            this.gridColumn_PosX.DefaultCellStyle = dataGridViewCellStyle48;
            this.gridColumn_PosX.HeaderText = "PosX";
            this.gridColumn_PosX.MinimumWidth = 8;
            this.gridColumn_PosX.Name = "gridColumn_PosX";
            this.gridColumn_PosX.ReadOnly = true;
            this.gridColumn_PosX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_PosX.Width = 60;
            // 
            // gridColumn_PosY
            // 
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle49.NullValue = null;
            this.gridColumn_PosY.DefaultCellStyle = dataGridViewCellStyle49;
            this.gridColumn_PosY.HeaderText = "PosY";
            this.gridColumn_PosY.MinimumWidth = 8;
            this.gridColumn_PosY.Name = "gridColumn_PosY";
            this.gridColumn_PosY.ReadOnly = true;
            this.gridColumn_PosY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_PosY.Width = 60;
            // 
            // gridColumn_PosZ
            // 
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_PosZ.DefaultCellStyle = dataGridViewCellStyle50;
            this.gridColumn_PosZ.HeaderText = "PosZ";
            this.gridColumn_PosZ.MinimumWidth = 8;
            this.gridColumn_PosZ.Name = "gridColumn_PosZ";
            this.gridColumn_PosZ.ReadOnly = true;
            this.gridColumn_PosZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_PosZ.Width = 60;
            // 
            // gridColumn_Orientation
            // 
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_Orientation.DefaultCellStyle = dataGridViewCellStyle51;
            this.gridColumn_Orientation.HeaderText = "Orientation";
            this.gridColumn_Orientation.MinimumWidth = 8;
            this.gridColumn_Orientation.Name = "gridColumn_Orientation";
            this.gridColumn_Orientation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_Orientation.Width = 65;
            // 
            // gridColumn_WCTime
            // 
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_WCTime.DefaultCellStyle = dataGridViewCellStyle52;
            this.gridColumn_WCTime.HeaderText = "Time";
            this.gridColumn_WCTime.MinimumWidth = 8;
            this.gridColumn_WCTime.Name = "gridColumn_WCTime";
            this.gridColumn_WCTime.ReadOnly = true;
            this.gridColumn_WCTime.Width = 60;
            // 
            // gridColumn_WCDelay
            // 
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_WCDelay.DefaultCellStyle = dataGridViewCellStyle53;
            this.gridColumn_WCDelay.HeaderText = "Delay";
            this.gridColumn_WCDelay.MinimumWidth = 8;
            this.gridColumn_WCDelay.Name = "gridColumn_WCDelay";
            this.gridColumn_WCDelay.Width = 50;
            // 
            // gridColumn_HasScript
            // 
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_HasScript.DefaultCellStyle = dataGridViewCellStyle54;
            this.gridColumn_HasScript.HeaderText = "HasScript";
            this.gridColumn_HasScript.MinimumWidth = 8;
            this.gridColumn_HasScript.Name = "gridColumn_HasScript";
            this.gridColumn_HasScript.ReadOnly = true;
            this.gridColumn_HasScript.Width = 60;
            // 
            // WaypointSource
            // 
            this.WaypointSource.HeaderText = "WaypointSource";
            this.WaypointSource.MinimumWidth = 8;
            this.WaypointSource.Name = "WaypointSource";
            this.WaypointSource.Visible = false;
            this.WaypointSource.Width = 150;
            // 
            // contextMenuStrip_WC
            // 
            this.contextMenuStrip_WC.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_WC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem_WC,
            this.removeNearestPointsToolStripMenuItem_WC,
            this.removeDuplicatePointsToolStripMenuItem_WC,
            this.createReturnPathToolStripMenuItem_WC,
            this.toolStripSeparator_WC,
            this.createSQLToolStripMenuItem_WC});
            this.contextMenuStrip_WC.Name = "contextMenuStrip_WC";
            this.contextMenuStrip_WC.Size = new System.Drawing.Size(206, 120);
            // 
            // cutToolStripMenuItem_WC
            // 
            this.cutToolStripMenuItem_WC.Name = "cutToolStripMenuItem_WC";
            this.cutToolStripMenuItem_WC.Size = new System.Drawing.Size(205, 22);
            this.cutToolStripMenuItem_WC.Text = "Cut";
            this.cutToolStripMenuItem_WC.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // removeNearestPointsToolStripMenuItem_WC
            // 
            this.removeNearestPointsToolStripMenuItem_WC.Name = "removeNearestPointsToolStripMenuItem_WC";
            this.removeNearestPointsToolStripMenuItem_WC.Size = new System.Drawing.Size(205, 22);
            this.removeNearestPointsToolStripMenuItem_WC.Text = "Remove nearest points";
            this.removeNearestPointsToolStripMenuItem_WC.Click += new System.EventHandler(this.removeExcessPointsToolStripMenuItem_Click);
            // 
            // removeDuplicatePointsToolStripMenuItem_WC
            // 
            this.removeDuplicatePointsToolStripMenuItem_WC.Name = "removeDuplicatePointsToolStripMenuItem_WC";
            this.removeDuplicatePointsToolStripMenuItem_WC.Size = new System.Drawing.Size(205, 22);
            this.removeDuplicatePointsToolStripMenuItem_WC.Text = "Remove duplicate points";
            this.removeDuplicatePointsToolStripMenuItem_WC.Click += new System.EventHandler(this.removeDuplicatePointsToolStripMenuItem_WC_Click);
            // 
            // createReturnPathToolStripMenuItem_WC
            // 
            this.createReturnPathToolStripMenuItem_WC.Name = "createReturnPathToolStripMenuItem_WC";
            this.createReturnPathToolStripMenuItem_WC.Size = new System.Drawing.Size(205, 22);
            this.createReturnPathToolStripMenuItem_WC.Text = "Create return path";
            this.createReturnPathToolStripMenuItem_WC.Click += new System.EventHandler(this.createReturnPathToolStripMenuItem_WC_Click);
            // 
            // toolStripSeparator_WC
            // 
            this.toolStripSeparator_WC.Name = "toolStripSeparator_WC";
            this.toolStripSeparator_WC.Size = new System.Drawing.Size(202, 6);
            // 
            // createSQLToolStripMenuItem_WC
            // 
            this.createSQLToolStripMenuItem_WC.Name = "createSQLToolStripMenuItem_WC";
            this.createSQLToolStripMenuItem_WC.Size = new System.Drawing.Size(205, 22);
            this.createSQLToolStripMenuItem_WC.Text = "Create SQL";
            this.createSQLToolStripMenuItem_WC.Click += new System.EventHandler(this.createSQLToolStripMenuItem1_Click);
            // 
            // listBox_WC_CreatureGuids
            // 
            this.listBox_WC_CreatureGuids.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_WC_CreatureGuids.Enabled = false;
            this.listBox_WC_CreatureGuids.FormattingEnabled = true;
            this.listBox_WC_CreatureGuids.Location = new System.Drawing.Point(604, 32);
            this.listBox_WC_CreatureGuids.Name = "listBox_WC_CreatureGuids";
            this.listBox_WC_CreatureGuids.Size = new System.Drawing.Size(239, 576);
            this.listBox_WC_CreatureGuids.TabIndex = 27;
            this.listBox_WC_CreatureGuids.SelectedIndexChanged += new System.EventHandler(this.listBox_WCCreatureGuids_SelectedIndexChanged);
            // 
            // chart_WC
            // 
            this.chart_WC.BorderlineWidth = 0;
            this.chart_WC.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_WC.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart_WC.BorderSkin.BorderWidth = 0;
            chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea3.AxisX.IsReversed = true;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea3.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea3.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX2.MajorGrid.Enabled = false;
            chartArea3.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX2.MajorTickMark.Enabled = false;
            chartArea3.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.LabelStyle.Enabled = false;
            chartArea3.AxisY.LabelStyle.IsEndLabelVisible = false;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea3.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY2.MajorGrid.Enabled = false;
            chartArea3.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY2.MajorTickMark.Enabled = false;
            chartArea3.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.CursorX.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea3.CursorY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.CursorY.IsUserEnabled = true;
            chartArea3.CursorY.IsUserSelectionEnabled = true;
            chartArea3.CursorY.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea3.Name = "ChartArea1";
            this.chart_WC.ChartAreas.Add(chartArea3);
            this.chart_WC.Enabled = false;
            legend3.Enabled = false;
            legend3.ForeColor = System.Drawing.Color.Transparent;
            legend3.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend3.Name = "Legend1";
            legend3.TitleForeColor = System.Drawing.Color.Transparent;
            legend3.TitleSeparatorColor = System.Drawing.Color.Transparent;
            this.chart_WC.Legends.Add(legend3);
            this.chart_WC.Location = new System.Drawing.Point(3, 32);
            this.chart_WC.Name = "chart_WC";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Path";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_WC.Series.Add(series3);
            this.chart_WC.Size = new System.Drawing.Size(596, 577);
            this.chart_WC.TabIndex = 26;
            this.chart_WC.Text = "Waypoints";
            title3.DockedToChartArea = "ChartArea1";
            title3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Path";
            title3.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.chart_WC.Titles.Add(title3);
            // 
            // toolStrip_WC
            // 
            this.toolStrip_WC.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip_WC.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_WC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_WC_Search,
            this.toolStripTextBox_WC_Entry,
            this.toolStripLabel_WC_Entry,
            this.toolStripSeparator1,
            this.toolStripButton_WC_Settings,
            this.toolStripButton_WC_LoadSniff});
            this.toolStrip_WC.Location = new System.Drawing.Point(2, 2);
            this.toolStrip_WC.Name = "toolStrip_WC";
            this.toolStrip_WC.Size = new System.Drawing.Size(1353, 27);
            this.toolStrip_WC.TabIndex = 24;
            this.toolStrip_WC.Text = "toolStrip_WC";
            // 
            // toolStripButton_WC_Search
            // 
            this.toolStripButton_WC_Search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_WC_Search.Enabled = false;
            this.toolStripButton_WC_Search.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_WC_Search.Image")));
            this.toolStripButton_WC_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_WC_Search.Name = "toolStripButton_WC_Search";
            this.toolStripButton_WC_Search.Size = new System.Drawing.Size(66, 24);
            this.toolStripButton_WC_Search.Text = "Search";
            this.toolStripButton_WC_Search.ToolTipText = "Fill listbox with guids of\r\nselected entry or all entries.";
            this.toolStripButton_WC_Search.Click += new System.EventHandler(this.toolStripButton_WCSearch_Click);
            // 
            // toolStripTextBox_WC_Entry
            // 
            this.toolStripTextBox_WC_Entry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox_WC_Entry.Enabled = false;
            this.toolStripTextBox_WC_Entry.MaxLength = 40;
            this.toolStripTextBox_WC_Entry.Name = "toolStripTextBox_WC_Entry";
            this.toolStripTextBox_WC_Entry.Size = new System.Drawing.Size(70, 27);
            this.toolStripTextBox_WC_Entry.Tag = "";
            this.toolStripTextBox_WC_Entry.ToolTipText = "Input entry of creature or leave\r\nblank to fill listbox will all in sniff.";
            this.toolStripTextBox_WC_Entry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_WCSearch_Enter);
            // 
            // toolStripLabel_WC_Entry
            // 
            this.toolStripLabel_WC_Entry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_WC_Entry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_WC_Entry.Name = "toolStripLabel_WC_Entry";
            this.toolStripLabel_WC_Entry.Size = new System.Drawing.Size(123, 24);
            this.toolStripLabel_WC_Entry.Text = "Creature EntryOrGuid:";
            this.toolStripLabel_WC_Entry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_WC_Settings
            // 
            this.toolStripButton_WC_Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_WC_Settings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_WC_Settings.Image")));
            this.toolStripButton_WC_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_WC_Settings.Name = "toolStripButton_WC_Settings";
            this.toolStripButton_WC_Settings.Size = new System.Drawing.Size(73, 24);
            this.toolStripButton_WC_Settings.Text = "Settings";
            this.toolStripButton_WC_Settings.ToolTipText = "Setup chart and output SQL.";
            this.toolStripButton_WC_Settings.Click += new System.EventHandler(this.toolStripButton_WCSettings_Click);
            // 
            // toolStripButton_WC_LoadSniff
            // 
            this.toolStripButton_WC_LoadSniff.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_WC_LoadSniff.Image")));
            this.toolStripButton_WC_LoadSniff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_WC_LoadSniff.Name = "toolStripButton_WC_LoadSniff";
            this.toolStripButton_WC_LoadSniff.Size = new System.Drawing.Size(94, 24);
            this.toolStripButton_WC_LoadSniff.Text = "Import Sniff";
            this.toolStripButton_WC_LoadSniff.ToolTipText = "Import a parsed wpp sniff file.";
            this.toolStripButton_WC_LoadSniff.Click += new System.EventHandler(this.toolStripButton_WCLoadSniff_Click);
            // 
            // tabPage_Output
            // 
            this.tabPage_Output.Controls.Add(this.textBox_SQLOutput);
            this.tabPage_Output.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Output.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Output.Name = "tabPage_Output";
            this.tabPage_Output.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Output.Size = new System.Drawing.Size(1357, 616);
            this.tabPage_Output.TabIndex = 1;
            this.tabPage_Output.Text = "SQL Output";
            this.tabPage_Output.UseVisualStyleBackColor = true;
            // 
            // textBox_SQLOutput
            // 
            this.textBox_SQLOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SQLOutput.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.textBox_SQLOutput.Location = new System.Drawing.Point(2, 2);
            this.textBox_SQLOutput.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SQLOutput.Multiline = true;
            this.textBox_SQLOutput.Name = "textBox_SQLOutput";
            this.textBox_SQLOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_SQLOutput.Size = new System.Drawing.Size(1353, 612);
            this.textBox_SQLOutput.TabIndex = 0;
            this.textBox_SQLOutput.WordWrap = false;
            // 
            // tabPage_DatabaseAdvisor
            // 
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBoxAreatriggerSplines);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.label_AreatriggerSplines);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBox_QuestFlags);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.label_QuestFlags);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBox_CreatureFlags);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.label_CreatureFlags);
            this.tabPage_DatabaseAdvisor.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DatabaseAdvisor.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_DatabaseAdvisor.Name = "tabPage_DatabaseAdvisor";
            this.tabPage_DatabaseAdvisor.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_DatabaseAdvisor.Size = new System.Drawing.Size(1357, 616);
            this.tabPage_DatabaseAdvisor.TabIndex = 2;
            this.tabPage_DatabaseAdvisor.Text = "Database Advisor";
            this.tabPage_DatabaseAdvisor.UseVisualStyleBackColor = true;
            // 
            // textBoxAreatriggerSplines
            // 
            this.textBoxAreatriggerSplines.Location = new System.Drawing.Point(5, 93);
            this.textBoxAreatriggerSplines.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAreatriggerSplines.Name = "textBoxAreatriggerSplines";
            this.textBoxAreatriggerSplines.Size = new System.Drawing.Size(94, 20);
            this.textBoxAreatriggerSplines.TabIndex = 5;
            this.textBoxAreatriggerSplines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAreatriggerSplines_KeyDown);
            // 
            // label_AreatriggerSplines
            // 
            this.label_AreatriggerSplines.AutoSize = true;
            this.label_AreatriggerSplines.Location = new System.Drawing.Point(2, 76);
            this.label_AreatriggerSplines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AreatriggerSplines.Name = "label_AreatriggerSplines";
            this.label_AreatriggerSplines.Size = new System.Drawing.Size(95, 13);
            this.label_AreatriggerSplines.TabIndex = 4;
            this.label_AreatriggerSplines.Text = "Areatrigger Splines";
            // 
            // textBox_QuestFlags
            // 
            this.textBox_QuestFlags.Location = new System.Drawing.Point(5, 55);
            this.textBox_QuestFlags.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_QuestFlags.Name = "textBox_QuestFlags";
            this.textBox_QuestFlags.Size = new System.Drawing.Size(62, 20);
            this.textBox_QuestFlags.TabIndex = 3;
            this.textBox_QuestFlags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_QuestFlags_KeyDown);
            // 
            // label_QuestFlags
            // 
            this.label_QuestFlags.AutoSize = true;
            this.label_QuestFlags.Location = new System.Drawing.Point(4, 39);
            this.label_QuestFlags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_QuestFlags.Name = "label_QuestFlags";
            this.label_QuestFlags.Size = new System.Drawing.Size(63, 13);
            this.label_QuestFlags.TabIndex = 2;
            this.label_QuestFlags.Text = "Quest Flags";
            // 
            // textBox_CreatureFlags
            // 
            this.textBox_CreatureFlags.Location = new System.Drawing.Point(5, 18);
            this.textBox_CreatureFlags.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_CreatureFlags.Name = "textBox_CreatureFlags";
            this.textBox_CreatureFlags.Size = new System.Drawing.Size(76, 20);
            this.textBox_CreatureFlags.TabIndex = 1;
            this.textBox_CreatureFlags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_CreatureFlags_KeyDown);
            // 
            // label_CreatureFlags
            // 
            this.label_CreatureFlags.AutoSize = true;
            this.label_CreatureFlags.Location = new System.Drawing.Point(3, 2);
            this.label_CreatureFlags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CreatureFlags.Name = "label_CreatureFlags";
            this.label_CreatureFlags.Size = new System.Drawing.Size(75, 13);
            this.label_CreatureFlags.TabIndex = 0;
            this.label_CreatureFlags.Text = "Creature Flags";
            // 
            // tabPage_DoubleSpawnsRemover
            // 
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.checkBox_DatabaseConsidering);
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.label_GameobjectsRemoved);
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.checkBox_GameobjectsRemover);
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.checkBox_CreaturesRemover);
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.label_CreaturesRemoved);
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.button_ImportFileForRemoving);
            this.tabPage_DoubleSpawnsRemover.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DoubleSpawnsRemover.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_DoubleSpawnsRemover.Name = "tabPage_DoubleSpawnsRemover";
            this.tabPage_DoubleSpawnsRemover.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_DoubleSpawnsRemover.Size = new System.Drawing.Size(1357, 616);
            this.tabPage_DoubleSpawnsRemover.TabIndex = 3;
            this.tabPage_DoubleSpawnsRemover.Text = "Double-Spawns Remover";
            this.tabPage_DoubleSpawnsRemover.UseVisualStyleBackColor = true;
            // 
            // checkBox_DatabaseConsidering
            // 
            this.checkBox_DatabaseConsidering.AutoSize = true;
            this.checkBox_DatabaseConsidering.Checked = true;
            this.checkBox_DatabaseConsidering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DatabaseConsidering.Location = new System.Drawing.Point(482, 50);
            this.checkBox_DatabaseConsidering.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_DatabaseConsidering.Name = "checkBox_DatabaseConsidering";
            this.checkBox_DatabaseConsidering.Size = new System.Drawing.Size(128, 17);
            this.checkBox_DatabaseConsidering.TabIndex = 5;
            this.checkBox_DatabaseConsidering.Text = "Considering database";
            this.checkBox_DatabaseConsidering.UseVisualStyleBackColor = true;
            // 
            // label_GameobjectsRemoved
            // 
            this.label_GameobjectsRemoved.AutoSize = true;
            this.label_GameobjectsRemoved.Location = new System.Drawing.Point(329, 86);
            this.label_GameobjectsRemoved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_GameobjectsRemoved.Name = "label_GameobjectsRemoved";
            this.label_GameobjectsRemoved.Size = new System.Drawing.Size(128, 13);
            this.label_GameobjectsRemoved.TabIndex = 4;
            this.label_GameobjectsRemoved.Text = "No gameobjects removed";
            this.label_GameobjectsRemoved.Visible = false;
            // 
            // checkBox_GameobjectsRemover
            // 
            this.checkBox_GameobjectsRemover.AutoSize = true;
            this.checkBox_GameobjectsRemover.Checked = true;
            this.checkBox_GameobjectsRemover.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_GameobjectsRemover.Location = new System.Drawing.Point(535, 3);
            this.checkBox_GameobjectsRemover.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_GameobjectsRemover.Name = "checkBox_GameobjectsRemover";
            this.checkBox_GameobjectsRemover.Size = new System.Drawing.Size(88, 17);
            this.checkBox_GameobjectsRemover.TabIndex = 3;
            this.checkBox_GameobjectsRemover.Text = "Gameobjects";
            this.checkBox_GameobjectsRemover.UseVisualStyleBackColor = true;
            this.checkBox_GameobjectsRemover.CheckedChanged += new System.EventHandler(this.checkBox_GameobjectsRemover_CheckedChanged);
            // 
            // checkBox_CreaturesRemover
            // 
            this.checkBox_CreaturesRemover.AutoSize = true;
            this.checkBox_CreaturesRemover.Checked = true;
            this.checkBox_CreaturesRemover.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CreaturesRemover.Location = new System.Drawing.Point(466, 3);
            this.checkBox_CreaturesRemover.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_CreaturesRemover.Name = "checkBox_CreaturesRemover";
            this.checkBox_CreaturesRemover.Size = new System.Drawing.Size(71, 17);
            this.checkBox_CreaturesRemover.TabIndex = 2;
            this.checkBox_CreaturesRemover.Text = "Creatures";
            this.checkBox_CreaturesRemover.UseVisualStyleBackColor = true;
            this.checkBox_CreaturesRemover.CheckedChanged += new System.EventHandler(this.checkBox_CreaturesRemover_CheckedChanged);
            // 
            // label_CreaturesRemoved
            // 
            this.label_CreaturesRemoved.AutoSize = true;
            this.label_CreaturesRemoved.Location = new System.Drawing.Point(329, 73);
            this.label_CreaturesRemoved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CreaturesRemoved.Name = "label_CreaturesRemoved";
            this.label_CreaturesRemoved.Size = new System.Drawing.Size(112, 13);
            this.label_CreaturesRemoved.TabIndex = 1;
            this.label_CreaturesRemoved.Text = "No creatures removed";
            this.label_CreaturesRemoved.Visible = false;
            // 
            // button_ImportFileForRemoving
            // 
            this.button_ImportFileForRemoving.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ImportFileForRemoving.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_ImportFileForRemoving.FlatAppearance.BorderSize = 5;
            this.button_ImportFileForRemoving.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ImportFileForRemoving.Location = new System.Drawing.Point(466, 19);
            this.button_ImportFileForRemoving.Margin = new System.Windows.Forms.Padding(2);
            this.button_ImportFileForRemoving.Name = "button_ImportFileForRemoving";
            this.button_ImportFileForRemoving.Size = new System.Drawing.Size(147, 28);
            this.button_ImportFileForRemoving.TabIndex = 0;
            this.button_ImportFileForRemoving.Text = "Import File";
            this.button_ImportFileForRemoving.UseVisualStyleBackColor = true;
            this.button_ImportFileForRemoving.Click += new System.EventHandler(this.button_ImportFile_Click);
            // 
            // coreScriptTemplates
            // 
            this.coreScriptTemplates.Controls.Add(this.treeView_CoreScriptTemplates_HookBodies);
            this.coreScriptTemplates.Controls.Add(this.label_CoreScriptTemplates_ScriptType);
            this.coreScriptTemplates.Controls.Add(this.comboBox_CoreScriptTemplates_ScriptType);
            this.coreScriptTemplates.Controls.Add(this.label_CoreScriptTemplates_Entry);
            this.coreScriptTemplates.Controls.Add(this.textBox_CoreScriptTemplates_Entry);
            this.coreScriptTemplates.Controls.Add(this.listBox_CoreScriptTemplates_Hooks);
            this.coreScriptTemplates.Location = new System.Drawing.Point(4, 22);
            this.coreScriptTemplates.Margin = new System.Windows.Forms.Padding(2);
            this.coreScriptTemplates.Name = "coreScriptTemplates";
            this.coreScriptTemplates.Padding = new System.Windows.Forms.Padding(2);
            this.coreScriptTemplates.Size = new System.Drawing.Size(1357, 616);
            this.coreScriptTemplates.TabIndex = 5;
            this.coreScriptTemplates.Text = "Core Script Templates";
            this.coreScriptTemplates.UseVisualStyleBackColor = true;
            // 
            // treeView_CoreScriptTemplates_HookBodies
            // 
            this.treeView_CoreScriptTemplates_HookBodies.CheckBoxes = true;
            this.treeView_CoreScriptTemplates_HookBodies.Location = new System.Drawing.Point(161, 32);
            this.treeView_CoreScriptTemplates_HookBodies.Margin = new System.Windows.Forms.Padding(2);
            this.treeView_CoreScriptTemplates_HookBodies.Name = "treeView_CoreScriptTemplates_HookBodies";
            this.treeView_CoreScriptTemplates_HookBodies.Size = new System.Drawing.Size(168, 576);
            this.treeView_CoreScriptTemplates_HookBodies.TabIndex = 6;
            // 
            // label_CoreScriptTemplates_ScriptType
            // 
            this.label_CoreScriptTemplates_ScriptType.AutoSize = true;
            this.label_CoreScriptTemplates_ScriptType.Location = new System.Drawing.Point(4, 8);
            this.label_CoreScriptTemplates_ScriptType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CoreScriptTemplates_ScriptType.Name = "label_CoreScriptTemplates_ScriptType";
            this.label_CoreScriptTemplates_ScriptType.Size = new System.Drawing.Size(64, 13);
            this.label_CoreScriptTemplates_ScriptType.TabIndex = 5;
            this.label_CoreScriptTemplates_ScriptType.Text = "Script Type:";
            // 
            // comboBox_CoreScriptTemplates_ScriptType
            // 
            this.comboBox_CoreScriptTemplates_ScriptType.Items.AddRange(new object[] {
            "Creature",
            "GameObject",
            "AreaTrigger",
            "Spell",
            "PlayerScript",
            "Aura",
            "BossScript"});
            this.comboBox_CoreScriptTemplates_ScriptType.Location = new System.Drawing.Point(69, 6);
            this.comboBox_CoreScriptTemplates_ScriptType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_CoreScriptTemplates_ScriptType.Name = "comboBox_CoreScriptTemplates_ScriptType";
            this.comboBox_CoreScriptTemplates_ScriptType.Size = new System.Drawing.Size(82, 21);
            this.comboBox_CoreScriptTemplates_ScriptType.TabIndex = 1;
            this.comboBox_CoreScriptTemplates_ScriptType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label_CoreScriptTemplates_Entry
            // 
            this.label_CoreScriptTemplates_Entry.AutoSize = true;
            this.label_CoreScriptTemplates_Entry.Location = new System.Drawing.Point(176, 8);
            this.label_CoreScriptTemplates_Entry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CoreScriptTemplates_Entry.Name = "label_CoreScriptTemplates_Entry";
            this.label_CoreScriptTemplates_Entry.Size = new System.Drawing.Size(81, 13);
            this.label_CoreScriptTemplates_Entry.TabIndex = 4;
            this.label_CoreScriptTemplates_Entry.Text = "Enter Object Id:";
            // 
            // textBox_CoreScriptTemplates_Entry
            // 
            this.textBox_CoreScriptTemplates_Entry.Enabled = false;
            this.textBox_CoreScriptTemplates_Entry.Location = new System.Drawing.Point(260, 6);
            this.textBox_CoreScriptTemplates_Entry.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_CoreScriptTemplates_Entry.MaxLength = 6;
            this.textBox_CoreScriptTemplates_Entry.Name = "textBox_CoreScriptTemplates_Entry";
            this.textBox_CoreScriptTemplates_Entry.Size = new System.Drawing.Size(48, 20);
            this.textBox_CoreScriptTemplates_Entry.TabIndex = 2;
            this.textBox_CoreScriptTemplates_Entry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CoreScriptTemplates_Enter);
            // 
            // listBox_CoreScriptTemplates_Hooks
            // 
            this.listBox_CoreScriptTemplates_Hooks.Location = new System.Drawing.Point(5, 32);
            this.listBox_CoreScriptTemplates_Hooks.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_CoreScriptTemplates_Hooks.Name = "listBox_CoreScriptTemplates_Hooks";
            this.listBox_CoreScriptTemplates_Hooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_CoreScriptTemplates_Hooks.Size = new System.Drawing.Size(146, 576);
            this.listBox_CoreScriptTemplates_Hooks.TabIndex = 0;
            this.listBox_CoreScriptTemplates_Hooks.SelectedIndexChanged += new System.EventHandler(this.ListBox_CoreScriptTemplates_SelectedIndexChanged);
            // 
            // tabPage_Achievements
            // 
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_ModifierTreeChildNodes);
            this.tabPage_Achievements.Controls.Add(this.treeView_Achievements_ModifierTreeChildNodes);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_ModifierTrees);
            this.tabPage_Achievements.Controls.Add(this.treeView_Achievements_ModifierTrees);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_Criterias);
            this.tabPage_Achievements.Controls.Add(this.treeView_Achievements_Criterias);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_CriteriaTree_Amount);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_CreteriaThreeChilds);
            this.tabPage_Achievements.Controls.Add(this.label_Achievement_CriteriaTree_Operator);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_CriteriaTreeName);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_CriteriaTreeId);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_Flags);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_Faction);
            this.tabPage_Achievements.Controls.Add(this.treeView_Achievements_ChildNodes);
            this.tabPage_Achievements.Controls.Add(this.label_Achievement_Name);
            this.tabPage_Achievements.Controls.Add(this.textBoxAchievements_Id);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_Id);
            this.tabPage_Achievements.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Achievements.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Achievements.Name = "tabPage_Achievements";
            this.tabPage_Achievements.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Achievements.Size = new System.Drawing.Size(1357, 616);
            this.tabPage_Achievements.TabIndex = 6;
            this.tabPage_Achievements.Text = "Achievements";
            this.tabPage_Achievements.UseVisualStyleBackColor = true;
            // 
            // label_Achievements_ModifierTreeChildNodes
            // 
            this.label_Achievements_ModifierTreeChildNodes.AutoSize = true;
            this.label_Achievements_ModifierTreeChildNodes.Location = new System.Drawing.Point(1118, 146);
            this.label_Achievements_ModifierTreeChildNodes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievements_ModifierTreeChildNodes.Name = "label_Achievements_ModifierTreeChildNodes";
            this.label_Achievements_ModifierTreeChildNodes.Size = new System.Drawing.Size(132, 13);
            this.label_Achievements_ModifierTreeChildNodes.TabIndex = 16;
            this.label_Achievements_ModifierTreeChildNodes.Text = "Modifier Tree Child Nodes:";
            // 
            // treeView_Achievements_ModifierTreeChildNodes
            // 
            this.treeView_Achievements_ModifierTreeChildNodes.Location = new System.Drawing.Point(1016, 163);
            this.treeView_Achievements_ModifierTreeChildNodes.Margin = new System.Windows.Forms.Padding(2);
            this.treeView_Achievements_ModifierTreeChildNodes.Name = "treeView_Achievements_ModifierTreeChildNodes";
            this.treeView_Achievements_ModifierTreeChildNodes.Size = new System.Drawing.Size(335, 444);
            this.treeView_Achievements_ModifierTreeChildNodes.TabIndex = 15;
            // 
            // label_Achievements_ModifierTrees
            // 
            this.label_Achievements_ModifierTrees.AutoSize = true;
            this.label_Achievements_ModifierTrees.Location = new System.Drawing.Point(807, 147);
            this.label_Achievements_ModifierTrees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievements_ModifierTrees.Name = "label_Achievements_ModifierTrees";
            this.label_Achievements_ModifierTrees.Size = new System.Drawing.Size(77, 13);
            this.label_Achievements_ModifierTrees.TabIndex = 14;
            this.label_Achievements_ModifierTrees.Text = "Modifier Trees:";
            // 
            // treeView_Achievements_ModifierTrees
            // 
            this.treeView_Achievements_ModifierTrees.Location = new System.Drawing.Point(678, 163);
            this.treeView_Achievements_ModifierTrees.Margin = new System.Windows.Forms.Padding(2);
            this.treeView_Achievements_ModifierTrees.Name = "treeView_Achievements_ModifierTrees";
            this.treeView_Achievements_ModifierTrees.Size = new System.Drawing.Size(335, 444);
            this.treeView_Achievements_ModifierTrees.TabIndex = 13;
            this.treeView_Achievements_ModifierTrees.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ModifierTrees_AfterCollapse);
            this.treeView_Achievements_ModifierTrees.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ModifierTrees_AfterExpand);
            // 
            // label_Achievements_Criterias
            // 
            this.label_Achievements_Criterias.AutoSize = true;
            this.label_Achievements_Criterias.Location = new System.Drawing.Point(484, 146);
            this.label_Achievements_Criterias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievements_Criterias.Name = "label_Achievements_Criterias";
            this.label_Achievements_Criterias.Size = new System.Drawing.Size(47, 13);
            this.label_Achievements_Criterias.TabIndex = 12;
            this.label_Achievements_Criterias.Text = "Criterias:";
            // 
            // treeView_Achievements_Criterias
            // 
            this.treeView_Achievements_Criterias.Location = new System.Drawing.Point(340, 163);
            this.treeView_Achievements_Criterias.Margin = new System.Windows.Forms.Padding(2);
            this.treeView_Achievements_Criterias.Name = "treeView_Achievements_Criterias";
            this.treeView_Achievements_Criterias.Size = new System.Drawing.Size(335, 444);
            this.treeView_Achievements_Criterias.TabIndex = 11;
            this.treeView_Achievements_Criterias.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_Criterias_AfterCollapse);
            this.treeView_Achievements_Criterias.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_Criterias_AfterExpand);
            // 
            // label_Achievements_CriteriaTree_Amount
            // 
            this.label_Achievements_CriteriaTree_Amount.AutoSize = true;
            this.label_Achievements_CriteriaTree_Amount.Location = new System.Drawing.Point(4, 110);
            this.label_Achievements_CriteriaTree_Amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievements_CriteriaTree_Amount.Name = "label_Achievements_CriteriaTree_Amount";
            this.label_Achievements_CriteriaTree_Amount.Size = new System.Drawing.Size(106, 13);
            this.label_Achievements_CriteriaTree_Amount.TabIndex = 10;
            this.label_Achievements_CriteriaTree_Amount.Text = "CriteriaTree Amount: ";
            // 
            // label_Achievements_CreteriaThreeChilds
            // 
            this.label_Achievements_CreteriaThreeChilds.AutoSize = true;
            this.label_Achievements_CreteriaThreeChilds.Location = new System.Drawing.Point(107, 148);
            this.label_Achievements_CreteriaThreeChilds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievements_CreteriaThreeChilds.Name = "label_Achievements_CreteriaThreeChilds";
            this.label_Achievements_CreteriaThreeChilds.Size = new System.Drawing.Size(127, 13);
            this.label_Achievements_CreteriaThreeChilds.TabIndex = 9;
            this.label_Achievements_CreteriaThreeChilds.Text = "Criteria Tree Child Nodes:";
            // 
            // label_Achievement_CriteriaTree_Operator
            // 
            this.label_Achievement_CriteriaTree_Operator.AutoSize = true;
            this.label_Achievement_CriteriaTree_Operator.Location = new System.Drawing.Point(4, 127);
            this.label_Achievement_CriteriaTree_Operator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievement_CriteriaTree_Operator.Name = "label_Achievement_CriteriaTree_Operator";
            this.label_Achievement_CriteriaTree_Operator.Size = new System.Drawing.Size(111, 13);
            this.label_Achievement_CriteriaTree_Operator.TabIndex = 8;
            this.label_Achievement_CriteriaTree_Operator.Text = "CriteriaTree Operator: ";
            // 
            // label_Achievements_CriteriaTreeName
            // 
            this.label_Achievements_CriteriaTreeName.AutoSize = true;
            this.label_Achievements_CriteriaTreeName.Location = new System.Drawing.Point(3, 94);
            this.label_Achievements_CriteriaTreeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievements_CriteriaTreeName.Name = "label_Achievements_CriteriaTreeName";
            this.label_Achievements_CriteriaTreeName.Size = new System.Drawing.Size(98, 13);
            this.label_Achievements_CriteriaTreeName.TabIndex = 7;
            this.label_Achievements_CriteriaTreeName.Text = "CriteriaTree Name: ";
            // 
            // label_Achievements_CriteriaTreeId
            // 
            this.label_Achievements_CriteriaTreeId.AutoSize = true;
            this.label_Achievements_CriteriaTreeId.Location = new System.Drawing.Point(4, 78);
            this.label_Achievements_CriteriaTreeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievements_CriteriaTreeId.Name = "label_Achievements_CriteriaTreeId";
            this.label_Achievements_CriteriaTreeId.Size = new System.Drawing.Size(79, 13);
            this.label_Achievements_CriteriaTreeId.TabIndex = 6;
            this.label_Achievements_CriteriaTreeId.Text = "CriteriaTree Id: ";
            // 
            // label_Achievements_Flags
            // 
            this.label_Achievements_Flags.AutoSize = true;
            this.label_Achievements_Flags.Location = new System.Drawing.Point(4, 55);
            this.label_Achievements_Flags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievements_Flags.Name = "label_Achievements_Flags";
            this.label_Achievements_Flags.Size = new System.Drawing.Size(103, 13);
            this.label_Achievements_Flags.TabIndex = 5;
            this.label_Achievements_Flags.Text = "Achievement Flags: ";
            // 
            // label_Achievements_Faction
            // 
            this.label_Achievements_Faction.AutoSize = true;
            this.label_Achievements_Faction.Location = new System.Drawing.Point(3, 39);
            this.label_Achievements_Faction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievements_Faction.Name = "label_Achievements_Faction";
            this.label_Achievements_Faction.Size = new System.Drawing.Size(113, 13);
            this.label_Achievements_Faction.TabIndex = 4;
            this.label_Achievements_Faction.Text = "Achievement Faction: ";
            // 
            // treeView_Achievements_ChildNodes
            // 
            this.treeView_Achievements_ChildNodes.Location = new System.Drawing.Point(3, 163);
            this.treeView_Achievements_ChildNodes.Margin = new System.Windows.Forms.Padding(2);
            this.treeView_Achievements_ChildNodes.Name = "treeView_Achievements_ChildNodes";
            this.treeView_Achievements_ChildNodes.Size = new System.Drawing.Size(335, 444);
            this.treeView_Achievements_ChildNodes.TabIndex = 3;
            this.treeView_Achievements_ChildNodes.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ChildNodes_AfterCollapse);
            this.treeView_Achievements_ChildNodes.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ChildNodes_AfterExpand);
            // 
            // label_Achievement_Name
            // 
            this.label_Achievement_Name.AutoSize = true;
            this.label_Achievement_Name.Location = new System.Drawing.Point(3, 23);
            this.label_Achievement_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievement_Name.Name = "label_Achievement_Name";
            this.label_Achievement_Name.Size = new System.Drawing.Size(106, 13);
            this.label_Achievement_Name.TabIndex = 2;
            this.label_Achievement_Name.Text = "Achievement Name: ";
            // 
            // textBoxAchievements_Id
            // 
            this.textBoxAchievements_Id.Location = new System.Drawing.Point(87, 2);
            this.textBoxAchievements_Id.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAchievements_Id.Name = "textBoxAchievements_Id";
            this.textBoxAchievements_Id.Size = new System.Drawing.Size(68, 20);
            this.textBoxAchievements_Id.TabIndex = 1;
            this.textBoxAchievements_Id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAchievements_Id_KeyUp);
            // 
            // label_Achievements_Id
            // 
            this.label_Achievements_Id.AutoSize = true;
            this.label_Achievements_Id.Location = new System.Drawing.Point(3, 5);
            this.label_Achievements_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Achievements_Id.Name = "label_Achievements_Id";
            this.label_Achievements_Id.Size = new System.Drawing.Size(84, 13);
            this.label_Achievements_Id.TabIndex = 0;
            this.label_Achievements_Id.Text = "Achievement Id:";
            // 
            // tabAuraSpell_Creator
            // 
            this.tabAuraSpell_Creator.Controls.Add(this.tableLayoutPanel2);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_SQL_Out_RichTextBox);
            this.tabAuraSpell_Creator.Controls.Add(this.label5);
            this.tabAuraSpell_Creator.Location = new System.Drawing.Point(4, 22);
            this.tabAuraSpell_Creator.Name = "tabAuraSpell_Creator";
            this.tabAuraSpell_Creator.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuraSpell_Creator.Size = new System.Drawing.Size(1357, 616);
            this.tabAuraSpell_Creator.TabIndex = 7;
            this.tabAuraSpell_Creator.Text = "SpellAuraScript Creator";
            this.tabAuraSpell_Creator.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ScriptType_Label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScripts_ActionTarget_ComboBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScript_Hooks_ComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScriptType_ComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScripts_GenerateSQL, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScript_ActionComboBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScripts_ActionOrgCaster_ComboBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScripts_ActionCaster_ComboBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScript_Hook_Label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScript_SpellID_TextBox, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.SpellAura_ActionLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScriptSources_ComboBox, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScript_CalcType_ComboBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScript_EffIndex_ComboBox, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScript_SpellId_Label, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScript_Button_Add, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.CalculationType_Label, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScripts_ActionSpellId_TextBox, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScript_Triggered_ComboBox, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScripts_ActionSpellList_TextBox, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.ScriptHookAuraSpell_Label, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.SpellAuraScript_Clear_Button, 0, 14);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 15;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 433);
            this.tableLayoutPanel2.TabIndex = 52;
            // 
            // ScriptType_Label
            // 
            this.ScriptType_Label.AutoSize = true;
            this.ScriptType_Label.Location = new System.Drawing.Point(2, 0);
            this.ScriptType_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScriptType_Label.Name = "ScriptType_Label";
            this.ScriptType_Label.Size = new System.Drawing.Size(64, 13);
            this.ScriptType_Label.TabIndex = 11;
            this.ScriptType_Label.Text = "Script Type:";
            // 
            // SpellAuraScripts_ActionTarget_ComboBox
            // 
            this.SpellAuraScripts_ActionTarget_ComboBox.Enabled = false;
            this.SpellAuraScripts_ActionTarget_ComboBox.Items.AddRange(new object[] {
            "Caster",
            "Target",
            "HitUnit",
            "ProcActor",
            "ProcTarget"});
            this.SpellAuraScripts_ActionTarget_ComboBox.Location = new System.Drawing.Point(99, 102);
            this.SpellAuraScripts_ActionTarget_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScripts_ActionTarget_ComboBox.Name = "SpellAuraScripts_ActionTarget_ComboBox";
            this.SpellAuraScripts_ActionTarget_ComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpellAuraScripts_ActionTarget_ComboBox.TabIndex = 50;
            // 
            // SpellAuraScript_Hooks_ComboBox
            // 
            this.SpellAuraScript_Hooks_ComboBox.Location = new System.Drawing.Point(99, 27);
            this.SpellAuraScript_Hooks_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScript_Hooks_ComboBox.Name = "SpellAuraScript_Hooks_ComboBox";
            this.SpellAuraScript_Hooks_ComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpellAuraScript_Hooks_ComboBox.TabIndex = 42;
            // 
            // SpellAuraScriptType_ComboBox
            // 
            this.SpellAuraScriptType_ComboBox.Items.AddRange(new object[] {
            "SpellScript",
            "AuraScript"});
            this.SpellAuraScriptType_ComboBox.Location = new System.Drawing.Point(99, 2);
            this.SpellAuraScriptType_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScriptType_ComboBox.Name = "SpellAuraScriptType_ComboBox";
            this.SpellAuraScriptType_ComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpellAuraScriptType_ComboBox.TabIndex = 8;
            this.SpellAuraScriptType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.SpellAuraScriptType_ComboBox_SelectedIndexChanged);
            // 
            // SpellAuraScripts_GenerateSQL
            // 
            this.SpellAuraScripts_GenerateSQL.Location = new System.Drawing.Point(99, 324);
            this.SpellAuraScripts_GenerateSQL.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScripts_GenerateSQL.Name = "SpellAuraScripts_GenerateSQL";
            this.SpellAuraScripts_GenerateSQL.Size = new System.Drawing.Size(93, 19);
            this.SpellAuraScripts_GenerateSQL.TabIndex = 51;
            this.SpellAuraScripts_GenerateSQL.Text = "Generate SQL";
            this.SpellAuraScripts_GenerateSQL.UseVisualStyleBackColor = true;
            this.SpellAuraScripts_GenerateSQL.Click += new System.EventHandler(this.SpellAuraScripts_GenerateSQL_Click);
            // 
            // SpellAuraScript_ActionComboBox
            // 
            this.SpellAuraScript_ActionComboBox.Location = new System.Drawing.Point(99, 52);
            this.SpellAuraScript_ActionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScript_ActionComboBox.Name = "SpellAuraScript_ActionComboBox";
            this.SpellAuraScript_ActionComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpellAuraScript_ActionComboBox.TabIndex = 39;
            this.SpellAuraScript_ActionComboBox.SelectedIndexChanged += new System.EventHandler(this.SpellAuraScript_ActionComboBox_SelectedIndexChanged);
            // 
            // SpellAuraScripts_ActionOrgCaster_ComboBox
            // 
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.Enabled = false;
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.Items.AddRange(new object[] {
            "Caster",
            "Target",
            "HitUnit",
            "ProcActor",
            "ProcTarget"});
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.Location = new System.Drawing.Point(99, 127);
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.Name = "SpellAuraScripts_ActionOrgCaster_ComboBox";
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.TabIndex = 49;
            // 
            // SpellAuraScripts_ActionCaster_ComboBox
            // 
            this.SpellAuraScripts_ActionCaster_ComboBox.Enabled = false;
            this.SpellAuraScripts_ActionCaster_ComboBox.Items.AddRange(new object[] {
            "Caster",
            "Target",
            "HitUnit",
            "ProcActor",
            "ProcTarget"});
            this.SpellAuraScripts_ActionCaster_ComboBox.Location = new System.Drawing.Point(99, 77);
            this.SpellAuraScripts_ActionCaster_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScripts_ActionCaster_ComboBox.Name = "SpellAuraScripts_ActionCaster_ComboBox";
            this.SpellAuraScripts_ActionCaster_ComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpellAuraScripts_ActionCaster_ComboBox.TabIndex = 37;
            // 
            // SpellAuraScript_Hook_Label
            // 
            this.SpellAuraScript_Hook_Label.AutoSize = true;
            this.SpellAuraScript_Hook_Label.Location = new System.Drawing.Point(2, 25);
            this.SpellAuraScript_Hook_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpellAuraScript_Hook_Label.Name = "SpellAuraScript_Hook_Label";
            this.SpellAuraScript_Hook_Label.Size = new System.Drawing.Size(41, 13);
            this.SpellAuraScript_Hook_Label.TabIndex = 41;
            this.SpellAuraScript_Hook_Label.Text = "Hooks:";
            // 
            // SpellAuraScript_SpellID_TextBox
            // 
            this.SpellAuraScript_SpellID_TextBox.Location = new System.Drawing.Point(99, 300);
            this.SpellAuraScript_SpellID_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScript_SpellID_TextBox.MaxLength = 6;
            this.SpellAuraScript_SpellID_TextBox.Name = "SpellAuraScript_SpellID_TextBox";
            this.SpellAuraScript_SpellID_TextBox.Size = new System.Drawing.Size(108, 20);
            this.SpellAuraScript_SpellID_TextBox.TabIndex = 45;
            // 
            // SpellAura_ActionLabel
            // 
            this.SpellAura_ActionLabel.AutoSize = true;
            this.SpellAura_ActionLabel.Location = new System.Drawing.Point(2, 50);
            this.SpellAura_ActionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpellAura_ActionLabel.Name = "SpellAura_ActionLabel";
            this.SpellAura_ActionLabel.Size = new System.Drawing.Size(40, 13);
            this.SpellAura_ActionLabel.TabIndex = 17;
            this.SpellAura_ActionLabel.Text = "Action:";
            // 
            // SpellAuraScriptSources_ComboBox
            // 
            this.SpellAuraScriptSources_ComboBox.Enabled = false;
            this.SpellAuraScriptSources_ComboBox.Items.AddRange(new object[] {
            "SourceSpellInfo",
            "SourceSpellAura"});
            this.SpellAuraScriptSources_ComboBox.Location = new System.Drawing.Point(99, 202);
            this.SpellAuraScriptSources_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScriptSources_ComboBox.Name = "SpellAuraScriptSources_ComboBox";
            this.SpellAuraScriptSources_ComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpellAuraScriptSources_ComboBox.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "ActionCaster:";
            // 
            // SpellAuraScript_CalcType_ComboBox
            // 
            this.SpellAuraScript_CalcType_ComboBox.Enabled = false;
            this.SpellAuraScript_CalcType_ComboBox.Items.AddRange(new object[] {
            "TypeCalcPct",
            "TypeAddPct",
            "TypeRemovePct",
            "TypeAddFlat",
            "TypeRemoveFlat"});
            this.SpellAuraScript_CalcType_ComboBox.Location = new System.Drawing.Point(99, 152);
            this.SpellAuraScript_CalcType_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScript_CalcType_ComboBox.Name = "SpellAuraScript_CalcType_ComboBox";
            this.SpellAuraScript_CalcType_ComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpellAuraScript_CalcType_ComboBox.TabIndex = 33;
            // 
            // SpellAuraScript_EffIndex_ComboBox
            // 
            this.SpellAuraScript_EffIndex_ComboBox.Enabled = false;
            this.SpellAuraScript_EffIndex_ComboBox.Items.AddRange(new object[] {
            "EFFECT_0,",
            "EFFECT_1,",
            "EFFECT_2,",
            "EFFECT_3,",
            "EFFECT_4,",
            "EFFECT_5,",
            "EFFECT_6,",
            "EFFECT_7,",
            "EFFECT_8,",
            "EFFECT_9,",
            "EFFECT_10,",
            "EFFECT_11,",
            "EFFECT_12,",
            "EFFECT_13,",
            "EFFECT_14,",
            "EFFECT_15,",
            "EFFECT_16,",
            "EFFECT_17,",
            "EFFECT_18,",
            "EFFECT_19,",
            "EFFECT_20,",
            "EFFECT_21,",
            "EFFECT_22,",
            "EFFECT_23,",
            "EFFECT_24,",
            "EFFECT_25,",
            "EFFECT_26,",
            "EFFECT_27,",
            "EFFECT_28,",
            "EFFECT_29,",
            "EFFECT_30,",
            "EFFECT_31,"});
            this.SpellAuraScript_EffIndex_ComboBox.Location = new System.Drawing.Point(99, 177);
            this.SpellAuraScript_EffIndex_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScript_EffIndex_ComboBox.Name = "SpellAuraScript_EffIndex_ComboBox";
            this.SpellAuraScript_EffIndex_ComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpellAuraScript_EffIndex_ComboBox.TabIndex = 35;
            // 
            // SpellAuraScript_SpellId_Label
            // 
            this.SpellAuraScript_SpellId_Label.AutoSize = true;
            this.SpellAuraScript_SpellId_Label.Location = new System.Drawing.Point(2, 298);
            this.SpellAuraScript_SpellId_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpellAuraScript_SpellId_Label.Name = "SpellAuraScript_SpellId_Label";
            this.SpellAuraScript_SpellId_Label.Size = new System.Drawing.Size(47, 13);
            this.SpellAuraScript_SpellId_Label.TabIndex = 46;
            this.SpellAuraScript_SpellId_Label.Text = "Spell ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "ActionOrgCaster:";
            // 
            // SpellAuraScript_Button_Add
            // 
            this.SpellAuraScript_Button_Add.Enabled = false;
            this.SpellAuraScript_Button_Add.Location = new System.Drawing.Point(2, 324);
            this.SpellAuraScript_Button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScript_Button_Add.Name = "SpellAuraScript_Button_Add";
            this.SpellAuraScript_Button_Add.Size = new System.Drawing.Size(93, 19);
            this.SpellAuraScript_Button_Add.TabIndex = 43;
            this.SpellAuraScript_Button_Add.Text = "Add Script";
            this.SpellAuraScript_Button_Add.UseVisualStyleBackColor = true;
            this.SpellAuraScript_Button_Add.Click += new System.EventHandler(this.SpellAuraScript_Button_Add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "ActionTarget:";
            // 
            // CalculationType_Label
            // 
            this.CalculationType_Label.AutoSize = true;
            this.CalculationType_Label.Location = new System.Drawing.Point(2, 150);
            this.CalculationType_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CalculationType_Label.Name = "CalculationType_Label";
            this.CalculationType_Label.Size = new System.Drawing.Size(86, 13);
            this.CalculationType_Label.TabIndex = 34;
            this.CalculationType_Label.Text = "CalculationType:";
            // 
            // SpellAuraScripts_ActionSpellId_TextBox
            // 
            this.SpellAuraScripts_ActionSpellId_TextBox.Enabled = false;
            this.SpellAuraScripts_ActionSpellId_TextBox.Location = new System.Drawing.Point(99, 227);
            this.SpellAuraScripts_ActionSpellId_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScripts_ActionSpellId_TextBox.MaxLength = 6;
            this.SpellAuraScripts_ActionSpellId_TextBox.Name = "SpellAuraScripts_ActionSpellId_TextBox";
            this.SpellAuraScripts_ActionSpellId_TextBox.Size = new System.Drawing.Size(108, 20);
            this.SpellAuraScripts_ActionSpellId_TextBox.TabIndex = 25;
            // 
            // SpellAuraScript_Triggered_ComboBox
            // 
            this.SpellAuraScript_Triggered_ComboBox.Enabled = false;
            this.SpellAuraScript_Triggered_ComboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.SpellAuraScript_Triggered_ComboBox.Location = new System.Drawing.Point(99, 251);
            this.SpellAuraScript_Triggered_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScript_Triggered_ComboBox.Name = "SpellAuraScript_Triggered_ComboBox";
            this.SpellAuraScript_Triggered_ComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpellAuraScript_Triggered_ComboBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "EffectIndex";
            // 
            // SpellAuraScripts_ActionSpellList_TextBox
            // 
            this.SpellAuraScripts_ActionSpellList_TextBox.Enabled = false;
            this.SpellAuraScripts_ActionSpellList_TextBox.Location = new System.Drawing.Point(99, 276);
            this.SpellAuraScripts_ActionSpellList_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScripts_ActionSpellList_TextBox.MaxLength = 6;
            this.SpellAuraScripts_ActionSpellList_TextBox.Name = "SpellAuraScripts_ActionSpellList_TextBox";
            this.SpellAuraScripts_ActionSpellList_TextBox.Size = new System.Drawing.Size(108, 20);
            this.SpellAuraScripts_ActionSpellList_TextBox.TabIndex = 30;
            // 
            // ScriptHookAuraSpell_Label
            // 
            this.ScriptHookAuraSpell_Label.AutoSize = true;
            this.ScriptHookAuraSpell_Label.Location = new System.Drawing.Point(2, 200);
            this.ScriptHookAuraSpell_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScriptHookAuraSpell_Label.Name = "ScriptHookAuraSpell_Label";
            this.ScriptHookAuraSpell_Label.Size = new System.Drawing.Size(72, 13);
            this.ScriptHookAuraSpell_Label.TabIndex = 10;
            this.ScriptHookAuraSpell_Label.Text = "DataSources:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Action Spell ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Triggered:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "ActionSpellList:";
            // 
            // SpellAuraScript_Clear_Button
            // 
            this.SpellAuraScript_Clear_Button.Location = new System.Drawing.Point(2, 347);
            this.SpellAuraScript_Clear_Button.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScript_Clear_Button.Name = "SpellAuraScript_Clear_Button";
            this.SpellAuraScript_Clear_Button.Size = new System.Drawing.Size(93, 19);
            this.SpellAuraScript_Clear_Button.TabIndex = 52;
            this.SpellAuraScript_Clear_Button.Text = "Clear Script Data";
            this.SpellAuraScript_Clear_Button.UseVisualStyleBackColor = true;
            this.SpellAuraScript_Clear_Button.Click += new System.EventHandler(this.SpellAuraScript_Clear_Button_Click);
            // 
            // SpellAuraScript_SQL_Out_RichTextBox
            // 
            this.SpellAuraScript_SQL_Out_RichTextBox.Location = new System.Drawing.Point(287, 20);
            this.SpellAuraScript_SQL_Out_RichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellAuraScript_SQL_Out_RichTextBox.Name = "SpellAuraScript_SQL_Out_RichTextBox";
            this.SpellAuraScript_SQL_Out_RichTextBox.Size = new System.Drawing.Size(842, 500);
            this.SpellAuraScript_SQL_Out_RichTextBox.TabIndex = 44;
            this.SpellAuraScript_SQL_Out_RichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 32;
            // 
            // tabSpellDBC_OverrideCreator
            // 
            this.tabSpellDBC_OverrideCreator.Controls.Add(this.SpellInfo_Override_RichBox);
            this.tabSpellDBC_OverrideCreator.Controls.Add(this.tableLayoutPanel1);
            this.tabSpellDBC_OverrideCreator.Location = new System.Drawing.Point(4, 22);
            this.tabSpellDBC_OverrideCreator.Margin = new System.Windows.Forms.Padding(2);
            this.tabSpellDBC_OverrideCreator.Name = "tabSpellDBC_OverrideCreator";
            this.tabSpellDBC_OverrideCreator.Padding = new System.Windows.Forms.Padding(2);
            this.tabSpellDBC_OverrideCreator.Size = new System.Drawing.Size(1357, 616);
            this.tabSpellDBC_OverrideCreator.TabIndex = 8;
            this.tabSpellDBC_OverrideCreator.Text = "Spell DBC Override Creator";
            this.tabSpellDBC_OverrideCreator.UseVisualStyleBackColor = true;
            // 
            // SpellInfo_Override_RichBox
            // 
            this.SpellInfo_Override_RichBox.Location = new System.Drawing.Point(270, 5);
            this.SpellInfo_Override_RichBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpellInfo_Override_RichBox.Name = "SpellInfo_Override_RichBox";
            this.SpellInfo_Override_RichBox.Size = new System.Drawing.Size(610, 500);
            this.SpellInfo_Override_RichBox.TabIndex = 45;
            this.SpellInfo_Override_RichBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_ClearSpellData_Button, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_EffIdx_Label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_Check_Data_Button, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_Spell_Id_Field_Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_Field_ComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_Spell_Id_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_Value_Label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_EffIdx_ComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_Value_TextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_Spell_Id_TextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SpellIInfo_AddSpellOverride_Button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SpellInfo_GenerateQuery_Button, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 216);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SpellInfo_ClearSpellData_Button
            // 
            this.SpellInfo_ClearSpellData_Button.Location = new System.Drawing.Point(125, 149);
            this.SpellInfo_ClearSpellData_Button.Name = "SpellInfo_ClearSpellData_Button";
            this.SpellInfo_ClearSpellData_Button.Size = new System.Drawing.Size(116, 34);
            this.SpellInfo_ClearSpellData_Button.TabIndex = 47;
            this.SpellInfo_ClearSpellData_Button.Text = "Clear Spell Data";
            this.SpellInfo_ClearSpellData_Button.UseVisualStyleBackColor = true;
            this.SpellInfo_ClearSpellData_Button.Click += new System.EventHandler(this.SpellInfo_ClearSpellData_Button_Click);
            // 
            // SpellInfo_EffIdx_Label
            // 
            this.SpellInfo_EffIdx_Label.AutoSize = true;
            this.SpellInfo_EffIdx_Label.Location = new System.Drawing.Point(3, 53);
            this.SpellInfo_EffIdx_Label.Name = "SpellInfo_EffIdx_Label";
            this.SpellInfo_EffIdx_Label.Size = new System.Drawing.Size(67, 13);
            this.SpellInfo_EffIdx_Label.TabIndex = 7;
            this.SpellInfo_EffIdx_Label.Text = "Effect Index:";
            // 
            // SpellInfo_Check_Data_Button
            // 
            this.SpellInfo_Check_Data_Button.Enabled = false;
            this.SpellInfo_Check_Data_Button.Location = new System.Drawing.Point(3, 149);
            this.SpellInfo_Check_Data_Button.Name = "SpellInfo_Check_Data_Button";
            this.SpellInfo_Check_Data_Button.Size = new System.Drawing.Size(116, 34);
            this.SpellInfo_Check_Data_Button.TabIndex = 46;
            this.SpellInfo_Check_Data_Button.Text = "Check Existent Spell Data";
            this.SpellInfo_Check_Data_Button.UseVisualStyleBackColor = true;
            // 
            // SpellInfo_Spell_Id_Field_Label
            // 
            this.SpellInfo_Spell_Id_Field_Label.AutoSize = true;
            this.SpellInfo_Spell_Id_Field_Label.Location = new System.Drawing.Point(3, 26);
            this.SpellInfo_Spell_Id_Field_Label.Name = "SpellInfo_Spell_Id_Field_Label";
            this.SpellInfo_Spell_Id_Field_Label.Size = new System.Drawing.Size(35, 13);
            this.SpellInfo_Spell_Id_Field_Label.TabIndex = 6;
            this.SpellInfo_Spell_Id_Field_Label.Text = "Field: ";
            // 
            // SpellInfo_Field_ComboBox
            // 
            this.SpellInfo_Field_ComboBox.Enabled = false;
            this.SpellInfo_Field_ComboBox.FormattingEnabled = true;
            this.SpellInfo_Field_ComboBox.Items.AddRange(new object[] {
            "SpellDurationId",
            "SpellOverrideSpellList      ",
            "SpellRangeId   ",
            "SpellStackAmount            ",
            "SpellAttribute0",
            "SpellAttribute1",
            "SpellAttribute2",
            "SpellAttribute3",
            "SpellAttribute4",
            "SpellAttribute5",
            "SpellAttribute6",
            "SpellAttribute7             ",
            "SpellAttribute8             ",
            "SpellAttribute9             ",
            "SpellAttribute10            ",
            "SpellAttribute11            ",
            "SpellAttribute12            ",
            "SpellAttribute13            ",
            "EffectName                  ",
            "EffectApplyAuraName         ",
            "EffectBasePoints            ",
            "EffectTargetA               ",
            "EffectTargetB               ",
            "EffectMiscA                 ",
            "EffectMiscB                 ",
            "EffectRadiusId              ",
            "EffectTriggerSpell          ",
            "EffectAmplitude             ",
            "EffectSpellClassMask0       ",
            "EffectSpellClassMask1       ",
            "EffectSpellClassMask2       ",
            "EffectSpellClassMask3       ",
            "ProcCharges                 ",
            "StartRecoveryTime           ",
            "ProcFlags                   ",
            "ProcChance                  ",
            "InterruptFlags              ",
            "AuraInterruptFlags          ",
            "SpellCustomAttributes       ",
            "ChannelInterruptFlags       ",
            "OverrideRecoveryTime        ",
            "OverrideDispelType          ",
            "OverrideTargetAuraState     ",
            "OverrideSpellSchoolMask     ",
            "OverrideSpellFamily         ",
            "MaxAffectedTargets          ",
            "ExcludeTargetAuraSpell      ",
            "ExcludeCasterAuraSpell      ",
            "ProcCooldown                ",
            "InternalCooldown            ",
            "DamageClass                 "});
            this.SpellInfo_Field_ComboBox.Location = new System.Drawing.Point(125, 29);
            this.SpellInfo_Field_ComboBox.Name = "SpellInfo_Field_ComboBox";
            this.SpellInfo_Field_ComboBox.Size = new System.Drawing.Size(116, 21);
            this.SpellInfo_Field_ComboBox.TabIndex = 4;
            // 
            // SpellInfo_Spell_Id_Label
            // 
            this.SpellInfo_Spell_Id_Label.AutoSize = true;
            this.SpellInfo_Spell_Id_Label.Location = new System.Drawing.Point(3, 0);
            this.SpellInfo_Spell_Id_Label.Name = "SpellInfo_Spell_Id_Label";
            this.SpellInfo_Spell_Id_Label.Size = new System.Drawing.Size(47, 13);
            this.SpellInfo_Spell_Id_Label.TabIndex = 5;
            this.SpellInfo_Spell_Id_Label.Text = "Spell ID:";
            // 
            // SpellInfo_Value_Label
            // 
            this.SpellInfo_Value_Label.AutoSize = true;
            this.SpellInfo_Value_Label.Location = new System.Drawing.Point(3, 80);
            this.SpellInfo_Value_Label.Name = "SpellInfo_Value_Label";
            this.SpellInfo_Value_Label.Size = new System.Drawing.Size(37, 13);
            this.SpellInfo_Value_Label.TabIndex = 8;
            this.SpellInfo_Value_Label.Text = "Value:";
            // 
            // SpellInfo_EffIdx_ComboBox
            // 
            this.SpellInfo_EffIdx_ComboBox.Enabled = false;
            this.SpellInfo_EffIdx_ComboBox.FormattingEnabled = true;
            this.SpellInfo_EffIdx_ComboBox.Items.AddRange(new object[] {
            "EFFECT_0,",
            "EFFECT_1,",
            "EFFECT_2,",
            "EFFECT_3,",
            "EFFECT_4,",
            "EFFECT_5,",
            "EFFECT_6,",
            "EFFECT_7,",
            "EFFECT_8,",
            "EFFECT_9,",
            "EFFECT_10,",
            "EFFECT_11,",
            "EFFECT_12,",
            "EFFECT_13,",
            "EFFECT_14,",
            "EFFECT_15,",
            "EFFECT_16,",
            "EFFECT_17,",
            "EFFECT_18,",
            "EFFECT_19,",
            "EFFECT_20,",
            "EFFECT_21,",
            "EFFECT_22,",
            "EFFECT_23,",
            "EFFECT_24,",
            "EFFECT_25,",
            "EFFECT_26,",
            "EFFECT_27,",
            "EFFECT_28,",
            "EFFECT_29,",
            "EFFECT_30,",
            "EFFECT_31,"});
            this.SpellInfo_EffIdx_ComboBox.Location = new System.Drawing.Point(125, 56);
            this.SpellInfo_EffIdx_ComboBox.Name = "SpellInfo_EffIdx_ComboBox";
            this.SpellInfo_EffIdx_ComboBox.Size = new System.Drawing.Size(116, 21);
            this.SpellInfo_EffIdx_ComboBox.TabIndex = 2;
            // 
            // SpellInfo_Value_TextBox
            // 
            this.SpellInfo_Value_TextBox.Enabled = false;
            this.SpellInfo_Value_TextBox.Location = new System.Drawing.Point(125, 83);
            this.SpellInfo_Value_TextBox.Name = "SpellInfo_Value_TextBox";
            this.SpellInfo_Value_TextBox.Size = new System.Drawing.Size(116, 20);
            this.SpellInfo_Value_TextBox.TabIndex = 9;
            this.SpellInfo_Value_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpellInfo_Value_TextBox_KeyPress);
            // 
            // SpellInfo_Spell_Id_TextBox
            // 
            this.SpellInfo_Spell_Id_TextBox.Location = new System.Drawing.Point(125, 3);
            this.SpellInfo_Spell_Id_TextBox.Name = "SpellInfo_Spell_Id_TextBox";
            this.SpellInfo_Spell_Id_TextBox.Size = new System.Drawing.Size(116, 20);
            this.SpellInfo_Spell_Id_TextBox.TabIndex = 10;
            this.SpellInfo_Spell_Id_TextBox.TextChanged += new System.EventHandler(this.SpellInfo_Spell_Id_TextBox_TextChanged);
            this.SpellInfo_Spell_Id_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpellInfo_Spell_Id_TextBox_KeyPress);
            // 
            // SpellIInfo_AddSpellOverride_Button
            // 
            this.SpellIInfo_AddSpellOverride_Button.Enabled = false;
            this.SpellIInfo_AddSpellOverride_Button.Location = new System.Drawing.Point(3, 109);
            this.SpellIInfo_AddSpellOverride_Button.Name = "SpellIInfo_AddSpellOverride_Button";
            this.SpellIInfo_AddSpellOverride_Button.Size = new System.Drawing.Size(116, 34);
            this.SpellIInfo_AddSpellOverride_Button.TabIndex = 1;
            this.SpellIInfo_AddSpellOverride_Button.Text = "Add Spell Override";
            this.SpellIInfo_AddSpellOverride_Button.UseVisualStyleBackColor = true;
            this.SpellIInfo_AddSpellOverride_Button.Click += new System.EventHandler(this.SpellIInfo_AddSpellOverride_Button_Click);
            // 
            // SpellInfo_GenerateQuery_Button
            // 
            this.SpellInfo_GenerateQuery_Button.Enabled = false;
            this.SpellInfo_GenerateQuery_Button.Location = new System.Drawing.Point(125, 109);
            this.SpellInfo_GenerateQuery_Button.Name = "SpellInfo_GenerateQuery_Button";
            this.SpellInfo_GenerateQuery_Button.Size = new System.Drawing.Size(116, 34);
            this.SpellInfo_GenerateQuery_Button.TabIndex = 11;
            this.SpellInfo_GenerateQuery_Button.Text = "Generate Sql Code";
            this.SpellInfo_GenerateQuery_Button.UseVisualStyleBackColor = true;
            this.SpellInfo_GenerateQuery_Button.Click += new System.EventHandler(this.SpellInfo_GenerateQuery_Button_Click);
            // 
            // tabCombatAI_Creator
            // 
            this.tabCombatAI_Creator.Controls.Add(this.CombatAICreatorSQL_RichTextBox);
            this.tabCombatAI_Creator.Controls.Add(this.tableLayoutPanel3);
            this.tabCombatAI_Creator.Location = new System.Drawing.Point(4, 22);
            this.tabCombatAI_Creator.Name = "tabCombatAI_Creator";
            this.tabCombatAI_Creator.Padding = new System.Windows.Forms.Padding(3);
            this.tabCombatAI_Creator.Size = new System.Drawing.Size(1357, 616);
            this.tabCombatAI_Creator.TabIndex = 9;
            this.tabCombatAI_Creator.Text = "Combat AI Creator";
            this.tabCombatAI_Creator.UseVisualStyleBackColor = true;
            // 
            // CombatAICreatorSQL_RichTextBox
            // 
            this.CombatAICreatorSQL_RichTextBox.Location = new System.Drawing.Point(376, 6);
            this.CombatAICreatorSQL_RichTextBox.Name = "CombatAICreatorSQL_RichTextBox";
            this.CombatAICreatorSQL_RichTextBox.Size = new System.Drawing.Size(761, 427);
            this.CombatAICreatorSQL_RichTextBox.TabIndex = 1;
            this.CombatAICreatorSQL_RichTextBox.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_NpcEntry_TextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_NpcEntry_Label, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_InitMin_TextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_InitMax_TextBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_RepeatMin_TextBox, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_RepeatMax_TextBox, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_RepeatMax_Label, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 11);
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 12);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_EventType_ComboBox, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_AttackDist_TextBox, 1, 11);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_Spell_Id_TextBox, 1, 12);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_Add_ScriptData_Button, 0, 13);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_GenerateSQL_Button, 1, 13);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_ClearData_Button, 0, 14);
            this.tableLayoutPanel3.Controls.Add(this.CombatAI_EventFlags_CheckedBox, 1, 10);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 15;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(364, 604);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // CombatAI_NpcEntry_TextBox
            // 
            this.CombatAI_NpcEntry_TextBox.Location = new System.Drawing.Point(153, 3);
            this.CombatAI_NpcEntry_TextBox.Name = "CombatAI_NpcEntry_TextBox";
            this.CombatAI_NpcEntry_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CombatAI_NpcEntry_TextBox.TabIndex = 11;
            this.CombatAI_NpcEntry_TextBox.TextChanged += new System.EventHandler(this.CombatAI_NpcEntry_TextBox_TextChanged);
            this.CombatAI_NpcEntry_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CombatAI_NpcEntry_TextBox_KeyPress);
            // 
            // CombatAI_NpcEntry_Label
            // 
            this.CombatAI_NpcEntry_Label.AutoSize = true;
            this.CombatAI_NpcEntry_Label.Location = new System.Drawing.Point(3, 0);
            this.CombatAI_NpcEntry_Label.Name = "CombatAI_NpcEntry_Label";
            this.CombatAI_NpcEntry_Label.Size = new System.Drawing.Size(57, 13);
            this.CombatAI_NpcEntry_Label.TabIndex = 0;
            this.CombatAI_NpcEntry_Label.Text = "Npc Entry:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Init Min: ";
            // 
            // CombatAI_InitMin_TextBox
            // 
            this.CombatAI_InitMin_TextBox.Enabled = false;
            this.CombatAI_InitMin_TextBox.Location = new System.Drawing.Point(153, 29);
            this.CombatAI_InitMin_TextBox.Name = "CombatAI_InitMin_TextBox";
            this.CombatAI_InitMin_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CombatAI_InitMin_TextBox.TabIndex = 9;
            this.CombatAI_InitMin_TextBox.TabStop = false;
            // 
            // CombatAI_InitMax_TextBox
            // 
            this.CombatAI_InitMax_TextBox.Enabled = false;
            this.CombatAI_InitMax_TextBox.Location = new System.Drawing.Point(153, 55);
            this.CombatAI_InitMax_TextBox.Name = "CombatAI_InitMax_TextBox";
            this.CombatAI_InitMax_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CombatAI_InitMax_TextBox.TabIndex = 14;
            this.CombatAI_InitMax_TextBox.TabStop = false;
            // 
            // CombatAI_RepeatMin_TextBox
            // 
            this.CombatAI_RepeatMin_TextBox.Enabled = false;
            this.CombatAI_RepeatMin_TextBox.Location = new System.Drawing.Point(153, 81);
            this.CombatAI_RepeatMin_TextBox.Name = "CombatAI_RepeatMin_TextBox";
            this.CombatAI_RepeatMin_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CombatAI_RepeatMin_TextBox.TabIndex = 17;
            this.CombatAI_RepeatMin_TextBox.TabStop = false;
            // 
            // CombatAI_RepeatMax_TextBox
            // 
            this.CombatAI_RepeatMax_TextBox.Enabled = false;
            this.CombatAI_RepeatMax_TextBox.Location = new System.Drawing.Point(153, 107);
            this.CombatAI_RepeatMax_TextBox.Name = "CombatAI_RepeatMax_TextBox";
            this.CombatAI_RepeatMax_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CombatAI_RepeatMax_TextBox.TabIndex = 18;
            this.CombatAI_RepeatMax_TextBox.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "RepeatMin: ";
            // 
            // CombatAI_RepeatMax_Label
            // 
            this.CombatAI_RepeatMax_Label.AutoSize = true;
            this.CombatAI_RepeatMax_Label.Location = new System.Drawing.Point(3, 52);
            this.CombatAI_RepeatMax_Label.Name = "CombatAI_RepeatMax_Label";
            this.CombatAI_RepeatMax_Label.Size = new System.Drawing.Size(44, 13);
            this.CombatAI_RepeatMax_Label.TabIndex = 2;
            this.CombatAI_RepeatMax_Label.Text = "InitMax:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "RepeatMax:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Event Type: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Event Flags: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 377);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Attack Dist: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 403);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Spell ID: ";
            // 
            // CombatAI_EventType_ComboBox
            // 
            this.CombatAI_EventType_ComboBox.Enabled = false;
            this.CombatAI_EventType_ComboBox.FormattingEnabled = true;
            this.CombatAI_EventType_ComboBox.Items.AddRange(new object[] {
            "MeleeNegative               ",
            "RangedNegative              ",
            "AoENegative                 ",
            "RangedPositive              ",
            "AoEPositive                 ",
            "RangedHeal                  ",
            "AoEHeal                     ",
            "NonTankNegative             ",
            "AoENonSelfPositive          ",
            "MeleeTopAggro               ",
            "AoENonSelfPositiveDispel    ",
            "FarthestNegative            ",
            "TopAggroTarget              "});
            this.CombatAI_EventType_ComboBox.Location = new System.Drawing.Point(153, 133);
            this.CombatAI_EventType_ComboBox.Name = "CombatAI_EventType_ComboBox";
            this.CombatAI_EventType_ComboBox.Size = new System.Drawing.Size(208, 21);
            this.CombatAI_EventType_ComboBox.TabIndex = 16;
            this.CombatAI_EventType_ComboBox.TabStop = false;
            // 
            // CombatAI_AttackDist_TextBox
            // 
            this.CombatAI_AttackDist_TextBox.Enabled = false;
            this.CombatAI_AttackDist_TextBox.Location = new System.Drawing.Point(153, 380);
            this.CombatAI_AttackDist_TextBox.Name = "CombatAI_AttackDist_TextBox";
            this.CombatAI_AttackDist_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CombatAI_AttackDist_TextBox.TabIndex = 10;
            this.CombatAI_AttackDist_TextBox.TabStop = false;
            this.CombatAI_AttackDist_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CombatAI_AttackDist_TextBox_KeyPress);
            // 
            // CombatAI_Spell_Id_TextBox
            // 
            this.CombatAI_Spell_Id_TextBox.Enabled = false;
            this.CombatAI_Spell_Id_TextBox.Location = new System.Drawing.Point(153, 406);
            this.CombatAI_Spell_Id_TextBox.Name = "CombatAI_Spell_Id_TextBox";
            this.CombatAI_Spell_Id_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CombatAI_Spell_Id_TextBox.TabIndex = 12;
            this.CombatAI_Spell_Id_TextBox.TabStop = false;
            // 
            // CombatAI_Add_ScriptData_Button
            // 
            this.CombatAI_Add_ScriptData_Button.Enabled = false;
            this.CombatAI_Add_ScriptData_Button.Location = new System.Drawing.Point(3, 432);
            this.CombatAI_Add_ScriptData_Button.Name = "CombatAI_Add_ScriptData_Button";
            this.CombatAI_Add_ScriptData_Button.Size = new System.Drawing.Size(100, 23);
            this.CombatAI_Add_ScriptData_Button.TabIndex = 19;
            this.CombatAI_Add_ScriptData_Button.Text = "Add Script Data";
            this.CombatAI_Add_ScriptData_Button.UseVisualStyleBackColor = true;
            this.CombatAI_Add_ScriptData_Button.Click += new System.EventHandler(this.CombatAI_Add_ScriptData_Button_Click);
            // 
            // CombatAI_GenerateSQL_Button
            // 
            this.CombatAI_GenerateSQL_Button.Location = new System.Drawing.Point(153, 432);
            this.CombatAI_GenerateSQL_Button.Name = "CombatAI_GenerateSQL_Button";
            this.CombatAI_GenerateSQL_Button.Size = new System.Drawing.Size(100, 23);
            this.CombatAI_GenerateSQL_Button.TabIndex = 21;
            this.CombatAI_GenerateSQL_Button.Text = "Generate SQL";
            this.CombatAI_GenerateSQL_Button.UseVisualStyleBackColor = true;
            this.CombatAI_GenerateSQL_Button.Click += new System.EventHandler(this.CombatAI_GenerateSQL_Button_Click);
            // 
            // CombatAI_ClearData_Button
            // 
            this.CombatAI_ClearData_Button.Location = new System.Drawing.Point(3, 461);
            this.CombatAI_ClearData_Button.Name = "CombatAI_ClearData_Button";
            this.CombatAI_ClearData_Button.Size = new System.Drawing.Size(100, 23);
            this.CombatAI_ClearData_Button.TabIndex = 20;
            this.CombatAI_ClearData_Button.Text = "Clear Script Data";
            this.CombatAI_ClearData_Button.UseVisualStyleBackColor = true;
            this.CombatAI_ClearData_Button.Click += new System.EventHandler(this.CombatAI_ClearData_Button_Click);
            // 
            // statusStrip_LoadedFile
            // 
            this.statusStrip_LoadedFile.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip_LoadedFile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip_LoadedFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_FileStatus,
            this.toolStripStatusLabel_CurrentAction});
            this.statusStrip_LoadedFile.Location = new System.Drawing.Point(0, 634);
            this.statusStrip_LoadedFile.Name = "statusStrip_LoadedFile";
            this.statusStrip_LoadedFile.Padding = new System.Windows.Forms.Padding(2, 0, 9, 0);
            this.statusStrip_LoadedFile.Size = new System.Drawing.Size(1155, 22);
            this.statusStrip_LoadedFile.TabIndex = 2;
            this.statusStrip_LoadedFile.Text = "statusStrip";
            // 
            // toolStripStatusLabel_FileStatus
            // 
            this.toolStripStatusLabel_FileStatus.Name = "toolStripStatusLabel_FileStatus";
            this.toolStripStatusLabel_FileStatus.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel_FileStatus.Text = "No File Loaded";
            // 
            // toolStripStatusLabel_CurrentAction
            // 
            this.toolStripStatusLabel_CurrentAction.Name = "toolStripStatusLabel_CurrentAction";
            this.toolStripStatusLabel_CurrentAction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel_CurrentAction.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog_WSC";
            // 
            // CombatAI_EventFlags_CheckedBox
            // 
            this.CombatAI_EventFlags_CheckedBox.FormattingEnabled = true;
            this.CombatAI_EventFlags_CheckedBox.Items.AddRange(new object[] {
            "DisableTurn           ",
            "CastAfterDeath        ",
            "CastOnDeath           ",
            "CastUnderHealthPct    ",
            "DespawnAfterCast       ",
            "DontCheckInCombat      ",
            "DieAfterCast           ",
            "DespawnSummonsAfterDie ",
            "DespawnAreaTriggers     ",
            "CastAfterSpell          ",
            "DisableMove             ",
            "DisableMeleeAttack      ",
            "CanBeRemoved            ",
            "CanRemoveOtherEvents    ",
            "CanScheduleOtherEvents  ",
            "TargetPriorityToPlayers ",
            "CastOnTargetPosition     ",
            "AddKnockbackImmunities   ",
            "CastOnJustReachedHome"});
            this.CombatAI_EventFlags_CheckedBox.Location = new System.Drawing.Point(153, 160);
            this.CombatAI_EventFlags_CheckedBox.Name = "CombatAI_EventFlags_CheckedBox";
            this.CombatAI_EventFlags_CheckedBox.Size = new System.Drawing.Size(208, 214);
            this.CombatAI_EventFlags_CheckedBox.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1155, 656);
            this.Controls.Add(this.statusStrip_LoadedFile);
            this.Controls.Add(this.SpellInfo_Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Wow Developer Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SpellInfo_Tab.ResumeLayout(false);
            this.tabPage_CreatureScriptsCreator.ResumeLayout(false);
            this.tabPage_CreatureScriptsCreator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spells)).EndInit();
            this.contextMenuStrip_CSC.ResumeLayout(false);
            this.toolStrip_CSC.ResumeLayout(false);
            this.toolStrip_CSC.PerformLayout();
            this.tabPage_WaypointsCreator.ResumeLayout(false);
            this.tabPage_WaypointsCreator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_WC_Waypoints)).EndInit();
            this.contextMenuStrip_WC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_WC)).EndInit();
            this.toolStrip_WC.ResumeLayout(false);
            this.toolStrip_WC.PerformLayout();
            this.tabPage_Output.ResumeLayout(false);
            this.tabPage_Output.PerformLayout();
            this.tabPage_DatabaseAdvisor.ResumeLayout(false);
            this.tabPage_DatabaseAdvisor.PerformLayout();
            this.tabPage_DoubleSpawnsRemover.ResumeLayout(false);
            this.tabPage_DoubleSpawnsRemover.PerformLayout();
            this.coreScriptTemplates.ResumeLayout(false);
            this.coreScriptTemplates.PerformLayout();
            this.tabPage_Achievements.ResumeLayout(false);
            this.tabPage_Achievements.PerformLayout();
            this.tabAuraSpell_Creator.ResumeLayout(false);
            this.tabAuraSpell_Creator.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabSpellDBC_OverrideCreator.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabCombatAI_Creator.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.statusStrip_LoadedFile.ResumeLayout(false);
            this.statusStrip_LoadedFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl SpellInfo_Tab;
        private System.Windows.Forms.TabPage tabPage_CreatureScriptsCreator;
        private System.Windows.Forms.ToolStrip toolStrip_CSC;
        public System.Windows.Forms.ToolStripButton toolStripButton_CSC_ImportSniff;
        public System.Windows.Forms.ToolStripButton toolStripButton_CSC_Search;
        private System.Windows.Forms.TabPage tabPage_Output;
        private System.Windows.Forms.StatusStrip statusStrip_LoadedFile;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_FileStatus;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox_CSC_CreatureEntry;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_CSC_CreatureEntry;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.DataGridView dataGridView_Spells;
        public System.Windows.Forms.ListBox listBox_CreatureGuids;
        public System.Windows.Forms.CheckBox checkBox_OnlyCombatSpells;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_CSC;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem createSQLToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox_SQLOutput;
        private System.Windows.Forms.TabPage tabPage_DatabaseAdvisor;
        private System.Windows.Forms.TextBox textBox_CreatureFlags;
        private System.Windows.Forms.Label label_CreatureFlags;
        private System.Windows.Forms.TextBox textBox_QuestFlags;
        private System.Windows.Forms.Label label_QuestFlags;
        private System.Windows.Forms.TabPage tabPage_DoubleSpawnsRemover;
        private System.Windows.Forms.Label label_CreaturesRemoved;
        private System.Windows.Forms.Button button_ImportFileForRemoving;
        private System.Windows.Forms.CheckBox checkBox_GameobjectsRemover;
        private System.Windows.Forms.CheckBox checkBox_CreaturesRemover;
        private System.Windows.Forms.Label label_GameobjectsRemoved;
        private System.Windows.Forms.CheckBox checkBox_DatabaseConsidering;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpellId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinCastStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxCastStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinCastRepeatTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxCastRepeatTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceSpell;
        private System.Windows.Forms.TextBox textBoxAreatriggerSplines;
        private System.Windows.Forms.Label label_AreatriggerSplines;
        private System.Windows.Forms.TabPage tabPage_WaypointsCreator;
        internal System.Windows.Forms.DataGridView grid_WC_Waypoints;
        public System.Windows.Forms.ListBox listBox_WC_CreatureGuids;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chart_WC;
        private System.Windows.Forms.ToolStrip toolStrip_WC;
        public System.Windows.Forms.ToolStripButton toolStripButton_WC_Search;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox_WC_Entry;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_WC_Entry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_WC_Settings;
        public System.Windows.Forms.ToolStripButton toolStripButton_WC_LoadSniff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_WC;
        private System.Windows.Forms.ToolStripMenuItem createSQLToolStripMenuItem_WC;
        private System.Windows.Forms.ToolStripMenuItem removeNearestPointsToolStripMenuItem_WC;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem_WC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_PosX;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_PosY;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_PosZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_Orientation;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_WCTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_WCDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_HasScript;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaypointSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_CSC;
        private System.Windows.Forms.ToolStripMenuItem removeDuplicatePointsToolStripMenuItem_WC;
        private System.Windows.Forms.ToolStripMenuItem createReturnPathToolStripMenuItem_WC;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_CurrentAction;
        private System.Windows.Forms.TabPage coreScriptTemplates;
        public System.Windows.Forms.ListBox listBox_CoreScriptTemplates_Hooks;
        public System.Windows.Forms.ComboBox comboBox_CoreScriptTemplates_ScriptType;
        public System.Windows.Forms.TextBox textBox_CoreScriptTemplates_Entry;
        private System.Windows.Forms.Label label_CoreScriptTemplates_ScriptType;
        private System.Windows.Forms.Label label_CoreScriptTemplates_Entry;
        public System.Windows.Forms.TreeView treeView_CoreScriptTemplates_HookBodies;
        public System.Windows.Forms.TabPage tabPage_Achievements;
        public System.Windows.Forms.TextBox textBoxAchievements_Id;
        public System.Windows.Forms.Label label_Achievements_Id;
        public System.Windows.Forms.TreeView treeView_Achievements_ChildNodes;
        public System.Windows.Forms.Label label_Achievement_Name;
        public System.Windows.Forms.Label label_Achievements_CreteriaThreeChilds;
        public System.Windows.Forms.Label label_Achievement_CriteriaTree_Operator;
        public System.Windows.Forms.Label label_Achievements_CriteriaTreeName;
        public System.Windows.Forms.Label label_Achievements_CriteriaTreeId;
        public System.Windows.Forms.Label label_Achievements_Flags;
        public System.Windows.Forms.Label label_Achievements_Faction;
        public System.Windows.Forms.Label label_Achievements_CriteriaTree_Amount;
        public System.Windows.Forms.TreeView treeView_Achievements_Criterias;
        private System.Windows.Forms.Label label_Achievements_Criterias;
        private System.Windows.Forms.Label label_Achievements_ModifierTrees;
        public System.Windows.Forms.TreeView treeView_Achievements_ModifierTrees;
        private System.Windows.Forms.Label label_Achievements_ModifierTreeChildNodes;
        public System.Windows.Forms.TreeView treeView_Achievements_ModifierTreeChildNodes;
        private System.Windows.Forms.TabPage tabAuraSpell_Creator;
        private System.Windows.Forms.Label SpellAura_ActionLabel;
        private System.Windows.Forms.Label ScriptType_Label;
        public System.Windows.Forms.ComboBox SpellAuraScriptType_ComboBox;
        private System.Windows.Forms.Label ScriptHookAuraSpell_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CalculationType_Label;
        public System.Windows.Forms.ComboBox SpellAuraScript_CalcType_ComboBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox SpellAuraScript_Triggered_ComboBox;
        public System.Windows.Forms.TextBox SpellAuraScripts_ActionSpellList_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox SpellAuraScripts_ActionSpellId_TextBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox SpellAuraScript_EffIndex_ComboBox;
        public System.Windows.Forms.ComboBox SpellAuraScript_ActionComboBox;
        private System.Windows.Forms.Label SpellAuraScript_Hook_Label;
        public System.Windows.Forms.ComboBox SpellAuraScriptSources_ComboBox;
        public System.Windows.Forms.ComboBox SpellAuraScript_Hooks_ComboBox;
        public System.Windows.Forms.ComboBox SpellAuraScripts_ActionCaster_ComboBox;
        public System.Windows.Forms.Button SpellAuraScript_Button_Add;
        private System.Windows.Forms.Label SpellAuraScript_SpellId_Label;
        public System.Windows.Forms.TextBox SpellAuraScript_SpellID_TextBox;
        public System.Windows.Forms.ComboBox SpellAuraScripts_ActionTarget_ComboBox;
        public System.Windows.Forms.ComboBox SpellAuraScripts_ActionOrgCaster_ComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RichTextBox SpellAuraScript_SQL_Out_RichTextBox;
        public System.Windows.Forms.Button SpellAuraScripts_GenerateSQL;
        private System.Windows.Forms.TabPage tabSpellDBC_OverrideCreator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label SpellInfo_EffIdx_Label;
        private System.Windows.Forms.Label SpellInfo_Spell_Id_Field_Label;
        private System.Windows.Forms.Label SpellInfo_Spell_Id_Label;
        private System.Windows.Forms.Label SpellInfo_Value_Label;
        public System.Windows.Forms.RichTextBox SpellInfo_Override_RichBox;
        private System.Windows.Forms.Button SpellInfo_Check_Data_Button;
        public System.Windows.Forms.Button SpellIInfo_AddSpellOverride_Button;
        public System.Windows.Forms.Button SpellInfo_GenerateQuery_Button;
        public System.Windows.Forms.ComboBox SpellInfo_Field_ComboBox;
        public System.Windows.Forms.ComboBox SpellInfo_EffIdx_ComboBox;
        public System.Windows.Forms.TextBox SpellInfo_Value_TextBox;
        public System.Windows.Forms.TextBox SpellInfo_Spell_Id_TextBox;
        private System.Windows.Forms.Button SpellInfo_ClearSpellData_Button;
        private System.Windows.Forms.TabPage tabCombatAI_Creator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Button SpellAuraScript_Clear_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label CombatAI_NpcEntry_Label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label CombatAI_RepeatMax_Label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button CombatAI_GenerateSQL_Button;
        private System.Windows.Forms.Button CombatAI_ClearData_Button;
        public System.Windows.Forms.RichTextBox CombatAICreatorSQL_RichTextBox;
        public System.Windows.Forms.TextBox CombatAI_NpcEntry_TextBox;
        public System.Windows.Forms.TextBox CombatAI_InitMin_TextBox;
        public System.Windows.Forms.TextBox CombatAI_InitMax_TextBox;
        public System.Windows.Forms.TextBox CombatAI_RepeatMin_TextBox;
        public System.Windows.Forms.TextBox CombatAI_RepeatMax_TextBox;
        public System.Windows.Forms.ComboBox CombatAI_EventType_ComboBox;
        public System.Windows.Forms.TextBox CombatAI_AttackDist_TextBox;
        public System.Windows.Forms.TextBox CombatAI_Spell_Id_TextBox;
        public System.Windows.Forms.Button CombatAI_Add_ScriptData_Button;
        public System.Windows.Forms.CheckedListBox CombatAI_EventFlags_CheckedBox;
    }
}

