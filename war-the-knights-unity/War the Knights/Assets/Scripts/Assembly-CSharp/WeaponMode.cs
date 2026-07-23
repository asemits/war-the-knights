using UnityEngine;

public abstract class WeaponMode : MonoBehaviour
{
	public WeaponModes currentMode;

	public WeaponBlockEffectPhysicsMaterial weaponPhysicsMaterial;

	public Collider[] colliders;

	public bool initialized;

	public Rigidbody rb;

	public abstract void Initialize();

	public abstract void SetModeToPlayer();

	public abstract void SetModeToBot(AIBehaviorBot bot);

	public abstract void SetModeToVisualsOnly();

	public abstract void SetModeToRagdoll(AIBehaviorBase bot);

	public abstract void SetModeToThrowable();

	public abstract void SetModeToPickup();

	public void SetTeamColors(bool playerTeam)
	{
	}
}
