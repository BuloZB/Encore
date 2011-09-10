using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities.Unit;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class BarbershopStyleRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Type { get; set; }

        public string Name { get; set; }

        public string Unknown { get; set; } // Always empty

        public float CostMultiplier { get; set; }

        public Race Race { get; set; }

        public Gender Gender { get; set; }

        public int Hair { get; set; }
    }
}
