using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AttackAnimKitsRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int AnimationId { get; set; }

        public int AttackAnimTypesId { get; set; }

        public int Flags { get; set; }

        [RealType(typeof(int))]
        public bool Unknown { get; set; } // True for OffHand types
    }
}
