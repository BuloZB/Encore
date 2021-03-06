﻿using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CharStartOutfitRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int RaceClassGender { get; set; }

        public OutfitData Outfit { get; set; }

        public OutfitData Displays { get; set; }

        public OutfitData InventorySlots { get; set; }

        public int Unknown1 { get; set; }

        public int Unknown2 { get; set; }

        public int Unknown3 { get; set; }

        public int Unknown4 { get; set; }

        public int Unknown5 { get; set; }

        public sealed class OutfitData
        {
            public int Field1 { get; set; }

            public int Field2 { get; set; }

            public int Field3 { get; set; }

            public int Field4 { get; set; }

            public int Field5 { get; set; }

            public int Field6 { get; set; }

            public int Field7 { get; set; }

            public int Field8 { get; set; }

            public int Field9 { get; set; }

            public int Field10 { get; set; }

            public int Field11 { get; set; }

            public int Field12 { get; set; }

            public int Field13 { get; set; }

            public int Field14 { get; set; }

            public int Field15 { get; set; }

            public int Field16 { get; set; }

            public int Field17 { get; set; }

            public int Field18 { get; set; }

            public int Field19 { get; set; }

            public int Field20 { get; set; }

            public int Field21 { get; set; }

            public int Field22 { get; set; }

            public int Field23 { get; set; }

            public int Field24 { get; set; }
        }
    }
}
