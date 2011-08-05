using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ChrClassesRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public PowerType Power { get; set; }

        public string PetType { get; set; }

        public string ClassName { get; set; }

        public int Unknown1 { get; set; } // Always 0

        public int Unknown2 { get; set; } // Always 0

        public string ClassNameUpperCase { get; set; }

        public int SpellClassSet { get; set; } // ?

        public int Flags { get; set; } // TODO: enum: 2 cloth, 4 summonpet, 8 userelicslot, 16 mail, 32 plate..

        public int OpeningCinematicCamera { get; set; } // Only set for DK

        public ClientBoxLevel RequiredExpansion { get; set; }

        public int AttackPowerPerStrength { get; set; }

        public int AttackPowerPerAgility { get; set; }

        public int RangedAttackPowerPerAgility { get; set; }
    }
}
