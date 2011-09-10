using System;

namespace Trinity.Encore.Game.Entities.Unit
{
    [Serializable]
    [Flags]
    public enum ClassFlags : uint
    {
        // TODO: enum: 2 cloth, 4 summonpet, 8 userelicslot, 16 mail, 32 plate..

        CanWearCloth = 0x002, // Rogue, Priest, Mage, Druid, Shaman, Warrior, Paladin, DK, Warlock
        CanSummonPet = 0x004, // Warlock, Hunter
        UsesRelicSlot = 0x008, // Druid, Shaman, Paladin, DK
        CanWearMail = 0x010, // Shaman, Warrior, Paladin, DK, Hunter
        CanWearPlate = 0x020, // Warior, Paladin, DK
        Unk1 = 0x040, // DK
        Unk2 = 0x080, // Warlock, Hunter
        Unk3 = 0x100 // Hunter

        // No CanWearLeather?
    }
}
