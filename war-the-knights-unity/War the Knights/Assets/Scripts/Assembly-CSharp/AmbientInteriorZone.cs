using UnityEngine;

public class AmbientInteriorZone : MonoBehaviour
{
	public Collider interiorZone;

	private bool isMeshCollider;

	public bool dontOptimize;

	public bool noWeatherEffectsInsideInteriorZone;

	public bool changeAmbientSoundVolumeInsideInteriorZone;

	public float ambientSoundVolumePercentage;

	public bool overrideAmbientSound;

	public AmbientSound ambientSound;

	public AudioClip customAmbientSoundClip;

	public float customAmbientSoundVolume;

	private bool notInitialized;

	private void Start()
	{
	}

	private void Reset()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void AddZoneToActiveZones()
	{
	}

	public void RemoveZoneFromActiveZones()
	{
	}

	public void RemoveZoneFromActiveZonesParticle()
	{
	}

	public bool ParticleSystemContainsZone(ParticleSystem.TriggerModule triggerModule)
	{
		return false;
	}

	public bool CheckPointInZone(Vector3 position)
	{
		return false;
	}
}
