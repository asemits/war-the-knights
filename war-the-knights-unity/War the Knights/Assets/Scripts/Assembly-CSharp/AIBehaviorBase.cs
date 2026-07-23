using UnityEngine;

public class AIBehaviorBase : MonoBehaviour
{
	public AITarget bot;

	public Animator thirdPersonAnim;

	public bool isCrouched;

	public int aiIndex;

	public int aiIndexTeam;

	public AudioSource footstepAudioSource;

	public AudioSource weaponAudioSource;

	public AudioSource headAudioSource;

	public GameObject visualWeapon;

	public GameObject visualAmmo;

	public GameObject visualAmmoSpecial;

	public Transform projectileSpawn;

	public GameObject weaponProjectilePrefab;

	public GameObject weaponProjectileVisualPrefab;

	public GameObject weaponProjectileSpecialPrefab;

	public GameObject weaponProjectileSpecialVisualPrefab;

	public TwoTransforms rightHandSpawnPos;

	public TwoTransforms leftHandSpawnPos;

	public Transform rightProjectileVisualSpawnPos;

	public Transform leftProjectileVisualSpawnPos;

	public TwoGameObjects weaponObject;

	public GameObject weaponObjectDropped;

	public TwoGameObjects weaponObject2;

	public GameObject weaponObject2Dropped;

	public WeaponMode weaponMode;

	public WeaponMode weaponModeRagdoll;

	public WeaponModeMelee weaponModeMelee;

	public WeaponMode weaponMode2;

	public WeaponMode weaponMode2Ragdoll;

	public WeaponModeShield weaponMode2Shield;

	public bool thirdPersonMelee;

	public void SpawnThirdPersonWeaponPlayerOnVehicle(bool primary, bool enteringVehicle)
	{
	}

	public void SpawnThirdPersonWeaponPlayer(Weapon weaponEquipped, bool spawnRight)
	{
	}

	public void DestroyThirdPersonWeaponsPlayer()
	{
	}

	public void DropWeaponsPlayer(Vector3 force, Vector3 position)
	{
	}

	public void EnableThirdPersonWeapons()
	{
	}

	public void DisableThirdPersonWeapons()
	{
	}

	public void PlayThirdPersonFootstepAudio(AudioClip clip, float volumeScale = 1f)
	{
	}

	public void PlayThirdPersonWeaponAudio(AudioClip clip, float pitch = 1f, float volumeScale = 1f)
	{
	}

	public void PlayThirdPersonHeadAudio(AudioClip clip, float volumeScale = 1f)
	{
	}
}
