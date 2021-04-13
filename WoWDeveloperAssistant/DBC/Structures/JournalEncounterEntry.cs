namespace WoWDeveloperAssistant.DBC.Structures
{
    public sealed class JournalEncounterEntry
    {
        public uint ID;
        public string Name;
        public string Description;
        public float[] Map = new float[2];
        public uint JournalInstanceID;
        public uint DungeonEncounterID;
        public uint OrderIndex;
        public uint FirstSectionID;
        public uint UiMapID;
        public uint MapDisplayConditionID;
        public long Flags;
        public long DifficultyMask;


    }
}