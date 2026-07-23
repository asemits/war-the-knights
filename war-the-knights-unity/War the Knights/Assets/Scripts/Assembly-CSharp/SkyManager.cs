using System.Collections.Generic;
using UnityEngine;

public class SkyManager : MonoBehaviour
{
	public static SkyManager Instance;

	public GameObject Clouds;

	public Transform _transform;

	public CloudsPreset cloudsPresetNoClouds;

	public CloudsPreset cloudsPresetClear;

	public CloudsPreset cloudsPresetSunny;

	public CloudsPreset cloudsPresetOvercast;

	public CloudsPreset cloudsPresetRainy;

	public CloudsPreset cloudsPresetStormy;

	public CloudsPreset cloudsPresetSnowy;

	public GameObject snowEffect;

	public ParticleSystem snowParticleEffect;

	public List<ParticleSystem> activeWeatherParticleEffects;

	public float Fogginess;

	public float AtmosphereBrightness;

	public float AtmosphereContrast;

	public Color SunRayColor;

	public Color SunSkyColor;

	public Color SunCloudColor;

	public Color FogColor;

	public Color AmbientColor;

	public ReflectionProbe Probe;

	public CloudsPreset currentCloudSetting;

	private static readonly float pi;

	public float AtmosphereDirectionality;

	public float AtmosphereRayleighMultiplier;

	public float AtmosphereMieMultiplier;

	public float CameraMovement;

	public Vector3 CloudUV;

	public Vector2 CloudUVWindDirection;

	public bool testUpdateValues;

	private Vector3 kBetaMie;

	private Vector4 kSun;

	private Vector4 k4PI;

	private Vector4 kRadius;

	private Vector4 kScale;

	public float Radius => 0f;

	public float Diameter => 0f;

	public void SetupShaderKeywords()
	{
	}

	public void SetSkySizeOnCameraChange(float farClipPlane, Vector3 position)
	{
	}

	public void SetupSky()
	{
	}

	public void SetupClouds(ref CloudsPreset cloudsPreset, bool updateCloudShader)
	{
	}

	private void LateUpdate()
	{
	}

	public void SetWindDirection(float degreesY)
	{
	}

	public void UpdateSun()
	{
	}

	public void UpdateStaticProperties()
	{
	}

	private void UpdateScattering()
	{
	}
}
