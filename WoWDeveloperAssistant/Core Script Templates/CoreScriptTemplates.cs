using System;
using System.Windows.Forms;

namespace WoWDeveloperAssistant.Core_Script_Templates
{
    public class CoreScriptTemplates
    {
        private MainForm mainForm;

        public CoreScriptTemplates(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private enum ScriptTypes
        {
            Creature     = 0,
            GameObject   = 1,
            AreaTrigger  = 2,
            Spell        = 3,
            PlayerScript = 4,
            Aura         = 5,
            BossScript   = 6,
            Unknown      = 7
        };

        public void FillBoxWithHooks()
        {
            mainForm.listBox_CoreScriptTemplates_Hooks.Items.Clear();

            switch (GetScriptType(mainForm.comboBox_CoreScriptTemplates_ScriptType.SelectedIndex))
            {
                case ScriptTypes.Creature:
                {
                    foreach (var key in CreatureScriptTemplate.hooksDictionary.Keys)
                    {
                        mainForm.listBox_CoreScriptTemplates_Hooks.Items.Add(key);
                    }
                    
                    break;
                }

                case ScriptTypes.Aura:
                {
                    foreach (var key in AuraScriptTemplate.hooksDictionary.Keys)
                    {
                        mainForm.listBox_CoreScriptTemplates_Hooks.Items.Add(key);
                    }
                    break;
                }

                case ScriptTypes.Spell:
                {
                    foreach (var key in SpellScriptTemplate.hooksDictionary.Keys)
                    {
                        mainForm.listBox_CoreScriptTemplates_Hooks.Items.Add(key);

                    }
                    break;
                }

                case ScriptTypes.BossScript:
                {
                    foreach (var key in BossScriptTemplate.hooksDictionary.Keys)
                    {
                        mainForm.listBox_CoreScriptTemplates_Hooks.Items.Add(key);
                    }
                    break;
                }
            }
        }

        public void FillTreeWithHookBodies()
        {
            int index = 0;
            TreeView treeView = mainForm.treeView_CoreScriptTemplates_HookBodies;
            treeView.Nodes.Clear();

            switch (GetScriptType(mainForm.comboBox_CoreScriptTemplates_ScriptType.SelectedIndex))
            {
                case ScriptTypes.Creature:
                {
                    foreach (var hook in mainForm.listBox_CoreScriptTemplates_Hooks.SelectedItems)
                    {
                        string hookName = hook.ToString();

                        if (!CreatureScriptTemplate.hookBodiesDictionary.ContainsKey(hookName))
                            continue;

                        treeView.Nodes.Add(new TreeNode(hookName));

                        foreach (var item in CreatureScriptTemplate.hookBodiesDictionary[hookName])
                        {
                            treeView.Nodes[index].Nodes.Add(item.Key);
                        }

                        index++;
                    }

                    treeView.ExpandAll();
                    break;
                }

                case ScriptTypes.Spell:
                {
                    foreach (var hook in mainForm.listBox_CoreScriptTemplates_Hooks.SelectedItems)
                    {
                        string hookName = hook.ToString();

                        if (!SpellScriptTemplate.hookBodiesDictionary.ContainsKey(hookName))
                            continue;

                        treeView.Nodes.Add(new TreeNode(hookName));

                        foreach (var item in SpellScriptTemplate.hookBodiesDictionary[hookName])
                            treeView.Nodes[index].Nodes.Add(item.Key);

                        index++;
                    }

                    treeView.ExpandAll();

                    break;
                }

                case ScriptTypes.Aura:
                {
                    foreach (var hook in mainForm.listBox_CoreScriptTemplates_Hooks.SelectedItems)
                    {
                        string hookName = hook.ToString();

                        if (!AuraScriptTemplate.hookBodiesDictionary.ContainsKey(hookName))
                            continue;

                        treeView.Nodes.Add(new TreeNode(hookName));

                        foreach (var item in AuraScriptTemplate.hookBodiesDictionary[hookName])
                            treeView.Nodes[index].Nodes.Add(item.Key);

                        index++;
                    }

                    treeView.ExpandAll();

                    break;
                }

                case ScriptTypes.BossScript:
                {
                    foreach (var hook in mainForm.listBox_CoreScriptTemplates_Hooks.SelectedItems)
                    {
                        string hookName = hook.ToString();

                        if (!BossScriptTemplate.hookBodiesDictionary.ContainsKey(hookName))
                            continue;

                        treeView.Nodes.Add(new TreeNode(hookName));

                        foreach (var item in BossScriptTemplate.hookBodiesDictionary[hookName])
                            treeView.Nodes[index].Nodes.Add(item.Key);

                        index++;
                    }

                    treeView.ExpandAll();

                    break;
                }
            }
        }

        public void CreateTemplate()
        {
            uint objectEntry = Convert.ToUInt32(mainForm.textBox_CoreScriptTemplates_Entry.Text);

            switch (GetScriptType(mainForm.comboBox_CoreScriptTemplates_ScriptType.SelectedIndex))
            {
                case ScriptTypes.Creature:
                {
                    CreatureScriptTemplate.CreateTemplate(objectEntry, mainForm.listBox_CoreScriptTemplates_Hooks, mainForm.treeView_CoreScriptTemplates_HookBodies);
                    break;
                }

                case ScriptTypes.Spell:
                {
                    SpellScriptTemplate.CreateTemplate(objectEntry, mainForm.listBox_CoreScriptTemplates_Hooks, mainForm.treeView_CoreScriptTemplates_HookBodies);
                    break;
                }

                case ScriptTypes.Aura:
                {
                    AuraScriptTemplate.CreateTemplate(objectEntry, mainForm.listBox_CoreScriptTemplates_Hooks, mainForm.treeView_CoreScriptTemplates_HookBodies);
                    break;
                }

                case ScriptTypes.BossScript:
                {
                    BossScriptTemplate.CreateTemplate(objectEntry, mainForm.listBox_CoreScriptTemplates_Hooks, mainForm.treeView_CoreScriptTemplates_HookBodies);
                    break;
                }
            }
        }

        private static ScriptTypes GetScriptType(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    return ScriptTypes.Creature;
                case 1:
                    return ScriptTypes.GameObject;
                case 2:
                    return ScriptTypes.AreaTrigger;
                case 3:
                    return ScriptTypes.Spell;
                case 4:
                    return ScriptTypes.PlayerScript;
                case 5: 
                    return ScriptTypes.Aura;
                case 6:
                    return ScriptTypes.BossScript;
                default:
                    return ScriptTypes.Unknown;
            }
        }
    }
}
