using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CreatureTypeRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public string Name { get; set; }

        [RealType(typeof(int))]
        public bool RewardsNoExperience { get; set; }

        [SkipProperty]
        public int RaceMask // Used in Spell
        {
            get { return 1 << Id - 1; }
        }
    }
}
