using System;
using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class ItemPetFoodRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public string FoodName { get; set; }

        [SkipProperty]
        public int RaceMask // Used in CreatureFamilyRecord.ItemPetFoodMask
        {
            get { return 1 << Id - 1; }
        }
    }
}
