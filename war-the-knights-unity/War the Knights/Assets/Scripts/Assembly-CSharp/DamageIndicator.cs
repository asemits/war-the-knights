using UnityEngine;
using UnityEngine.UI;

public class DamageIndicator : MonoBehaviour
{
	public Vector3 damageRelative;

	public Vector3 localRotation;

	public Animator anim;

	public Image indicatorFill;

	public Transform _transform;

	public void UpdateIndicator()
	{
	}

	public void ShowIndicator(Vector3 origin, float damageRatio, bool blocked)
	{
	}
}
