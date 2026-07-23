using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickUseBuff : UsableItem
{
	private sealed class _003CLiquidDepleteOverTime_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuickUseBuff _003C_003E4__this;

		private float _003CstartAmount_003E5__2;

		private float _003Ctimer_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLiquidDepleteOverTime_003Ed__19(int _003C_003E1__state)
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

	public BuffTypes buffType;

	public float buffAmount;

	public float maxOverhealAmount;

	public WeaponGadgetQuickUseSound buffSound;

	public AudioClip customBuffSound;

	public ParticleSystem[] particleSystemsToUnparentOnImpact;

	public bool depleteableLiquid;

	public bool depleteLiquidAfterDrinking;

	public LiquidMovement liquidMovement;

	public float depletionDuration;

	public float liquidFillAmountEnd;

	public override void PlayerStart()
	{
	}

	public override void BotStart()
	{
	}

	private void SetSounds()
	{
	}

	public override void BotAttack()
	{
	}

	public override void BotCancelAttack()
	{
	}

	public override void QuickUseItem()
	{
	}

	public void Buff()
	{
	}

	public void BuffDepleteLiquid()
	{
	}

	private IEnumerator LiquidDepleteOverTime()
	{
		return null;
	}

	public override void ConsumeAmmo()
	{
	}

	public override void StopUsingItem()
	{
	}

	public override void BlockHit(bool heavy)
	{
	}

	public override void Kick()
	{
	}
}
