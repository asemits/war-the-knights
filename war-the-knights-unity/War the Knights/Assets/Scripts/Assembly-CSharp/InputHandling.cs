using System;
using System.Collections;
using System.Collections.Generic;
using KinematicCharacterController;
using UnityEngine;

public class InputHandling : MonoBehaviour
{
	private enum ClimbStates
	{
		Climb = 0,
		Slide = 1
	}

	private sealed class _003CClimbCooldown_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InputHandling _003C_003E4__this;

		private Vector3 _003CpositionToMoveTo_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CClimbCooldown_003Ed__61(int _003C_003E1__state)
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

	private sealed class _003CCrouchSlide_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InputHandling _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		private Vector3 _003CoriginalDirection_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCrouchSlide_003Ed__58(int _003C_003E1__state)
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

	private sealed class _003CDash_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InputHandling _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDash_003Ed__57(int _003C_003E1__state)
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

	private sealed class _003CSmoothMoveTowardsGoalCoroutine_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InputHandling _003C_003E4__this;

		public bool leaveLadder;

		public bool ladder;

		public bool rotateCamera;

		private Vector3 _003CcurrentPos_003E5__2;

		private Vector3 _003CcurrentRot_003E5__3;

		private float _003Cduration_003E5__4;

		private bool _003CbehindLadder_003E5__5;

		private bool _003CleftOfLadder_003E5__6;

		private float _003CnormalizedTime_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSmoothMoveTowardsGoalCoroutine_003Ed__69(int _003C_003E1__state)
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

	public Transform mainCamera;

	public Transform _transform;

	public PlayerMovement playerMovement;

	public KinematicCharacterMotor motor;

	private Vector3 _moveInputVector;

	private const string HorizontalInput = "Horizontal";

	private const string VerticalInput = "Vertical";

	public Animator cameraAnimation;

	public LayerMask climbBoxLayerMask;

	public LayerMask playerSphereLayerMask;

	private Vector3 playerBoxSize;

	private Vector3 playerSlideBoxSize;

	public Mesh boxMesh;

	private RaycastHit hitClimb;

	private RaycastHit hitSlide;

	public bool ableToDash;

	public AnimationCurve slideSpeedCurve;

	public Vector3 coolMoveDirection;

	public bool ableToDoACoolMove;

	public AnimationCurve crouchSlideSpeedCurve;

	private Coroutine crouchSlideCoroutine;

	private Coroutine climbCoroutine;

	private float timeWhenLastStoppedSprinting;

	private bool hasStoppedSprinting;

	public Transform enemyFinishPosition;

	public bool checkClimb;

	public bool checkSlide;

	public float climbMaxY;

	public float climbMinY;

	public float climbForwardCheckLength;

	public bool canClimb;

	private float climbHeightOffset;

	private Transform smoothMoveTowardsGoalTransform;

	private Vector3 smoothMoveTowardsGoalRelativePosition;

	private Coroutine smoothMoveTowardsGoalCoroutine;

	private Ladder ladder;

	public float ladderClimbRatio;

	public bool canMoveOnLadder;

	public float slideMaxY;

	public float slideMinY;

	public float slideForwardCheckLength;

	public float slideBackCheckStartDistance;

	public LayerMask wallrunLayerMask;

	public RaycastHit wallHit;

	public Vector3 wallHitForward;

	public bool cameraCrouching;

	public bool cameraStandingUp;

	private static readonly WaitForSeconds WaitForDashFinishTimer;

	private static readonly WaitForSeconds WaitForDashCooldownTimer;

	private float weaponParentMovementDirection;

	private float weaponParentMovementDirectionVelocity;

	public bool HasStoppedSprinting
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	private void HandleCharacterInput()
	{
	}

	private IEnumerator Dash()
	{
		return null;
	}

	private IEnumerator CrouchSlide()
	{
		return null;
	}

	public void StopCrouchSliding(bool stopCrouch)
	{
	}

	private void CheckForClimbable()
	{
	}

	private IEnumerator ClimbCooldown()
	{
		return null;
	}

	private void Disable_Move_Enable_CharacterAfterJump(ClimbStates state)
	{
	}

	public bool AbleToSprint()
	{
		return false;
	}

	private void Sprint(Vector3 movement)
	{
	}

	public void PlayCameraAnim()
	{
	}

	public void SmoothMoveTowardsVehicle(Transform goalTransform, Vector3 goalRelativePosition)
	{
	}

	public void SmoothMoveTowardsLadder(Ladder ladder)
	{
	}

	public void LeaveLadder()
	{
	}

	private IEnumerator SmoothMoveTowardsGoalCoroutine(bool rotateCamera, bool ladder, bool leaveLadder)
	{
		return null;
	}

	public void StopCoroutinesAndResetSomeStates()
	{
	}
}
