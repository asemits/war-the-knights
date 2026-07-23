using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	public class WaterPlanarReflection : MonoBehaviour
	{
		public Water water;

		public LayerMask reflectionMask;

		public Color clearColor;

		public string reflectionSampler;

		public float clipPlaneOffset;

		private Vector3 m_Oldpos;

		private Camera m_ReflectionCamera;

		private Material sharedMaterial;

		private Dictionary<Camera, bool> m_HelperCameras;

		private Vector4 clippingPlane;

		private Vector4 plane;

		private void Start()
		{
		}

		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		public void RenderHelpCameras(Camera currentCam)
		{
		}

		public void LateUpdate()
		{
		}

		public void WaterTileBeingRendered(Camera currentCam)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}
	}
}
