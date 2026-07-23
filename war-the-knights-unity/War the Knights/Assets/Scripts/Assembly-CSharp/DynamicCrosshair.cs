using UnityEngine;

public class DynamicCrosshair : MonoBehaviour
{
	public float spreadTarget;

	public float spread;

	public float spreadPerSecond;

	public Transform[] crosshairParts;

	public RectTransform[] crosshairPartsSize;

	public int[] crosshairPartsBaseSize;

	public CanvasGroup[] crosshairPartsAlpha;

	public AnimationCurve[] crosshairPartsAlphaChange;

	public int alphaCurveStart;

	public CanvasGroup canvas;

	private void Update()
	{
	}

	private void UpdateCrosshair()
	{
	}
}
