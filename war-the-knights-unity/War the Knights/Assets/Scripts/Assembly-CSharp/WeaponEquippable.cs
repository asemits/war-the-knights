using UnityEngine;

public abstract class WeaponEquippable : Weapon
{
	public float damage;

	public float poiseDamage;

	public DamageTypes damageType;

	public WeaponCrosshair crosshairType;

	public CameraEquipAnim cameraEquipAnim;

	public bool useCustomAnimset;

	public RuntimeAnimatorController customAnimset;

	public abstract WeaponEquippableTypes GetEquippableType { get; }
}
