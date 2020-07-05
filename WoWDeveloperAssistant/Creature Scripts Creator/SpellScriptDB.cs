using System;
using System.Windows.Forms;
using WoWDeveloperAssistant.Misc;

namespace WoWDeveloperAssistant.Spell_Aura_Script_DbCreator
{
    public static class SpellScriptDB
    {
        public static readonly string[] hooksList =
        {
            "BeforeCast",
            "OnCast",
            "AfterCast",
            "OnPrepare",
            "CheckCast",
            "TakePowers",
            "OnEffectHit",
            "OnEffectHitTarget",
            "BeforeHit",
            "OnHit",
            "AfterHit"
        };

        public static readonly string[] actionsList =
        {
            "SpellCast",
            "CheckingCast",
            "AuraRemove",
            "ModDamage",
            "SetDamage",
            "ModAuraAmount",
            "SetAuraAmount",
            "ModAuraDuration",
            "SetAuraDuration",
            "CooldownReduce",
            "CooldownRemove"
        };

        public static string CreateSqlQuery(SpellScriptEntry spell, uint id)
        {
            var SQLtext = "";
            var spellName = "\"\"";
            var actionSpellList = spell.ActionSpellList.Length > 1 ? spell.ActionSpellList : "\"\"";

            if (spell.ActionSpellList.Length > 1)
                actionSpellList = "\"" + spell.ActionSpellList + "\"";

            uint triggered = Convert.ToUInt32(spell.Triggered);

            if (DBC.DBC.IsLoaded() && DBC.DBC.SpellName.ContainsKey((int)spell.SpellId))
                spellName = "\"" + DBC.DBC.SpellName[(int)spell.SpellId].Name + "--" + hooksList[spell.Hook] + " - EFFECT_" + spell.EffectId.ToString() + "\"";

            SQLtext += "(" + spell.SpellId + ", " + id.ToString() + ", "  + spell.Hook + ", " + spell.EffectId + ", " + spell.Action + ", " + spell.ActionSpellId + ", " +
                spell.ActionOriginalCaster + ", " + spell.ActionCaster + ", " + spell.ActionTarget + ", " + triggered + ", " + spell.CalculationType + ", " + spell.DataSource + ", " + actionSpellList  + ", "
                + spellName + ")";

            return SQLtext;
        }
    }
}
