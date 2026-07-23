using System;
using UnityEngine;

[Serializable]
public class RecoilProfile
{
	public AnimationCurve recoilCurve;

	public float recoilDuration;

	public float recoilStrength;

	public float recoilRestoreSpeed;

	public Vector2 recoilRatio;

	public float maxRecoil;

	public float recoilZRotationIntensity;
}
