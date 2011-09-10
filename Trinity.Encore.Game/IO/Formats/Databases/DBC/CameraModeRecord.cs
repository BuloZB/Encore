using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CameraModRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public string Name { get; set; }

        public int Unknown1 { get; set; }

        public int Unknown2 { get; set; }

        public float Unknown3 { get; set; }

        public float Unknown4 { get; set; }

        public float Unknown5 { get; set; }

        public float Unknown6 { get; set; }

        public float Unknown7 { get; set; }

        public float Unknown8 { get; set; }

        public float Unknown9 { get; set; }

        public float Unknown10 { get; set; }

        public float Unknown11 { get; set; }

        public int Unknown12 { get; set; }

        public int Unknown13 { get; set; }

        public int Unknown14 { get; set; }

        public int Unknown15 { get; set; }
    }
}
