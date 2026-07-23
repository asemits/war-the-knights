using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableAmmo : Interactable
{
	private sealed class _003CRefillCooldown_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InteractableAmmo _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefillCooldown_003Ed__4(int _003C_003E1__state)
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

	public bool usable;

	public GameObject objectUsable;

	private static readonly WaitForSeconds WaitForRefillTimer;

	private void Start()
	{
	}

	public IEnumerator RefillCooldown()
	{
		return null;
	}

	public override InteractionTip GetInteractionTip()
	{
		return null;
	}

	public override void Interact()
	{
	}
}
