using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class CreatureSoundDataRecord : IClientDbRecord
    {
        // Verified in 14545

        public int Id { get; set; }

        public int SoundExertionId { get; set; } // SoundEntries.Id

        public int SoundExertionCriticalId { get; set; } // SoundEntries.Id

        public int SoundInjuryId { get; set; } // SoundEntries.Id

        public int SoundInjuryCriticalId { get; set; } // SoundEntries.Id

        public int SoundInjuryCrushingBlowId { get; set; } // SoundEntries.Id Always 0

        public int SoundDeathId { get; set; } // SoundEntries.Id

        public int SoundStunId { get; set; } // SoundEntries.Id

        public int SoundStandId { get; set; } // SoundEntries.Id

        public int SoundFootstepId { get; set; } // SoundEntries.Id

        public int SoundAggroId { get; set; } // SoundEntries.Id

        public int SoundWingFlapId { get; set; } // SoundEntries.Id

        public int SoundWingGlideId { get; set; } // SoundEntries.Id

        public int SoundAlertId { get; set; } // SoundEntries.Id

        public int SoundFidgetId1 { get; set; } // SoundEntries.Id

        public int SoundFidgetId2 { get; set; } // SoundEntries.Id

        public int SoundFidgetId3 { get; set; } // SoundEntries.Id

        public int SoundFidgetId4 { get; set; } // SoundEntries.Id

        public int SoundFidgetId5 { get; set; } // SoundEntries.Id

        public int SoundCustomAttackId1 { get; set; } // SoundEntries.Id

        public int SoundCustomAttackId2 { get; set; } // SoundEntries.Id

        public int SoundCustomAttackId3 { get; set; } // SoundEntries.Id

        public int SoundCustomAttackId4 { get; set; } // SoundEntries.Id

        public int NPCSoundId { get; set; } // SoundEntries.Id

        public int LoopSoundId { get; set; } // SoundEntries.Id

        public int CreatureImpactType { get; set; } // ?

        public int SoundJumpstartId { get; set; } // SoundEntries.Id

        public int SoundJumpendId { get; set; } // SoundEntries.Id

        public int SoundPetAttackId { get; set; } // SoundEntries.Id

        public int SoundPetOrderId { get; set; } // SoundEntries.Id

        public int SoundPetDismissId { get; set; } // SoundEntries.Id Used by SMSG_PET_DISMISS_SOUND?

        public float FidgetDelaySecondsMin { get; set; } // ?

        public float FidgetDelaySecondsMax { get; set; } // ?

        public int SoundBirthId { get; set; } // SoundEntries.Id

        public int SpellCastDirectedSoundId { get; set; } // SoundEntries.Id

        public int SubmergeSoundId { get; set; } // SoundEntries.Id

        public int SubmergedSoundId { get; set; } // SoundEntries.Id

        public int CreatureSoundDataIdPet { get; set; } // SoundEntries.Id

        public int TransformSoundId { get; set; } // SoundEntries.Id

        public int TransformAnimatedSoundId { get; set; } // SoundEntries.Id
    }
}
