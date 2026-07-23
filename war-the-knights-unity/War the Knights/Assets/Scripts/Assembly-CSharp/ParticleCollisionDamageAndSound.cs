using System.Collections.Generic;
using UnityEngine;

public class ParticleCollisionDamageAndSound : MonoBehaviour
{
	public ParticleSystem particleCollisionSystem;

	private List<ParticleCollisionEvent> collisionEvents;

	private RaycastHit hit;

	public float chanceToTriggerDamageOrSoundEffect;

	public bool dealDamage;

	public float damageRadius;

	public float damage;

	public float poiseDamage;

	public float fireDamage;

	public DestructibleMaterial materialParticleImpactSound;

	public AudioClip[] customImpactSound;

	private AudioClip[] impactSound;

	private int currentSoundIndex;

	private int currentSoundSize;

	private double nextValidImpactTime;

	private void Awake()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}
}
