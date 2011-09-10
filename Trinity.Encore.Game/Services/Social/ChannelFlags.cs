using System;

namespace Trinity.Encore.Game.Services.Social
{
    [Serializable]
    [Flags]
    public enum ChannelFlags : uint
    {
        Unk1 = 0x00001, // General, Trade, LocalDefense, LFG
        Unk2 = 0x00002, // General, Trade, LocalDefense
        /// <summary>
        /// Available anywhere.
        /// </summary>
        Global = 0x00004, // WorldDefense
        Unk4 = 0x00008, // General, Trade, LocalDefense, LFG
        /// <summary>
        /// Only available to players in a capital city.
        /// </summary>
        RequiresCity = 0x00010, // Trade, LFG
        /// <summary>
        /// Only available to players in a capital city. Duplicate.
        /// </summary>
        RequiresCity2 = 0x00020, // Trade, LFG
        Defense = 0x10000, // LocalDefense, WorldDefense
        /// <summary>
        /// Only available to guildless players.
        /// </summary>
        RequiresGuild = 0x20000, // none
        Unk9 = 0x40000, // LFG
        Unk10 = 0x80000, // General
    }
}
