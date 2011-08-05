using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ZoneMusicRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SilenceIntervalMinDay { get; set; }

        public int SilenceIntervalMinNight { get; set; }

        public int SilenceIntervalMaxDay { get; set; }

        public int SilenceIntervalMaxNight { get; set; }

        public int DayMusc { get; set; }    // SoundEntry.Id

        public int NightMusic { get; set; } // SoundEntry.Id
    }
}
