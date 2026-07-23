using UnityEngine;

public class WeaponMelee : WeaponEquippable
{
	public MeleeWeaponCategories category;

	public MeleeWeaponAnimationSet animation;

	public MeleeAnimation meleeAnimation;

	public bool canBackstab;

	public float backstabDamageMultiplier;

	public float backstabPoiseDamageMultiplier;

	public float heavyAttackDamage;

	public float heavyAttackPoiseDamage;

	public WeaponRangeLevels rangeLevel;

	public float bladeBroadness;

	public float bladeThickness;

	public Vector3 bladeForwardDirection;

	public Vector3 bladeUpDirection;

	public bool extendIntoTwoDirections;

	public override WeaponEquippableTypes GetEquippableType => WeaponEquippableTypes.Melee;

	public override RuntimeAnimatorController GetAnimatorController(bool thirdPerson)
	{
		return null;
	}

	public MeleeWeaponCameraMovement GetCameraMovement(int index)
	{
		return null;
	}
}
