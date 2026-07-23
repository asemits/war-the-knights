using UnityEngine;

public class AITarget : MonoBehaviour
{
	public string aiTargetName;

	public bool alive;

	public AITarget currentTarget;

	public AIAttackable attackable;

	public AttackBehavior currentAttackBehavior;

	public bool currentAttackBehaviorIsAttack;

	public CombatBehavior combatBehavior;

	public bool vehicleAttackable;

	public bool isPlayer;

	public ActiveRagdoll ragdoll;

	public PlayerHealth playerHealth;

	public AIBehaviorBase behaviorBase;

	public AIBehaviorBot behaviorBot;

	public BotHealth botHealth;

	public HealthBase healthBase;

	public bool isVehicle;

	public VehicleHealth vehicleHealth;

	public AIAlliance alliance;

	public CapsuleCollider baseCollider;

	public Transform _transform;

	public Transform botAttackPointL1;

	public Transform botAttackPointL2;

	public Transform botAttackPointR1;

	public Transform botAttackPointR2;

	public bool hasAttackPoints;

	public float botAttackPointL1XPos;

	public float botAttackPointL2XPos;

	public float botAttackPointR1XPos;

	public float botAttackPointR2XPos;

	public float botAttackPointLXPosSideThreshold;

	public float botAttackPointRXPosSideThreshold;

	public float botAttackPointLXPosBackSideThreshold;

	public float botAttackPointRXPosBackSideThreshold;

	public TwoTransforms helmetParent;

	public CustomHelmet helmetPrefab;

	public TwoGameObjects helmet;

	public TwoGameObjects hair;

	public TwoTransforms quiverParent;

	public TwoTransforms boltQuiverParent;

	public TwoGameObjects classAccessoire;

	public CapturePoint currentObjectivePoint;

	public Vector3 capturePointDestination;

	public bool attackPoint;

	public VehicleBase currentVehicle;

	public BotToVehicleBehavior vehicleBehavior;

	public bool isUsingVehicle;

	public int vehicleSeatIndex;

	public VehicleSeat vehicleSeat;

	public ScoreboardData scoreboardData;

	public Vector3 cachedPosition;

	public Quaternion cachedRotation;

	public Vector2 cachedForward;

	public bool forwardCached;

	public bool cachedBestTarget;

	public AITarget bestPossibleTarget;

	public float bestPossibleTargetVisibilityScore;

	public AttackBehavior bestPossibleAttackBehavior;

	public bool cachedAbleToFindNewTarget;

	private void Start()
	{
	}

	public void ScoreAddKill()
	{
	}

	public void ScoreAddDeath()
	{
	}

	public void ScoreAddObjectivePlay(int objectivePoints)
	{
	}

	public void ScoreAddSupport(int supportPoints)
	{
	}

	public void AddScore(int score)
	{
	}

	public void ChangeAttackBehavior(AttackBehavior newBehavior)
	{
	}

	public void OnSpawn()
	{
	}

	public void OnDefeat()
	{
	}

	public Vector3 GetCurrentSpeed()
	{
		return default(Vector3);
	}

	public Vector3 GetCurrentSpeedToAddToProjectile()
	{
		return default(Vector3);
	}

	public void AssignTarget(AITarget target, bool behaviorImportanceCanBeEqualToCurrent = false)
	{
	}

	public void ForceAssignTargetAsAttackTarget(AITarget target)
	{
	}

	public void SetTarget(AITarget aiTarget)
	{
	}

	public void FindNewTarget()
	{
	}

	public void FindNewTargetAfterOldTargetDefeated()
	{
	}

	public void ChangeCurrentTargetAttackBehavior(AttackBehavior newBehavior)
	{
	}

	public void SetLook(CustomHelmet helmetPrefab, GameObject hairPrefab)
	{
	}

	public void UpdateClassAccessoires(CombatBehavior combatBehavior)
	{
	}

	public void LoseHelmet(Vector3 position, Vector3 force)
	{
	}

	public void RemoveFromVehicle(bool ragdoll = false)
	{
	}

	public void EnterVehicle()
	{
	}

	public void StopReservingVehicleSeat(VehicleBase vehicleTarget)
	{
	}

	public void ReconsiderCurrentVehicleOnObjectiveChange()
	{
	}

	public void ReserveVehicleSlot(VehicleBase vehicleToCheck)
	{
	}
}
