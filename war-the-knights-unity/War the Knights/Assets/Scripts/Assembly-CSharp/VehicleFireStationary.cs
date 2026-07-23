using UnityEngine;

public class VehicleFireStationary : VehicleBase
{
	public Transform enterPos;

	public bool instantAimZoom;

	public CrosshairShowType crosshairShowType;

	public bool hasRecoil;

	public RecoilProfile recoilProfile;

	public bool hasAnimRecoil;

	public RecoilTypes animRecoilType;

	public bool hasCameraShake;

	public CameraShakeType cameraShakeType;

	public AudioSource audioSource;

	public WeaponRangedAttackSounds attackSound;

	public AudioClip customAttackSound;

	public WeaponReloadSounds reloadSound;

	public AudioClip customReloadSound;

	public Animator anim;

	public Transform rotateY;

	public Vector3 rotateYLocalRotationAngle;

	private Vector3 rotateYDefaultRotation;

	public Transform rotateX;

	public Vector3 rotateXLocalRotationAngle;

	private Vector3 rotateXDefaultRotation;

	public Transform projectileSpawn;

	private GameObject spawnedProjectile;

	public GameObject projectilePrefab;

	public GameObject visualProjectilePrefab;

	public bool rotateVisualProjectileRandomlyOnZAxis;

	public float damage;

	public float poiseDamage;

	public float projectileForce;

	public float fireRateMin;

	public float fireRateMax;

	private float fireRateTimer;

	private bool isReloaded;

	private Vector3 target;

	private Vector4 rotationVelocityX;

	private Vector4 rotationVelocityY;

	public override void StartExtended()
	{
	}

	private void SetSounds()
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

	public void Shoot(bool player)
	{
	}

	public void ReloadEvent()
	{
	}

	public void ShowProjectileEvent()
	{
	}
}
