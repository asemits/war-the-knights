using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBehaviorBot : AIBehaviorBase
{
	private sealed class _003CChangeLookAtTargetForDuration_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AIBehaviorBot _003C_003E4__this;

		public float duration;

		public AIAttackable target;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CChangeLookAtTargetForDuration_003Ed__91(int _003C_003E1__state)
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

	private sealed class _003CEmoteAfterTime_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AIBehaviorBot _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CEmoteAfterTime_003Ed__98(int _003C_003E1__state)
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

	private sealed class _003CNavLinkLadderClimb_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AIBehaviorBot _003C_003E4__this;

		private Ladder _003Cladder_003E5__2;

		private Transform _003CladderStartPos_003E5__3;

		private Transform _003CladderEndPos_003E5__4;

		private Vector3 _003ClinkEndPos_003E5__5;

		private Vector3 _003ClinkStartPos_003E5__6;

		private Quaternion _003CtargetRotation_003E5__7;

		private bool _003CclimbingUp2_003E5__8;

		private Vector3 _003ColdPos_003E5__9;

		private Quaternion _003ColdRot_003E5__10;

		private Vector3 _003ColdAnimRotation_003E5__11;

		private Vector3 _003CtargetLadderRotation_003E5__12;

		private float _003CnormalizedTime3_003E5__13;

		private bool _003Cfalling_003E5__14;

		private bool _003CplayedFallAnim_003E5__15;

		private bool _003CleftAnim_003E5__16;

		private float _003CleaveDuration_003E5__17;

		private Quaternion _003CendLadderRotation_003E5__18;

		private Quaternion _003CstartLadderRotation_003E5__19;

		private float _003CbuildProgressTime2_003E5__20;

		private float _003CanimTime_003E5__21;

		private float _003CtimeToFallOff_003E5__22;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CNavLinkLadderClimb_003Ed__92(int _003C_003E1__state)
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

	private sealed class _003CWaitForTargetVisibility_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AIBehaviorBot _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForTargetVisibility_003Ed__93(int _003C_003E1__state)
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

	public NavMeshAgent agent;

	public WeaponBase currentWeaponBase;

	public Melee equippedWeaponMelee;

	public Gun equippedWeaponRanged;

	public WeaponEquippable currentWeapon;

	public CharacterClasses currentClass;

	public WeaponMelee primaryWeapon;

	public bool meleeThrownAway;

	public WeaponGun secondaryWeapon;

	public WeaponThrowable throwableWeapon;

	public WeaponShield shield;

	public bool shieldThrownAway;

	public PlaceableBase placedGadget;

	public int viewDistance;

	public int viewDistanceSquared;

	public int projectileForce;

	public float chaseDistanceMinSquared;

	public float chaseDistanceMaxSquared;

	public float fleeDistanceSquared;

	public float attackDistanceSquared;

	public float attackDistance;

	public float attackFrequency;

	public float attackFrequencyHeavy;

	public float attackFrequencyChargeMin;

	public float attackFrequencyChargeMax;

	public bool isCharging;

	public bool isBlocking;

	public bool hasShieldEquipped;

	public bool canInitializeEmote;

	private int avoidancePriority;

	public float distanceToTargetSquared;

	public float attackTimer;

	public float emoteInitializeTimer;

	public float movementUpdateTimer;

	public float howLongToWaitAfterVisibilityLossTime;

	public float forgetTime;

	public bool strafeRight;

	public bool strafeForward;

	public bool canSeeTarget;

	public bool canSeekTargetAfterTargetIsntVisibleAnymore;

	public Coroutine waitForTargetVisibilityCoroutine;

	private bool isUsingNavLink;

	private NavLinkPointMover navLink;

	public Coroutine navMeshLinkCoroutine;

	public bool changeMovementPointWait;

	public float changeMovementPointTimer;

	public bool isSwimming;

	private Vector3 relativeMoveDirection;

	public Vector3 lookAtPoint;

	public int currentAmmo;

	public bool outOfAmmo;

	private int visibilityCheckPausedForFrames;

	public float horizontalLookAngleCurrent;

	public float verticalLookAngleCurrent;

	private float currentHorizontalLookAtVelocity;

	private float currentVerticalLookAtVelocity;

	private static readonly float headOffsetVector;

	private static readonly Quaternion hipMovementAnimationRotationOffset;

	private BotMovementStates _currentMovementState;

	public Vector3 currentMovementDestination;

	private float destinationUpdateFrequency;

	public float destinationUpdateFrequencyTimer;

	private bool fleeing;

	private bool changedLookAtTarget;

	private Vector3 changedLookAtTargetPosition;

	private Coroutine changeLookAtTargetCoroutine;

	private float footstepTimer;

	private static readonly Vector3 footstepCheckDirection;

	private static readonly Vector3 ladderLookAtTargetOffset;

	private WaitForSeconds WaitForTargetVisibilityTimer;

	private WaitForSeconds WaitTilTargetForgottenTimer;

	private Coroutine EmoteCoroutine;

	public bool stunned;

	public float stunTimer;

	public bool knockback;

	private bool knockbackWhenStanding;

	private float knockbackDuration;

	public float knockbackDurationTimer;

	private Vector3 knockbackDirection;

	private Vector3 knockbackDirectionCurrent;

	private float knockbackDesiredVelocityStartingMagnitude;

	public BotMovementStates CurrentMovementState
	{
		get
		{
			return BotMovementStates.VerySlow;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void UpdateBehavior()
	{
	}

	public void UpdateInSpawnFormationOnly()
	{
	}

	public void SetDestination(Vector3 destination, float updateFrequency)
	{
	}

	public void SetDestinationImmediately(Vector3 destination, float updateFrequency)
	{
	}

	private void SetFleeDestination(Vector3 destination)
	{
	}

	public void ChangeLookAtTarget(AIAttackable target, float duration)
	{
	}

	private IEnumerator ChangeLookAtTargetForDuration(AIAttackable target, float duration)
	{
		return null;
	}

	private IEnumerator NavLinkLadderClimb()
	{
		return null;
	}

	private IEnumerator WaitForTargetVisibility()
	{
		return null;
	}

	public void OnChangeTarget()
	{
	}

	public void SetAttackTimer(float timer)
	{
	}

	public void EmoteInitialize()
	{
	}

	public bool Emote(bool instantly)
	{
		return false;
	}

	private IEnumerator EmoteAfterTime()
	{
		return null;
	}

	public void GetStunned(float duration)
	{
	}

	public void AddKnockback(Vector3 direction)
	{
	}

	public void GetAttackStunned()
	{
	}

	public void Reload()
	{
	}

	public void StopBlocking(bool playSound = false)
	{
	}

	private void Attack()
	{
	}

	public void StartAttacking()
	{
	}

	public void StopAttacking()
	{
	}

	public void StartAttackingMeleeVehicle()
	{
	}

	public void BlockBash()
	{
	}

	public bool StartKick()
	{
		return false;
	}

	public void Kick()
	{
	}

	public bool CheckCanDoRangedAttack()
	{
		return false;
	}

	public void RangedAttack()
	{
	}

	public void Flee(float distanceSquared)
	{
	}

	public void SetBehaviorStats(CombatBehaviorConfig stats)
	{
	}

	public void SpawnThirdPersonWeaponBot()
	{
	}

	public void DropWeaponsBot(Vector3 force, Vector3 position)
	{
	}

	public int RefillAmmo(float ratio)
	{
		return 0;
	}

	public void EnterWater()
	{
	}

	public void LeaveWater()
	{
	}

	public void UpdateSpeed()
	{
	}

	public void StopNavMeshLinkCoroutine()
	{
	}

	public void FindNewPointOnObjective()
	{
	}

	public void UpdateObjectivePoint(CapturePoint capturePoint, bool attack)
	{
	}

	public void FindPointOnObjective()
	{
	}
}
