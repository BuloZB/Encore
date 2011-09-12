using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class DurabilityCostsRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
        public int[] WeaponMultiplier;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public int[] ArmorMultiplier;

        /*
        const int ItemClassWeapon = 2;
        const int ItemClassArmor = 4;
        public int GetDurabilityMultiplier(int itemClass, int itemSubclass)
        {
            if (itemClass == ItemClassWeapon && WeaponMultiplier.Length > itemSubclass)
                return WeaponMultiplier[itemSubclass];
            if (itemClass == ItemClassArmor && ArmorSubClass.Length > itemSubclass)
                return ArmorSubclass[itemSubclass];
            return 0;
        }

        * This is the "unrolled" structure, if the above does not work replace it by this.

        public int Id { get; set; } // ItemLevel

        public int WeaponMultiplier0 { get; set; } // Axe

        public int WeaponMultiplier1 { get; set; } // Axe2

        public int WeaponMultiplier2 { get; set; } // Bow

        public int WeaponMultiplier3 { get; set; } // Gun

        public int WeaponMultiplier4 { get; set; } // Mace

        public int WeaponMultiplier5 { get; set; } // Mace2

        public int WeaponMultiplier6 { get; set; } // Polearm

        public int WeaponMultiplier7 { get; set; } // Sword

        public int WeaponMultiplier8 { get; set; } // Sword2

        public int WeaponMultiplier9 { get; set; } // Obsolete, always 0

        public int WeaponMultiplier10 { get; set; } // Staff

        public int WeaponMultiplier11 { get; set; } // Exotic

        public int WeaponMultiplier12 { get; set; } // Exotic2

        public int WeaponMultiplier13 { get; set; } // Fist

        public int WeaponMultiplier14 { get; set; } // Misc

        public int WeaponMultiplier15 { get; set; } // Dagger

        public int WeaponMultiplier16 { get; set; } // Thrown

        public int WeaponMultiplier17 { get; set; } // Spear

        public int WeaponMultiplier18 { get; set; } // Crossbow

        public int WeaponMultiplier19 { get; set; } // Wand

        public int WeaponMultiplier20 { get; set; } // Fishing Pole

        public int ArmorMultiplier0 { get; set; } // Misc, always 0

        public int ArmorMultiplier1 { get; set; } // Cloth

        public int ArmorMultiplier2 { get; set; } // Leather

        public int ArmorMultiplier3 { get; set; } // Mail

        public int ArmorMultiplier4 { get; set; } // Plate

        public int ArmorMultiplier5 { get; set; } // Buckler, always 0

        public int ArmorMultiplier6 { get; set; } // Shield

        public int ArmorMultiplier7 { get; set; } // Libram, always 0
                                                
                                                  // Idol, Totem, Sigil?
        */
    }
}
