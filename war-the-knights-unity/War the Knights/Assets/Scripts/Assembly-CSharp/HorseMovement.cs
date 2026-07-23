using System;
using System.Collections;
using System.Collections.Generic;
using KinematicCharacterController;
using UnityEngine;

public class HorseMovement : MonoBehaviour, ICharacterController
{
	private sealed class _003CTakeFallDamageAtEndOfFrame_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HorseMovement _003C_003E4__this;

		public float fallDistance;

		public Vector3 velocity;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTakeFallDamageAtEndOfFrame_003Ed__75(int _003C_003E1__state)
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

	public Animator horseAnim;

	public float currentAnimMoveX;

	public float currentAnimMoveZ;

	public float animMoveX;

	public float animMoveZ;

	private Vector3 _rootMotionPositionDelta;

	public float ForwardAxisSharpness;

	public float TurnAxisSharpness;

	public float StableMovementSharpness;

	public float OrientationSharpness;

	public OrientationMethod OrientationMethod;

	public float currentSpeedMultiplier;

	private float highestPointDuringJump;

	private float lastYPos;

	private bool startedToLeaveGround;

	public VehicleAttackHorse horseVehicle;

	public Transform SwimmingReferencePoint;

	public Transform CameraReferencePoint;

	public LayerMask WaterLayer;

	public LayerMask waterEnterDepthCheckLayerMask;

	public Collider waterZone;

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

	public Transform MeshRoot;

	public HorseState CurrentCharacterState;

	private Collider[] _probedColliders;

	public float movementSpeedLevel;

	public float movementSpeedLevelTarget;

	public float rotationSpeed;

	public float movementSpeedTarget;

	public float movementSpeed;

	public float rotationSpeedLevelTarget;

	private float rotationDirection;

	private float _targetForwardAxis;

	private float rotationDirectionTarget;

	public bool _jumpRequested;

	private bool _jumpConsumed;

	private bool _jumpedThisFrame;

	private float _timeSinceJumpRequested;

	private float _timeSinceLastAbleToJump;

	private Vector3 _internalVelocityAdd;

	public float _verticalInput;

	public float timeLastLanded;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TransitionToState(HorseState newState)
	{
	}

	public void OnStateEnter(HorseState state, HorseState fromState)
	{
	}

	public void OnStateExit(HorseState state, HorseState toState)
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

	public void OnJump()
	{
	}

	public void UpdateRootMotionDelta(Vector3 deltaPos, Quaternion deltaRot)
	{
	}

	private void OnEnable()
	{
	}
}
