using System;
using UnityEngine;

[Serializable]
public class ParticleSystemEffect
{
	public ParticleSystem particleSystem;

	public bool noRandomCount;

	public short minParticles;

	public short maxParticles;

	public ParticleSystem.MinMaxGradient colorShadowed;

	public ParticleSystem.MinMaxGradient colorLit;
}
