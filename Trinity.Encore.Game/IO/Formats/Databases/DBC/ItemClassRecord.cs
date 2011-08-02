using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ItemClassRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int ClassId { get; set; }

        public int SubClassId { get; set; }     // or InventoryType

        public int Unk1 { get; set; }           // Unk, sometimes this >> SubclassID & 1 is checked

        public int Unk2 { get; set; }           // Unk
    }
}
