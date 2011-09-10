using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class BannedAddOnsRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public MD5String Name { get; set; }

        public MD5String Version { get; set; }

        public int Unknown1 { get; set; }

        public int Unknown2 { get; set; } // 1/2

        public sealed class MD5String // 16 chars or similar
        {
            // TODO: If needed serverside, create method to join these 4 fields properly

            public int Part1 { get; set; }

            public int Part2 { get; set; }

            public int Part3 { get; set; }

            public int Part4 { get; set; }
        }
    }
}
