using UnityEngine;

public class HitboxBreakable : Hitbox
{
	public HealthBreakable health;

	public Rigidbody rb;

	public bool takePhysicsCollisionDamage;

	public bool takePhysicsCollisionDamageAgainstProjectiles;

	public bool dealDamageOnCollision;

	public float collisionOutputDamageMultiplier;

	public float collisionOutputPoiseDamageMultiplier;

	public float collisionDamageTakenMultiplier;

	public bool spreadFireOnCollision;

	private float lastCollision;

	public override bool IsVehicleOrBot => false;

	public override HitType GetHit(float damage, float poiseDamage, DamageTypes damageType, AITarget damageSource, Vector3 hitPoint, Vector3 hitDirection, bool ableToCrit, bool useDamageMultiplier, bool playImpactEffectAndSound, Vector3 hitNormal)
	{
		return null;
	}

	public override HealthBase Health()
	{
		return null;
	}

	public override void AddAsChild(GameObject projectile)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public override void GetHitFireDamage(float fireDamage, AITarget damageSource)
	{
	}
}
