using UnityEngine;

public class MouseLookThirdPerson : MonoBehaviour
{
	public bool inverted;

	public Transform cameraTargetTransform;

	public Transform cameraParentTransform;

	public Transform cameraAdditionalMovementTransform;

	public Transform cameraTransform;

	public Camera thirdPersonCamera;

	public int defaultFOV;

	public int aimingFOV;

	public bool clampHorizontal;

	public int clampInDegreesHorizontalHalf;

	public bool clampVerticalWithTarget;

	public bool clampVerticalWithoutTarget;

	public int clampInDegreesVerticalLookUp;

	public int clampInDegreesVerticalLookDown;

	public bool cameraLocked;

	public Vector3 _localRotation;

	public Transform camPosTarget;

	public Vector3 targetCameraStartSmoothingDistance;

	public Vector3 targetCameraDistance;

	public Vector3 aimingCameraDistance;

	public LayerMask cameraBlockLayerMask;

	private bool camSmoothTransition;

	private Vector3 camSmoothTransitionStartPosition;

	private Quaternion camSmoothTransitionStartRotation;

	private float camSmoothTransitionTimer;

	private float camSmoothTransitionDuration;

	public Vector3 lastFramePos;

	public Vector3 lastFrameForwardDirection;

	private void LateUpdate()
	{
	}

	private void UpdateCameraFreeRotation()
	{
	}

	public void ChangeTarget(Transform target)
	{
	}

	public void ChangeTarget(Transform target, Vector3 smoothTransitionStartPosition, Quaternion smoothTransitionStartRotation, float smoothTransitionDuration = 0f)
	{
	}

	public void SetCameraDistance(bool instantly, float distance, float startingDistance)
	{
	}

	public void SetRotation(Vector3 newRotation)
	{
	}
}
