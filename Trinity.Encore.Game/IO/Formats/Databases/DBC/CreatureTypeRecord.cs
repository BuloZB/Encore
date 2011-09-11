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

        public int GetMask() // Used in Spell
        {
            return 1 << Id - 1; // (int)Math.Pow(2.0, Id - 1.0);
        }
    }
}
