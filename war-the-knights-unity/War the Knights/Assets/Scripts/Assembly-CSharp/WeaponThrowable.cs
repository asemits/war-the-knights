using UnityEngine;

public class WeaponThrowable : Weapon
{
	public ThrowableWeaponCategories category;

	public ThrowableWeaponAnimationSet animation;

	public RuntimeAnimatorController customAnimation;

	public bool infiniteAmmo;

	public int ammo;

	public float rechargeDuration;

	public bool limitedToOnePlacedAtOnce;

	public override RuntimeAnimatorController GetAnimatorController(bool thirdPerson)
	{
		return null;
	}
}
