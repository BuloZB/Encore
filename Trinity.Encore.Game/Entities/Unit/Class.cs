using System;

namespace Trinity.Encore.Game.Entities.Unit
{
    [Serializable]
    public enum Class // TODO: Rename
    {
        // As in ChrClasses.dbc

        None = 0,
        Warrior = 1,
        Paladin = 2,
        Hunter = 3,
        Rogue = 4,
        Priest = 5,
        DeathKnight = 6,
        Shaman = 7,
        Mage = 8,
        Warlock = 9,
        Druid = 11,
    }
}
