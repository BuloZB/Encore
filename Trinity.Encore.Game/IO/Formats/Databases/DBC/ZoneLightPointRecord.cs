using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ZoneLightPointRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int ZoneLight { get; set; }  // ZoneLight.Id

        public float MapX { get; set; }     // Pretty sure this is X coordinate for the map, not zone

        public float MapY { get; set; }     // Dito

        public float PointId { get; set; }  // Multiple entries with the same ZoneLight have different PointIds and coordinates. PointId goes from 1 and up
    }
}
