using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class DeathThudLookupsRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Size { get; set; } // 0-4, higher bigger

        public int TerrainType { get; set; } // TerrainType.Id

        public int DirtSoundId { get; set; } // SoundEntries.Id

        public int WaterSoundId { get; set; } // SoundEntries.Id
    }
}
