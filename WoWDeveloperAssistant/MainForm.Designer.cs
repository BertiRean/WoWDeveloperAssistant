﻿namespace WoWDeveloperAssistant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
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
            this.SpellAuraScript_SpellId_Label = new System.Windows.Forms.Label();
            this.SpellAuraScript_SpellID_TextBox = new System.Windows.Forms.TextBox();
            this.SpellAuraScript_SQL_Out_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SpellAuraScript_Button_Add = new System.Windows.Forms.Button();
            this.SpellAuraScript_Hooks_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScript_Hook_Label = new System.Windows.Forms.Label();
            this.SpellAuraScriptSources_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScript_ActionComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SpellAuraScripts_ActionCaster_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScript_EffIndex_ComboBox = new System.Windows.Forms.ComboBox();
            this.CalculationType_Label = new System.Windows.Forms.Label();
            this.SpellAuraScript_CalcType_ComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SpellAuraScript_Triggered_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScripts_ActionSpellList_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpellAuraScripts_ActionSpellId_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpellAura_ActionLabel = new System.Windows.Forms.Label();
            this.ScriptType_Label = new System.Windows.Forms.Label();
            this.SpellAuraScriptType_ComboBox = new System.Windows.Forms.ComboBox();
            this.ScriptHookAuraSpell_Label = new System.Windows.Forms.Label();
            this.statusStrip_LoadedFile = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_FileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_CurrentAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SpellAuraScripts_ActionOrgCaster_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScripts_ActionTarget_ComboBox = new System.Windows.Forms.ComboBox();
            this.SpellAuraScripts_GenerateSQL = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
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
            this.statusStrip_LoadedFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_CreatureScriptsCreator);
            this.tabControl.Controls.Add(this.tabPage_WaypointsCreator);
            this.tabControl.Controls.Add(this.tabPage_Output);
            this.tabControl.Controls.Add(this.tabPage_DatabaseAdvisor);
            this.tabControl.Controls.Add(this.tabPage_DoubleSpawnsRemover);
            this.tabControl.Controls.Add(this.coreScriptTemplates);
            this.tabControl.Controls.Add(this.tabPage_Achievements);
            this.tabControl.Controls.Add(this.tabAuraSpell_Creator);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1820, 790);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage_CreatureScriptsCreator
            // 
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.checkBox_OnlyCombatSpells);
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.dataGridView_Spells);
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.listBox_CreatureGuids);
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.toolStrip_CSC);
            this.tabPage_CreatureScriptsCreator.Location = new System.Drawing.Point(4, 25);
            this.tabPage_CreatureScriptsCreator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_CreatureScriptsCreator.Name = "tabPage_CreatureScriptsCreator";
            this.tabPage_CreatureScriptsCreator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_CreatureScriptsCreator.Size = new System.Drawing.Size(1812, 761);
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
            this.checkBox_OnlyCombatSpells.Location = new System.Drawing.Point(1289, 6);
            this.checkBox_OnlyCombatSpells.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_OnlyCombatSpells.Name = "checkBox_OnlyCombatSpells";
            this.checkBox_OnlyCombatSpells.Size = new System.Drawing.Size(161, 24);
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
            this.dataGridView_Spells.Location = new System.Drawing.Point(676, 39);
            this.dataGridView_Spells.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Spells.Name = "dataGridView_Spells";
            this.dataGridView_Spells.RowHeadersWidth = 62;
            this.dataGridView_Spells.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Spells.RowTemplate.Height = 28;
            this.dataGridView_Spells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Spells.Size = new System.Drawing.Size(1128, 709);
            this.dataGridView_Spells.TabIndex = 3;
            // 
            // SpellId
            // 
            this.SpellId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SpellId.DefaultCellStyle = dataGridViewCellStyle21;
            this.SpellId.HeaderText = "SpellId";
            this.SpellId.MaxInputLength = 10;
            this.SpellId.MinimumWidth = 8;
            this.SpellId.Name = "SpellId";
            this.SpellId.ReadOnly = true;
            this.SpellId.Width = 79;
            // 
            // SpellName
            // 
            this.SpellName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SpellName.DefaultCellStyle = dataGridViewCellStyle22;
            this.SpellName.HeaderText = "SpellName";
            this.SpellName.MaxInputLength = 50;
            this.SpellName.MinimumWidth = 8;
            this.SpellName.Name = "SpellName";
            this.SpellName.ReadOnly = true;
            this.SpellName.Width = 105;
            // 
            // CastTime
            // 
            this.CastTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CastTime.DefaultCellStyle = dataGridViewCellStyle23;
            this.CastTime.HeaderText = "CastTime";
            this.CastTime.MaxInputLength = 10;
            this.CastTime.MinimumWidth = 8;
            this.CastTime.Name = "CastTime";
            this.CastTime.ReadOnly = true;
            this.CastTime.Width = 96;
            // 
            // MinCastStartTime
            // 
            this.MinCastStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MinCastStartTime.DefaultCellStyle = dataGridViewCellStyle24;
            this.MinCastStartTime.HeaderText = "MinCastStartTime";
            this.MinCastStartTime.MaxInputLength = 10;
            this.MinCastStartTime.MinimumWidth = 8;
            this.MinCastStartTime.Name = "MinCastStartTime";
            this.MinCastStartTime.ReadOnly = true;
            this.MinCastStartTime.Width = 148;
            // 
            // MaxCastStartTime
            // 
            this.MaxCastStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxCastStartTime.DefaultCellStyle = dataGridViewCellStyle25;
            this.MaxCastStartTime.HeaderText = "MaxCastStartTime";
            this.MaxCastStartTime.MaxInputLength = 10;
            this.MaxCastStartTime.MinimumWidth = 8;
            this.MaxCastStartTime.Name = "MaxCastStartTime";
            this.MaxCastStartTime.ReadOnly = true;
            this.MaxCastStartTime.Width = 151;
            // 
            // MinCastRepeatTime
            // 
            this.MinCastRepeatTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MinCastRepeatTime.DefaultCellStyle = dataGridViewCellStyle26;
            this.MinCastRepeatTime.HeaderText = "MinCastRepeatTime";
            this.MinCastRepeatTime.MaxInputLength = 10;
            this.MinCastRepeatTime.MinimumWidth = 8;
            this.MinCastRepeatTime.Name = "MinCastRepeatTime";
            this.MinCastRepeatTime.ReadOnly = true;
            this.MinCastRepeatTime.Width = 164;
            // 
            // MaxCastRepeatTime
            // 
            this.MaxCastRepeatTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxCastRepeatTime.DefaultCellStyle = dataGridViewCellStyle27;
            this.MaxCastRepeatTime.HeaderText = "MaxCastRepeatTime";
            this.MaxCastRepeatTime.MaxInputLength = 10;
            this.MaxCastRepeatTime.MinimumWidth = 8;
            this.MaxCastRepeatTime.Name = "MaxCastRepeatTime";
            this.MaxCastRepeatTime.ReadOnly = true;
            this.MaxCastRepeatTime.Width = 167;
            // 
            // CastsCount
            // 
            this.CastsCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CastsCount.DefaultCellStyle = dataGridViewCellStyle28;
            this.CastsCount.HeaderText = "CastsCount";
            this.CastsCount.MaxInputLength = 4;
            this.CastsCount.MinimumWidth = 8;
            this.CastsCount.Name = "CastsCount";
            this.CastsCount.ReadOnly = true;
            this.CastsCount.Width = 109;
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
            this.contextMenuStrip_CSC.Size = new System.Drawing.Size(152, 58);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(148, 6);
            // 
            // createSQLToolStripMenuItem
            // 
            this.createSQLToolStripMenuItem.Name = "createSQLToolStripMenuItem";
            this.createSQLToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.createSQLToolStripMenuItem.Text = "Create SQL";
            this.createSQLToolStripMenuItem.Click += new System.EventHandler(this.createSQLToolStripMenuItem_Click);
            // 
            // listBox_CreatureGuids
            // 
            this.listBox_CreatureGuids.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_CreatureGuids.Enabled = false;
            this.listBox_CreatureGuids.FormattingEnabled = true;
            this.listBox_CreatureGuids.ItemHeight = 16;
            this.listBox_CreatureGuids.Location = new System.Drawing.Point(7, 39);
            this.listBox_CreatureGuids.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_CreatureGuids.Name = "listBox_CreatureGuids";
            this.listBox_CreatureGuids.Size = new System.Drawing.Size(647, 708);
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
            this.toolStrip_CSC.Location = new System.Drawing.Point(3, 2);
            this.toolStrip_CSC.Name = "toolStrip_CSC";
            this.toolStrip_CSC.Size = new System.Drawing.Size(1806, 27);
            this.toolStrip_CSC.TabIndex = 1;
            this.toolStrip_CSC.Text = "toolStrip_CreatureScriptsCreator";
            // 
            // toolStripButton_CSC_ImportSniff
            // 
            this.toolStripButton_CSC_ImportSniff.Image = global::WoWDeveloperAssistant.Properties.Resources.PIC_Import;
            this.toolStripButton_CSC_ImportSniff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CSC_ImportSniff.Name = "toolStripButton_CSC_ImportSniff";
            this.toolStripButton_CSC_ImportSniff.Size = new System.Drawing.Size(112, 24);
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
            this.toolStripButton_CSC_Search.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton_CSC_Search.Text = "Search";
            this.toolStripButton_CSC_Search.Click += new System.EventHandler(this.toolStripButton_Search_Click);
            // 
            // toolStripTextBox_CSC_CreatureEntry
            // 
            this.toolStripTextBox_CSC_CreatureEntry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox_CSC_CreatureEntry.Enabled = false;
            this.toolStripTextBox_CSC_CreatureEntry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_CSC_CreatureEntry.MaxLength = 40;
            this.toolStripTextBox_CSC_CreatureEntry.Name = "toolStripTextBox_CSC_CreatureEntry";
            this.toolStripTextBox_CSC_CreatureEntry.Size = new System.Drawing.Size(89, 27);
            this.toolStripTextBox_CSC_CreatureEntry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_CSC_CreatureEntrySearch_Enter);
            // 
            // toolStripLabel_CSC_CreatureEntry
            // 
            this.toolStripLabel_CSC_CreatureEntry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_CSC_CreatureEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_CSC_CreatureEntry.Name = "toolStripLabel_CSC_CreatureEntry";
            this.toolStripLabel_CSC_CreatureEntry.Size = new System.Drawing.Size(152, 24);
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
            this.tabPage_WaypointsCreator.Location = new System.Drawing.Point(4, 25);
            this.tabPage_WaypointsCreator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_WaypointsCreator.Name = "tabPage_WaypointsCreator";
            this.tabPage_WaypointsCreator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_WaypointsCreator.Size = new System.Drawing.Size(1812, 761);
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
            dataGridViewCellStyle29.NullValue = null;
            this.grid_WC_Waypoints.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.grid_WC_Waypoints.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.NullValue = null;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_WC_Waypoints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
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
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.NullValue = null;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_WC_Waypoints.DefaultCellStyle = dataGridViewCellStyle39;
            this.grid_WC_Waypoints.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_WC_Waypoints.Enabled = false;
            this.grid_WC_Waypoints.Location = new System.Drawing.Point(1132, 39);
            this.grid_WC_Waypoints.Margin = new System.Windows.Forms.Padding(4);
            this.grid_WC_Waypoints.Name = "grid_WC_Waypoints";
            this.grid_WC_Waypoints.RowHeadersWidth = 62;
            this.grid_WC_Waypoints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_WC_Waypoints.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.grid_WC_Waypoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_WC_Waypoints.Size = new System.Drawing.Size(675, 709);
            this.grid_WC_Waypoints.TabIndex = 28;
            this.grid_WC_Waypoints.TabStop = false;
            // 
            // gridColumn_Id
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_Id.DefaultCellStyle = dataGridViewCellStyle31;
            this.gridColumn_Id.HeaderText = "Id";
            this.gridColumn_Id.MinimumWidth = 8;
            this.gridColumn_Id.Name = "gridColumn_Id";
            this.gridColumn_Id.ReadOnly = true;
            this.gridColumn_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gridColumn_Id.Width = 35;
            // 
            // gridColumn_PosX
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle32.NullValue = null;
            this.gridColumn_PosX.DefaultCellStyle = dataGridViewCellStyle32;
            this.gridColumn_PosX.HeaderText = "PosX";
            this.gridColumn_PosX.MinimumWidth = 8;
            this.gridColumn_PosX.Name = "gridColumn_PosX";
            this.gridColumn_PosX.ReadOnly = true;
            this.gridColumn_PosX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_PosX.Width = 60;
            // 
            // gridColumn_PosY
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle33.NullValue = null;
            this.gridColumn_PosY.DefaultCellStyle = dataGridViewCellStyle33;
            this.gridColumn_PosY.HeaderText = "PosY";
            this.gridColumn_PosY.MinimumWidth = 8;
            this.gridColumn_PosY.Name = "gridColumn_PosY";
            this.gridColumn_PosY.ReadOnly = true;
            this.gridColumn_PosY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_PosY.Width = 60;
            // 
            // gridColumn_PosZ
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_PosZ.DefaultCellStyle = dataGridViewCellStyle34;
            this.gridColumn_PosZ.HeaderText = "PosZ";
            this.gridColumn_PosZ.MinimumWidth = 8;
            this.gridColumn_PosZ.Name = "gridColumn_PosZ";
            this.gridColumn_PosZ.ReadOnly = true;
            this.gridColumn_PosZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_PosZ.Width = 60;
            // 
            // gridColumn_Orientation
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_Orientation.DefaultCellStyle = dataGridViewCellStyle35;
            this.gridColumn_Orientation.HeaderText = "Orientation";
            this.gridColumn_Orientation.MinimumWidth = 8;
            this.gridColumn_Orientation.Name = "gridColumn_Orientation";
            this.gridColumn_Orientation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_Orientation.Width = 65;
            // 
            // gridColumn_WCTime
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_WCTime.DefaultCellStyle = dataGridViewCellStyle36;
            this.gridColumn_WCTime.HeaderText = "Time";
            this.gridColumn_WCTime.MinimumWidth = 8;
            this.gridColumn_WCTime.Name = "gridColumn_WCTime";
            this.gridColumn_WCTime.ReadOnly = true;
            this.gridColumn_WCTime.Width = 60;
            // 
            // gridColumn_WCDelay
            // 
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_WCDelay.DefaultCellStyle = dataGridViewCellStyle37;
            this.gridColumn_WCDelay.HeaderText = "Delay";
            this.gridColumn_WCDelay.MinimumWidth = 8;
            this.gridColumn_WCDelay.Name = "gridColumn_WCDelay";
            this.gridColumn_WCDelay.Width = 50;
            // 
            // gridColumn_HasScript
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_HasScript.DefaultCellStyle = dataGridViewCellStyle38;
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
            this.contextMenuStrip_WC.Size = new System.Drawing.Size(244, 130);
            // 
            // cutToolStripMenuItem_WC
            // 
            this.cutToolStripMenuItem_WC.Name = "cutToolStripMenuItem_WC";
            this.cutToolStripMenuItem_WC.Size = new System.Drawing.Size(243, 24);
            this.cutToolStripMenuItem_WC.Text = "Cut";
            this.cutToolStripMenuItem_WC.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // removeNearestPointsToolStripMenuItem_WC
            // 
            this.removeNearestPointsToolStripMenuItem_WC.Name = "removeNearestPointsToolStripMenuItem_WC";
            this.removeNearestPointsToolStripMenuItem_WC.Size = new System.Drawing.Size(243, 24);
            this.removeNearestPointsToolStripMenuItem_WC.Text = "Remove nearest points";
            this.removeNearestPointsToolStripMenuItem_WC.Click += new System.EventHandler(this.removeExcessPointsToolStripMenuItem_Click);
            // 
            // removeDuplicatePointsToolStripMenuItem_WC
            // 
            this.removeDuplicatePointsToolStripMenuItem_WC.Name = "removeDuplicatePointsToolStripMenuItem_WC";
            this.removeDuplicatePointsToolStripMenuItem_WC.Size = new System.Drawing.Size(243, 24);
            this.removeDuplicatePointsToolStripMenuItem_WC.Text = "Remove duplicate points";
            this.removeDuplicatePointsToolStripMenuItem_WC.Click += new System.EventHandler(this.removeDuplicatePointsToolStripMenuItem_WC_Click);
            // 
            // createReturnPathToolStripMenuItem_WC
            // 
            this.createReturnPathToolStripMenuItem_WC.Name = "createReturnPathToolStripMenuItem_WC";
            this.createReturnPathToolStripMenuItem_WC.Size = new System.Drawing.Size(243, 24);
            this.createReturnPathToolStripMenuItem_WC.Text = "Create return path";
            this.createReturnPathToolStripMenuItem_WC.Click += new System.EventHandler(this.createReturnPathToolStripMenuItem_WC_Click);
            // 
            // toolStripSeparator_WC
            // 
            this.toolStripSeparator_WC.Name = "toolStripSeparator_WC";
            this.toolStripSeparator_WC.Size = new System.Drawing.Size(240, 6);
            // 
            // createSQLToolStripMenuItem_WC
            // 
            this.createSQLToolStripMenuItem_WC.Name = "createSQLToolStripMenuItem_WC";
            this.createSQLToolStripMenuItem_WC.Size = new System.Drawing.Size(243, 24);
            this.createSQLToolStripMenuItem_WC.Text = "Create SQL";
            this.createSQLToolStripMenuItem_WC.Click += new System.EventHandler(this.createSQLToolStripMenuItem1_Click);
            // 
            // listBox_WC_CreatureGuids
            // 
            this.listBox_WC_CreatureGuids.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_WC_CreatureGuids.Enabled = false;
            this.listBox_WC_CreatureGuids.FormattingEnabled = true;
            this.listBox_WC_CreatureGuids.ItemHeight = 16;
            this.listBox_WC_CreatureGuids.Location = new System.Drawing.Point(805, 39);
            this.listBox_WC_CreatureGuids.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_WC_CreatureGuids.Name = "listBox_WC_CreatureGuids";
            this.listBox_WC_CreatureGuids.Size = new System.Drawing.Size(317, 708);
            this.listBox_WC_CreatureGuids.TabIndex = 27;
            this.listBox_WC_CreatureGuids.SelectedIndexChanged += new System.EventHandler(this.listBox_WCCreatureGuids_SelectedIndexChanged);
            // 
            // chart_WC
            // 
            this.chart_WC.BorderlineWidth = 0;
            this.chart_WC.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_WC.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart_WC.BorderSkin.BorderWidth = 0;
            chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea2.AxisX.IsReversed = true;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea2.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX2.MajorTickMark.Enabled = false;
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.LabelStyle.IsEndLabelVisible = false;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY2.MajorTickMark.Enabled = false;
            chartArea2.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea2.CursorY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.CursorY.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea2.Name = "ChartArea1";
            this.chart_WC.ChartAreas.Add(chartArea2);
            this.chart_WC.Enabled = false;
            legend2.Enabled = false;
            legend2.ForeColor = System.Drawing.Color.Transparent;
            legend2.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            legend2.TitleForeColor = System.Drawing.Color.Transparent;
            legend2.TitleSeparatorColor = System.Drawing.Color.Transparent;
            this.chart_WC.Legends.Add(legend2);
            this.chart_WC.Location = new System.Drawing.Point(4, 39);
            this.chart_WC.Margin = new System.Windows.Forms.Padding(4);
            this.chart_WC.Name = "chart_WC";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Path";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_WC.Series.Add(series2);
            this.chart_WC.Size = new System.Drawing.Size(795, 710);
            this.chart_WC.TabIndex = 26;
            this.chart_WC.Text = "Waypoints";
            title2.DockedToChartArea = "ChartArea1";
            title2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Path";
            title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.chart_WC.Titles.Add(title2);
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
            this.toolStrip_WC.Location = new System.Drawing.Point(3, 2);
            this.toolStrip_WC.Name = "toolStrip_WC";
            this.toolStrip_WC.Size = new System.Drawing.Size(1806, 27);
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
            this.toolStripButton_WC_Search.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton_WC_Search.Text = "Search";
            this.toolStripButton_WC_Search.ToolTipText = "Fill listbox with guids of\r\nselected entry or all entries.";
            this.toolStripButton_WC_Search.Click += new System.EventHandler(this.toolStripButton_WCSearch_Click);
            // 
            // toolStripTextBox_WC_Entry
            // 
            this.toolStripTextBox_WC_Entry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox_WC_Entry.Enabled = false;
            this.toolStripTextBox_WC_Entry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_WC_Entry.MaxLength = 40;
            this.toolStripTextBox_WC_Entry.Name = "toolStripTextBox_WC_Entry";
            this.toolStripTextBox_WC_Entry.Size = new System.Drawing.Size(92, 27);
            this.toolStripTextBox_WC_Entry.Tag = "";
            this.toolStripTextBox_WC_Entry.ToolTipText = "Input entry of creature or leave\r\nblank to fill listbox will all in sniff.";
            this.toolStripTextBox_WC_Entry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_WCSearch_Enter);
            // 
            // toolStripLabel_WC_Entry
            // 
            this.toolStripLabel_WC_Entry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_WC_Entry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_WC_Entry.Name = "toolStripLabel_WC_Entry";
            this.toolStripLabel_WC_Entry.Size = new System.Drawing.Size(152, 24);
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
            this.toolStripButton_WC_Settings.Size = new System.Drawing.Size(86, 24);
            this.toolStripButton_WC_Settings.Text = "Settings";
            this.toolStripButton_WC_Settings.ToolTipText = "Setup chart and output SQL.";
            this.toolStripButton_WC_Settings.Click += new System.EventHandler(this.toolStripButton_WCSettings_Click);
            // 
            // toolStripButton_WC_LoadSniff
            // 
            this.toolStripButton_WC_LoadSniff.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_WC_LoadSniff.Image")));
            this.toolStripButton_WC_LoadSniff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_WC_LoadSniff.Name = "toolStripButton_WC_LoadSniff";
            this.toolStripButton_WC_LoadSniff.Size = new System.Drawing.Size(112, 24);
            this.toolStripButton_WC_LoadSniff.Text = "Import Sniff";
            this.toolStripButton_WC_LoadSniff.ToolTipText = "Import a parsed wpp sniff file.";
            this.toolStripButton_WC_LoadSniff.Click += new System.EventHandler(this.toolStripButton_WCLoadSniff_Click);
            // 
            // tabPage_Output
            // 
            this.tabPage_Output.Controls.Add(this.textBox_SQLOutput);
            this.tabPage_Output.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Output.Name = "tabPage_Output";
            this.tabPage_Output.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Output.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_Output.TabIndex = 1;
            this.tabPage_Output.Text = "SQL Output";
            this.tabPage_Output.UseVisualStyleBackColor = true;
            // 
            // textBox_SQLOutput
            // 
            this.textBox_SQLOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SQLOutput.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.textBox_SQLOutput.Location = new System.Drawing.Point(3, 2);
            this.textBox_SQLOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SQLOutput.Multiline = true;
            this.textBox_SQLOutput.Name = "textBox_SQLOutput";
            this.textBox_SQLOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_SQLOutput.Size = new System.Drawing.Size(1806, 757);
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
            this.tabPage_DatabaseAdvisor.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DatabaseAdvisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_DatabaseAdvisor.Name = "tabPage_DatabaseAdvisor";
            this.tabPage_DatabaseAdvisor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_DatabaseAdvisor.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_DatabaseAdvisor.TabIndex = 2;
            this.tabPage_DatabaseAdvisor.Text = "Database Advisor";
            this.tabPage_DatabaseAdvisor.UseVisualStyleBackColor = true;
            // 
            // textBoxAreatriggerSplines
            // 
            this.textBoxAreatriggerSplines.Location = new System.Drawing.Point(7, 114);
            this.textBoxAreatriggerSplines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAreatriggerSplines.Name = "textBoxAreatriggerSplines";
            this.textBoxAreatriggerSplines.Size = new System.Drawing.Size(124, 22);
            this.textBoxAreatriggerSplines.TabIndex = 5;
            this.textBoxAreatriggerSplines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAreatriggerSplines_KeyDown);
            // 
            // label_AreatriggerSplines
            // 
            this.label_AreatriggerSplines.AutoSize = true;
            this.label_AreatriggerSplines.Location = new System.Drawing.Point(3, 94);
            this.label_AreatriggerSplines.Name = "label_AreatriggerSplines";
            this.label_AreatriggerSplines.Size = new System.Drawing.Size(129, 17);
            this.label_AreatriggerSplines.TabIndex = 4;
            this.label_AreatriggerSplines.Text = "Areatrigger Splines";
            // 
            // textBox_QuestFlags
            // 
            this.textBox_QuestFlags.Location = new System.Drawing.Point(7, 68);
            this.textBox_QuestFlags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_QuestFlags.Name = "textBox_QuestFlags";
            this.textBox_QuestFlags.Size = new System.Drawing.Size(81, 22);
            this.textBox_QuestFlags.TabIndex = 3;
            this.textBox_QuestFlags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_QuestFlags_KeyDown);
            // 
            // label_QuestFlags
            // 
            this.label_QuestFlags.AutoSize = true;
            this.label_QuestFlags.Location = new System.Drawing.Point(5, 48);
            this.label_QuestFlags.Name = "label_QuestFlags";
            this.label_QuestFlags.Size = new System.Drawing.Size(84, 17);
            this.label_QuestFlags.TabIndex = 2;
            this.label_QuestFlags.Text = "Quest Flags";
            // 
            // textBox_CreatureFlags
            // 
            this.textBox_CreatureFlags.Location = new System.Drawing.Point(7, 22);
            this.textBox_CreatureFlags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CreatureFlags.Name = "textBox_CreatureFlags";
            this.textBox_CreatureFlags.Size = new System.Drawing.Size(100, 22);
            this.textBox_CreatureFlags.TabIndex = 1;
            this.textBox_CreatureFlags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_CreatureFlags_KeyDown);
            // 
            // label_CreatureFlags
            // 
            this.label_CreatureFlags.AutoSize = true;
            this.label_CreatureFlags.Location = new System.Drawing.Point(4, 2);
            this.label_CreatureFlags.Name = "label_CreatureFlags";
            this.label_CreatureFlags.Size = new System.Drawing.Size(101, 17);
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
            this.tabPage_DoubleSpawnsRemover.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DoubleSpawnsRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_DoubleSpawnsRemover.Name = "tabPage_DoubleSpawnsRemover";
            this.tabPage_DoubleSpawnsRemover.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_DoubleSpawnsRemover.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_DoubleSpawnsRemover.TabIndex = 3;
            this.tabPage_DoubleSpawnsRemover.Text = "Double-Spawns Remover";
            this.tabPage_DoubleSpawnsRemover.UseVisualStyleBackColor = true;
            // 
            // checkBox_DatabaseConsidering
            // 
            this.checkBox_DatabaseConsidering.AutoSize = true;
            this.checkBox_DatabaseConsidering.Checked = true;
            this.checkBox_DatabaseConsidering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DatabaseConsidering.Location = new System.Drawing.Point(643, 62);
            this.checkBox_DatabaseConsidering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_DatabaseConsidering.Name = "checkBox_DatabaseConsidering";
            this.checkBox_DatabaseConsidering.Size = new System.Drawing.Size(168, 21);
            this.checkBox_DatabaseConsidering.TabIndex = 5;
            this.checkBox_DatabaseConsidering.Text = "Considering database";
            this.checkBox_DatabaseConsidering.UseVisualStyleBackColor = true;
            // 
            // label_GameobjectsRemoved
            // 
            this.label_GameobjectsRemoved.AutoSize = true;
            this.label_GameobjectsRemoved.Location = new System.Drawing.Point(439, 106);
            this.label_GameobjectsRemoved.Name = "label_GameobjectsRemoved";
            this.label_GameobjectsRemoved.Size = new System.Drawing.Size(169, 17);
            this.label_GameobjectsRemoved.TabIndex = 4;
            this.label_GameobjectsRemoved.Text = "No gameobjects removed";
            this.label_GameobjectsRemoved.Visible = false;
            // 
            // checkBox_GameobjectsRemover
            // 
            this.checkBox_GameobjectsRemover.AutoSize = true;
            this.checkBox_GameobjectsRemover.Checked = true;
            this.checkBox_GameobjectsRemover.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_GameobjectsRemover.Location = new System.Drawing.Point(713, 4);
            this.checkBox_GameobjectsRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_GameobjectsRemover.Name = "checkBox_GameobjectsRemover";
            this.checkBox_GameobjectsRemover.Size = new System.Drawing.Size(113, 21);
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
            this.checkBox_CreaturesRemover.Location = new System.Drawing.Point(621, 4);
            this.checkBox_CreaturesRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_CreaturesRemover.Name = "checkBox_CreaturesRemover";
            this.checkBox_CreaturesRemover.Size = new System.Drawing.Size(92, 21);
            this.checkBox_CreaturesRemover.TabIndex = 2;
            this.checkBox_CreaturesRemover.Text = "Creatures";
            this.checkBox_CreaturesRemover.UseVisualStyleBackColor = true;
            this.checkBox_CreaturesRemover.CheckedChanged += new System.EventHandler(this.checkBox_CreaturesRemover_CheckedChanged);
            // 
            // label_CreaturesRemoved
            // 
            this.label_CreaturesRemoved.AutoSize = true;
            this.label_CreaturesRemoved.Location = new System.Drawing.Point(439, 90);
            this.label_CreaturesRemoved.Name = "label_CreaturesRemoved";
            this.label_CreaturesRemoved.Size = new System.Drawing.Size(149, 17);
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
            this.button_ImportFileForRemoving.Location = new System.Drawing.Point(621, 23);
            this.button_ImportFileForRemoving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ImportFileForRemoving.Name = "button_ImportFileForRemoving";
            this.button_ImportFileForRemoving.Size = new System.Drawing.Size(196, 34);
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
            this.coreScriptTemplates.Location = new System.Drawing.Point(4, 25);
            this.coreScriptTemplates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coreScriptTemplates.Name = "coreScriptTemplates";
            this.coreScriptTemplates.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coreScriptTemplates.Size = new System.Drawing.Size(1812, 761);
            this.coreScriptTemplates.TabIndex = 5;
            this.coreScriptTemplates.Text = "Core Script Templates";
            this.coreScriptTemplates.UseVisualStyleBackColor = true;
            // 
            // treeView_CoreScriptTemplates_HookBodies
            // 
            this.treeView_CoreScriptTemplates_HookBodies.CheckBoxes = true;
            this.treeView_CoreScriptTemplates_HookBodies.Location = new System.Drawing.Point(215, 39);
            this.treeView_CoreScriptTemplates_HookBodies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_CoreScriptTemplates_HookBodies.Name = "treeView_CoreScriptTemplates_HookBodies";
            this.treeView_CoreScriptTemplates_HookBodies.Size = new System.Drawing.Size(223, 708);
            this.treeView_CoreScriptTemplates_HookBodies.TabIndex = 6;
            // 
            // label_CoreScriptTemplates_ScriptType
            // 
            this.label_CoreScriptTemplates_ScriptType.AutoSize = true;
            this.label_CoreScriptTemplates_ScriptType.Location = new System.Drawing.Point(5, 10);
            this.label_CoreScriptTemplates_ScriptType.Name = "label_CoreScriptTemplates_ScriptType";
            this.label_CoreScriptTemplates_ScriptType.Size = new System.Drawing.Size(84, 17);
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
            this.comboBox_CoreScriptTemplates_ScriptType.Location = new System.Drawing.Point(92, 7);
            this.comboBox_CoreScriptTemplates_ScriptType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_CoreScriptTemplates_ScriptType.Name = "comboBox_CoreScriptTemplates_ScriptType";
            this.comboBox_CoreScriptTemplates_ScriptType.Size = new System.Drawing.Size(108, 24);
            this.comboBox_CoreScriptTemplates_ScriptType.TabIndex = 1;
            this.comboBox_CoreScriptTemplates_ScriptType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label_CoreScriptTemplates_Entry
            // 
            this.label_CoreScriptTemplates_Entry.AutoSize = true;
            this.label_CoreScriptTemplates_Entry.Location = new System.Drawing.Point(235, 10);
            this.label_CoreScriptTemplates_Entry.Name = "label_CoreScriptTemplates_Entry";
            this.label_CoreScriptTemplates_Entry.Size = new System.Drawing.Size(106, 17);
            this.label_CoreScriptTemplates_Entry.TabIndex = 4;
            this.label_CoreScriptTemplates_Entry.Text = "Enter Object Id:";
            // 
            // textBox_CoreScriptTemplates_Entry
            // 
            this.textBox_CoreScriptTemplates_Entry.Enabled = false;
            this.textBox_CoreScriptTemplates_Entry.Location = new System.Drawing.Point(347, 7);
            this.textBox_CoreScriptTemplates_Entry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CoreScriptTemplates_Entry.MaxLength = 6;
            this.textBox_CoreScriptTemplates_Entry.Name = "textBox_CoreScriptTemplates_Entry";
            this.textBox_CoreScriptTemplates_Entry.Size = new System.Drawing.Size(63, 22);
            this.textBox_CoreScriptTemplates_Entry.TabIndex = 2;
            this.textBox_CoreScriptTemplates_Entry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CoreScriptTemplates_Enter);
            // 
            // listBox_CoreScriptTemplates_Hooks
            // 
            this.listBox_CoreScriptTemplates_Hooks.ItemHeight = 16;
            this.listBox_CoreScriptTemplates_Hooks.Location = new System.Drawing.Point(7, 39);
            this.listBox_CoreScriptTemplates_Hooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_CoreScriptTemplates_Hooks.Name = "listBox_CoreScriptTemplates_Hooks";
            this.listBox_CoreScriptTemplates_Hooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_CoreScriptTemplates_Hooks.Size = new System.Drawing.Size(193, 708);
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
            this.tabPage_Achievements.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Achievements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Achievements.Name = "tabPage_Achievements";
            this.tabPage_Achievements.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Achievements.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_Achievements.TabIndex = 6;
            this.tabPage_Achievements.Text = "Achievements";
            this.tabPage_Achievements.UseVisualStyleBackColor = true;
            // 
            // label_Achievements_ModifierTreeChildNodes
            // 
            this.label_Achievements_ModifierTreeChildNodes.AutoSize = true;
            this.label_Achievements_ModifierTreeChildNodes.Location = new System.Drawing.Point(1491, 180);
            this.label_Achievements_ModifierTreeChildNodes.Name = "label_Achievements_ModifierTreeChildNodes";
            this.label_Achievements_ModifierTreeChildNodes.Size = new System.Drawing.Size(176, 17);
            this.label_Achievements_ModifierTreeChildNodes.TabIndex = 16;
            this.label_Achievements_ModifierTreeChildNodes.Text = "Modifier Tree Child Nodes:";
            // 
            // treeView_Achievements_ModifierTreeChildNodes
            // 
            this.treeView_Achievements_ModifierTreeChildNodes.Location = new System.Drawing.Point(1355, 201);
            this.treeView_Achievements_ModifierTreeChildNodes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_Achievements_ModifierTreeChildNodes.Name = "treeView_Achievements_ModifierTreeChildNodes";
            this.treeView_Achievements_ModifierTreeChildNodes.Size = new System.Drawing.Size(445, 546);
            this.treeView_Achievements_ModifierTreeChildNodes.TabIndex = 15;
            // 
            // label_Achievements_ModifierTrees
            // 
            this.label_Achievements_ModifierTrees.AutoSize = true;
            this.label_Achievements_ModifierTrees.Location = new System.Drawing.Point(1076, 181);
            this.label_Achievements_ModifierTrees.Name = "label_Achievements_ModifierTrees";
            this.label_Achievements_ModifierTrees.Size = new System.Drawing.Size(103, 17);
            this.label_Achievements_ModifierTrees.TabIndex = 14;
            this.label_Achievements_ModifierTrees.Text = "Modifier Trees:";
            // 
            // treeView_Achievements_ModifierTrees
            // 
            this.treeView_Achievements_ModifierTrees.Location = new System.Drawing.Point(904, 201);
            this.treeView_Achievements_ModifierTrees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_Achievements_ModifierTrees.Name = "treeView_Achievements_ModifierTrees";
            this.treeView_Achievements_ModifierTrees.Size = new System.Drawing.Size(445, 546);
            this.treeView_Achievements_ModifierTrees.TabIndex = 13;
            this.treeView_Achievements_ModifierTrees.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ModifierTrees_AfterCollapse);
            this.treeView_Achievements_ModifierTrees.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ModifierTrees_AfterExpand);
            // 
            // label_Achievements_Criterias
            // 
            this.label_Achievements_Criterias.AutoSize = true;
            this.label_Achievements_Criterias.Location = new System.Drawing.Point(645, 180);
            this.label_Achievements_Criterias.Name = "label_Achievements_Criterias";
            this.label_Achievements_Criterias.Size = new System.Drawing.Size(64, 17);
            this.label_Achievements_Criterias.TabIndex = 12;
            this.label_Achievements_Criterias.Text = "Criterias:";
            // 
            // treeView_Achievements_Criterias
            // 
            this.treeView_Achievements_Criterias.Location = new System.Drawing.Point(453, 201);
            this.treeView_Achievements_Criterias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_Achievements_Criterias.Name = "treeView_Achievements_Criterias";
            this.treeView_Achievements_Criterias.Size = new System.Drawing.Size(445, 546);
            this.treeView_Achievements_Criterias.TabIndex = 11;
            this.treeView_Achievements_Criterias.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_Criterias_AfterCollapse);
            this.treeView_Achievements_Criterias.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_Criterias_AfterExpand);
            // 
            // label_Achievements_CriteriaTree_Amount
            // 
            this.label_Achievements_CriteriaTree_Amount.AutoSize = true;
            this.label_Achievements_CriteriaTree_Amount.Location = new System.Drawing.Point(5, 135);
            this.label_Achievements_CriteriaTree_Amount.Name = "label_Achievements_CriteriaTree_Amount";
            this.label_Achievements_CriteriaTree_Amount.Size = new System.Drawing.Size(143, 17);
            this.label_Achievements_CriteriaTree_Amount.TabIndex = 10;
            this.label_Achievements_CriteriaTree_Amount.Text = "CriteriaTree Amount: ";
            // 
            // label_Achievements_CreteriaThreeChilds
            // 
            this.label_Achievements_CreteriaThreeChilds.AutoSize = true;
            this.label_Achievements_CreteriaThreeChilds.Location = new System.Drawing.Point(143, 182);
            this.label_Achievements_CreteriaThreeChilds.Name = "label_Achievements_CreteriaThreeChilds";
            this.label_Achievements_CreteriaThreeChilds.Size = new System.Drawing.Size(171, 17);
            this.label_Achievements_CreteriaThreeChilds.TabIndex = 9;
            this.label_Achievements_CreteriaThreeChilds.Text = "Criteria Tree Child Nodes:";
            // 
            // label_Achievement_CriteriaTree_Operator
            // 
            this.label_Achievement_CriteriaTree_Operator.AutoSize = true;
            this.label_Achievement_CriteriaTree_Operator.Location = new System.Drawing.Point(5, 156);
            this.label_Achievement_CriteriaTree_Operator.Name = "label_Achievement_CriteriaTree_Operator";
            this.label_Achievement_CriteriaTree_Operator.Size = new System.Drawing.Size(152, 17);
            this.label_Achievement_CriteriaTree_Operator.TabIndex = 8;
            this.label_Achievement_CriteriaTree_Operator.Text = "CriteriaTree Operator: ";
            // 
            // label_Achievements_CriteriaTreeName
            // 
            this.label_Achievements_CriteriaTreeName.AutoSize = true;
            this.label_Achievements_CriteriaTreeName.Location = new System.Drawing.Point(4, 116);
            this.label_Achievements_CriteriaTreeName.Name = "label_Achievements_CriteriaTreeName";
            this.label_Achievements_CriteriaTreeName.Size = new System.Drawing.Size(132, 17);
            this.label_Achievements_CriteriaTreeName.TabIndex = 7;
            this.label_Achievements_CriteriaTreeName.Text = "CriteriaTree Name: ";
            // 
            // label_Achievements_CriteriaTreeId
            // 
            this.label_Achievements_CriteriaTreeId.AutoSize = true;
            this.label_Achievements_CriteriaTreeId.Location = new System.Drawing.Point(5, 96);
            this.label_Achievements_CriteriaTreeId.Name = "label_Achievements_CriteriaTreeId";
            this.label_Achievements_CriteriaTreeId.Size = new System.Drawing.Size(106, 17);
            this.label_Achievements_CriteriaTreeId.TabIndex = 6;
            this.label_Achievements_CriteriaTreeId.Text = "CriteriaTree Id: ";
            // 
            // label_Achievements_Flags
            // 
            this.label_Achievements_Flags.AutoSize = true;
            this.label_Achievements_Flags.Location = new System.Drawing.Point(5, 68);
            this.label_Achievements_Flags.Name = "label_Achievements_Flags";
            this.label_Achievements_Flags.Size = new System.Drawing.Size(135, 17);
            this.label_Achievements_Flags.TabIndex = 5;
            this.label_Achievements_Flags.Text = "Achievement Flags: ";
            // 
            // label_Achievements_Faction
            // 
            this.label_Achievements_Faction.AutoSize = true;
            this.label_Achievements_Faction.Location = new System.Drawing.Point(4, 48);
            this.label_Achievements_Faction.Name = "label_Achievements_Faction";
            this.label_Achievements_Faction.Size = new System.Drawing.Size(147, 17);
            this.label_Achievements_Faction.TabIndex = 4;
            this.label_Achievements_Faction.Text = "Achievement Faction: ";
            // 
            // treeView_Achievements_ChildNodes
            // 
            this.treeView_Achievements_ChildNodes.Location = new System.Drawing.Point(4, 201);
            this.treeView_Achievements_ChildNodes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_Achievements_ChildNodes.Name = "treeView_Achievements_ChildNodes";
            this.treeView_Achievements_ChildNodes.Size = new System.Drawing.Size(445, 546);
            this.treeView_Achievements_ChildNodes.TabIndex = 3;
            this.treeView_Achievements_ChildNodes.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ChildNodes_AfterCollapse);
            this.treeView_Achievements_ChildNodes.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ChildNodes_AfterExpand);
            // 
            // label_Achievement_Name
            // 
            this.label_Achievement_Name.AutoSize = true;
            this.label_Achievement_Name.Location = new System.Drawing.Point(4, 28);
            this.label_Achievement_Name.Name = "label_Achievement_Name";
            this.label_Achievement_Name.Size = new System.Drawing.Size(138, 17);
            this.label_Achievement_Name.TabIndex = 2;
            this.label_Achievement_Name.Text = "Achievement Name: ";
            // 
            // textBoxAchievements_Id
            // 
            this.textBoxAchievements_Id.Location = new System.Drawing.Point(116, 2);
            this.textBoxAchievements_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAchievements_Id.Name = "textBoxAchievements_Id";
            this.textBoxAchievements_Id.Size = new System.Drawing.Size(89, 22);
            this.textBoxAchievements_Id.TabIndex = 1;
            this.textBoxAchievements_Id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAchievements_Id_KeyUp);
            // 
            // label_Achievements_Id
            // 
            this.label_Achievements_Id.AutoSize = true;
            this.label_Achievements_Id.Location = new System.Drawing.Point(4, 6);
            this.label_Achievements_Id.Name = "label_Achievements_Id";
            this.label_Achievements_Id.Size = new System.Drawing.Size(108, 17);
            this.label_Achievements_Id.TabIndex = 0;
            this.label_Achievements_Id.Text = "Achievement Id:";
            // 
            // tabAuraSpell_Creator
            // 
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScripts_GenerateSQL);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScripts_ActionTarget_ComboBox);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScripts_ActionOrgCaster_ComboBox);
            this.tabAuraSpell_Creator.Controls.Add(this.label8);
            this.tabAuraSpell_Creator.Controls.Add(this.label6);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_SpellId_Label);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_SpellID_TextBox);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_SQL_Out_RichTextBox);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_Button_Add);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_Hooks_ComboBox);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_Hook_Label);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScriptSources_ComboBox);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_ActionComboBox);
            this.tabAuraSpell_Creator.Controls.Add(this.label7);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScripts_ActionCaster_ComboBox);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_EffIndex_ComboBox);
            this.tabAuraSpell_Creator.Controls.Add(this.CalculationType_Label);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_CalcType_ComboBox);
            this.tabAuraSpell_Creator.Controls.Add(this.label5);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScript_Triggered_ComboBox);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScripts_ActionSpellList_TextBox);
            this.tabAuraSpell_Creator.Controls.Add(this.label4);
            this.tabAuraSpell_Creator.Controls.Add(this.label3);
            this.tabAuraSpell_Creator.Controls.Add(this.label2);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScripts_ActionSpellId_TextBox);
            this.tabAuraSpell_Creator.Controls.Add(this.label1);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAura_ActionLabel);
            this.tabAuraSpell_Creator.Controls.Add(this.ScriptType_Label);
            this.tabAuraSpell_Creator.Controls.Add(this.SpellAuraScriptType_ComboBox);
            this.tabAuraSpell_Creator.Controls.Add(this.ScriptHookAuraSpell_Label);
            this.tabAuraSpell_Creator.Location = new System.Drawing.Point(4, 25);
            this.tabAuraSpell_Creator.Margin = new System.Windows.Forms.Padding(4);
            this.tabAuraSpell_Creator.Name = "tabAuraSpell_Creator";
            this.tabAuraSpell_Creator.Padding = new System.Windows.Forms.Padding(4);
            this.tabAuraSpell_Creator.Size = new System.Drawing.Size(1812, 761);
            this.tabAuraSpell_Creator.TabIndex = 7;
            this.tabAuraSpell_Creator.Text = "SpellAuraScript Creator";
            this.tabAuraSpell_Creator.UseVisualStyleBackColor = true;
            // 
            // SpellAuraScript_SpellId_Label
            // 
            this.SpellAuraScript_SpellId_Label.AutoSize = true;
            this.SpellAuraScript_SpellId_Label.Location = new System.Drawing.Point(9, 498);
            this.SpellAuraScript_SpellId_Label.Name = "SpellAuraScript_SpellId_Label";
            this.SpellAuraScript_SpellId_Label.Size = new System.Drawing.Size(60, 17);
            this.SpellAuraScript_SpellId_Label.TabIndex = 46;
            this.SpellAuraScript_SpellId_Label.Text = "Spell ID:";
            // 
            // SpellAuraScript_SpellID_TextBox
            // 
            this.SpellAuraScript_SpellID_TextBox.Location = new System.Drawing.Point(126, 495);
            this.SpellAuraScript_SpellID_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScript_SpellID_TextBox.MaxLength = 6;
            this.SpellAuraScript_SpellID_TextBox.Name = "SpellAuraScript_SpellID_TextBox";
            this.SpellAuraScript_SpellID_TextBox.Size = new System.Drawing.Size(142, 22);
            this.SpellAuraScript_SpellID_TextBox.TabIndex = 45;
            // 
            // SpellAuraScript_SQL_Out_RichTextBox
            // 
            this.SpellAuraScript_SQL_Out_RichTextBox.Location = new System.Drawing.Point(383, 38);
            this.SpellAuraScript_SQL_Out_RichTextBox.Name = "SpellAuraScript_SQL_Out_RichTextBox";
            this.SpellAuraScript_SQL_Out_RichTextBox.Size = new System.Drawing.Size(1122, 615);
            this.SpellAuraScript_SQL_Out_RichTextBox.TabIndex = 44;
            this.SpellAuraScript_SQL_Out_RichTextBox.Text = "";
            // 
            // SpellAuraScript_Button_Add
            // 
            this.SpellAuraScript_Button_Add.Enabled = false;
            this.SpellAuraScript_Button_Add.Location = new System.Drawing.Point(7, 540);
            this.SpellAuraScript_Button_Add.Name = "SpellAuraScript_Button_Add";
            this.SpellAuraScript_Button_Add.Size = new System.Drawing.Size(124, 23);
            this.SpellAuraScript_Button_Add.TabIndex = 43;
            this.SpellAuraScript_Button_Add.Text = "Add Script";
            this.SpellAuraScript_Button_Add.UseVisualStyleBackColor = true;
            this.SpellAuraScript_Button_Add.Click += new System.EventHandler(this.SpellAuraScript_Button_Add_Click);
            // 
            // SpellAuraScript_Hooks_ComboBox
            // 
            this.SpellAuraScript_Hooks_ComboBox.Location = new System.Drawing.Point(125, 38);
            this.SpellAuraScript_Hooks_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScript_Hooks_ComboBox.Name = "SpellAuraScript_Hooks_ComboBox";
            this.SpellAuraScript_Hooks_ComboBox.Size = new System.Drawing.Size(143, 24);
            this.SpellAuraScript_Hooks_ComboBox.TabIndex = 42;
            // 
            // SpellAuraScript_Hook_Label
            // 
            this.SpellAuraScript_Hook_Label.AutoSize = true;
            this.SpellAuraScript_Hook_Label.Location = new System.Drawing.Point(8, 38);
            this.SpellAuraScript_Hook_Label.Name = "SpellAuraScript_Hook_Label";
            this.SpellAuraScript_Hook_Label.Size = new System.Drawing.Size(52, 17);
            this.SpellAuraScript_Hook_Label.TabIndex = 41;
            this.SpellAuraScript_Hook_Label.Text = "Hooks:";
            // 
            // SpellAuraScriptSources_ComboBox
            // 
            this.SpellAuraScriptSources_ComboBox.Enabled = false;
            this.SpellAuraScriptSources_ComboBox.Items.AddRange(new object[] {
            "SourceSpellInfo",
            "SourceSpellAura"});
            this.SpellAuraScriptSources_ComboBox.Location = new System.Drawing.Point(125, 314);
            this.SpellAuraScriptSources_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScriptSources_ComboBox.Name = "SpellAuraScriptSources_ComboBox";
            this.SpellAuraScriptSources_ComboBox.Size = new System.Drawing.Size(143, 24);
            this.SpellAuraScriptSources_ComboBox.TabIndex = 40;
            // 
            // SpellAuraScript_ActionComboBox
            // 
            this.SpellAuraScript_ActionComboBox.Location = new System.Drawing.Point(125, 69);
            this.SpellAuraScript_ActionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScript_ActionComboBox.Name = "SpellAuraScript_ActionComboBox";
            this.SpellAuraScript_ActionComboBox.Size = new System.Drawing.Size(143, 24);
            this.SpellAuraScript_ActionComboBox.TabIndex = 39;
            this.SpellAuraScript_ActionComboBox.SelectedIndexChanged += new System.EventHandler(this.SpellAuraScript_ActionComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "ActionCaster:";
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
            this.SpellAuraScripts_ActionCaster_ComboBox.Location = new System.Drawing.Point(126, 111);
            this.SpellAuraScripts_ActionCaster_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScripts_ActionCaster_ComboBox.Name = "SpellAuraScripts_ActionCaster_ComboBox";
            this.SpellAuraScripts_ActionCaster_ComboBox.Size = new System.Drawing.Size(142, 24);
            this.SpellAuraScripts_ActionCaster_ComboBox.TabIndex = 37;
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
            this.SpellAuraScript_EffIndex_ComboBox.Location = new System.Drawing.Point(125, 267);
            this.SpellAuraScript_EffIndex_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScript_EffIndex_ComboBox.Name = "SpellAuraScript_EffIndex_ComboBox";
            this.SpellAuraScript_EffIndex_ComboBox.Size = new System.Drawing.Size(143, 24);
            this.SpellAuraScript_EffIndex_ComboBox.TabIndex = 35;
            // 
            // CalculationType_Label
            // 
            this.CalculationType_Label.AutoSize = true;
            this.CalculationType_Label.Location = new System.Drawing.Point(6, 237);
            this.CalculationType_Label.Name = "CalculationType_Label";
            this.CalculationType_Label.Size = new System.Drawing.Size(113, 17);
            this.CalculationType_Label.TabIndex = 34;
            this.CalculationType_Label.Text = "CalculationType:";
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
            this.SpellAuraScript_CalcType_ComboBox.Location = new System.Drawing.Point(125, 234);
            this.SpellAuraScript_CalcType_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScript_CalcType_ComboBox.Name = "SpellAuraScript_CalcType_ComboBox";
            this.SpellAuraScript_CalcType_ComboBox.Size = new System.Drawing.Size(143, 24);
            this.SpellAuraScript_CalcType_ComboBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 32;
            // 
            // SpellAuraScript_Triggered_ComboBox
            // 
            this.SpellAuraScript_Triggered_ComboBox.Enabled = false;
            this.SpellAuraScript_Triggered_ComboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.SpellAuraScript_Triggered_ComboBox.Location = new System.Drawing.Point(125, 402);
            this.SpellAuraScript_Triggered_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScript_Triggered_ComboBox.Name = "SpellAuraScript_Triggered_ComboBox";
            this.SpellAuraScript_Triggered_ComboBox.Size = new System.Drawing.Size(143, 24);
            this.SpellAuraScript_Triggered_ComboBox.TabIndex = 31;
            // 
            // SpellAuraScripts_ActionSpellList_TextBox
            // 
            this.SpellAuraScripts_ActionSpellList_TextBox.Enabled = false;
            this.SpellAuraScripts_ActionSpellList_TextBox.Location = new System.Drawing.Point(125, 451);
            this.SpellAuraScripts_ActionSpellList_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScripts_ActionSpellList_TextBox.MaxLength = 6;
            this.SpellAuraScripts_ActionSpellList_TextBox.Name = "SpellAuraScripts_ActionSpellList_TextBox";
            this.SpellAuraScripts_ActionSpellList_TextBox.Size = new System.Drawing.Size(143, 22);
            this.SpellAuraScripts_ActionSpellList_TextBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "ActionSpellList:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Triggered:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Action Spell ID:";
            // 
            // SpellAuraScripts_ActionSpellId_TextBox
            // 
            this.SpellAuraScripts_ActionSpellId_TextBox.Enabled = false;
            this.SpellAuraScripts_ActionSpellId_TextBox.Location = new System.Drawing.Point(126, 362);
            this.SpellAuraScripts_ActionSpellId_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScripts_ActionSpellId_TextBox.MaxLength = 6;
            this.SpellAuraScripts_ActionSpellId_TextBox.Name = "SpellAuraScripts_ActionSpellId_TextBox";
            this.SpellAuraScripts_ActionSpellId_TextBox.Size = new System.Drawing.Size(142, 22);
            this.SpellAuraScripts_ActionSpellId_TextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "EffectIndex";
            // 
            // SpellAura_ActionLabel
            // 
            this.SpellAura_ActionLabel.AutoSize = true;
            this.SpellAura_ActionLabel.Location = new System.Drawing.Point(9, 69);
            this.SpellAura_ActionLabel.Name = "SpellAura_ActionLabel";
            this.SpellAura_ActionLabel.Size = new System.Drawing.Size(51, 17);
            this.SpellAura_ActionLabel.TabIndex = 17;
            this.SpellAura_ActionLabel.Text = "Action:";
            // 
            // ScriptType_Label
            // 
            this.ScriptType_Label.AutoSize = true;
            this.ScriptType_Label.Location = new System.Drawing.Point(7, 13);
            this.ScriptType_Label.Name = "ScriptType_Label";
            this.ScriptType_Label.Size = new System.Drawing.Size(84, 17);
            this.ScriptType_Label.TabIndex = 11;
            this.ScriptType_Label.Text = "Script Type:";
            // 
            // SpellAuraScriptType_ComboBox
            // 
            this.SpellAuraScriptType_ComboBox.Items.AddRange(new object[] {
            "SpellScript",
            "AuraScript"});
            this.SpellAuraScriptType_ComboBox.Location = new System.Drawing.Point(125, 10);
            this.SpellAuraScriptType_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScriptType_ComboBox.Name = "SpellAuraScriptType_ComboBox";
            this.SpellAuraScriptType_ComboBox.Size = new System.Drawing.Size(143, 24);
            this.SpellAuraScriptType_ComboBox.TabIndex = 8;
            this.SpellAuraScriptType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.SpellAuraScriptType_ComboBox_SelectedIndexChanged);
            // 
            // ScriptHookAuraSpell_Label
            // 
            this.ScriptHookAuraSpell_Label.AutoSize = true;
            this.ScriptHookAuraSpell_Label.Location = new System.Drawing.Point(9, 314);
            this.ScriptHookAuraSpell_Label.Name = "ScriptHookAuraSpell_Label";
            this.ScriptHookAuraSpell_Label.Size = new System.Drawing.Size(94, 17);
            this.ScriptHookAuraSpell_Label.TabIndex = 10;
            this.ScriptHookAuraSpell_Label.Text = "DataSources:";
            // 
            // statusStrip_LoadedFile
            // 
            this.statusStrip_LoadedFile.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip_LoadedFile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip_LoadedFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_FileStatus,
            this.toolStripStatusLabel_CurrentAction});
            this.statusStrip_LoadedFile.Location = new System.Drawing.Point(0, 781);
            this.statusStrip_LoadedFile.Name = "statusStrip_LoadedFile";
            this.statusStrip_LoadedFile.Padding = new System.Windows.Forms.Padding(3, 0, 12, 0);
            this.statusStrip_LoadedFile.Size = new System.Drawing.Size(1540, 26);
            this.statusStrip_LoadedFile.TabIndex = 2;
            this.statusStrip_LoadedFile.Text = "statusStrip";
            // 
            // toolStripStatusLabel_FileStatus
            // 
            this.toolStripStatusLabel_FileStatus.Name = "toolStripStatusLabel_FileStatus";
            this.toolStripStatusLabel_FileStatus.Size = new System.Drawing.Size(110, 20);
            this.toolStripStatusLabel_FileStatus.Text = "No File Loaded";
            // 
            // toolStripStatusLabel_CurrentAction
            // 
            this.toolStripStatusLabel_CurrentAction.Name = "toolStripStatusLabel_CurrentAction";
            this.toolStripStatusLabel_CurrentAction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel_CurrentAction.Size = new System.Drawing.Size(0, 20);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog_WSC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "ActionOrgCaster:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "ActionTarget:";
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
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.Location = new System.Drawing.Point(126, 200);
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.Name = "SpellAuraScripts_ActionOrgCaster_ComboBox";
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.Size = new System.Drawing.Size(142, 24);
            this.SpellAuraScripts_ActionOrgCaster_ComboBox.TabIndex = 49;
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
            this.SpellAuraScripts_ActionTarget_ComboBox.Location = new System.Drawing.Point(126, 163);
            this.SpellAuraScripts_ActionTarget_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellAuraScripts_ActionTarget_ComboBox.Name = "SpellAuraScripts_ActionTarget_ComboBox";
            this.SpellAuraScripts_ActionTarget_ComboBox.Size = new System.Drawing.Size(142, 24);
            this.SpellAuraScripts_ActionTarget_ComboBox.TabIndex = 50;
            // 
            // SpellAuraScripts_GenerateSQL
            // 
            this.SpellAuraScripts_GenerateSQL.Location = new System.Drawing.Point(144, 540);
            this.SpellAuraScripts_GenerateSQL.Name = "SpellAuraScripts_GenerateSQL";
            this.SpellAuraScripts_GenerateSQL.Size = new System.Drawing.Size(124, 23);
            this.SpellAuraScripts_GenerateSQL.TabIndex = 51;
            this.SpellAuraScripts_GenerateSQL.Text = "Generate SQL";
            this.SpellAuraScripts_GenerateSQL.UseVisualStyleBackColor = true;
            this.SpellAuraScripts_GenerateSQL.Click += new System.EventHandler(this.SpellAuraScripts_GenerateSQL_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1540, 807);
            this.Controls.Add(this.statusStrip_LoadedFile);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Wow Developer Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl.ResumeLayout(false);
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
            this.statusStrip_LoadedFile.ResumeLayout(false);
            this.statusStrip_LoadedFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
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
    }
}

