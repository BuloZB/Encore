using System;

namespace Trinity.Encore.Game.Entities.Unit
{
    [Serializable]
    [Flags]
    public enum RaceFlags : uint
    {
        NotPlayable = 0x001,
        BareFeet = 0x002,
        CanCurrentFormMount = 0x004, // CGUnit_C::CanCurrentFormMount
        Unk2 = 0x008,
        Unk3 = 0x020,
        Unk4 = 0x040,
        Unk5 = 0x080,
        Unk6 = 0x100

    }
}
