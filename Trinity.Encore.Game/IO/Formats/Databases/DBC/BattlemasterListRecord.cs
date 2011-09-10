using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class BattlemasterListRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Map1 { get; set; }

        public int Map2 { get; set; }

        public int Map3 { get; set; }

        public int Map4 { get; set; }

        public int Map5 { get; set; }

        public int Map6 { get; set; }

        public int Map7 { get; set; }

        public int Map8 { get; set; }

        public int Type { get; set; }

        [RealType(typeof(int))]
        public bool CanJoinAsGroup { get; set; }

        public string Name { get; set; }

        public int Unknown1 { get; set; }

        public int HolidayWorldStateId { get; set; }

        public int MinLevel { get; set; }

        public int MaxLevel { get; set; }

        public int MaxGroupSize { get; set; } // ?

        public int MinGroupSize { get; set; } // ?

        public int Unknown2 { get; set; } // Related to rated BGs?

        public int Unknown3 { get; set; } // 2 for Rated BGs, 0 otherwise
    }
}
