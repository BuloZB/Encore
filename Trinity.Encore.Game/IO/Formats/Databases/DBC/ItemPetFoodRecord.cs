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

        public int GetMask() // Used in CreatureFamilyRecord.ItemPetFoodMask
        {
            return 1 << Id - 1; // (int)Math.Pow(2.0, Id - 1.0);
        }
    }
}
