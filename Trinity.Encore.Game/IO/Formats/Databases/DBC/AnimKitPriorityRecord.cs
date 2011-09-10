using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AnimKitPriorityRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Priority { get; set; }
    }
}
