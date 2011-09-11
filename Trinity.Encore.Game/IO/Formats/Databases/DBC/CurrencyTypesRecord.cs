using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CurrencyTypesRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Category { get; set; } // CurrencyCategory.Id

        public string Name { get; set; }

        public string IconName { get; set; }

        public int Unknown1 { get; set; } // Always 0

        public int Unknown2 { get; set; } // "Archaeology Fragment" got this set to 1, there is a 4 and everything else is 0

        public int Unknown3 { get; set; }

        // "Patch 4.0.6 (2011-02-08): Archaeology fragments now have a hard cap of 200 per race"
        // Need to divide by 100 for Category == 2 || Category == 22
        public int MaxCount { get; set; }

        // "Patch 4.2.0 (2011-06-28): (...) Weekly valor cap reduced from 1250 to 980.
        // Need to divide by 100 for Category == 22
        public int MaxWeekCount { get; set; }

        public int Unknown5 { get; set; }
        
        public string Description { get; set; }
    }
}
