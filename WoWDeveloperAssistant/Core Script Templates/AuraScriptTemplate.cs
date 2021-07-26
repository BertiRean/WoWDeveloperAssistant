using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WoWDeveloperAssistant.Misc;
using System;

namespace WoWDeveloperAssistant.Core_Script_Templates
{
    public static class AuraScriptTemplate
    {
        public static readonly Dictionary<string, string> hooksDictionary = new Dictionary<string, string>
        {
            { "OnDispel",                   "void HandleOnDispel(DispelInfo* p_DispelInfo)"   },
            { "AfterDispel",                "void HandleAfterDispel(DispelInfo* p_DispelInfo)"   },
            { "OnEffectApply",              "void HandleOnEffApply(AuraEffect const* p_AurEff, AuraEffectHandleModes p_Mode)"   },
            { "AfterEffectApply",           "void HandleAfterEffApply(AuraEffect const* p_AurEff, AuraEffectHandleModes p_Mode)"   },
            { "OnEffectRemove",             "void HandleOnEffRemove(AuraEffect const* p_AurEff, AuraEffectHandleModes p_Mode)"   },
            { "AfterEffectRemove",          "void HandleAfterEffRemove(AuraEffect const* p_AurEff, AuraEffectHandleModes p_Mode)"   },
            { "OnEffectPeriodic",           "void HandleOnEffPeriodic(AuraEffect const* p_AurEff)"   },
            { "AfterEffectPeriodic",        "void HandleAfterEffPeriodic(AuraEffect const* p_AurEff)"   },
            { "OnAuraUpdate",               "void HandleOnAuraUpdate(const uint32 p_Diff)"   },
            { "OnEffectUpdate",             "void HandleOnEffUpdate(AuraEffect* p_AurEff)"   },
            { "OnEffectUpdatePeriodic",     "void HandleOnEffUpdatePeriodic(AuraEffect* p_AurEff)"   },
            { "DoEffectCalcAmount",         "void HandleCalcEffAmount(AuraEffect const* aurEff, int32& amount, bool& canBeRecalculated)"   },
            { "DoCalcMaxDuration",          "void HandleCalcMaxDuration(int32 & p_MaxDuration)"   },
            { "DoEffectCalcPeriodic",       "void HandleCalcMaxDuration(AuraEffect const* p_AurEff, bool& p_IsPeriodic, int32& p_AuraPeriod)"   },
            { "DoEffectCalcSpellMod",       "void HandleCalcEffSpellMod(AuraEffect const* p_AurEff, SpellModifier*& p_SpellMod)"   },
            { "OnEffectAbsorb",             "void HandleOnEffAbsorb(AuraEffect* p_AurEff, DamageInfo& p_DmgInfo, uint32& p_AbsorbAmount)"   },
            { "AfterEffectAbsorb",          "void HandleAfterEffAbsorb(AuraEffect* p_AurEff, DamageInfo& p_DmgInfo, uint32& p_AbsorbAmount)"   },
            { "OnEffectManaShield",         "void HandleOnEffManaShield(AuraEffect* p_AurEff, DamageInfo& p_DmgInfo, uint32& p_AbsorbAmount)"   },
            { "AfterEffectManaShield",      "void HandleAfterEffManaShield(AuraEffect* p_AurEff, DamageInfo& p_DmgInfo, uint32& p_AbsorbAmount)"   },
            { "OnEffectSplitDamage",        "void HandleOnEffSplitDmg(AuraEffect* p_AurEff, DamageInfo& p_DmgInfo, uint32& p_SplitAmount)"   },
            { "DoCheckProc",                "bool HandleCheckProc(ProcEventInfo & p_EventInfo)"   },
            { "DoCheckEffectProc",          "void HandleCheckEffProc(AuraEffect const* p_AurEff, ProcEventInfo& p_EventInfo, bool & p_IsTriggeredEffect)"   },
            { "DoCalcPPM",                  "void HandleCalcPPM(float & p_PPM, ProcEventInfo & p_EventInfo)"   },
            { "DoCalcProcChance",           "void HandleCalcProcChance(float & p_Chance, ProcEventInfo & p_EventInfo)"   },
            { "DoPrepareProc",              "void HandlePrepareProc(ProcEventInfo & p_EventInfo)"   },
            { "OnProc",                     "void HandleOnProc(ProcEventInfo & p_EventInfo)"   },
            { "AfterProc",                  "void HandleAfterProc(ProcEventInfo & p_EventInfo)"   },
            { "OnEffectProc",               "void HandleOnEffProc(AuraEffect const* p_AurEff, ProcEventInfo& p_EventInfo)"   },
            { "AfterEffectProc",            "void HandleAfterEffProc(AuraEffect const* p_AurEff, ProcEventInfo& p_EventInfo)"   },
            { "CanRefreshProc",             "bool HandleCheckRefreshProc()"   },
            { "OnEffectKeyboundOverride",   "void HandleOnEffKeyboundOverride(AuraEffect* p_AurEff, DamageInfo& p_DmgInfo, uint32& p_SplitAmount)"   },
        };

