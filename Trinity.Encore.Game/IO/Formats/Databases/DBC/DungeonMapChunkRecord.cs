using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class DungeonMapChunkRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Map { get; set; } // Map.Id

        public int Wmo { get; set; } // WMOAreaTable.Id

        public int DungeonMap { get; set; } // DungeonMap.Id

        public float MinimumZ { get; set; }
    }
}
