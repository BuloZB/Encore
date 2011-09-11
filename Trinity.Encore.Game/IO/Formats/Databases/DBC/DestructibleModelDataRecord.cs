using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class DestructibleModelDataRecord : IClientDbRecord
    {
        // Verified in 14545
        // Only the GameObjectDisplayInfo.Id fields are confirmed

        public int Id { get; set; }

        public int State0Wmo { get; set; } // GameObjectDisplayInfo.Id, damaged

        public int State0ImpactEffectDoodadSet { get; set; }

        public int Unk1 { get; set; } // Always 0

        public int State0AmbientDoodadSet { get; set; }

        public int State1Wmo { get; set; } // GameObjectDisplayInfo.Id, destroyed

        public int State1DestructionDoodadSet { get; set; }

        public int State1ImpactEffectDoodadSet { get; set; }

        public int State1AmbientDoodadSet { get; set; }

        public int Unk2 { get; set; } // Always 0

        public int State2Wmo { get; set; } // GameObjectDisplayInfo.Id, destroyed_constructing

        public int State2DestructionDoodadSet { get; set; }

        public int State2ImpactEffectDoodadSet { get; set; }

        public int Unk3 { get; set; } // Always 0

        public int Unk4 { get; set; } // Always 0

        public int State3Wmo { get; set; } // GameObjectDisplayInfo.Id, "phase2"

        public int State3InitDoodadSet { get; set; }

        public int State3AmbientDoodadSet { get; set; }

        public int Unk5 { get; set; } // Always 0

        public int Unk6 { get; set; }

        public int SmokeWmo { get; set; } // GameObjectDisplayInfo.Id

        [RealType(typeof(int))]
        public bool Unk7 { get; set; }

        public int Unk8 { get; set; }

        public int Unk9 { get; set; }

    }
}
