using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using MilkShake;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static TweenCallback _003C_003E9__115_0;

		public static TweenCallback _003C_003E9__115_1;

		public static TweenCallback _003C_003E9__115_2;

		public static TweenCallback _003C_003E9__116_0;

		internal void _003CRespawn_003Eb__115_0()
		{
		}

		internal void _003CRespawn_003Eb__115_1()
		{
		}

		internal void _003CRespawn_003Eb__115_2()
		{
		}

		internal void _003CDefeatSlowmo_003Eb__116_0()
		{
		}
	}

	private sealed class _003CDefeatSlowmo_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject damageDealer;

		public PlayerStats _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDefeatSlowmo_003Ed__116(int _003C_003E1__state)
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

	private sealed class _003CRespawn_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStats _003C_003E4__this;

		public bool dontMove;

		public int point;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRespawn_003Ed__115(int _003C_003E1__state)
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

	private sealed class _003CSpawnCountdown_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStats _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private int _003CnextLowerInteger_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSpawnCountdown_003Ed__117(int _003C_003E1__state)
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

	public PlayerHealth health;

	public AIAlliance alliance;

	public AITarget target;

	public bool canRespawn;

	private static readonly Vector3 spawnPointSelectionClickAnimationScale;

	public bool deployedClicked;

	public PlayerMovement playerMovement;

	public InputHandling playerMovementInputHandling;

	public Transform _transform;

	public Animator cameraAnimation;

	public Transform playerCameraTransform;

	public Transform playerCameraMovementTransform;

	public Transform playerCameraAnimationTransform;

	public Camera weaponCamera;

	public Camera defaultCamera;

	public GameObject playerCameraParent;

	public Transform carrySmallTransform;

	public Transform carryMediumTransform;

	public Shaker cameraShake;

	public ShakePreset shakeMeleeHitLight;

	public ShakePreset shakeMeleeHitHeavy;

	public ShakePreset shakeBowFire;

	public ShakePreset shakeBallistaFire;

	public ShakePreset shakeTakeDamage;

	public ShakePreset shakeExplosion;

	public ShakePreset shakeDefeat;

	public Vector2 meleeAttackAnimDirectionCurrent;

	public Vector2 meleeAttackAnimDirection;

	private Vector2 meleeAttackAnimDirectionSmoothingCurrentVelocity;

	private float meleeAttackAnimTransitionDurationStartTime;

	private float meleeAttackAnimTransitionDuration;

	private float meleeAttackAnimLayerWeightCurrent;

	private float meleeAttackAnimLayerWeightTarget;

	private float meleeAttackAnimLayerWeightSmoothingCurrentVelocity;

	public CameraRecoil recoilObject;

	public int defaultCameraFOV;

	public int fovTargetCamera;

	public int defaultWeaponCameraFOV;

	public int fovTargetWeaponCamera;

	public static float blockableDamage;

	private CrosshairState currentCrosshairState;

	public WeaponCrosshair currentCrosshairType;

	public GameObject currentCrosshair;

	public GameObject allCrosshairs;

	public GameObject sprintingCrosshair;

	public GameObject interactionCrosshair;

	public GameObject crosshairDefault;

	public GameObject crosshairNone;

	public GameObject crosshairRevolver;

	public GameObject crosshairRevolverFanning;

	public GameObject crosshairRifle;

	public GameObject crosshairMelee;

	public GameObject crosshairBow;

	public GameObject crosshairShotgun;

	public GameObject crosshairDynamite;

	public GameObject crosshairThrowable;

	public GameObject crosshairDot;

	public Image[] sprintingCrosshairImages;

	public Image[] interactionCrosshairImages;

	public Image[] crosshairDefaultImages;

	public Image[] crosshairNoneImages;

	public Image[] crosshairRevolverImages;

	public Image[] crosshairRevolverFanningImages;

	public Image[] crosshairRifleImages;

	public Image[] crosshairMeleeImages;

	public Image[] crosshairBowImages;

	public Image[] crosshairShotgunImages;

	public Image[] crosshairDynamiteImages;

	public Image[] crosshairThrowableImages;

	public Image[] crosshairDotImages;

	public Animator hitmarkerAnim;

	public float spreadSizeWeapon;

	public bool changeCrosshairSizeImmediately;

	public Image reloadProgressWheel;

	public float currentEndurance;

	public bool rechargingEndurance;

	public static PlayerStats Instance;

	public AnimationCurve swingCurveStart;

	public AnimationCurve swingCurve;

	public AnimationCurve swingCurveFinish;

	private float swingStartDuration;

	private float swingDuration;

	private float swingFinishDuration;

	private Vector3 meleeAttackRotationPrevious;

	private Vector3 meleeAttackRotationCurrent;

	private Vector3 meleeAttackRotationTarget;

	public static Vector3 playerSpawnRotation;

	private static readonly WaitForSeconds WaitForInputAfterDefeatTimer;

	private static readonly Vector3 spawnTimerTextAnimationScale;

	public bool DeployedClicked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void FOVChange()
	{
	}

	public void PlayCameraRecoil(RecoilTypes recoilType)
	{
	}

	public void PlayCameraEquip(CameraEquipAnim equipAnim)
	{
	}

	public void PlayCameraAttack(MeleeWeaponCameraMovement meleeWeaponCameraMovement, bool stab)
	{
	}

	public void CameraShake(CameraShakeType shakeType, float strength = 1f)
	{
	}

	public void SetCrosshair(WeaponCrosshair crosshair)
	{
	}

	public void SetCrosshairColor(Color color)
	{
	}

	public void SetSprintingOrInteractionCrosshair(CrosshairState crosshair)
	{
	}

	public void ShowHitmarker(HitmarkerType hitType)
	{
	}

	public void UpdateUIAfterLoading()
	{
	}

	public bool AddHealthDrink(int amount)
	{
		return false;
	}

	public void RemoveHealthDrink()
	{
	}

	public void UpdateReloadProgress(float current)
	{
	}

	public void FinishReloadProgress()
	{
	}

	public void Defeat(GameObject damageDealer)
	{
	}

	public void ResetStats(bool equipWeapon)
	{
	}

	public void ResetStates()
	{
	}

	public void ResetMovementStates()
	{
	}

	public void SetPlayerSpawnRotation(CapturePoint pointToSpawnAt)
	{
	}

	public IEnumerator Respawn(int point, bool dontMove = false)
	{
		return null;
	}

	private IEnumerator DefeatSlowmo(GameObject damageDealer)
	{
		return null;
	}

	private IEnumerator SpawnCountdown()
	{
		return null;
	}

	public void OpenSpawnMenuAtStart(bool onlyShowSideSelection)
	{
	}

	public void OpenSpawnMenuAfterDefeatConfirm()
	{
	}

	public void OpenSpawnMenuAfterCamMove()
	{
	}
}
