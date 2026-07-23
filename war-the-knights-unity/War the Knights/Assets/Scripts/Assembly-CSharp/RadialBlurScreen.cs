using UnityEngine;

public class RadialBlurScreen : MonoBehaviour
{
	public Shader rbShader;

	public float samples;

	public float effectAmount;

	public float radius;

	private Material rbMaterial;

	private Material GetMaterial()
	{
		return null;
	}

	private void OnRenderImage(RenderTexture source, RenderTexture dest)
	{
	}
}
