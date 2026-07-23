using UnityEngine;

public class HitboxVehicle : Hitbox
{
	public float damageMultiplier;

	public float poiseDamageMultiplier;

	public Rigidbody rb;

	public Transform transformRagdollOrAnimatedCounterpart;

	public bool isRagdollHitbox;

	public VehicleHealth health;

	public float meleeResistance;

	public float projectileResistance;

	public float fireResistance;

	public float explosionResistance;

	public float impactForceResistance;

	public float kickResistance;

	public override bool IsVehicleOrBot => false;

	public override HitType GetHit(float damage, float poiseDamage, DamageTypes damageType, AITarget damageSource, Vector3 hitPoint, Vector3 hitDirection, bool ableToCrit, bool useDamageMultiplier, bool playImpactEffectAndSound, Vector3 hitNormal)
	{
		return null;
	}

	public override void AddAsChild(GameObject projectile)
	{
	}

	public override HealthBase Health()
	{
		return null;
	}

	public override void GetHitFireDamage(float fireDamage, AITarget damageSource)
	{
	}
}
