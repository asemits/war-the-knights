using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
	private sealed class _003CFadeOutAudioSourceAndDisableIt_003Ed__205 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource audioSource;

		public float fadeOutTime;

		private float _003CtargetVolume_003E5__2;

		private float _003Ctimer_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFadeOutAudioSourceAndDisableIt_003Ed__205(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CSupressSoundForDuration_003Ed__208 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public SoundManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSupressSoundForDuration_003Ed__208(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CWaitTilAudioSourceIsDonePlayingToDisableIt_003Ed__203 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource audioSource;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitTilAudioSourceIsDonePlayingToDisableIt_003Ed__203(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CWaitTilLoopingAudioSourceIsDonePlayingToFadeOutAndDisableIt_003Ed__204 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public float fadeInTime;

		public AudioSource audioSource;

		public float fadeOutTime;

		private float _003CtargetVolume_003E5__2;

		private float _003Ctimer2_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitTilLoopingAudioSourceIsDonePlayingToFadeOutAndDisableIt_003Ed__204(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public AudioClip[] footstepsStone;

	public AudioClip[] footstepsStoneJump;

	public AudioClip[] footstepsStoneLand;

	public AudioClip[] footstepsDirt;

	public AudioClip[] footstepsDirtJump;

	public AudioClip[] footstepsDirtLand;

	public AudioClip[] footstepsGrass;

	public AudioClip[] footstepsGrassJump;

	public AudioClip[] footstepsGrassLand;

	public AudioClip[] footstepsGravel;

	public AudioClip[] footstepsGravelJump;

	public AudioClip[] footstepsGravelLand;

	public AudioClip[] footstepsMetal;

	public AudioClip[] footstepsMetalJump;

	public AudioClip[] footstepsMetalLand;

	public AudioClip[] footstepsWood;

	public AudioClip[] footstepsWoodJump;

	public AudioClip[] footstepsWoodLand;

	public AudioClip[] footstepsSnow;

	public AudioClip[] footstepsSnowJump;

	public AudioClip[] footstepsSnowLand;

	public AudioClip[] footstepsIce;

	public AudioClip[] footstepsIceJump;

	public AudioClip[] footstepsIceLand;

	public AudioClip[] footstepsSand;

	public AudioClip[] footstepsSandJump;

	public AudioClip[] footstepsSandLand;

	public AudioClip[] footstepsWater;

	public AudioClip[] footstepsWaterJump;

	public AudioClip[] footstepsWaterLand;

	public AudioClip footstepsWaterLandBig;

	public AudioClip[] footstepsLightArmor;

	public AudioClip[] footstepsHeavyArmor;

	public AudioClip[] ladderClimb;

	public AudioClip swingWeaponLight;

	public AudioClip swingWeaponVeryLight;

	public AudioClip swingWeaponHeavy;

	public AudioClip stabWeaponLight;

	public AudioClip stabWeaponVeryLight;

	public AudioClip stabWeaponHeavy;

	public AudioClip throwWeapon;

	public AudioClip throwWeaponFlyLoop;

	public AudioClip throwWeaponFlySpinLoop;

	public AudioClip kick;

	public AudioClip equipBladeLight;

	public AudioClip equipBladeVeryLight;

	public AudioClip equipBladeHeavy;

	public AudioClip equipWooden;

	public AudioClip equipBlunt;

	public AudioClip equipSpinTwohanded;

	public AudioClip equipShield;

	public AudioClip unequipShield;

	public AudioClip blockBash;

	public AudioClip blockBashShield;

	public AudioClip blockBashHitMetalShield;

	public AudioClip blockBashHitWoodShield;

	public AudioClip blockBashHitMetal;

	public AudioClip blockBashHitWood;

	public AudioClip blockHitMetal;

	public AudioClip blockHitMetalShield;

	public AudioClip blockHitWood;

	public AudioClip blockHitWoodShield;

	public AudioClip blockBreakMetal;

	public AudioClip blockBreakMetalShield;

	public AudioClip blockBreakWood;

	public AudioClip blockBreakWoodShield;

	public AudioClip equipBow;

	public AudioClip equipBowHeavy;

	public AudioClip equipCrossbow;

	public AudioClip equipMagicStaff;

	public AudioClip drawBow;

	public AudioClip drawBowHeavy;

	public AudioClip chargeMagicStaff;

	public AudioClip chargeMagicStaffFire;

	public AudioClip chargeFireball;

	public AudioClip aimBow;

	public AudioClip aimStopBow;

	public AudioClip aimCrossbow;

	public AudioClip aimStopCrossbow;

	public AudioClip aimMagicStaff;

	public AudioClip aimStopMagicStaff;

	public AudioClip fireBow;

	public AudioClip fireHeavyBow;

	public AudioClip fireCrossbow;

	public AudioClip fireMagicStaffFireball;

	public AudioClip fireMagicStaffArcane;

	public AudioClip reloadBow;

	public AudioClip reloadCrossbow;

	public AudioClip reloadMagicStaff;

	public AudioClip gadgetThrowingKnifeEquip;

	public AudioClip gadgetFireballEquip;

	public AudioClip gadgetCrateEquip;

	public AudioClip gadgetThrowingKnifeThrow;

	public AudioClip gadgetFireballThrow;

	public AudioClip gadgetFirstAidPackThrow;

	public AudioClip gadgetCrateThrow;

	public AudioClip gadgetPlaceWood;

	public AudioClip gadgetPlaceMetal;

	public AudioClip gadgetDrink;

	public AudioClip gadgetMagicBuff;

	public AudioClip gadgetMagic;

	public AudioClip gadgetSpecialAmmoAttackFire;

	public AudioClip gadgetSpecialAmmoAttackSharp;

	public AudioClip gadgetSpecialAmmoReloadFire;

	public AudioClip gadgetSpecialAmmoReloadSharp;

	public AudioClip gadgetPotionRemoveCork;

	public AudioClip emptySound;

	public AudioClip effectMetalHit;

	public AudioClip effectWoodHit;

	public AudioClip effectDirtHit;

	public AudioClip effectStoneHit;

	public AudioClip effectWaterHit;

	public AudioClip effectSnowHit;

	public AudioClip effectSandHit;

	public AudioClip effectDustHit;

	public AudioClip effectExplosionDistant1;

	public AudioClip effectExplosionDistant2;

	public AudioClip effectExplosion;

	public AudioClip effectExplosionBig;

	public AudioClip effectExplosionWater;

	public AudioClip[] effectDebris;

	public AudioClip[] effectDebrisWood;

	public AudioClip[] effectDebrisGlass;

	public AudioClip effectDebrisLarge;

	public AudioClip effectDebrisWoodLarge;

	public AudioClip effectDebrisGlassLarge;

	public AudioClip breakStone;

	public AudioClip breakWood;

	public AudioClip breakGlass;

	public AudioClip effectFireLoop;

	public AudioClip effectFire;

	public AudioClip takeDamage;

	public AudioClip takeFallDamage;

	public AudioClip[] bloodImpact;

	public AudioClip horseFootsteps;

	public AudioClip horseTakeDamage;

	public AudioClip horseTakeHeavy;

	public AudioClip catapultReload;

	public AudioClip catapultRotate;

	public AudioClip catapultFire;

	public AudioClip ballistaReload;

	public AudioClip ballistaFire;

	public AudioClip[] vehicleBreakWood;

	public AudioClip smallProjectileFlyBy;

	public AudioClip bigProjectileFlyBy;

	public AudioClip hitSound;

	public AudioClip defeatSound;

	public AudioSource ambienceAudioSourcePrefab;

	public AudioClip ambienceVeryLightWind;

	public AudioClip ambienceWind;

	public AudioClip ambienceCave;

	public AudioMixer audioMixer;

	public AudioMixerSnapshot audioSnapshotDefault;

	public AudioMixerSnapshot audioSnapshotSupressed;

	public static List<AudioSource> audioSourcePool;

	public static int audioSourcePoolCount;

	public AudioSource audioSourcePoolObjectPrefab;

	public static int currentAmbientZoneCount;

	public static int currentAmbientZoneCheckIndex;

	public static int currentAmbientZoneIndex;

	public static bool checkAmbienceTargetsNextFrame;

	public static float targetAmbientVolume;

	public static AudioClip targetAmbientAudioClip;

	public static float defaultAmbientVolume;

	public static AudioClip defaultAmbientAudioClip;

	public static bool ambienceZoneCurrentlyEntered;

	public static bool ambienceZoneLeft;

	public static AudioSource instantiatedAmbienceAudioSource;

	public static List<AmbientInteriorZone> activeAmbienceInteriorZones;

	public static SoundManager Instance;

	private Coroutine supressSoundForDurationCoroutine;

	public AudioClip GetSound(WeaponRangedEquipSounds sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponRangedAttackSounds sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponAimSounds sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponAimStopSounds sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponRangedChargeSounds sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponReloadSounds sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponReload2Sounds sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponMeleeEquipSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponMeleeUnequipSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponMeleeAttackSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponMeleeBlockBashSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponMeleeBlockBashHitSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponMeleeBlockHitSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponMeleeBlockBreakSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponThrowableEquipSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponThrowableThrowSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponGadgetPlaceSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponGadgetSpecialAmmoReloadAdditiveSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponGadgetSpecialAmmoAttackAdditiveSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponGadgetQuickUseSound sound)
	{
		return null;
	}

	public AudioClip GetSound(WeaponGadgetOtherSounds sound)
	{
		return null;
	}

	public AudioClip GetSound(VehicleBreakSounds sound)
	{
		return null;
	}

	public AudioClip GetSound(ProjectileFlyByCameraSounds sound)
	{
		return null;
	}

	public AudioClip GetFootstepAudioClipFromPhysicsMaterial(PhysicsMaterial physicMaterial)
	{
		return null;
	}

	public AudioClip GetFootstepAudioClipFromTerrain(float positionX, float positionZ)
	{
		return null;
	}

	public AudioClip GetJumpLandAudioClipFromPhysicsMaterial(PhysicsMaterial physicMaterial, bool jump)
	{
		return null;
	}

	public AudioClip GetJumpLandAudioClipFromTerrain(float positionX, float positionZ, bool jump)
	{
		return null;
	}

	public void InitializePool()
	{
	}

	public void PlayPooledAudio(AudioClip sound, Vector3 position, float minRange = 5f, float maxRange = 70f, float pitch = 1f, float volume = 1f)
	{
	}

	public AudioSource PlayPooledAudioLoopForDuration(AudioClip sound, Vector3 position, float duration, ref Coroutine coroutine, float fadeInTime = 1f, float fadeOutTime = 1f, float minRange = 5f, float maxRange = 70f, float pitch = 1f, float volume = 1f)
	{
		return null;
	}

	public void StopAudioCoroutineOnlyAndStartFadeOut(Coroutine coroutine, AudioSource audioSource, float fadeOutTime)
	{
	}

	private AudioSource GetAudioSourceFromPool()
	{
		return null;
	}

	private IEnumerator WaitTilAudioSourceIsDonePlayingToDisableIt(AudioSource audioSource)
	{
		return null;
	}

	private IEnumerator WaitTilLoopingAudioSourceIsDonePlayingToFadeOutAndDisableIt(AudioSource audioSource, float duration, float fadeInTime, float fadeOutTime)
	{
		return null;
	}

	private IEnumerator FadeOutAudioSourceAndDisableIt(AudioSource audioSource, float fadeOutTime)
	{
		return null;
	}

	public void SupressSound(float transitionDuration, float supressionDuration = 0f)
	{
	}

	public void UnsupressSound(float transitionDuration)
	{
	}

	private IEnumerator SupressSoundForDuration(float duration)
	{
		return null;
	}

	public void ChangeAmbientSounds(AmbientSound ambientSound)
	{
	}

	public AudioClip GetAmbientSound(AmbientSound ambientSound, out float volume)
	{
		volume = default(float);
		return null;
	}

	public void ChangeAmbientSounds(AudioClip ambientSound, float volume)
	{
	}
}
