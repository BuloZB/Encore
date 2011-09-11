using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Entities.Unit;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CreatureDisplayInfoExtraRecordRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public Race Race { get; set; }

        public Gender Gender { get; set; }

        public int SkinColor { get; set; } // ?

        public int FaceType { get; set; } // ?

        public int HairType { get; set; } // ?

        public int Hairstyle { get; set; } // ?

        public int Beardstyle { get; set; } // ?

        public int Helm { get; set; } // ItemDisplayInfo.Id

        public int Shoulder { get; set; } // ItemDisplayInfo.Id

        public int Shirt { get; set; } // ItemDisplayInfo.Id

        public int Cuirass { get; set; } // ItemDisplayInfo.Id

        public int Belt { get; set; } // ItemDisplayInfo.Id

        public int Legs { get; set; } // ItemDisplayInfo.Id

        public int Boots { get; set; } // ItemDisplayInfo.Id

        public int Rings { get; set; } // ItemDisplayInfo.Id

        public int Gloves { get; set; } // ItemDisplayInfo.Id

        public int Wrists { get; set; } // ItemDisplayInfo.Id

        public int Cape { get; set; } // ItemDisplayInfo.Id

        [RealType(typeof(int))]
        public bool CanEquipOther { get; set; }

        public string Texture { get; set; } // .blp file names
    }
}
