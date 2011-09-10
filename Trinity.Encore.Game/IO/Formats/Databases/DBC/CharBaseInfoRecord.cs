using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities.Unit;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CharBaseInfoRecord : IClientDbRecord
    {
        // Verified in 14545
        // This DBC has a 'weird' format. "Byte packed DBC Files not supported."
        // TODO: Verify this structure

        public int Id { get; set; }

        // [RealType(typeof(byte))]
        public Race Race { get; set; }

        // [RealType(typeof(byte))]
        public Class Class { get; set; }
    }
}
