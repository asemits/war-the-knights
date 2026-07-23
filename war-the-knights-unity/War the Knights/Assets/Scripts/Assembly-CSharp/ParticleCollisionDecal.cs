using System.Collections.Generic;
using UnityEngine;

public class ParticleCollisionDecal : MonoBehaviour
{
	public ParticleSystem particleSystemBlood;

	public bool playerTeam;

	private List<ParticleCollisionEvent> collisionEvents;

	private RaycastHit hit;

	private void OnParticleCollision(GameObject other)
	{
	}
}
