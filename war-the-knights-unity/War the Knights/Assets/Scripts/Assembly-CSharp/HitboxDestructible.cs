using UnityEngine;

public class HitboxDestructible : Hitbox
{
	public HealthDestructible health;

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
