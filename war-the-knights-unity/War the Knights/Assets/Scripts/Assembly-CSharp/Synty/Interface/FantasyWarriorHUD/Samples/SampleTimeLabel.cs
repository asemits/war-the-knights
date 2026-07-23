using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Synty.Interface.FantasyWarriorHUD.Samples
{
	public class SampleTimeLabel : MonoBehaviour
	{
		private sealed class _003CC_UpdateTime_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SampleTimeLabel _003C_003E4__this;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CC_UpdateTime_003Ed__9(int _003C_003E1__state)
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

		public TMP_Text label;

		public bool is24Hour;

		public float timeToRefreshInSeconds;

		private bool beat;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public string GetCurrentTimeString()
		{
			return null;
		}

		public void UpdateTime()
		{
		}

		private IEnumerator C_UpdateTime()
		{
			return null;
		}
	}
}
