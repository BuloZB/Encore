using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Terrain;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AreaTableRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int MapId { get; set; }

        public int ZoneId { get; set; }

        public int ExplorationFlag { get; set; }

        public AreaFlags Flags { get; set; }

        public int Unknown1 { get; set; } // SoundProviderPref?

        public int Unknown2 { get; set; } // SoundProviderPrefUnderwater?

        public int Unknown3 { get; set; } // AmbienceId?

        public int ZoneMusic { get; set; } // ZoneMusic.Id

        public int IntroMusic { get; set; } // ZoneIntroMusic.Id

        public int Level { get; set; }

        public string Name { get; set; }

        public int Team { get; set; } // FactionGroupMask?

        public int Unknown6 { get; set; } // LiquidTypeId1?

        public int Unknown7 { get; set; } // LiquidTypeId2?

        public int Unknown8 { get; set; } // LiquidTypeId3?

        public int Unknown9 { get; set; } // LiquidTypeId4?

        public int Unknown10 { get; set; } // MinElevation?

        public float Unknown11 { get; set; } // AmbientMultiplier?

        public int Unknown12 { get; set; } // Always 0, LightId?

        public int Unknown13 { get; set; }

        public int Unknown14 { get; set; } // Always 0

        public int Unknown15 { get; set; }

        public int Unknown16 { get; set; }

        public int Unknown17 { get; set; }

        public int Unknown18 { get; set; }

        [SkipProperty]
        public bool IsSanctuary
        {
            get
            {
                // Map 609 is Ebon Hold. Does not have the sanctuary flag, for some reason.
                return MapId == 609 || Flags.HasFlag(AreaFlags.Sanctuary);
            }
        }
    }
}
