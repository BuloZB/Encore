using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ZoneLightRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public string Name { get; set; }    // Zone name

        public int MapId { get; set; }      // Only seems to be continent maps in which the zones are present

        public int Unk2 { get; set; }
    }
}
