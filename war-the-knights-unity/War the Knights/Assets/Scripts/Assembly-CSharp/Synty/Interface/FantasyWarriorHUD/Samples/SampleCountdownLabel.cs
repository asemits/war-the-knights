using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Synty.Interface.FantasyWarriorHUD.Samples
{
	public class SampleCountdownLabel : MonoBehaviour
	{
		private sealed class _003CC_TickDown_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SampleCountdownLabel _003C_003E4__this;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CC_TickDown_003Ed__12(int _003C_003E1__state)
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

		private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SampleCountdownLabel _003C_003E4__this;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CStart_003Ed__10(int _003C_003E1__state)
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

		public Animator animator;

		public TMP_Text text;

		public bool setAnimatorActive;

		public float initialDelay;

		public float countdownTime;

		public float updateInterval;

		public float timeUpDuration;

		public UnityEvent onCountdownComplete;

		private float currentTime;

		private void Reset()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void BeginTimer()
		{
		}

		private IEnumerator C_TickDown()
		{
			return null;
		}

		private void RefreshUI()
		{
		}
	}
}
