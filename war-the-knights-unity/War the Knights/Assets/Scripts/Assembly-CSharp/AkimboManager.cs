using UnityEngine;

public class AkimboManager : MonoBehaviour
{
	public Gun leftWeapon;

	public Gun rightWeapon;

	public float fireRateTimerAkimbo;

	public Animator leftGunAnim;

	public void StartAkimbo(WeaponGun currentRevolver)
	{
	}

	public void Reload(bool dontChainReload = false)
	{
	}

	public bool CanReload()
	{
		return false;
	}

	public void SwitchAkimbo(bool leftGun, bool reverse = false)
	{
	}

	public void StopAkimbo(int newGun)
	{
	}

	public void StopStoppingAkimbo()
	{
	}
}
