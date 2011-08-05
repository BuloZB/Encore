using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ChatChannelsRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int UnknownFlag { get; set; }

        public int Unknown { get; set; } // Always 0

        public string Name { get; set; }

        public string ShortcutName { get; set; }
    }
}
