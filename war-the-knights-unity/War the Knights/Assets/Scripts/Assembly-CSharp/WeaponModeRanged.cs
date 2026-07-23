using UnityEngine;

public class WeaponModeRanged : WeaponMode
{
	public WeaponModeThrownMainWeapon projectileMode;

	public Gun gun;

	private void Awake()
	{
	}

	private void Start()
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
