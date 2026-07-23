using UnityEngine;

public class WeaponModeShield : WeaponMode
{
	public WeaponModeThrownMainWeapon projectileMode;

	public WeaponMeleeEquipSound equipSound;

	public AudioClip customEquipSound;

	public WeaponMeleeUnequipSound unequipSound;

	public AudioClip customUnequipSound;

	public WeaponMeleeBlockBashSound blockBashSound;

	public AudioClip customBlockBashSound;

	public WeaponMeleeBlockBashHitSound blockBashHitSound;

	public AudioClip customBlockBashHitSound;

	public WeaponMeleeBlockHitSound blockHitSound;

	public AudioClip customBlockHitSound;

	public WeaponMeleeBlockBreakSound blockBreakSound;

	public AudioClip customBlockBreakSound;

	private void Awake()
	{
	}

	private void SetSounds()
	{
	}

	public override void Initialize()
	{
	}

	public override void SetModeToPlayer()
	{
	}

	public override void SetModeToBot(AIBehaviorBot bot)
	{
	}

	public override void SetModeToVisualsOnly()
	{
	}

	public override void SetModeToRagdoll(AIBehaviorBase bot)
	{
	}

	public override void SetModeToThrowable()
	{
	}

	public override void SetModeToPickup()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
