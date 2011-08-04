using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AnimKitBonesetRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BoneDataId { get; set; }

        public int ParentId { get; set; }

        public int ExtraBoneCount { get; set; }

        public int AltId { get; set; }
    }
}
