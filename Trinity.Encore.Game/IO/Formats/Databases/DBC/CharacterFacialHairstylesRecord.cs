using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities.Unit;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CharacterFacialHairstylesRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Unknown1 { get; set; }

        public Gender Gender { get; set; }

        public int SpecificId { get; set; } // Unique per gender, per race (?)

        public GeoSet GeoSetData { get; set; }

        public sealed class GeoSet
        {
            public int Field1 { get; set; }

            public int Field2 { get; set; }

            public int Field3 { get; set; }

            public int Field4 { get; set; }

            public int Field5 { get; set; }
        }
    }
}
