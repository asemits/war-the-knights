using UnityEngine;

public abstract class UsableItem : WeaponBase
{
	public AudioClip[] playableSounds;

	public bool isGadget;

	public bool gadget1;

	public abstract void ConsumeAmmo();

	public abstract void StopUsingItem();

	public abstract void QuickUseItem();

	public void PlayItemSound(int sound)
	{
	}
}
