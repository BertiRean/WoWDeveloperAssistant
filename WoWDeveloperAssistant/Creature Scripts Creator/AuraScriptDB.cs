using System;
using System.Windows.Forms;
using WoWDeveloperAssistant.Misc;

namespace WoWDeveloperAssistant.Spell_Aura_Script_DbCreator
{
    public static class AuraScriptDB
    {
        public static readonly string[] hooksList =
        {
            "OnDispel",
            "AfterDispel",
            "AfterEffectApply",
            "AfterEffectRemove",
            "OnEffectPeriodic",
            "AfterEffectPeriodic",
            "OnAbsorb",
            "AfterAbsorb",
            "CheckProc",
            "PrepareProc",
            "OnProc",
            "AfterProc",
            "OnEffectProc",
            "AfterEffectProc",
            "OnSplitDamage"
        };

        public static readonly string[] actionsList =
        {
            "CastSpell",
            "CheckingProc",
            "RemoveAura",
            "ModAmount",
            "SetAmount",
            "ModAbsorb",
            "SetDuration",
            "ModDuration",
            "ReduceCooldown",
            "RemoveCooldown",
            "TriggerSAI",
            "AddAura"
        };

        public static void CreateAuraScript(AuraScriptEntry spell)
        {

        }

        private static string GetEnumsBody(TreeView hookBodiesTreeView)
        {
            return "";
        }
    }
}
