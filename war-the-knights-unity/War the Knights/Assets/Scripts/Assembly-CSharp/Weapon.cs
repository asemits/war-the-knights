using UnityEngine;

public abstract class Weapon : ScriptableObject
{
	public string weaponName;

	public string[] weaponDescription;

	public Sprite weaponIcon;

	public GameObject prefab;

	public bool rewardReceived;

	public bool spawnInLeftHand;

	public bool hidden;

	public abstract RuntimeAnimatorController GetAnimatorController(bool thirdPerson);
}
