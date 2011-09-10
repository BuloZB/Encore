using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AreaPOISortedWorldStateRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }             // AreaPOIRecord.Id

        public int WorldState { get; set; }     // AreaPOIRecord.WoldState

        public int Unknown { get; set; }        // AreaPOIRecord.Unknown3

        // All entries (5) are related to Wintergrasp graveyards
    }
}
