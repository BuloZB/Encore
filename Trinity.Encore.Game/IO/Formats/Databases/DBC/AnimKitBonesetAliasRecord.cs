using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AnimKitBonesetAliasRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int BoneDataId { get; set; }

        public int BonesetId { get; set; }
    }
}
