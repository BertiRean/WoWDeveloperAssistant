﻿using DBFileReaderLib.Attributes;

namespace WoWDeveloperAssistant.DBC.Structures
{
    [DBFile("CriteriaTree")]
    public sealed class CriteriaTreeEntry
    {
        [Index(true)]
        public uint ID;
        public string Description;
        public uint Parent;
        public uint Amount;
        public sbyte Operator;
        public uint CriteriaID;
        public int OrderIndex;
        public short Flags;
    }
}
