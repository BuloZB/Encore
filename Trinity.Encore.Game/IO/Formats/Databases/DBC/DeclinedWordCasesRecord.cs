using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class DeclinedWordCasesRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int DeclensionWord { get; set; } // DeclinedWord.Id

        public int Case { get; set; } // 1-5, {nominative, genitive, dative, accusative, ablative}

        public string Word { get; set; } // Again, only in Russian
    }
}
