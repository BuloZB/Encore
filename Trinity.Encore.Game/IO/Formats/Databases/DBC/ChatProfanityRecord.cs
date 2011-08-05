using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ChatProfanityRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public string Word { get; set; }

        public ClientLocale Language { get; set; }
    }
}
