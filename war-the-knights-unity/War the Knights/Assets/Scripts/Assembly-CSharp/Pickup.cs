using UnityEngine;

public class Pickup : MonoBehaviour
{
	public PickupType type;

	public LayerMask groundDetectLayerMask;

	public int amount;

	private void Start()
	{
	}

	public void PickupItem()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
