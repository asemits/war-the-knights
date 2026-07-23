using UnityEngine;

public class WeaponGun : WeaponEquippable
{
	public RangedWeaponCategories category;

	public RangedWeaponAnimationSet animation;

	public AmmoType ammoType;

	public bool primaryWeapon;

	public bool reloadBulletsInsteadOfMagazine;

	public int ammoPerMagazine;

	public int magazines;

	public float minSpread;

	public float maxSpread;

	public float spreadAdd;

	public int movementSpread;

	public int spreadChangeSpeedMultiplier;

	public bool fireRateByAnimation;

	public float fireRate;

	public float fireRateAkimbo;

	public float accuracy;

	public float accuracyAkimbo;

	public float accuracyAiming;

	public int bulletAmount;

	public float impactForce;

	public float range;

	public AnimationCurve damageFalloff;

	public int AmmoTotal => 0;

	public override WeaponEquippableTypes GetEquippableType => WeaponEquippableTypes.Melee;

	public override RuntimeAnimatorController GetAnimatorController(bool thirdPerson)
	{
		return null;
	}
}
