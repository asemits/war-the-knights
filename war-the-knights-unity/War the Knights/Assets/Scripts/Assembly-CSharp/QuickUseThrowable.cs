using UnityEngine;

public class QuickUseThrowable : UsableItem
{
	public float damage;

	public float poiseDamage;

	public DamageTypes damageType;

	public float throwingForce;

	public Vector3 throwingTorqueForce;

	public bool throwablePlaceable;

	public Transform spawn;

	public MeshRenderer[] hideMeshAfterThrow;

	public ParticleSystem[] stopParticlesAfterThrow;

	public GameObject[] disableGameobjectsAfterThrow;

	public ParticleSystem[] particleSystemsToUnparentOnImpact;

	public bool hasAnimRecoil;

	public RecoilTypes animRecoilType;

	public bool hasCameraShake;

	public CameraShakeType cameraShakeType;

	public GameObject throwablePrefab;

	public WeaponThrowableEquipSound weaponThrowableEquipSound;

	public AudioClip customWeaponThrowableEquipSound;

	public WeaponThrowableThrowSound weaponThrowableThrowSound;

	public AudioClip customWeaponThrowableThrowSound;

	public bool fixBigObjectCollision;

	public override void PlayerStart()
	{
	}

	public override void BotStart()
	{
	}

	private void SetSounds()
	{
	}

	public override void BotAttack()
	{
	}

	public override void BotCancelAttack()
	{
	}

	public override void QuickUseItem()
	{
	}

	public void Throw()
	{
	}

	public override void ConsumeAmmo()
	{
	}

	public override void StopUsingItem()
	{
	}

	public override void BlockHit(bool heavy)
	{
	}

	public override void Kick()
	{
	}
}
