using System.Diagnostics.Contracts;
using Mono.GameMath;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CreatureModelDataRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; } // 1849 and 1860

        public int Flags { get; set; }

        public string ModelPath { get; set; } // .mdx file names

        public int SizeClass { get; set; } // ?

        public int ModelScale { get; set; }

        public int BloodLevel { get; set; } // UnitBloodLevels.Id

        public int Footprint { get; set; } // FootprintTextures.Id

        public float FootprintTextureLength { get; set; }

        public float FootprintTextureWidth { get; set; }

        public float FootprintParticleScale { get; set; }

        public int Unknown1 { get; set; } // Always 0

        public int FootstepShake { get; set; } // CameraShakes.Id ?

        public int DeathThudShake { get; set; } // CameraShakes.Id ?

        public int SoundData { get; set; } // CreatureSoundData.Id

        public float CollisionWidth { get; set; } // ?

        public float CollisionHeight { get; set; } // ?

        public float MountHeight { get; set; } // ?

        public Vector3 GeoBoxMin { get; set; } // ?

        public Vector3 GeoBoxMax { get; set; } // ?

        public float WorldEffectScale { get; set; } // ?

        public float AttachedEffectScale { get; set; } // ?

        public float Unknown2 { get; set; } // ?

        public float Unknown3 { get; set; } // ?

        public float Unknown4 { get; set; } // ?

        public float Unknown5 { get; set; } // ?

        public float Unknown6 { get; set; } // ?

        public float Unknown7 { get; set; } // ?
    }
}
