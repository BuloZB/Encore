using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ItemReforgeRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int Unk1 { get; set; }

        public int Unk2 { get; set; }

        public int Unk3 { get; set; }
    }
}
