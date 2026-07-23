using UnityEngine;

public class HitboxBotWeapon : Hitbox
{
	public HitboxBot hitboxHoldingTheWeapon;

	public BotHealth health;

	public bool isShield;

	private HitType hitType;

	public Transform transformRagdollOrAnimatedCounterpart;

	public bool isRagdollHitbox;

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
