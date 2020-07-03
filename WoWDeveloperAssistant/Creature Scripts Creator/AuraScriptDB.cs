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

        public static string CreateSqlQuery(AuraScriptEntry spell, uint id)
        {
            var SQLtext = "";
            var spellName = "\"\"";
            var actionSpellList = spell.ActionSpellList.Length > 1 ? spell.ActionSpellList : "\"\"";

            if (spell.ActionSpellList.Length > 1)
                actionSpellList = "\"" + spell.ActionSpellList + "\"";

            uint triggered = Convert.ToUInt32(spell.Triggered);

            if (DBC.DBC.IsLoaded() && DBC.DBC.SpellName.ContainsKey((int)spell.SpellId))
                spellName = DBC.DBC.SpellName[(int)spell.SpellId].Name + "" + hooksList[spell.Hook] + " - EFFECT_" + spell.EffectId.ToString();

            SQLtext += "(" + spell.SpellId + ", " + id.ToString() + ", " + spell.Hook + ", " + spell.EffectId + ", " + spell.Action + ", " + spell.ActionSpellId + ", " +
                spell.ActionOriginalCaster + ", " + spell.ActionCaster + ", " + spell.ActionTarget + ", " + triggered + ", " + spell.CalculationType + ", " + spell.DataSource + ", " + actionSpellList + ", "
                + spellName + ")";

            return SQLtext;
        }
    }
}
