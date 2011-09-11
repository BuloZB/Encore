using System.Diagnostics.Contracts;
using Mono.GameMath;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CinematicCameraRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public string Name { get; set; }

        public int Voiceover { get; set; } // SoundEntries.Id

        public Vector4 StartPosition { get; set; } // Start or end?
    }
}
