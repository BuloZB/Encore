using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CinematicSequenceRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int Sound { get; set; } // SoundEntries.Id

        public int CinematicCamera { get; set; } // CinematicCamera.Id

        public int Unknown1 { get; set; } // Always 0

        public int Unknown2 { get; set; } // Always 0

        public int Unknown3 { get; set; } // Always 0

        public int Unknown4 { get; set; } // Always 0

        public int Unknown5 { get; set; } // Always 0

        public int Unknown6 { get; set; } // Always 0

        public int Unknown7 { get; set; } // Always 0
    }
}
