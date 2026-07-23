using System;
using System.Collections;
using System.Collections.Generic;
using KinematicCharacterController;
using UnityEngine;

public class VehicleAttackHorse : VehicleBase
{
	private sealed class _003CChainAttack_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VehicleAttackHorse _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CChainAttack_003Ed__71(int _003C_003E1__state)
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

	private sealed class _003CStopMovement_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VehicleAttackHorse _003C_003E4__this;

		public float duration;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStopMovement_003Ed__76(int _003C_003E1__state)
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

	public bool isAiming;

	public bool isCharging;

	public Transform enterPosLeft;

	public Transform enterPosRight;

	private Vector3 moveInputVector;

	public HorseMovementSpeeds horseMovementSpeed;

	private const string HorizontalInput = "Horizontal";

	private const string VerticalInput = "Vertical";

	public HorseMovement horseMovement;

	public KinematicCharacterMotor motor;

	public LayerMask groundOrientationLayerMask;

	public Transform groundOrientationRaycastPositionFront;

	public Transform groundOrientationRaycastPositionMid;

	public Transform groundOrientationRaycastPositionBack;

	public AudioSource footstepAudioSource;

	private bool isGrounded;

	private Collider currentGroundCollider;

	public Transform horseVisualTransform;

	private Coroutine ChainAttackCoroutine;

	private HealthBase lastHitTarget;

	private float lastHitTargetTime;

	private float navmeshCheckTimer;

	public AITarget horseAttackTarget;

	private bool isAttackRunning;

	private float attackRunStartedTime;

	private float attackRunDuration;

	public Vector3 attackRunTarget;

	private float targetXRotationToApply;

	private float horseDestinationChangeSetTimer;

	private float horseDestinationChangeToStandingSetTimer;

	private bool horseWaitToChangeDestination;

	private float agentSpeedTarget;

	private float agentRotationSpeed;

	private float agentRotationSpeedTarget;

	public static readonly float speedTrotForwards;

	public static readonly float speedTrotBackwards;

	public static readonly float speedGallop;

	public static readonly float speedSprint;

	public bool isSwimming;

	public bool movementStopped;

	private Coroutine stopMovementCoroutine;

	public float overrideMovementSpeed;

	public float overrideRotationSpeed;

	public override bool OnPlayerEnterVehicle(int seat)
	{
		return false;
	}

	public override void OnPlayerExitVehicle(int seat, bool ragdoll)
	{
	}

	public override void OnBotEnterVehicle(int seat)
	{
	}

	public override void OnBotExitVehicle(int seat)
	{
	}

	public override void OnSpawnAndRespawn(Vector3 spawnPos, Quaternion spawnRot)
	{
	}

	public override void OnDestroyed()
	{
	}

	public override void OnStartRagdoll()
	{
	}

	public override void OnStopRagdoll()
	{
	}

	public override void OnTakeDamage(float damage, DamageTypes damageType, Vector3 hitPoint)
	{
	}

	public override void OnCollisionTriggerEnter(Collider other, Vector3 forceOrigin)
	{
	}

	public override void OnBotAttackTriggerEnter(Collider other, Vector3 forceOrigin)
	{
	}

	public override AITarget BotFindNewTarget(AITarget bot)
	{
		return null;
	}

	public override Vector3 GetEnterPos(Vector3 currentPos)
	{
		return default(Vector3);
	}

	public override Vector3 GetExitPos(int seat)
	{
		return default(Vector3);
	}

	public override Vector3 GetCurrentVelocity()
	{
		return default(Vector3);
	}

	public void ResetStates()
	{
	}

	public override void StartExtended()
	{
	}

	public void BotFindTarget()
	{
	}

	private void Update()
	{
	}

	public bool RotatedToGroundTarget()
	{
		return false;
	}

	public void PlayerChargeEmote()
	{
	}

	public bool CanAttackCheck(AITarget bot)
	{
		return false;
	}

	public void Attack(bool left)
	{
	}

	public void HorseApproachDestination()
	{
	}

	public void HorseRunAway()
	{
	}

	public void HorseWaitToChangeDestination(float minWait, float maxWait)
	{
	}

	public void Bot_FindTarget()
	{
	}

	public void Bot_Attack(AITarget bot, bool left, bool attack)
	{
	}

	public IEnumerator ChainAttack()
	{
		return null;
	}

	public override void PlayDriverAnim(int anim, bool allPasssengers)
	{
	}

	private void Sprint(Vector3 movement)
	{
	}

	public void SetNavmeshSpeed(bool botControlled)
	{
	}

	public void StopMovementForDuration(float duration, float movementSpeed, float rotationSpeed)
	{
	}

	private IEnumerator StopMovement(float duration)
	{
		return null;
	}

	public void SetCurrentControlState(bool controlled, bool useNavmesh)
	{
	}

	public void PlayFootstepAudio(int speedLevel)
	{
	}
}
