using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : WeaponBase
{
	private sealed class _003CDisableScope_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Gun _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDisableScope_003Ed__101(int _003C_003E1__state)
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

	private sealed class _003CWaitForFireAnim_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Gun _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForFireAnim_003Ed__102(int _003C_003E1__state)
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

	public WeaponGun weapon;

	public float equipAnimPercentageTilAbleToAttack;

	public bool outOfAmmo;

	public bool autoReloadOnEquip;

	public bool canReloadWhilstAiming;

	public bool stoppedShooting;

	public bool dontShowReloadWarning;

	public bool hasAmmoObject;

	private GameObject ammoObject;

	private GameObject ammoObjectSpecialAmmo;

	public AmmoSpawn ammoSpawnPosition;

	public Transform customAmmoSpawnPosition;

	public bool hasOutOfAmmoAnimation;

	public bool usingSpecialAmmo;

	public int specialAmmo;

	public float fireRateTimer;

	public bool isAkimbo;

	public bool akimboReady;

	public bool akimboIsLeftGun;

	public bool canCharge;

	public ChargeType chargeType;

	public bool chargeTimeByAnimation;

	public float chargeTime;

	public float chargeTimeProgress;

	public bool stoppedCharging;

	public bool hasRecoil;

	public RecoilProfile recoilProfile;

	public bool hasAnimRecoil;

	public RecoilTypes animRecoilType;

	public bool hasCameraShake;

	public CameraShakeType cameraShakeType;

	public WeaponRangedEquipSounds equipSound;

	public AudioClip customEquipSound;

	public WeaponRangedAttackSounds attackSound;

	public AudioClip customAttackSound;

	public bool randomizeAttackSoundPitch;

	public WeaponRangedChargeSounds chargeSound;

	public AudioClip customChargeSound;

	public WeaponReloadSounds reloadSound;

	public AudioClip customReloadSound;

	public WeaponAimSounds aimSound;

	public AudioClip customAimSound;

	public WeaponAimStopSounds aimStopSound;

	public AudioClip customAimStopSound;

	public WeaponReload2Sounds reload2Sound;

	public AudioClip customReload2Sound;

	public AudioClip[] customAdditionalSounds;

	public ParticleSystem[] muzzleParticles;

	public bool hasTrail;

	public GameObject trailPrefab;

	public GameObject trailOrigin;

	public bool trailOnlyWhenAimed;

	public float aimMovementMultiplier;

	public bool hasAimZoom;

	public float zoomFovRatio;

	public int zoomFovWeapon;

	public bool instantAimZoom;

	public CrosshairShowType crosshairShowType;

	public WeaponScopes scope;

	public MeshRenderer[] weaponParts;

	private bool isInScope;

	public int projectileSpeedOrImpactForce;

	public int maxPenetrationsAmount;

	public float maxPenetrationLengthSquared;

	public bool hasProjectile;

	public ProjectileType projectileType;

	public GameObject customProjectile;

	public GameObject customProjectileVisual;

	public bool isAutomatic;

	public bool isBoltAction;

	private bool fired;

	private static readonly RaycastHit[] enemyHits;

	private static readonly RaycastHit[] enemyHitExits;

	private static readonly WaitForSeconds WaitForUnscopeTimer;

	public override void PlayerStart()
	{
	}

	public override void BotStart()
	{
	}

	private void SetSounds()
	{
	}

	private void Update()
	{
	}

	public override void BotAttack()
	{
	}

	public override void BotCancelAttack()
	{
	}

	public void BotReload()
	{
	}

	public float GetFireRateTimer()
	{
		return 0f;
	}

	public float GetFireRate()
	{
		return 0f;
	}

	public bool IsReloading()
	{
		return false;
	}

	public void TryToReload()
	{
	}

	public bool IsFiring()
	{
		return false;
	}

	public bool IsFiringNextState()
	{
		return false;
	}

	public bool CanShoot(bool startToShoot)
	{
		return false;
	}

	public void Shoot()
	{
	}

	public void StartAiming()
	{
	}

	public void StopAiming()
	{
	}

	public void StopCharging(bool playIdleAnim)
	{
	}

	public void StopReload()
	{
	}

	public void Reload()
	{
	}

	public void ReloadAkimbo()
	{
	}

	public void ReloadBullet()
	{
	}

	public void CheckReloadProgressAfterReloadingBullet()
	{
	}

	public void CallbackToAkimboManagerAfterFinishingReload()
	{
	}

	public void GunReadyWhenEquippingOrReloading()
	{
	}

	public void ReloadAllAmmo()
	{
	}

	public void ToggleScope()
	{
	}

	public IEnumerator DisableScope()
	{
		return null;
	}

	public IEnumerator WaitForFireAnim()
	{
		return null;
	}

	public void CheckAmmo()
	{
	}

	public void SetSpecialAmmo(WeaponGadget ammoType, bool playAnim)
	{
	}

	public void SetSpecialAmmoLook()
	{
	}

	public void SetSpecialAmmoLookOnly()
	{
	}

	public void PlayCustomAdditionalWeaponSound(int sound)
	{
	}

	public void ShowFlash()
	{
	}

	public void ConsumeAmmo()
	{
	}

	public void UpdateAmmo()
	{
	}

	public void ShowAmmoObject()
	{
	}

	public void HideAmmoObject()
	{
	}

	private void OnDestroy()
	{
	}

	public void UnequipDone()
	{
	}

	public void UnequipFastDone()
	{
	}

	public override void BlockHit(bool breakBlock)
	{
	}

	public override void Kick()
	{
	}
}
