using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AreaAssigmentRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int MapId { get; set; }

        public int AreaId { get; set; }

        public int ChunkX { get; set; }

        public int ChunkY { get; set; }
    }
}
