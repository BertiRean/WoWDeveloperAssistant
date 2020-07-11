namespace WoWDeveloperAssistant.DBC.Structures
{
    public sealed class JournalInstanceEntry
    {
        public string Name;
        public string Description;
        public uint ButtonFileDataID;
        public uint ButtonSmallFileDataID;
        public uint BackgroundFileDataID;
        public uint LoreFileDataID;
        public ushort MapID;
        public ushort AreaID;
        public byte OrderIndex;
        public byte Flags;
        public uint ID;
    }
}