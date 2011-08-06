using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CharBaseInfoRecord : IClientDbRecord
    {
        // This DBC has a 'weird' format. "Byte packed DBC Files not supported."
        // TODO: Verify this structure

        public int Id { get; set; } // Race

        public int Class { get; set; }
    }
}
