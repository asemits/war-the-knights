using KinematicCharacterController;
using UnityEngine;

public class Platform : BaseMoverController
{
	private Transform _transform;

	public Rigidbody shipDeckRigidbody;

	private void Start()
	{
	}

	public override void UpdateMovement(out Vector3 goalPosition, out Quaternion goalRotation, float deltaTime)
	{
		goalPosition = default(Vector3);
		goalRotation = default(Quaternion);
	}
}
