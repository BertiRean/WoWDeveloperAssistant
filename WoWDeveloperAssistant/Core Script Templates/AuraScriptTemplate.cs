using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WoWDeveloperAssistant.Misc;

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
            { "DoCheckEffectProc",          "void HandleCheckProc(AuraEffect const* p_AurEff, ProcEventInfo& p_EventInfo, bool & p_IsTriggeredEffect)"   },
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

        private static readonly Dictionary<string, string> commonAuraMethods = new Dictionary<string, string>
        {
            { "CasterCheck",    "Unit* l_Caster = GetCaster();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_Caster)" + "\r\n" + Utils.AddSpacesCount(12) + "return;"   },
            { "OwnerCheck",     "Unit* l_Owner  = GetUnitOwner();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_Owner)" + "\r\n" + Utils.AddSpacesCount(12) + "return;" },
            { "GetCasterGUID",  "ObjectGuid l_CasterGUID = GetCasterGUID();" + "\r\n" },
            { "GetSpellInfo",   "SpellInfo* l_SpellInfo = GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_SpellInfo)" + "\r\n" + Utils.AddSpacesCount(12) + "return;"    },
            { "GetAura",        "Aura* l_Aura = GetAura();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_Aura)" + "\r\n" + Utils.AddSpacesCount(12) + "return;"    },
            { "GetEffect",      "AuraEffect* l_AurEff = GetEffect(Index);" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_AurEff)" + "\r\n" + Utils.AddSpacesCount(12) + "return;"    },

            { "CasterAuraCheck","if (l_Caster->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(8) + "{" + "\r\n" + Utils.AddSpacesCount(12) + "\r\n" + Utils.AddSpacesCount(8) + "}" },
            { "OwnerAuraCheck","if (l_Owner->HasAura(eSpells::SpellName))" + "\r\n" + Utils.AddSpacesCount(8) + "{" + "\r\n" + Utils.AddSpacesCount(12) + "\r\n" + Utils.AddSpacesCount(8) + "}" },
            { "AuraIdCheck","if (GetId() == DESIRED_ID)" + "\r\n" + Utils.AddSpacesCount(8) + "{" + "\r\n" + Utils.AddSpacesCount(12) + "\r\n" + Utils.AddSpacesCount(8) + "}" },
            

            { "PreventDefaultAction", "PreventDefaultAction();" + "\r\n" },
        };

        private static readonly Dictionary<string, string> commonProcMethods = new Dictionary<string, string>
        {
            { "GetDmgInfo",             "DamageInfo* l_DmgInfo  = p_EventInfo.GetDamageInfo();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_DmgInfo)" + "\r\n" + Utils.AddSpacesCount(12) + "return;"   },
            { "GetActor",               "Unit* l_Actor          = p_EventInfo.GetActor();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_Actor)" + "\r\n" + Utils.AddSpacesCount(12) + "return;" },
            { "GetActionTarget",        "Unit* l_ActionTarget   = p_EventInfo.GetActionTarget();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_ActionTarget)" + "\r\n" + Utils.AddSpacesCount(12) + "return;" },
            { "GetProcTarget",          "Unit* l_Target         = p_ProcEventInfo.GetProcTarget();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_Target)" + "\r\n" + Utils.AddSpacesCount(12) + "return;" },
            { "GetProcEventSpellInfo",  "SpellInfo* l_ProcSpellInfo = p_EventInfo.GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_ProcSpellInfo)" + "\r\n" + Utils.AddSpacesCount(12) + "return;"    },
            { "GetProcSpell",           "Spell* l_ProcSpell = p_EventInfo.GetSpell();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_ProcSpell)" + "\r\n" + Utils.AddSpacesCount(12) + "return;"    },
            { "GetTriggerSpell",        "SpellInfo* l_DmgSpellInfo = p_ProcEventInfo.GetDamageInfo()->GetSpellInfo();" + "\r\n" + Utils.AddSpacesCount(8) + "if (!l_DmgSpellInfo)" + "\r\n" + Utils.AddSpacesCount(12) + "return;"    },

            { "TriggerSpellCheck","if (l_DmgSpellInfo->Id == DESIRED_ID)" + "\r\n" + Utils.AddSpacesCount(8) + "{" + "\r\n" + Utils.AddSpacesCount(12) + "\r\n" + Utils.AddSpacesCount(8) + "}" },
            { "AuraProcSpellCheck","if (l_ProcSpellInfo->Id == DESIRED_ID)" + "\r\n" + Utils.AddSpacesCount(8) + "{" + "\r\n" + Utils.AddSpacesCount(12) + "\r\n" + Utils.AddSpacesCount(8) + "}" },
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
            scriptBody += Utils.AddSpacesCount(4) + "PrepareAuraScript(" + scriptName + ");" + "\r\n";
            scriptBody += GetEnumsBody(hookBodiesTreeView);
            scriptBody += GetHooksBody(hooksListBox, hookBodiesTreeView) + "\r\n\r\n";
            scriptBody += Utils.AddSpacesCount(4) + "void Register() override" + "\r\n";
            scriptBody += Utils.AddSpacesCount(4) + "{" + "\r\n";
            scriptBody += Utils.AddSpacesCount(8) + "" + "\r\n";
            scriptBody += Utils.AddSpacesCount(4) + "}" + "\r\n";
            scriptBody += "};";

            Clipboard.SetText(scriptBody);
            MessageBox.Show("Template has been successfully builded and copied on your clipboard!");
        }

        private static string GetEnumsBody(TreeView hookBodiesTreeView)
        {
            string body = "";

            body += "\r\n" + Utils.AddSpacesCount(4) + "enum eSpells" + "\r\n" + Utils.AddSpacesCount(4) + "{" + "\r\n" + Utils.AddSpacesCount(8) + "\r\n" + Utils.AddSpacesCount(4) + "};";

            return body;
        }

        private static string GetHooksBody(ListBox hooksListBox, TreeView hookBodiesTreeView)
        {
            string body = "";

            foreach (var hook in hooksListBox.SelectedItems)
            {
                body += "\r\n\r\n" + Utils.AddSpacesCount(4) + hooksDictionary[hook.ToString()];
                body += "\r\n" + Utils.AddSpacesCount(4) + "{" + "\r\n" + Utils.AddSpacesCount(8);

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
                                body += "\r\n\r\n" + Utils.AddSpacesCount(8);
                            }

                            body += hookBodiesDictionary[hook.ToString()][childNode.Text];

                            if (!moreThanOne)
                            {
                                moreThanOne = true;
                            }
                        }
                    }
                }

                body += "\r\n" + Utils.AddSpacesCount(4) + "}";
            }

            return body;
        }
    }
}
