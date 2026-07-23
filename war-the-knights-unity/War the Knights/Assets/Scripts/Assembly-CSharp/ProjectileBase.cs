using UnityEngine;

public abstract class ProjectileBase : MonoBehaviour
{
	public bool collisionDisabled;

	public float damage;

	public float poiseDamage;

	public DamageTypes damageType;

	public bool overrideWeaponDamage;

	public float damageOverride;

	public bool overrideWeaponPoiseDamage;

	public float poiseDamageOverride;

	public bool overrideWeaponDamageType;

	public DamageTypes damageTypeOverride;

	public bool dealsFireDamage;

	public float fireDamage;

	public bool dealsSplashDamage;

	public SplashDamage splashDamage;

	public SpawnableEffects visualEffectToPlayOnImpact;

	public GameObject customEffectPrefabToSpawnOnImpact;

	public bool createsEnvironmentFlames;

	public bool scattersFlameDebris;

	public int flameDebrisCount;

	public float flameDebrisConeAngle;

	public bool scattersFlameLargeDebris;

	public int flameLargeDebrisCount;

	public float flameLargeDebrisConeAngle;

	public HealthBase healthSource;

	public HealthBase healthSourceVehicle;

	public Rigidbody rb;

	public AITarget damageSource;

	public bool playerFired;

	public bool vehicleFired;

	public Transform _transform;

	public static RaycastHit[] raycastHits;

	public FlyPastCameraSoundDistance flyBySoundDistance;

	public ProjectileFlyByCameraSounds flyBySound;

	private bool hasFlyBySound;

	private bool hasPlayedFlyBySound;

	private float flyByDistance;

	public AudioSource projectileAudioSource;

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	public void PlayImpactEffect(Vector3 position, Vector3 normal, PhysicsMaterial physicMaterial = null)
	{
	}

	public void DetectCameraFlybySound()
	{
	}
}
