using System.Diagnostics.Contracts;
using Mono.GameMath;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class DungeonMapRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Map { get; set; } // Map.Id

        public int Layer { get; set; } // Order

        public Vector2 Point1  { get; set; }

        public Vector2 Point2 { get; set; }

        public int Area { get; set; } // AreaTable.Id
    }
}
