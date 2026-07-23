using UnityEngine;

public class MeleeRaycastCollision : MonoBehaviour
{
	public Melee melee;

	public AITarget bot;

	private Vector3[] raycastPointsLastFrame;

	private Vector3[] raycastPointsLastFixedUpdate;

	private int raycastPointCount;

	private static readonly float raycastPointSpacing;

	private float raycastFirstPointStartOffset;

	private bool firstFrame;

	private Vector3 localDirection;

	private float oneDirectionalWeaponLength;

	private Transform _transform;

	public void CreateRaycastValues()
	{
	}

	public void StartAttacking()
	{
	}

	public void StopAttacking()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}
}
