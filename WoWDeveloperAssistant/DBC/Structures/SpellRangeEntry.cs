namespace WoWDeveloperAssistant.DBC.Structures
{
    public sealed class SpellRangeEntry
    {
        public uint ID;
        public string DisplayName_lang;
        public string DisplayNameShort_lang;
        public byte Flags;
        public float[] RangesMin = new float[2];
        public float[] RangesMax = new float[2];
    }
}
