using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ItemDisenchantLootRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int Unk1 { get; set; }

        public int Unk2 { get; set; }   // Can be < 0

        public int Unk3 { get; set; }

        public int Unk4 { get; set; }

        public int Unk5 { get; set; }   // Client checks Unk5 >= (signed int) Unk4 in ItemDisenchantInitialize

        public int Unk6 { get; set; }   // Possibly required disenchant skill
    }
}
