namespace WoWDeveloperAssistant.DBC.Structures
{
    public sealed class JournalInstanceEntry
    {
        public string Name;
        public string Description;
        public uint ID;
        public ushort MapID;
        public uint BackgroundFileDataID;
        public uint ButtonFileDataID;
        public uint ButtonSmallFileDataID;
        public uint LoreFileDataID;
        public byte OrderIndex;
        public byte Flags;
        public ushort AreaID;
    }
}