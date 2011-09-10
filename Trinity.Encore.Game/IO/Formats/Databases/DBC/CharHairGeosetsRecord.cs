using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities.Unit;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CharHairGeosetsRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public Race Race { get; set; }

        public Gender Gender { get; set; }

        public int HairType { get; set; }

        public int Geoset { get; set; }

        [RealType(typeof(int))]
        public bool IsBald { get; set; }
    }
}
