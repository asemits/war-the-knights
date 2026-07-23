using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
	private sealed class _003CBossWaitToDecreaseFill_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealthBarController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBossWaitToDecreaseFill_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CWaitToDecreaseFill_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealthBarController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitToDecreaseFill_003Ed__18(int _003C_003E1__state)
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

	private sealed class _003CWaitToHide_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealthBarController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitToHide_003Ed__20(int _003C_003E1__state)
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

	public Image enemyHealthBar;

	public Image enemyHealthBarLeft;

	public Image enemyHealthBar2;

	public Image enemyHealthBar2Left;

	public TextMeshProUGUI enemyNameText;

	public HealthBase currentEnemy;

	public CanvasGroup canvas;

	public bool canDecrease;

	private Coroutine hideCoroutine;

	public CanvasGroup bossCanvas;

	public Text bossNameText;

	public Image bossHealthBar;

	public Image bossHealthBar2;

	public bool fightingBoss;

	public bool canDecreaseBoss;

	private static readonly WaitForSeconds WaitForDecreaseFillTimer;

	public void UpdateBar(float oldHealth, float health, float maxHealth, ref HealthBase healthScript)
	{
	}

	public void Hide()
	{
	}

	public IEnumerator WaitToDecreaseFill()
	{
		return null;
	}

	public IEnumerator BossWaitToDecreaseFill()
	{
		return null;
	}

	public IEnumerator WaitToHide()
	{
		return null;
	}
}
