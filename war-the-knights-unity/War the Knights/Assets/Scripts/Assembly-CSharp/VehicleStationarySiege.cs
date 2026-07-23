using UnityEngine;

public class VehicleStationarySiege : VehicleBase
{
	public Transform enterPos;

	public Animator anim;

	public Transform rotateY;

	public Transform rotateX;

	public Transform projectileSpawn;

	public GameObject projectilePrefab;

	public GameObject visualProjectilePrefab;

	public int damage;

	public float fireRateMin;

	public float fireRateMax;

	public float fireRateTimer;

	public Vector3 pointToAttack;

	public Vector3 flyDirection;

	public bool isReloaded;

	private GameObject visualProjectile;

	public AITarget botThatShot;

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

	public override void StartExtended()
	{
	}

	private void Update()
	{
	}

	private void SetNewAttackPoint()
	{
	}

	private void Shoot(bool player)
	{
	}

	public void ShootEvent()
	{
	}

	public void ReloadEvent()
	{
	}
}
