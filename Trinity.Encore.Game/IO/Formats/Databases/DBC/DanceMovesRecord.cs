using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class DanceMovesRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Type { get; set; }

        public int Value { get; set; }

        public int Fallback { get; set; } // DanceMoves.Id

        public int Racemask { get; set; } // ChrRaces.GetMask
        
        public string Description1 { get; set; }

        public string Description2 { get; set; }

        public int Lockid { get; set; } // ?

        /* 
         * Type 0: "normal"
         *   Value: AnimationData.Id
         * Type 1: "spells"
         *   Value: SpellVisualKit.Id
         * Type 2: unk (Gnome - FemaleLaugh)
         *   Value: unk
         * Type 3: Hold
         *   Value: seconds
         * Type 4: Repeat
         *   Value: seconds
         */
    }
}
