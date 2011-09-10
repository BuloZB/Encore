using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities.Unit;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ChrRacesRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public RaceFlags Flags { get; set; }

        public int Faction { get; set; } // FactionTemplate.Id

        public int ExplorationSound { get; set; } // SoundEntries.Id

        public int MaleModel { get; set; } // CreatureDisplayInfo.Id

        public int FemaleModel { get; set; } // CreatureDisplayInfo.Id

        public string NamePrefix { get; set; }

        public int Unknown1 { get; set; } // 1: Horde races, 7: Alliance & other races

        public int CreatureType { get; set; } // CreatureType.Id; always 7 (Humanoid)

        public int ResSicknessSpell { get; set; } // Spell.Id; always 15007

        public int SplashSoundId { get; set; } // SoundEntries.Id

        public string ClientName { get; set; }

        public int CinematicSequence { get; set; } // CinematicSequence.Id

        public int Alliance { get; set; } // 0: Alliance, 1: Horde, 2: Others

        public string Name { get; set; }

        public string NameFemale { get; set; } // Empty

        public string NameMale { get; set; } // Empty

        public Customization HairCustomization { get; set; }

        public ClientBoxLevel RequiredExpansion { get; set; }

        public int Unknown2 { get; set; } // 0 for all except 23 for Worgen

        public int Unknown3 { get; set; } // 0 for all except 3133 for Gilnean

        public int Unknown4 { get; set; } // 0 for all except 3134 for Gilnean

        public sealed class Customization
        {
            public string FacialHair1 { get; set; }

            public string FacialHair2 { get; set; }

            public string Hair { get; set; }
        }

    }
}
