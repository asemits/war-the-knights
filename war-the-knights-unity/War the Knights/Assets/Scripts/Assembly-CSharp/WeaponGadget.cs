using UnityEngine;

public class WeaponGadget : Weapon
{
	public GameObject visualPrefab;

	public RuntimeAnimatorController animation;

	public ThirdPersonGadgetAnimations thirdPersonAnimation;

	public GadgetCategories category;

	public SpecialAmmoTypes specialAmmoType;

	public WeaponGun weaponGun;

	public bool limitedToOnePlacedAtOnce;

	public WeaponGadgetPlaceSound gadgetPlaceSound;

	public int ammo;

	public float rechargeDuration;

	public override RuntimeAnimatorController GetAnimatorController(bool thirdPerson)
	{
		return null;
	}
}
