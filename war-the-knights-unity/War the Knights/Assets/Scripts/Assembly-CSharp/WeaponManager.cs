using System;
using System.Collections;
using System.Collections.Generic;
using MilkShake;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour
{
	private sealed class _003CRestartAnimsetCoroutine_003Ed__190 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRestartAnimsetCoroutine_003Ed__190(int _003C_003E1__state)
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

	private sealed class _003CStartWaitingForAttackButtonReleaseCoroutine_003Ed__168 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartWaitingForAttackButtonReleaseCoroutine_003Ed__168(int _003C_003E1__state)
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

	private sealed class _003CWaitFrameToCloseCircleMenu_003Ed__222 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitFrameToCloseCircleMenu_003Ed__222(int _003C_003E1__state)
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

	private sealed class _003CWaitUntilColliderLeftCollider_003Ed__220 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Collider colliderToLeave;

		public Collider colliderToBeLeft;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitUntilColliderLeftCollider_003Ed__220(int _003C_003E1__state)
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

	public WeaponEquippable currentWeapon;

	public WeaponBase currentWeaponBase;

	public CharacterClasses currentClass;

	public WeaponMelee primaryWeapon;

	public bool meleeThrownAway;

	public WeaponGun secondaryWeapon;

	public WeaponThrowable throwableWeapon;

	public WeaponMelee fists;

	public WeaponShield shield;

	public bool shieldThrownAway;

	public WeaponGadget gadget1;

	public WeaponGadget gadget2;

	public EquipmentLoadout currentLoadout;

	public AkimboManager akimboManager;

	public GameObject healthDrinkPrefab;

	public GameObject kickPrefab;

	public GameObject kickObject;

	public LayerMask weaponRayLayerMask;

	public LayerMask placementLayerMask;

	public Animator weaponParentAnim;

	private float weaponParentDamageDirectionVelocity;

	public float weaponParentDamageDirectionCurrent;

	public float weaponParentDamageDirectionTarget;

	public GameObject defaultArrow;

	public GameObject defaultArrowVisual;

	public GameObject defaultQuiver;

	public GameObject defaultBolt;

	public GameObject defaultBoltVisual;

	public GameObject defaultBoltQuiver;

	public AIBehaviorBase playerAIBehaviorBase;

	public LayerMask defaultProjectileLayerMask;

	public LayerMask defaultExplosionLayerMask;

	public LayerMask defaultExplosionHitCheckLayerMask;

	public LayerMask defaultFireLayerMask;

	public LayerMask gunLayerMask;

	public LayerMask vehicleLayerMask;

	public LayerMask botLayerMask;

	public LayerMask botsAndPlayerLayerMask;

	public LayerMask botsAndPlayerAndVehiclesLayerMask;

	public LayerMask droppedHelmetIgnoreLayerMask;

	public Material placeablePreviewMaterial;

	public MeleeWeaponTrail meleeWeaponTrailPrefab;

	public Material meleeWeaponTrailMaterial;

	public Material meleeWeaponTrailMaterialThirdPerson;

	public List<WeaponTrailCustomMaterial> weaponTrailCustomMaterial;

	public Ammo currentAmmo;

	public Ammo primaryAmmo;

	public Ammo secondaryAmmo;

	public Ammo gadget1Ammo;

	public Ammo gadget2Ammo;

	public Ammo throwableAmmo;

	public bool cantFireUI;

	public bool canUseAkimbo;

	public WeaponGadget specialAmmoToSwitchTo;

	public float kickDamage;

	public float kickPoiseDamage;

	public float kickPoiseDamageBehindIncrease;

	public DamageTypes kickDamageType;

	public AnimationCurve splashDamageStrengthFalloffCurve;

	public AnimationCurve breakableCollisionDamageFalloffCurve;

	public AnimationCurve ladderBuildRotationSpeedCurve;

	public WeaponGadget placedGadget1;

	public GameObject placedGadgetObject1;

	public WeaponGadget placedGadget2;

	public GameObject placedGadgetObject2;

	public WeaponThrowable placedThrowable;

	public GameObject placedThrowableObject;

	public List<RectTransform> instantiatedBulletIcons;

	public List<RectTransform> instantiatedBulletIconsLeft;

	public TextMeshProUGUI totalAmmoLeftText;

	public CanvasGroup ammoCanvas;

	public Animator reloadButtonAnim;

	public CanvasGroup reloadButtonCanvas;

	public CanvasGroup reloadIndicatorCanvas;

	public TextMeshProUGUI reloadIndicatorText;

	public GameObject currentActive;

	public GameObject finisherPrefab;

	public bool isQuickUsingItem;

	public int activeItemSlot;

	public int lastEquipped;

	public RectTransform hotBarSelect;

	public Animator itemSelectAnim;

	public CanvasGroup itemSelectCanvas;

	public Text itemName;

	public Animator UISelectAnim;

	public int slots;

	public UsableItem currentUsableItem;

	public LayerMask finisherLayerMask;

	public radialSelection radSelection;

	public Sprite emptySlotSprite;

	public float spreadTarget;

	public float currentSpread;

	public int nextToEquip;

	public WeaponGadget currentlyPlacingGadget;

	public Transform currentlyPlacingGadgetPreviewObject;

	public AudioSource weaponAudioSource;

	public bool manualWeaponSwitch;

	public bool hasPressedMainAttackButton;

	public GameObject[] weaponPickupObjects;

	public int weaponPickupObjectsNewestIndex;

	public GameObject[] thrownMeleeWeaponObjects;

	public int thrownMeleeWeaponObjectsNewestIndex;

	public GameObject[] droppedHelmetObjects;

	public int droppedthrownHelmetObjectsNewestIndex;

	public Animator thirdPersonAnim;

	public Renderer[] thirdPersonVisualRenderers;

	public AnimEventHandler currentWeaponAnimEventHandler;

	public Animator armsAnim;

	public GameObject armsObject;

	public Transform armsRightWeaponSpawn;

	public Transform armsLeftWeaponSpawn;

	public Transform armsLeftShieldShoulder;

	public Vector3 armsLeftShieldShoulderLocalPosition;

	public Transform weaponBaseSpawn;

	public RuntimeAnimatorController animatorRangedBow;

	public RuntimeAnimatorController animatorRangedBowTP;

	public RuntimeAnimatorController animatorRangedCrossbow;

	public RuntimeAnimatorController animatorRangedCrossbowTP;

	public RuntimeAnimatorController animatorRangedStaff;

	public RuntimeAnimatorController animatorRangedStaffTP;

	public RuntimeAnimatorController animatorRangedWand;

	public RuntimeAnimatorController animatorRangedWandTP;

	public MeleeAnimation animatorMeleeOnehandedMorningstar;

	public MeleeAnimation animatorMeleeOnehanded;

	public RuntimeAnimatorController animatorMeleeOnehandedTP;

	public RuntimeAnimatorController animatorMeleeOnehandedShieldTP;

	public MeleeAnimation animatorMeleeTwohanded;

	public RuntimeAnimatorController animatorMeleeTwohandedTP;

	public MeleeAnimation animatorMeleeTwohandedAxe;

	public RuntimeAnimatorController animatorMeleeTwohandedAxeTP;

	public MeleeAnimation animatorMeleeSpear;

	public RuntimeAnimatorController animatorMeleeSpearTP;

	public MeleeAnimation animatorMeleeDagger;

	public RuntimeAnimatorController animatorMeleeDaggerTP;

	public MeleeAnimation animatorMeleeFists;

	public RuntimeAnimatorController animatorMeleeFistsTP;

	public RuntimeAnimatorController animatorThrowable;

	public RuntimeAnimatorController animatorThrowableTP;

	public RuntimeAnimatorController animatorThrowableMagic;

	public RuntimeAnimatorController animatorThrowableOther;

	public RuntimeAnimatorController animatorGadgetDrinkTP;

	public RuntimeAnimatorController animatorGadgetThrowWithBothHandsTP;

	public RuntimeAnimatorController animatorGadgetMagicBuffTP;

	public RuntimeAnimatorController animatorGadgetPlaceTP;

	public RuntimeAnimatorController healthDrink;

	public Transform[] armTansforms;

	public Vector3[] defaultArmPositions;

	public Quaternion[] defaultArmRotations;

	public Shaker weaponShake;

	public ShakePreset shakeWeaponHit;

	public ShakePreset shakeWeaponBlock;

	public static WeaponManager Instance;

	private float gadgetRefillTimer;

	private float throwableRefillTimer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void QuickUseItem()
	{
	}

	public void UseGadget(bool useGadget1)
	{
	}

	public bool CheckGadgetAmmo(bool checkGadget1)
	{
		return false;
	}

	public void ConsumeThrowableAmmo()
	{
	}

	public void ConsumeGadgetAmmo(bool ammoGadget1)
	{
	}

	public void DestroyOldPlacedGadget(bool destroyPlacedGadget1)
	{
	}

	public void DestroyOldPlacedThrowable()
	{
	}

	private bool PlaceGadgetCheck(out RaycastHit hit)
	{
		hit = default(RaycastHit);
		return false;
	}

	public void PlaceGadget(Vector3 pos)
	{
	}

	public void ToggleGadgetPlacingMode(WeaponGadget gadget = null)
	{
	}

	public void StartWaitingForAttackButtonRelease()
	{
	}

	private IEnumerator StartWaitingForAttackButtonReleaseCoroutine()
	{
		return null;
	}

	public int RefillAmmo(float ratio, bool refillMag, float gadgetAndThrowableTimerRefillPercentage, float gadgetAndThrowableRefillRatio)
	{
		return 0;
	}

	public int RefillGadgetAmmo(float ratio, bool refillMag)
	{
		return 0;
	}

	public int RefillThrowable(float ratio)
	{
		return 0;
	}

	public int RefillAmmo(float ratio, bool refillMag, bool refillGadgets, bool refillThrowable, bool showUIIndicator)
	{
		return 0;
	}

	public void SetCurrentAmmoSlot(int ammoSlot)
	{
	}

	private void InstantiateAmmoUI(int weapon)
	{
	}

	public void AkimboAmmoUI(bool show)
	{
	}

	public void UpdateCurrentAmmoText()
	{
	}

	public int GetCurrentWeaponsAmmoInMagazine(bool leftAkimboGun)
	{
		return 0;
	}

	public int GetCurrentWeaponsTotalAmmo()
	{
		return 0;
	}

	public int IsAmmoReloadLimitReached()
	{
		return 0;
	}

	public void ConsumeAmmo(bool leftAkimboGun)
	{
	}

	public void ReloadCurrentWeaponsAmmoPartially(bool leftAkimboGun)
	{
	}

	public void ReloadCurrentWeaponsAmmoFully(bool akimboLeft)
	{
	}

	public void StartReloading()
	{
	}

	public void StopReloading()
	{
	}

	public void ShowReloadIndicator()
	{
	}

	public void HideReloadIndicator()
	{
	}

	public GameObject SpawnWeapon(Weapon weapon)
	{
		return null;
	}

	public void ResetDefaultArmTransforms()
	{
	}

	public void RestartAnimset()
	{
	}

	private IEnumerator RestartAnimsetCoroutine()
	{
		return null;
	}

	public void EquipWeapons(int weapon)
	{
	}

	public void StartUnequipAnim(int weaponToSwitchTo, bool fast, bool equipManually, bool canReequip)
	{
	}

	public void UnequipWeapons(bool equipAfterwards)
	{
	}

	public void CheckForEquipped()
	{
	}

	public void ForceStopUsingCurrentQuickItem()
	{
	}

	public void ReequipAfterAbilityUse()
	{
	}

	public void CloseCircleMenu()
	{
	}

	public bool AddAmmo(AmmoType ammoType, int amount)
	{
		return false;
	}

	public void KickStart()
	{
	}

	public void Kick()
	{
	}

	public void PlayWeaponSound(AudioClip clip, float pitch = 1f, float volumeScale = 1f)
	{
	}

	public void PlayFootstepSound(AudioClip clip)
	{
	}

	public void PlayFootstepSound(AudioClip clip, float volumeScale)
	{
	}

	public void WeaponShake(bool block, float strength = 1f)
	{
	}

	public void ToggleBlocking(bool startBlocking)
	{
	}

	public bool ThirdPersonEmote()
	{
		return false;
	}

	public void Inspire()
	{
	}

	public void PlayMovementAnim(string animationName, int layer)
	{
	}

	public void PlayCurrentWeaponAnim(string animationName)
	{
	}

	public void SetWeaponParentMovementAnimSpeed(float animationSpeed)
	{
	}

	public void SetWeaponParentMovement(bool isMoving)
	{
	}

	public bool IsUnequipping()
	{
		return false;
	}

	public bool IsBlockBroken()
	{
		return false;
	}

	public void ThrowMeleeWeapon(bool shield)
	{
	}

	public void ChangePlayerClass(CharacterClasses newClass)
	{
	}

	public bool PickUpWeapon(InteractableWeaponPickup weaponPickUp)
	{
		return false;
	}

	public void AddWeaponToMaxWeaponDropArray(GameObject weapon, bool thrown)
	{
	}

	public void AddHelmetToMaxHelmetDropArray(GameObject helmet)
	{
	}

	public void WaitUntilColliderLeftColliderToEnableCollision(Collider colliderToLeave, Collider colliderToBeLeft)
	{
	}

	private IEnumerator WaitUntilColliderLeftCollider(Collider colliderToLeave, Collider colliderToBeLeft)
	{
		return null;
	}

	public void SetLoadout()
	{
	}

	public IEnumerator WaitFrameToCloseCircleMenu()
	{
		return null;
	}
}