        public static readonly Dictionary<string, string> hooksMacrosDictionary = new Dictionary<string, string>
        {
            { "OnDispel",                   "+= AuraDispelFn({0}::HandleOnDispel);"   },
            { "AfterDispel",                "+= AuraDispelFn({0}::HandleAfterDispel);"   },
            { "OnEffectApply",              "+= AuraEffectApplyFn({0}::HandleOnEffApply, SpellEffIndex::, AuraType::, AuraEffectHandleModes::);"   },
            { "AfterEffectApply",           "+= AuraEffectApplyFn({0}::HandleAfterEffApply, SpellEffIndex::, AuraType::, AuraEffectHandleModes::);"   },
            { "OnEffectRemove",             "+= AuraEffectRemoveFn({0}::HandleOnEffRemove, SpellEffIndex::, AuraType::, AuraEffectHandleModes::);"   },
            { "AfterEffectRemove",          "+= AuraEffectRemoveFn({0}::HandleAfterEffRemove, SpellEffIndex::, AuraType::, AuraEffectHandleModes::);"   },
            { "OnEffectPeriodic",           "+= AuraEffectPeriodicFn({0}::HandleOnEffPeriodic, SpellEffIndex::, AuraType::);"   },
            { "AfterEffectPeriodic",        "+= AuraEffectPeriodicFn({0}::HandleAfterEffPeriodic, SpellEffIndex::, AuraType::);"   },
            { "OnAuraUpdate",               "+= AuraUpdateFn({0}::HandleOnAuraUpdate);"   },
            { "OnEffectUpdate",             "+= AuraEffectUpdateFn({0}::HandleOnEffUpdate, SpellEffIndex::, AuraType::);"   },
            { "OnEffectUpdatePeriodic",     "+= AuraEffectUpdatePeriodicFn({0}::HandleOnEffUpdatePeriodic, SpellEffIndex::, AuraType::);"   },
            { "DoEffectCalcAmount",         "+= AuraEffectCalcAmounFn({0}::HandleCalcEffAmount, SpellEffIndex::, AuraType::);"   },
            { "DoCalcMaxDuration",          "+= AuraCalcMaxDurationFn({0}::HandleCalcMaxDuration);"   },
            { "DoEffectCalcPeriodic",       "+= AuraEffectCalcPeriodicFn({0}::HandleCalcMaxDuration, SpellEffIndex::, AuraType::);"   },
            { "DoEffectCalcSpellMod",       "+= AuraEffectCalcSpellModFn({0}::HandleCalcEffSpellMod, SpellEffIndex::, AuraType::);"   },
            { "OnEffectAbsorb",             "+= AuraEffectAbsorbFn({0}::HandleOnEffAbsorb, SpellEffIndex::);"   },
            { "AfterEffectAbsorb",          "+= AuraEffectAbsorbFn({0}::HandleAfterEffAbsorb, SpellEffIndex::, AuraType::);"   },
            { "OnEffectManaShield",         "+= AuraEffectAbsorbFn({0}::HandleOnEffManaShield, SpellEffIndex::);"   },
            { "AfterEffectManaShield",      "+= AuraEffectAbsorbFn({0}::HandleAfterEffManaShield, SpellEffIndex::);"   },
            { "OnEffectSplitDamage",        "+= AuraEffectSplitDamageFn({0}::HandleOnEffSplitDmg, SpellEffIndex::);"   },
            { "DoCheckProc",                "+= AuraCheckProcFn({0}::HandleCheckProc);"   },
            { "DoCheckEffectProc",          "+= AuraCheckEffectProcFn({0}::HandleCheckEffProc, SpellEffIndex::, AuraType::);"   },
            { "DoCalcPPM",                  "+= AuraProcPerMinuteFn({0}::HandleCalcPPM);"   },
            { "DoCalcProcChance",           "+= AuraProcChanceFn({0}::HandleCalcProcChance);"   },
            { "DoPrepareProc",              "+= AuraProcFn({0}::HandlePrepareProc);"   },
            { "OnProc",                     "+= AuraProcFn({0}::HandleOnProc);"   },
            { "AfterProc",                  "+= AuraProcFn({0}::HandleAfterProc);"   },
            { "OnEffectProc",               "+= AuraEffectProcFn({0}::HandleOnEffProc, SpellEffIndex::, AuraType::);"   },
            { "AfterEffectProc",            "+= AuraEffectProcFn({0}::HandleAfterEffProc, SpellEffIndex::, AuraType::);"   },
            { "CanRefreshProc",             "+= AuraCanRefreshProcFn({0}::HandleCheckRefreshProc);"   },
            { "OnEffectKeyboundOverride",   "+= AuraEffectKeyboundOverrideFn({0}::HandleOnEffKeyboundOverride, SpellEffIndex::);"   },
        };

