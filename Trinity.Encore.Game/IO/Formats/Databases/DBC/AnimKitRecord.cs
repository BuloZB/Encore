using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AnimKitRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int OneShotDuration { get; set; }

        public int OneShotStopAnimKitId { get; set; }
    }
}
