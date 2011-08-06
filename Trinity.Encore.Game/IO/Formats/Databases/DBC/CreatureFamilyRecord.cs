using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CreatureFamilyRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public float MinScale { get; set; }

        public int MinScaleLevel { get; set; } // Player level or pet level?

        public float MaxScale { get; set; }

        public int MaxScaleLevel { get; set; }

        public int SkillLine1 { get; set; } // SkillLine.Id

        public int SkillLine2 { get; set; } // SkillLine.Id

        public int ItemPetFood { get; set; }  // ItemPetFood.id

        public int PetTalentType { get; set; } // ?

        public int CategoryEnumId { get; set; } // ?

        public string Name { get; set; }

        public string IconFileName { get; set; }
    }
}
