using System;

namespace Trinity.Encore.Game.Spells
{
    [Serializable]
    public enum SpellFamily : uint
    {
        Generic = 0,
        Unk1 = 1,
        Mage = 3,
        Warrior = 4,
        Warlock = 5,
        Priest = 6,
        Druid = 7,
        Rogue = 8,
        Hunter = 9,
        Paladin = 10,
        Shaman = 11,
        Unk2 = 12,
        Potion = 13,
        DeathKnight = 15,
        Pet = 17,
        Plants = 50, // Peacebloom vs Ghouls (Plants vs Zombies). True story.
    }
}