        private static readonly Dictionary<string, string> commonAuraMethods = new Dictionary<string, string>
        {
            { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"   },
            { "OwnerCheck",     "Unit* l_Owner  = GetUnitOwner();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Owner)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;" },
            { "GetCasterGUID",  "ObjectGuid l_CasterGUID = GetCasterGUID();" + "\r\n" },
            { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
            { "GetAura",        "Aura* l_Aura = GetAura();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Aura)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
            { "GetEffect",      "AuraEffect* l_AurEff = GetEffect(Index);" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_AurEff)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },

            { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
            { "OwnerAuraCheck","if (l_Owner->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
            { "AuraIdCheck","if (GetId() == DESIRED_ID)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },


            { "PreventDefaultAction", "PreventDefaultAction();" + "\r\n" },
        };

        private static readonly Dictionary<string, string> commonProcMethods = new Dictionary<string, string>
        {
            { "GetDmgInfo",             "DamageInfo* l_DmgInfo  = p_EventInfo.GetDamageInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_DmgInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"   },
            { "GetActor",               "Unit* l_Actor          = p_EventInfo.GetActor();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Actor)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;" },
            { "GetActionTarget",        "Unit* l_ActionTarget   = p_EventInfo.GetActionTarget();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_ActionTarget)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;" },
            { "GetProcTarget",          "Unit* l_Target         = p_ProcEventInfo.GetProcTarget();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_Target)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;" },
            { "GetProcEventSpellInfo",  "SpellInfo* l_ProcSpellInfo = p_EventInfo.GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_ProcSpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
            { "GetProcSpell",           "Spell* l_ProcSpell = p_EventInfo.GetSpell();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_ProcSpell)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },
            { "GetTriggerSpell",        "SpellInfo* l_DmgSpellInfo = p_ProcEventInfo.GetDamageInfo()->GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "if (!l_DmgSpellInfo)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "return;"    },

            { "TriggerSpellCheck","if (l_DmgSpellInfo->Id == DESIRED_ID)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
            { "AuraProcSpellCheck","if (l_ProcSpellInfo->Id == DESIRED_ID)" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.THREE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + "}" },
        };

        public static Dictionary<string, Dictionary<string, string>> hookBodiesDictionary = new Dictionary<string, Dictionary<string, string>>
        {
            { "OnDispel",                   commonAuraMethods   },
            { "AfterDispel",                commonAuraMethods   },
            { "OnEffectApply",              commonAuraMethods   },
            { "AfterEffectApply",           commonAuraMethods   },
            { "OnEffectRemove",             commonAuraMethods   },
            { "AfterEffectRemove",          commonAuraMethods   },
            { "OnEffectPeriodic",           commonAuraMethods   },
            { "AfterEffectPeriodic",        commonAuraMethods   },
            { "OnAuraUpdate",               commonAuraMethods   },
            { "OnEffectUpdate",             commonAuraMethods   },
            { "OnEffectUpdatePeriodic",     commonAuraMethods   },
            { "DoEffectCalcAmount",         commonAuraMethods   },
            { "DoCalcMaxDuration",          commonAuraMethods   },
            { "DoEffectCalcPeriodic",       commonAuraMethods   },
            { "DoEffectCalcSpellMod",       commonAuraMethods   },
            { "OnEffectAbsorb",             commonAuraMethods   },
            { "AfterEffectAbsorb",          commonAuraMethods   },
            { "OnEffectManaShield",         commonAuraMethods   },
            { "AfterEffectManaShield",      commonAuraMethods   },
            { "OnEffectSplitDamage",        commonAuraMethods   },
            { "DoCheckProc",                commonAuraMethods.Union(commonProcMethods).ToDictionary(k => k.Key, v => v.Value)   },
            { "DoCheckEffectProc",          commonAuraMethods.Union(commonProcMethods).ToDictionary(k => k.Key, v => v.Value)   },
            { "DoCalcPPM",                  commonAuraMethods.Union(commonProcMethods).ToDictionary(k => k.Key, v => v.Value)   },
            { "DoCalcProcChance",           commonAuraMethods.Union(commonProcMethods).ToDictionary(k => k.Key, v => v.Value)   },
            { "DoPrepareProc",              commonAuraMethods.Union(commonProcMethods).ToDictionary(k => k.Key, v => v.Value)   },
            { "OnProc",                     commonAuraMethods.Union(commonProcMethods).ToDictionary(k => k.Key, v => v.Value)   },
            { "AfterProc",                  commonAuraMethods.Union(commonProcMethods).ToDictionary(k => k.Key, v => v.Value)   },
            { "OnEffectProc",               commonAuraMethods.Union(commonProcMethods).ToDictionary(k => k.Key, v => v.Value)   },
            { "AfterEffectProc",            commonAuraMethods.Union(commonProcMethods).ToDictionary(k => k.Key, v => v.Value)   },
            { "CanRefreshProc",             commonAuraMethods   },
            { "OnEffectKeyboundOverride",   commonAuraMethods   },
        };

        public static void CreateTemplate(uint spellId, ListBox hooksListBox, TreeView hookBodiesTreeView)
        {
            string scriptBody = "";
            string defaultName = "";
            string scriptName = "";

            if (!DBC.DBC.IsLoaded())
                DBC.DBC.Load();

            if (DBC.DBC.IsLoaded() && DBC.DBC.SpellName.ContainsKey((int)spellId))
                defaultName = DBC.DBC.SpellName[(int)spellId].Name;

            if (defaultName == "")
                defaultName = "unknow_aura";

            scriptName = "spell_" + defaultName.Replace(" ", "_").ToLower().Replace("'", "") + "_" + spellId;

            scriptBody = "/// " + defaultName + " - " + spellId + "\r\n";
            scriptBody += "class " + scriptName + " : public AuraScript" + "\r\n";
            scriptBody += "{" + "\r\n";
            scriptBody += Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "PrepareAuraScript(" + scriptName + "_AuraScript" + ");" + "\r\n";
            scriptBody += GetEnumsBody(hookBodiesTreeView) + "\r\n\r\n";
            scriptBody += GetHooksBody(hooksListBox, hookBodiesTreeView) + "\r\n\r\n";
            scriptBody += Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "void Register() override" + "\r\n";
            scriptBody += Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "{" + "\r\n";
            scriptBody += GetHooksMacrosBody(hooksListBox, hookBodiesTreeView, scriptName) + "\r\n";
            scriptBody += Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB   ) + "}" + "\r\n";
            scriptBody += "};" + "\r\n";

            Clipboard.SetText(scriptBody);
            MessageBox.Show("Template has been successfully builded and copied on your clipboard!");
        }

        private static string GetGettersBody(string scriptName)
        {
            string body = "";

            body += Utils.AddSpacesCount(8) + "AuraScript* GetAuraScript() const override" + "\r\n";
            body += Utils.AddSpacesCount(8) + "{" + "\r\n";
            body += Utils.AddSpacesCount(12) + "return new " + scriptName + "_AuraScript();" + "\r\n";
            body += Utils.AddSpacesCount(8) + "}";

            return body;
        }

        private static string GetEnumsBody(TreeView hookBodiesTreeView)
        {
            string body = "";

            body += "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "enum eSpells" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + 
            "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "};";

            return body;
        }

        private static string GetHooksBody(ListBox hooksListBox, TreeView hookBodiesTreeView)
        {
            string body = "";

            foreach (var hook in hooksListBox.SelectedItems)
            {
                body += "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + hooksDictionary[hook.ToString()];
                body += "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "{" + "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB);

                foreach (TreeNode parentNode in hookBodiesTreeView.Nodes)
                {
                    if (parentNode.Text != hook.ToString())
                        continue;

                    bool moreThanOne = false;

                    foreach (TreeNode childNode in parentNode.Nodes)
                    {
                        if (childNode.Checked)
                        {
                            if (moreThanOne)
                            {
                                body += "\r\n\r\n" + Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB);
                            }

                            body += hookBodiesDictionary[hook.ToString()][childNode.Text];

                            if (!moreThanOne)
                            {
                                moreThanOne = true;
                            }
                        }
                    }
                }

                body += "\r\n" + Utils.AddSpacesCount(Utils.TabsSize.ONE_TAB) + "}";
            }

            return body;
        }

        private static string GetHooksMacrosBody(ListBox hooksListBox, TreeView hookBodiesTreeView, string scriptName)
        {
            string body = "";
            int counter = 1;

            foreach (var hook in hooksListBox.SelectedItems)
            {
                string hookStr = hook.ToString();

                body += Utils.AddSpacesCount(Utils.TabsSize.TWO_TAB) + hookStr;
                body += ' ' + String.Format(hooksMacrosDictionary[hookStr], scriptName, hookStr);

                if (counter <= hooksListBox.SelectedItems.Count)
                    body += "\r\n";

                counter++;
            }

            return body;
        }
    }
}
