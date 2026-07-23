using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class VehicleBase : MonoBehaviour
{
	public float respawnDuration;

	public WaitForSeconds WaitForVehicleRespawnTimer;

	public VehicleNames vehicleName;

	public string customVehicleName;

	public VehicleHealth health;

	public AITarget vehicleTarget;

	public Transform camTarget;

	public bool controlledByPlayer;

	public bool controlledByBot;

	public VehicleSeat[] seats;

	public AITarget[] seatsReserved;

	public bool[] seatsOccupied;

	public int freeSeat;

	public VehicleBehaviorTypes vehicleType;

	public bool canChaseTargets;

	public bool loyalVehicle;

	public PlayerReserved playerReserved;

	public bool onlyUseableByBotsWithMeleeWeapon;

	public bool emptyVehicle;

	public Transform _transform;

	public float enterDistance;

	public float enterDistanceSquared;

	public int awarenessDistance;

	public NavMeshAgent agent;

	public Vector3 currentMovementDestination;

	public int destinationUpdateFrequency;

	public int destinationUpdateFrequencyTimer;

	public NavMeshObstacle obstacle;

	public Collider triggerCollider;

	public WeaponCrosshair crosshair;

	public bool hasCharacterControllerCollider;

	public Collider characterControllerCollider;

	public bool findTargetOverride;

	public List<VehicleCollisionTrigger> vehicleCollisionTriggers;

	public bool anySeatReserved;

	public abstract void StartExtended();

	public abstract bool OnPlayerEnterVehicle(int seat);

	public abstract void OnPlayerExitVehicle(int seat, bool ragdoll);

	public abstract void OnBotEnterVehicle(int seat);

	public abstract void OnBotExitVehicle(int seat);

	public abstract void OnSpawnAndRespawn(Vector3 spawnPos, Quaternion spawnRot);

	public abstract void OnDestroyed();

	public abstract void OnStartRagdoll();

	public abstract void OnStopRagdoll();

	public abstract void OnTakeDamage(float damage, DamageTypes damageType, Vector3 hitPoint);

	public abstract void OnCollisionTriggerEnter(Collider other, Vector3 forceOrigin);

	public abstract void OnBotAttackTriggerEnter(Collider other, Vector3 forceOrigin);

	public abstract AITarget BotFindNewTarget(AITarget bot);

	public abstract Vector3 GetEnterPos(Vector3 currentPos);

	public abstract Vector3 GetExitPos(int seat);

	public abstract Vector3 GetCurrentVelocity();

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public bool EnterVehicle(AITarget bot)
	{
		return false;
	}

	public void BotExitVehicle(AITarget bot)
	{
	}

	public void DestinationReached()
	{
	}

	public void EveryoneExit()
	{
	}

	public void VehicleDestroyed(Vector3 currentMovementForce, AITarget destroyer, Vector3 force)
	{
	}

	public void OnVehicleDestroyed()
	{
	}

	private void SetFreeVehicleSeat()
	{
	}

	public int ReserveVehicleSeat(AITarget bot)
	{
		return 0;
	}

	public float CalculatePath(Vector3 pos)
	{
		return 0f;
	}

	public Vector3 GetExitSpawnPoint(AITarget bot)
	{
		return default(Vector3);
	}

	public virtual void PlayDriverAnim(int anim, bool allPasssengers)
	{
	}

	public float GetThirdPersonCameraAngleToCurrentSeat()
	{
		return 0f;
	}

	public Vector3 GetThirdPersonCameraDirectionHorizontally()
	{
		return default(Vector3);
	}

	public string GetVehicleName()
	{
		return null;
	}

	public void SetDestination(Vector3 destination, int updateFrequency)
	{
	}

	public void SetDestinationImmediately(Vector3 destination, int updateFrequency)
	{
	}

	public void UpdateVehicleCollisionTriggers()
	{
	}
}
