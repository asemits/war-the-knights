using UnityEngine;

public class InteractablePhysicsPickup : Interactable
{
	public PhysicsPickupType physicsPickupType;

	public float collisionMaxRadius;

	public Rigidbody rb;

	public Collider[] colliders;

	public bool useGravity;

	public int physicsLayer;

	private void Start()
	{
	}

	public override InteractionTip GetInteractionTip()
	{
		return null;
	}

	public override void Interact()
	{
	}

	private void SetCollisionRadius()
	{
	}
}
