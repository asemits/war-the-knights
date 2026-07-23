using System;
using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public abstract class NavLinkPointMover : MonoBehaviour
{
	private sealed class _003CClimbCooldown_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NavLinkPointMover _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CClimbCooldown_003Ed__13(int _003C_003E1__state)
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

	private sealed class _003CUpdateNavmeshLate_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NavLinkPointMover _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdateNavmeshLate_003Ed__12(int _003C_003E1__state)
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

	public NavMeshLink link;

	public Transform _transform;

	public Transform startPoint;

	public Transform endPoint;

	public List<AITarget> botsUsingThisLink;

	public int maxBotsAtOnce;

	private bool disabledLink;

	public Vector3 climbDirectionHorizontal;

	private Coroutine climbCooldownCoroutine;

	public float lastTimeBotClimbed;

	private static readonly WaitForSeconds WaitBeforeNewBotCanUseLinkTimer;

	public void LinkAwake()
	{
	}

	public IEnumerator UpdateNavmeshLate()
	{
		return null;
	}

	public IEnumerator ClimbCooldown()
	{
		return null;
	}

	public void AddClimber(AITarget bot)
	{
	}

	public void RemoveClimber(AITarget bot)
	{
	}

	public void DisableLink()
	{
	}

	public void EnableLink()
	{
	}

	public void DestroyLink()
	{
	}
}
