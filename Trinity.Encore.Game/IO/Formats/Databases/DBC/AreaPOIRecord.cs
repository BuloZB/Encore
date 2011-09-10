using System.Diagnostics.Contracts;
using Mono.GameMath;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AreaPOIRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Importance { get; set; } // ?

        public IconSet NormalIconSet { get; set; }

        public IconSet HordeIconSet { get; set; }

        public IconSet AllianceIconSet { get; set; }

        public int FactionId { get; set; }

        public Vector2 Point { get; set; }

        public int Map { get; set; }

        public int Unknown1 { get; set; }

        public int Zone { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int WorldState { get; set; }

        public float Unknown2 { get; set; } // Always 0

        public int Unknown3 { get; set; } // 13XX for areas related to Wintergrasp graveyards or 0

        public class IconSet // BG and destructible buildings related
        {
            public int Icon100 { get; set; }

            public int Icon50 { get; set; }

            public int Icon0 { get; set; }
        }
    }
}
