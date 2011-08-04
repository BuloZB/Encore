using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CfgConfigsRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int Unknown1 { get; set; } // (Id + 1)

        public int Unknown2 { get; set; } // Same as Id

        [RealType(typeof(int))]
        public bool Unknown3 { get; set; } // PvP?

        [RealType(typeof(int))]
        public bool Unknown4 { get; set; } // RP?
    }
}
