using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CfgCategoriesRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int LocaleMask { get; set; } // 205: EU, 256: Russia, 0: rest.

        public int CharsetMask { get; set; } // 0: Development, 1: US and EU, 4: Russia, 10: Korea, 17: Taiwan & China

        public int Flags { get; set; } // Or bool. 1 if Tournament, 0 otherwise
    }
}
