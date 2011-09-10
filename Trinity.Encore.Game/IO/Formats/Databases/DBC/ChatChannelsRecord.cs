using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Services.Social;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ChatChannelsRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public ChannelFlags Flags { get; set; }

        public int Unknown { get; set; } // Always 0

        public string Name { get; set; }

        public string ShortcutName { get; set; }
    }
}
