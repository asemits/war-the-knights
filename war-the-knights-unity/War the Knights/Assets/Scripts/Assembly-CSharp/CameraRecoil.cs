using UnityEngine;

public class CameraRecoil : MonoBehaviour
{
	public Transform firstPersonRecoilTransform;

	public Transform thirdPersonRecoilTransform;

	private RecoilProfile recoilProfile;

	private float currentRecoil;

	private float targetRecoil;

	private float lastRecoil;

	private float recoilTimer;

	private bool isAddingRecoil;

	private float currentRecoilIntensity;

	private Vector3 currentRotation;

	private Vector3 targetRotation;

	private Vector3 lastRotation;

	private Vector2 currentOffset;

	private Vector2 targetOffset;

	private Vector2 lastOffset;

	private Vector2 offsetTimer;

	private Vector2 offsetProgressSpeed;

	private void Awake()
	{
	}

	public void Update()
	{
	}

	public void SetRecoilProfile(RecoilProfile profile)
	{
	}

	private void RestoreRecoil()
	{
	}

	public void AddRecoil(float multiplier)
	{
	}

	public void SetRecoilIntensity(float intensity)
	{
	}

	private void UpdateTargetPos(int index)
	{
	}
}
