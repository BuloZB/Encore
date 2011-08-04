using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CastableRaidBuffsRecord : IClientDbRecord
    {
        // Only one entry in this DBC

        public int Id { get; set; }

        public int SpellId1 { get; set; } // 33076 Prayer of Mending (Rank 1)

        public int SpellId2 { get; set; } // 41635 Prayer of Mending (Rank 1)
    }
}
