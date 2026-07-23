using UnityEngine;

public abstract class Hitbox : MonoBehaviour
{
	public bool isCritical;

	public bool centralHealthHitbox;

	public VisualImpactEffects impactEffect;

	public abstract bool IsVehicleOrBot { get; }

	public abstract HitType GetHit(float damage, float poiseDamage, DamageTypes damageType, AITarget damageSource, Vector3 hitPoint, Vector3 hitDirection, bool ableToCrit, bool useDamageMultiplier, bool playImpactEffectAndSound, Vector3 hitNormal);

	public abstract void GetHitFireDamage(float fireDamage, AITarget damageSource);

	public abstract HealthBase Health();

	public abstract void AddAsChild(GameObject projectile);
}
