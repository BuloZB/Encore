using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AchievementCategoryRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }
    }
}
