using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CreatureImmunitiesRecord : IClientDbRecord
    {
        // Verified in 14545
        // Only two records

        public int Id { get; set; } // 1849 and 1860

        public int Unknown1 { get; set; } // Always 0

        public int Unknown2 { get; set; } // Always 0

        public int Unknown3 { get; set; } // Always 0

        public int Unknown4 { get; set; } // 1058 and 133280

        public int Unknown5 { get; set; } // Always 0

        public int Unknown6 { get; set; } // Always 0

        public int Unknown7 { get; set; } // Always 0

        public int Unknown8 { get; set; } // Always 0

        public int Unknown9 { get; set; } // Always 0

        public int Unknown10 { get; set; } // Always 0

        public int Unknown11 { get; set; } // Always 0

        public int Unknown12 { get; set; } // Always 0

        public int Unknown13 { get; set; } // 0 and 67108872

        public int Unknown14 { get; set; } // 0 and 2

        public int Unknown15 { get; set; } // Always 0

        public int Unknown16 { get; set; } // Always 0

        public int Unknown17 { get; set; } // Always 0

        public int Unknown18 { get; set; } // Always 0

        public int Unknown19 { get; set; } // Always 0

        public int Unknown20 { get; set; } // Always 0

        public int Unknown21 { get; set; } // Always 0

        public int Unknown22 { get; set; } // Always 0

        public int Unknown23 { get; set; } // Always 0

        public int Unknown24 { get; set; } // Always 0

        public int Unknown25 { get; set; } // 4
    }
}
