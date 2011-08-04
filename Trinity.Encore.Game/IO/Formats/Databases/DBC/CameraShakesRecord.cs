using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CameraShakesRecord : IClientDbRecord
    {
        // Use in client: CGCamera::AddShake( vector, shakeType, direction, amplitude*0.027777778, frequency, duration, phase, coefficient );

        public int Id { get; set; }

        public int ShakeType { get; set; }

        public int Direction { get; set; }

        public float Amplitude { get; set; }

        public float Frequency { get; set; }

        public float Duration { get; set; }

        public float Phase { get; set; }

        public float Coefficient { get; set; }

        public int Unknown { get; set; } // Always 0
    }
}
