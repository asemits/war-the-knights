using UnityEngine;

public class WeaponSway : MonoBehaviour
{
	public float xSwayAmount;

	public float ySwayAmount;

	public float xSwayMax;

	public float ySwayMax;

	public float swayFollowSpeed;

	private Vector3 newSwayPosition;

	private Vector3 swayCurrentVelocity;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
