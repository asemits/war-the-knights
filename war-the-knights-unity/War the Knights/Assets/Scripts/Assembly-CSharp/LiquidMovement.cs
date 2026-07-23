using UnityEngine;

public class LiquidMovement : MonoBehaviour
{
	public Renderer liquidRenderer;

	public Transform _transform;

	public int liquidMaterialIndex;

	public Material liquidMaterial;

	public float maxShake;

	public float shakeSpeed;

	public float recoverySpeed;

	private Vector3 lastPosition;

	private Vector3 velocity;

	private Vector3 lastRotation;

	private Vector3 angularVelocity;

	private float shakeAmountToAddX;

	private float shakeAmountToAddZ;

	private float pulse;

	private float timer;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
