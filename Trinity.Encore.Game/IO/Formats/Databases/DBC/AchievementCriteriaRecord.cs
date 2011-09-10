using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AchievementCriteriaRecord : IClientDbRecord
    {
        // Verified in 14545
        // TODO: Add RequiredTypes enums

        public int Id { get; set; }

        public int ReferencedAchievementId { get; set; }

        public int RequiredType { get; set; }

        public int Criteria1 { get; set; }

        public int Criteria2 { get; set; }

        public int Unknown1 { get; set; } // Always 0

        public CriteriaRequirementData Requirement1 { get; set; }

        public CriteriaRequirementData Requirement2 { get; set; }

        public string Name { get; set; }

        public int CompletionFlag { get; set; }

        public int TimedType { get; set; }

        /// <summary>
        /// For timed spells, this is the spell ID, while for timed kills, it is the creature entry ID.
        /// </summary>
        public int TimerStartId { get; set; }

        /// <summary>
        /// Time in seconds for achievements that require "*something* in %i seconds".
        /// </summary>
        public int TimeLimit { get; set; }

        /// <summary>
        /// User interface order.
        /// </summary>
        public int Order { get; set; }

        public int Unknown2 { get; set; } // mostly 0; 6000 > x > 3922

        public int Unknown3 { get; set; } // 0/1/2

        public int MoreRequiredType1 { get; set; }

        public int MoreRequiredType2 { get; set; }

        public int MoreRequiredType3 { get; set; } // No matching Value? Needs research

        public int MoreRequiredValue1 { get; set; }

        public int MoreRequiredValue2 { get; set; }

        public sealed class CriteriaRequirementData
        {
            public int Type { get; set; }

            public int Value { get; set; }
        }
    }
}
