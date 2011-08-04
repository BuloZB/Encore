using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AnimKitConfigBonesetRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int ParentAnimKitConfigId { get; set; }

        public int AnimKitBonesetId { get; set; }

        public int AnimKitPriorityId { get; set; }
    }
}
