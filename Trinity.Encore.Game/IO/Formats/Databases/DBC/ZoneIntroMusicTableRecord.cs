using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ZoneIntroMusicTableRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public string MusicName { get; set; }

        public int SoundId { get; set; }        // SoundEntry.Id

        public int Unk1 { get; set; }           // Almost all records have 1, only "New Intro" has 0

        public int Unk2 { get; set; }           // Some timer in seconds
    }
}
