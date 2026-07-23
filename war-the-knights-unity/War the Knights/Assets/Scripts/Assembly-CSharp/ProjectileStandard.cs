using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileStandard : ProjectileBase
{
	private sealed class _003CDestroyWithEffectAfterTime_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProjectileStandard _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDestroyWithEffectAfterTime_003Ed__14(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public bool rotateToUpDirection;

	public bool effectOnImpact;

	public bool splashDamageOnImpact;

	public float splashDamageAfterTime;

	public TrailRenderer trailRenderer;

	public ParticleSystem[] particleSystems;

	public ParticleSystem[] particleSystemsToActivateOnImpact;

	public ParticleSystem[] particleSystemsToUnparentOnImpact;

	public bool spawnCollisionImpactVisualEffects;

	private Vector3 hitPoint;

	protected override void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void SplashDamageImpactEffect(Vector3 hitPoint, Vector3 hitNormal, PhysicsMaterial physicMaterial)
	{
	}

	private IEnumerator DestroyWithEffectAfterTime()
	{
		return null;
	}
}
