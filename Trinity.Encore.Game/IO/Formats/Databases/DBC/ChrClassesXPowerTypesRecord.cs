using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities.Unit;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ChrClassesXPowerTypesRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public Class Class { get; set; }

        public PowerType PowerType { get; set; } // Usable power types?
    }
}
