using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CreatureMovementInfoRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public float SmoothFacingChaseRate { get; set; } // ?
    }
}
