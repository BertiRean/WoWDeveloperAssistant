﻿namespace DB2.Structures
{
    [Hotfix("ConversationLine")]
    public class ConversationLine
    {
        public uint BroadcastTextID;
        public uint SpellVisualKitID;
        public int AdditionalDuration;
        public ushort NextConversationLineID;
        public ushort AnimKitID;
        public byte SpeechType;
        public byte StartAnimation;
        public byte EndAnimation;
    }
}
