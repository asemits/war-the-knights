using UnityEngine;

public class CustomHelmet : ScriptableObject
{
	public string helmetName;

	public GameObject helmetPrefab;

	public bool canFallOff;

	public Rigidbody helmetPrefabPhysics;

	public bool madeOutOfMetal;
}
