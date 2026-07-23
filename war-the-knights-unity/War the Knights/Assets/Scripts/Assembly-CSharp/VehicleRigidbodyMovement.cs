using UnityEngine;

public class VehicleRigidbodyMovement : MonoBehaviour
{
	public Rigidbody rb;

	public Animator vehicleAnim;

	public VehicleAttackHorse horseVehicle;

	public bool isSwimming;

	public Transform swimmingReferencePoint;

	public bool isGrounded;

	public Transform groundedCheckStart;

	public LayerMask groundLayerMask;

	public RaycastHit[] groundRaycastResults;

	private float leaveGroundTime;

	private bool jumpedThisFrame;

	public float speedLevel;

	private float speedLevelTarget;

	private float _targetForwardAxis;

	private float _targetRightAxis;

	public float TurnAxisSharpness;

	private float _rightAxis;

	public float currentSpeedMultiplier;

	private float highestPointDuringJump;

	private float lastYPos;

	private float _mustUngroundTimeCounter;

	public Vector3 _rootMotionPositionDelta;

	public Quaternion _rootMotionRotationDelta;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetInputs(Vector3 inputs)
	{
	}

	public void Jump()
	{
	}

	public void ForceUnground()
	{
	}

	public void LeaveWater(bool jump)
	{
	}

	public void EnterWater()
	{
	}

	public void UpdateRootMotionDelta(Vector3 deltaPos, Quaternion deltaRot)
	{
	}
}
