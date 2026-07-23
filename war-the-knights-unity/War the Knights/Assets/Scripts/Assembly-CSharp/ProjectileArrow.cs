using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileArrow : ProjectileBase
{
	private sealed class _003CWobble_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool parented;

		public ProjectileArrow _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWobble_003Ed__10(int _003C_003E1__state)
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

	public float depth;

	public float projectileLengthFromCenterToFront;

	public TrailRenderer trailRenderer;

	public ParticleSystem[] particleSystems;

	public ParticleSystem[] particleSystemsToActivateOnImpact;

	private Vector3 hitPoint;

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void DisableCollisionAfterImpact(Vector3 hitPoint, Vector3 hitNormal, PhysicsMaterial physicMaterial)
	{
	}

	private IEnumerator Wobble(bool parented)
	{
		return null;
	}
}
