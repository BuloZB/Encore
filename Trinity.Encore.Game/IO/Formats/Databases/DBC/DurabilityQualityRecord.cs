using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class DurabilityQualityRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public float Multiplier { get; set; }

        /*
        DurabilityQualityRecordId = (item.Quality + 1) * 2;
        multiplier = DurabilityQualityRecord(DurabilityQualityRecordId).Multiplier;
        */
    }
}
