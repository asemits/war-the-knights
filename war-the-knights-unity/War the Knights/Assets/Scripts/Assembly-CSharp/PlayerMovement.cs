using System;
using System.Collections;
using System.Collections.Generic;
using KinematicCharacterController;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, ICharacterController
{
	private sealed class _003CTakeFallDamageAtEndOfFrame_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerMovement _003C_003E4__this;

		public float fallDistance;

		public Vector3 velocity;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTakeFallDamageAtEndOfFrame_003Ed__83(int _003C_003E1__state)
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

	public KinematicCharacterMotor Motor;

	public float MaxStableMoveSpeed;

	public float StableMovementSharpness;

	public float OrientationSharpness;

	public OrientationMethod OrientationMethod;

	public float currentSpeedMultiplier;

	public float highestPointDuringJump;

	private float lastYPos;

	private bool startedToLeaveGround;

	public LayerMask crouchRaycastLayer;

	public Transform SwimmingReferencePoint;

	public Transform CameraReferencePoint;

	public LayerMask WaterLayer;

	private Collider[] _waterOverlap;

	public float waterSpeed;

	public float waterMovementSharpness;

	public float waterOrientationSharpness;

	public bool jumpOutOfWater;

	public float MaxAirMoveSpeed;

	public float AirAccelerationSpeed;

	public float Drag;

	public bool AllowJumpingWhenSliding;

	public float JumpSpeed;

	public float JumpPreGroundingGraceTime;

	public float JumpPostGroundingGraceTime;

	public bool OrientTowardsGravity;

	public Vector3 Gravity;

	public Vector3 GravityWallRun;

	public Transform MeshRoot;

	public CharacterState CurrentCharacterState;

	private Collider[] _probedColliders;

	private Vector3 _moveInputVector;

	private Vector3 _lookInputVector;

	public bool _jumpRequested;

	private bool _jumpConsumed;

	private bool _jumpedThisFrame;

	private float _timeSinceJumpRequested;

	private float _timeSinceLastAbleToJump;

	private Vector3 _internalVelocityAdd;

	public bool _isTryingToUncrouch;

	public bool _isTryingToCrouch;

	private Vector3 lastInnerNormal;

	private Vector3 lastOuterNormal;

	public float _verticalInput;

	public Vector3 localCameraStandingHeight;

	public Vector3 localCameraCrouchingHeight;

	public Vector3 localCameraHeightChangeVelocity;

	private float minFallDistanceToTakeDamage;

	private float maxFallDistanceDifference;

	public AnimationCurve fallDamageCurve;

	public AnimationCurve weaponHeavyAttackMovementMultiplierCurve;

	public AnimationCurve kickAttackMovementMultiplierCurve;

	private float weaponHeavyAttackStartTime;

	private float weaponHeavyAttackDuration;

	private bool usingWeaponAttackMovementMultiplier;

	private bool usingWeaponAttackMovementMultiplierKick;

	public float footstepTimer;

	private float speedMult;

	private float weaponParentSpeedMult;

	private Collider _003C_waterZone_003Ek__BackingField;

	public Collider _waterZone
	{
		get
		{
			return _003C_waterZone_003Ek__BackingField;
		}
		set
		{
			_003C_waterZone_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void TransitionToState(CharacterState newState)
	{
	}

	public void OnStateEnter(CharacterState state, CharacterState fromState)
	{
	}

	public void OnStateExit(CharacterState state, CharacterState toState)
	{
	}

	public void SetInputs(ref PlayerCharacterInputs inputs)
	{
	}

	public void BeforeCharacterUpdate(float deltaTime)
	{
	}

	public void UpdateRotation(ref Quaternion currentRotation, float deltaTime)
	{
	}

	public void UpdateVelocity(ref Vector3 currentVelocity, float deltaTime)
	{
	}

	public void AfterCharacterUpdate(float deltaTime)
	{
	}

	public void ResetCrouching()
	{
	}

	public void PostGroundingUpdate(float deltaTime)
	{
	}

	public bool IsColliderValidForCollisions(Collider coll)
	{
		return false;
	}

	public void OnGroundHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, ref HitStabilityReport hitStabilityReport)
	{
	}

	public void OnMovementHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, ref HitStabilityReport hitStabilityReport)
	{
	}

	public void OnDiscreteCollisionDetected(Collider hitCollider)
	{
	}

	public void AddVelocity(Vector3 velocity)
	{
	}

	public void ResetVelocity()
	{
	}

	public void ProcessHitStabilityReport(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, Vector3 atCharacterPosition, Quaternion atCharacterRotation, ref HitStabilityReport hitStabilityReport)
	{
	}

	protected void OnLanded()
	{
	}

	private IEnumerator TakeFallDamageAtEndOfFrame(float fallDistance, Vector3 velocity)
	{
		return null;
	}

	protected void OnLeaveStableGround()
	{
	}

	public void PlayerEnterWater(bool enterWater)
	{
	}

	public void Crouch(bool crouch)
	{
	}

	public void CrouchToggle()
	{
	}

	public void OnJump()
	{
	}

	public void StartHeavyAttackSpeedChange(MeleeWeaponCameraMovement meleeWeaponCameraMovement = null)
	{
	}

	public void StartKickAttackSpeedChange()
	{
	}

	private void SetSpeed()
	{
	}
}
