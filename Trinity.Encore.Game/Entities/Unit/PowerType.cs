// TODO: Move this to a better folder

using System;

namespace Trinity.Encore.Game.Entities.Unit
{
    [Serializable]
    public enum PowerType : uint
    {
        Mana = 0,
        Rage = 1,
        Focus = 2,
        Energy = 3,
        Unused = 4, // Was happiness
        Runes = 5,
        RunicPower = 6,
        SoulShards = 7,
        Eclipse = 8,
        HolyPower = 9,
        Alternate = 10,
    }
}
