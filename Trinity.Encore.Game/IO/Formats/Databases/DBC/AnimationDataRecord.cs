using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AnimationDataRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public string Name { get; set; }

        public int Flags { get; set; }          // Unknown

        public int FallbackId { get; set; }     // preceeding AnimationData.Id

        public int BehaviourId { get; set; }    // same as Id for "normal" animations

        public int BehaviourTier { get; set; }  // 3 for "Fly*", 0 otherwise
    }
}
