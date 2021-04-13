namespace WoWDeveloperAssistant.DBC.Structures
{
    public sealed class JournalEncounterItemEntry
    {
        public uint ID;
        public uint JournalEncounterID;
        public uint ItemID;
        public long FactionMask;
        public long Flags;
        public long DifficultyMask;
    }
}