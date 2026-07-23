using UnityEngine;

public class WeaponShield : WeaponEquippable
{
	public float blockAngle;

	public float blockMovementMultiplier;

	public float shieldBlockableDamage;

	public override WeaponEquippableTypes GetEquippableType => WeaponEquippableTypes.Melee;

	public override RuntimeAnimatorController GetAnimatorController(bool thirdPerson)
	{
		return null;
	}
}
