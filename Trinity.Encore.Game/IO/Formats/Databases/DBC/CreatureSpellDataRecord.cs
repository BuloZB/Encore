using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CreatureSpellDataRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Spell1 { get; set; } // Spell.Id

        public int Spell2 { get; set; } // Spell.Id

        public int Spell3 { get; set; } // Spell.Id

        public int Spell4 { get; set; } // Spell.Id

        public int Cooldown1 { get; set; } // Divide by 10 for time in seconds?

        public int Cooldown2 { get; set; }

        public int Cooldown3 { get; set; }

        public int Cooldown4 { get; set; }
    }
}
