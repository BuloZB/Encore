using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class DungeonEncounterRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Map { get; set; } // Map.Id

        public int Difficulty { get; set; } // TODO: Add enum (-1,0,1,2,3)

        public int Unk1 { get; set; }

        public int OrderIndex { get; set; }

        public string Name { get; set; }

        public int SpellIconId { get; set; } // references what?

        public int Unk2 { get; set; } // Always 0
    }
}
