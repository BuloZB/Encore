using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CreatureDisplayInfoRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int Model { get; set; } // CreatureModelData.Id

        public int Sound { get; set; } // CreatureSoundData.Id

        public int DisplayInfoExtra { get; set; } // CreatureDisplayInfoExtra.Id

        public float Scale { get; set; }

        public int Opacity { get; set; } // From 0 to 255

        public string Skin1 { get; set; }

        public string Skin2 { get; set; }

        public string Skin3 { get; set; }

        public string PortraitTexture { get; set; }

        // TODO: Verify the following fields

        public int SizeClass { get; set; }

        public int BloodLevel { get; set; } // UnitBloodLevel.Id or UnitBlood.Id

        public int NPCSounds { get; set; } // NPCSounds.Id

        public int Particles { get; set; } // ParticleColor

        public int CreatureGeosetData { get; set; }

        public int ObjecteffectPackage { get; set; } // ObjectEffectPackage.Id

        public int AnimReplacementSet { get; set; }

        [SkipProperty]
        public float OpacityPercent
        {
            get
            {
                return Opacity * (float)(100/byte.MaxValue);
            }
        }
    }
}
