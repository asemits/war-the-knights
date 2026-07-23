public class InteractableWeaponPickup : Interactable
{
	public WeaponEquippable weapon;

	public int ammo;

	public override InteractionTip GetInteractionTip()
	{
		return null;
	}

	public override void Interact()
	{
	}
}
