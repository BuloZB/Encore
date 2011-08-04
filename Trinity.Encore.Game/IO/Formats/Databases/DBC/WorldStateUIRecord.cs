using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class WorldStateUIRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int MapId { get; set; }

        public int ZoneId { get; set; }

        public int Unknown1 { get; set; }       // Always 0

        public int Unknown2 { get; set; }       // Related worldstates have same number or 0

        public int Unknown3 { get; set; }       // Always 0

        public string Icon { get; set; }

        public string Text1 { get; set; }

        public string Text2 { get; set; }

        public int WorldState { get; set; }     // The actual Id

        public int Type { get; set; }           // 0/1/2/3

        public string DynamicIcon { get; set; }

        public string DynamicTooltip { get; set; }

        public UI ExtendedUI { get; set; }

        public sealed class UI
        {
            public string Text { get; set; }            // "CAPTUREPOINT" otherwise empty

            public int StateVariable { get; set; }

            public int StateVariableNeutral { get; set; }

            public int StateVariableUnk { get; set; }   // Always 0
        }
    }
}
