using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class DeclinedWordRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public string Word { get; set; } // Only in Russian
    }
}
