using UnityEngine;

public class WeaponModeThrownMainWeapon : ProjectileBase
{
	public float depth;

	public bool rotateAfterThrown;

	public bool stickToHitbox;

	public bool stickToWeakSurfaces;

	public bool retrieavable;

	private WeaponMode weaponMode;

	public Vector3 mainHitForwardDirection;

	public bool keepVelocityOnBounce;

	public bool keepHighQualityCollisionDetectionOnBounce;

	private bool wasProjectileBefore;

	public bool meleeHitEffectImpactAfterThrownIsSlash;

	public bool isShield;

	protected override void Awake()
	{
	}

	public void AwakeFromWeaponMode(WeaponMode weaponMode, Rigidbody rigidbody)
	{
	}

	private void FixedUpdate()
	{
	}

	public void EnableProjectile()
	{
	}

	public void EnablePickup()
	{
	}

	public void Hit(Collision collision)
	{
	}

	public bool StickToSurface(Collision collision)
	{
		return false;
	}
}
