using UnityEngine;

public class VehicleFlying : VehicleBase
{
	public Transform enterPosLeft;

	public Transform enterPosRight;

	public AudioSource rotorAudioSource;

	public Rigidbody rb;

	public bool isSprinting;

	public Vector3 targetVelocity;

	public Vector3 velocityToAdd;

	public Transform vehicleBodyTransform;

	public Vector3 flightDirectionRotation;

	public Vector3 flightDirectionForward;

	public Vector3 flightDirectionUp;

	public Quaternion flightDirectionRotationWorld;

	public Transform cameraTargetParent;

	private Quaternion targetMainRotation;

	public AnimationCurve rotationFollowCurve;

	public float maxFlightDirectionMagnitude;

	public float velocityChangeSpeed;

	public float velocityTarget;

	public float rotationSpeed;

	public float rotationSpeedTarget;

	public FlyingSpeedLevel currentSpeedLevel;

	public float cameraRotationSpeedMultiplier;

	public float cameraRotationSpeedMultiplierTarget;

	public bool rocketsActivated;

	public bool lockedOn;

	public float lockOnTimer;

	public Rigidbody lockedOnEnemy;

	public float rocketReloadTimer;

	public int rockets;

	public ParticleSystem fireBreathParticles;

	public AudioSource fireBreathAudioSource;

	public AudioClip fireBreathSound;

	public Transform fireBreathSpawn;

	public float fireBreathFirerate;

	public float fireBreathFirerateTimer;

	public Collider[] vehiclehelicopterColliders;

	public AITarget target;

	public override void StartExtended()
	{
	}

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

	private void Update()
	{
	}

	private void ResetStates()
	{
	}

	private void ControlsPlayer()
	{
	}

	public void ControlsBot()
	{
	}
}
