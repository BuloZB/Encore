using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities.Unit;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CharHairGeosetsRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int Race { get; set; }

        public Gender Gender { get; set; }

        public string String { get; set; }

        [RealType(typeof(int))]
        public bool Boolean { get; set; }

        public float Float { get; set; }
    }
}
