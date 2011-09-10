using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AreaGroupRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int AreaId1 { get; set; }

        public int AreaId2 { get; set; }

        public int AreaId3 { get; set; }

        public int AreaId4 { get; set; }

        public int AreaId5 { get; set; }

        public int AreaId6 { get; set; }

        /// <summary>
        /// AreaGroupId if a group needs more than 6 areas
        /// </summary>
        public int NextGroupId { get; set; }
    }
}
