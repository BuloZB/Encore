using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AuctionHouseRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int FactionId { get; set; }

        public int DepositPercent { get; set; }

        public int CutPercent { get; set; }

        public string Name { get; set; }
    }
}
