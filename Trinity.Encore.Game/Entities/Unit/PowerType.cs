// TODO: Move this to a better folder

using System;

namespace Trinity.Encore.Game.Entities
{
    [Serializable]
    public enum PowerType : uint
    {
        Mana = 0,
        Rage = 1,
        Focus = 2,
        Energy = 3,
        Happiness = 4, // byte_F00978, without name
        Runes = 5,
        RunicPower = 6,
        SoulShards = 7,
        Eclipse = 8,
        HolyPower = 9,
        Alternate = 10,
    }
}
