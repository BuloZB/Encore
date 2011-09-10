using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities.Unit;
using Trinity.Encore.Game.Spells;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ChrClassesRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public PowerType Power { get; set; }

        public string PetType { get; set; }

        public string ClassName { get; set; }

        public int Unknown1 { get; set; } // Always 0

        public int Unknown2 { get; set; } // Always 0

        public string ClientClassName { get; set; } // Upper cased without spaces

        public SpellFamily SpellClassSet { get; set; }

        public ClassFlags Flags { get; set; }

        public int OpeningCinematicCamera { get; set; } // Only set for DK

        public ClientBoxLevel RequiredExpansion { get; set; }

        public int AttackPowerPerStrength { get; set; }

        public int AttackPowerPerAgility { get; set; }

        public int RangedAttackPowerPerAgility { get; set; }
    }
}
