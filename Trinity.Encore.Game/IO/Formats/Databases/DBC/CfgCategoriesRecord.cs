using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CfgCategoriesRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int LocaleMask { get; set; } // 205: EU, 256: Russia, 0: rest.

        public int CharsetMask { get; set; } // 0: Development, 1: US and EU, 4: Russia, 10: Korea, 17: Taiwan & China

        [RealType(typeof(int))]
        public bool IsTournament { get; set; }

        public string Name { get; set; }
    }
}
