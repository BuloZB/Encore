using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CinematicCameraRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Voiceover { get; set; } // SoundEntries.Id

        public Vector4 StartPosition { get; set; } // Start or end?

        public sealed class Vector4
        {
            public float X { get; set; }

            public float Y { get; set; }

            public float Z { get; set; }

            public float O { get; set; }
        }
    }
}
