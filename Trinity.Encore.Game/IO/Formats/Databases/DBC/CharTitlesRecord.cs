using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CharTitlesRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int Unknown1 { get; set; }

        public string TitleMale { get; set; }

        public string TitleFemale { get; set; }

        public int TitleMaskId { get; set; } // Used in the client drop-down menu

        public int Unknown2 { get; set; } // Always 0
   }
}
