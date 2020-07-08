using System;

namespace WoWDeveloperAssistant.Misc
{
    public struct Aura
    {
        public uint slot;
        public bool HasAura;
        public TimeSpan time;
        public uint spellId;

        public Aura(uint slot, bool HasAura, TimeSpan time, uint spellId)
        { this.slot = slot; this.HasAura = HasAura; this.time = time; this.spellId = spellId; }
    }

    public struct AuraScriptEntry
    {
        public uint SpellId;                                   ///< SpellId to which bind the script
        public uint Hook;                                      ///< Hook used to do stuffs (see eAuraHooks)
        public int EffectId;                                   ///< Index of the effect to use (-1 if not an effect hook)
        public uint Action;                                    ///< Action to do (see eAuraScriptActions)
        public uint ActionSpellId;                             ///< SpellId (use depends of the action)
        public uint ActionCaster;                              ///< Actor of the action (see eAuraScriptActors)
        public uint ActionOriginalCaster;                      ///< Original caster if needed (see eAuraScriptActors)
        public uint ActionTarget;                              ///< Target of the action (see eAuraScriptActors)
        public bool Triggered;                                 ///< for cast spell action
        public uint CalculationType;                           ///< see eCalculationType
        public uint DataSource;                                ///< see eDataSources
        public string ActionSpellList;                         ///< in case of CheckProc, only allow the spellId in this list

        public AuraScriptEntry(uint spellId, uint hook, int effectIdx, uint action, uint actionSpellId, uint actionCaster, uint actionTarget, bool triggered, string actionSpellList,
            uint actionOriginalCaster, uint dataSource, uint calcType)
        { 
            this.SpellId        = spellId; 
            this.Hook           = hook; 
            this.EffectId       = effectIdx; 
            this.Action         = action;
            this.ActionSpellId  = actionSpellId;
            this.ActionCaster   = actionCaster;
            this.ActionSpellList = actionSpellList;
            this.ActionTarget   = actionTarget;
            this.ActionOriginalCaster = actionOriginalCaster;
            this.Triggered = triggered;
            this.DataSource = dataSource;
            this.CalculationType = calcType;
        }
    };

    public struct SpellScriptEntry
    {
        public uint SpellId;                                    ///< SpellId to which bind the script
        public uint Hook;                                       ///< Hook used to do stuffs (see eAuraHooks)
        public int EffectId;                                   ///< Index of the effect to use (-1 if not an effect hook)
        public uint Action;                                     ///< Action to do (see eAuraScriptActions)
        public uint ActionSpellId;                              ///< SpellId (use depends of the action)
        public uint ActionCaster;                               ///< Actor of the action (see eAuraScriptActors)
        public uint ActionOriginalCaster;                       ///< Original caster if needed (see eAuraScriptActors)
        public uint ActionTarget;                               ///< Target of the action (see eAuraScriptActors)
        public bool Triggered;                                  ///< for cast spell action
        public uint CalculationType;                            ///< see eCalculationType
        public uint DataSource;                                 ///< see eDataSources
        public string ActionSpellList;                            ///< in case of CheckProc, only allow the spellId in this list

        public SpellScriptEntry(uint spellId, uint hook, int effectIdx, uint action, uint actionSpellId, uint actionCaster, uint actionTarget, bool triggered, string actionSpellList,
            uint actionOriginalCaster, uint dataSource, uint calcType)
        {
            this.SpellId = spellId;
            this.Hook = hook;
            this.EffectId = effectIdx;
            this.Action = action;
            this.ActionSpellId = actionSpellId;
            this.ActionCaster = actionCaster;
            this.ActionSpellList = actionSpellList;
            this.ActionTarget = actionTarget;
            this.ActionOriginalCaster = actionOriginalCaster;
            this.Triggered = triggered;
            this.DataSource = dataSource;
            this.CalculationType = calcType;
        }
    };

    public struct SpellInfoOverrideEntry
    {
        public uint spellId;                                    ///< SpellId needing data override
        public uint effectID;                                   ///< Index of the effect to override (-1 if not an effect value)
        public uint overrideField;                              ///< Data to override (see enum : eOverrideValues)
        public int overrideValue;                                      ///< New Value

        public SpellInfoOverrideEntry(uint SpellId, uint EffectIndex, uint OverrideField, int OverrideValue)
        {
            this.spellId        = SpellId;
            this.effectID       = EffectIndex;
            this.overrideField  = OverrideField;
            this.overrideValue  = OverrideValue;
        }
    };

    public struct CombatAIEventDataEntry
    {
        public uint NpcEntry;

        public uint StartMin;
        public uint StartMax;
        public uint RepeatMin;
        public uint RepeatMax;
        public uint RepeatFail;

        public uint SpellId;
        public float AttackDist;

        public uint EventCheck;
        public uint EventFlags;

        public uint DifficultyMask;

        public CombatAIEventDataEntry(uint npcEntry, uint startMin, uint startMax, uint repeatMin, uint repeatMax, uint spellId, float attackDist, uint eventCheck, uint eventFlags, uint diffMask = 0)
        {
            this.NpcEntry   = npcEntry;
            this.StartMin   = startMin;
            this.StartMax   = startMax;
            this.RepeatMin = repeatMin;
            this.RepeatMax = repeatMax;
            this.RepeatFail = 1000;
            this.SpellId    = spellId;
            this.AttackDist = attackDist;
            this.EventCheck = eventCheck;
            this.EventFlags = eventFlags;
            this.DifficultyMask = diffMask;
        }
    };
}
