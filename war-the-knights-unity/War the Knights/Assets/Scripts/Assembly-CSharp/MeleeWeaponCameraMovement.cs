using System;
using UnityEngine;

[Serializable]
public class MeleeWeaponCameraMovement
{
	public float durationFromStartToFinish;

	public float durationBeforeStart;

	public bool useBaseValue;

	public float durationAfterFinish;

	public float swingDirectionAngle;

	public Vector2 swingDirectionVector;
}
