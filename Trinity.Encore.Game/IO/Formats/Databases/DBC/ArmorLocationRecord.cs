using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ArmorLocationRecord : IClientDbRecord
    {
        // Also inventory type?
        public int Id { get; set; }

        public float ClothModifier { get; set; }

        public float LeatherModifier { get; set; }

        public float ChainModifier { get; set; } // Mail

        public float PlateModifier { get; set; }

        public float Modifier { get; set; }
    }
}
