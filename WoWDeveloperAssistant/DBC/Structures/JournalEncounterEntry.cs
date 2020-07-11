namespace WoWDeveloperAssistant.DBC.Structures
{
    public sealed class JournalEncounterEntry
    {
        public uint ID;
        public string Name;
        public string Description;
        public float[] Map = new float[2];
        public uint DungeonMapID;
        public uint WorldMapAreaID;
        public uint FirstSectionID;
        public uint JournalInstanceID;
        public long DifficultyMask;
        public long Flags;
        public uint OrderIndex;
        public uint MapDisplayConditionID;

    }
}