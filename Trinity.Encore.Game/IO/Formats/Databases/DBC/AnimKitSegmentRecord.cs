using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AnimKitSegmentRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int ParentAnimKitId { get; set; }

        public int AnimKitConfigId { get; set; }

        public Condition StartCondition { get; set; }

        public Condition EndCondition { get; set; }

        public int Unknown1 { get; set; } // mostly values ending in 0, 0-15000,3000000

        public float Speed { get; set; }

        public int SegmentFlags { get; set; }

        public int ForcedVariation { get; set; }

        public int OverrideConfigFlags { get; set; }

        public int LoopToSegmentIndex { get; set; }

        public sealed class Condition
        {
            public int Type { get; set; }

            public int Param { get; set; }

            public int Delay { get; set; } // index? 0-10
        }
    }
}
