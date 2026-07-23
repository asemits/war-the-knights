using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZoneTrigger : SpawnableGameplayEffect
{
	private sealed class _003CDealDamageAtEndOfFrame_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealthBase health;

		public DamageZoneTrigger _003C_003E4__this;

		public Collider other;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDealDamageAtEndOfFrame_003Ed__16(int _003C_003E1__state)
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

	public int damage;

	public int poiseDamage;

	public int fireDamage;

	public bool instantlyDefeat;

	public bool hitsVehicles;

	public Vector3 localForceApplyVector;

	public bool forceAwayFromCenter;

	public float forceStrength;

	public bool scaleDamageWithForceStrength;

	public bool continuoslyHitTargetsInsideTriggerColliders;

	public Collider[] triggerColliders;

	public float resetTriggerTimerDuration;

	private float resetTriggerTimer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private IEnumerator DealDamageAtEndOfFrame(HealthBase health, Collider other)
	{
		return null;
	}
}
