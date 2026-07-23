using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : WeaponBase
{
	private sealed class _003CChainAttack_003Ed__113 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Melee _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CChainAttack_003Ed__113(int _003C_003E1__state)
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

	private sealed class _003CHitPause_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHitPause_003Ed__104(int _003C_003E1__state)
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

	public bool isDualWielded;

	public WeaponMelee weapon;

	public WeaponModeMelee weaponMode;

	public bool isAttacking;

	public bool swingFromLeftSide;

	public float equipAnimPercentageTilAbleToAttack;

	public bool randomSwingDirectionAfterBlocking;

	public bool hasTrail;

	public MeleeHitEffects meleeHitEffectLightAttack;

	private DecalEffect meleeHitEffectLightAttackCached;

	public MeleeHitEffects meleeHitEffectHeavyAttack;

	private DecalEffect meleeHitEffectHeavyAttackCached;

	private MeleeWeaponCameraMovement cameraAttackAnim_Left1;

	private MeleeWeaponCameraMovement cameraAttackAnim_Left2;

	private MeleeWeaponCameraMovement cameraAttackAnim_LeftHeavy;

	private MeleeWeaponCameraMovement cameraAttackAnim_Right1;

	private MeleeWeaponCameraMovement cameraAttackAnim_Right2;

	private MeleeWeaponCameraMovement cameraAttackAnim_RightHeavy;

	public WeaponMeleeEquipSound equipSound;

	public AudioClip customEquipSound;

	public WeaponMeleeAttackSound lightAttackSound;

	public AudioClip customLightAttackSound;

	public WeaponMeleeAttackSound heavyAttackSound;

	public AudioClip customHeavyAttackSound;

	public WeaponMeleeBlockBashSound blockBashSound;

	public AudioClip customBlockBashSound;

	public WeaponMeleeBlockBashHitSound blockBashHitSound;

	public AudioClip customBlockBashHitSound;

	public WeaponMeleeBlockHitSound blockHitSound;

	public AudioClip customBlockHitSound;

	public WeaponMeleeBlockBreakSound blockBreakSound;

	public AudioClip customBlockBreakSound;

	public float blockMovementMultiplier;

	public bool heavyAttack;

	public float chargeTimeLength;

	public float meleeCharge;

	public bool isCharging;

	public bool pressedAttackButtonButNotReleasedYet;

	private readonly HealthBase[] enemiesHit;

	private readonly RaycastHit[] enemiesHitForwardAttack;

	private readonly GameObject[] environmentHits;

	private bool enemyDefeatedDuringThisSwing;

	private bool soundPlayedDuringThisSwing;

	private Coroutine hitPauseCoroutine;

	private Coroutine ChainAttackCoroutine;

	private MeleeWeaponCameraMovement currentAttackCameraMovement;

	public bool isHoldingToThrow;

	public bool hasThrown;

	public bool isBlocking;

	public bool stoppedCharging;

	public bool isUsingShield;

	public WeaponModeShield spawnedShield;

	private BoxCollider meleeWeaponCollider;

	public float weaponColliderLength;

	private MeleeRaycastCollision meleeRaycastCollision;

	public Transform weaponTrailStart;

	public Transform weaponTrailEnd;

	public bool customWeaponTrail;

	public Color customWeaponTrailColor;

	public bool customWeaponTrailIncreasedFirstPersonVisibility;

	public bool customWeaponTrailVisibleOnBots;

	private MeleeWeaponTrail meleeWeaponTrail;

	private static readonly WaitForSeconds WaitForHitstopTimer;

	private static readonly WaitForSeconds WaitForHitstopTimerHeavy;

	public void DisableWeaponColliders()
	{
	}

	public void CreateMeleeCollider()
	{
	}

	private void OnEnable()
	{
	}

	private void IgnoreCollisions()
	{
	}

	public override void PlayerStart()
	{
	}

	public void SetAnimRecoveryValuesAfterAnimSetup()
	{
	}

	private void CreateRaycastCollision()
	{
	}

	public override void BotStart()
	{
	}

	public void PlayerVehicleStart()
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

	public void BotStartAttacking()
	{
	}

	public void BotStopAttacking()
	{
	}

	public void BotBlockBashAttack()
	{
	}

	public void StartBlocking()
	{
	}

	public void StopBlocking()
	{
	}

	public void StopHoldingToThrow()
	{
	}

	public bool CanAttack()
	{
		return false;
	}

	public bool CanAttackCheck()
	{
		return false;
	}

	public void Attack(bool heavy)
	{
	}

	public void EquipDualWieldWeapon()
	{
	}

	public void StartAttacking()
	{
	}

	public void StopAttacking()
	{
	}

	public void StartAttackingVehicle()
	{
	}

	public void StopAttackingVehicle()
	{
	}

	public void StartAttackingVehicleBot()
	{
	}

	public void ForwardAttack()
	{
	}

	public void BlockBashAttack()
	{
	}

	public void SetLeftAnim(int yes)
	{
	}

	public void EquipShield()
	{
	}

	public void UnequipShield()
	{
	}

	public void SpawnShield()
	{
	}

	public void DespawnShield()
	{
	}

	private void OnDestroy()
	{
	}

	public void CreateTrail(bool isBot)
	{
	}

	public void ActivateTrail(bool bot)
	{
	}

	public void ActivateTrailOnVehicle()
	{
	}

	public void DeactivateTrail()
	{
	}

	private IEnumerator HitPause(bool heavy)
	{
		return null;
	}

	public void Hit(GameObject hitObject, ref Collision collision)
	{
	}

	public void HitRaycastCollision(GameObject hitObject, ref RaycastHit hit)
	{
	}

	public void BotHit(GameObject hitObject, ref Collision collision)
	{
	}

	public void VehicleHit(GameObject hitObject, ref Collision collision)
	{
	}

	public void VehicleHitRaycastCollision(GameObject hitObject, ref RaycastHit hit)
	{
	}

	public void VehicleBotHit(GameObject hitObject, ref Collision collision)
	{
	}

	public void UnequipDone()
	{
	}

	public void UnequipFastDone()
	{
	}

	public IEnumerator ChainAttack()
	{
		return null;
	}

	public void Throw()
	{
	}

	public void SwitchAfterThrow()
	{
	}

	public override void BlockHit(bool breakBlock)
	{
	}

	public override void Kick()
	{
	}
}
