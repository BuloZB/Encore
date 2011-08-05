using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities.Unit;
using Trinity.Encore.Game.Entities.Unit.Player;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CharSectionsRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int Race { get; set; }

        public Gender Gender { get; set; }

        public TextureSection GeneralType { get; set; }

        public string Texture1 { get; set; }

        public string Texture2 { get; set; }

        public string Texture3 { get; set; }

        public int Flags { get; set; }

        public int Type { get; set; }

        public int Variation { get; set; }
    }
}
