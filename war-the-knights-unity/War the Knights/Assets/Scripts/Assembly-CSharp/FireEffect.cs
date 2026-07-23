using System;
using UnityEngine;

[Serializable]
public class FireEffect
{
	public bool isActive;

	public Vector3 position;

	public Vector3 damagePosition;

	public float finishTime;

	public AITarget damageSource;

	public TeamStatus team;

	public Coroutine fireAudioCoroutine;

	public AudioSource fireAudioSource;
}
