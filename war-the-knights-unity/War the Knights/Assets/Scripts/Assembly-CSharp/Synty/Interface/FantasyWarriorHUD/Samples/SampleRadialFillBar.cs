using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Synty.Interface.FantasyWarriorHUD.Samples
{
	public class SampleRadialFillBar : MonoBehaviour
	{
		private sealed class _003CC_TweenBackAndForth_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SampleRadialFillBar _003C_003E4__this;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CC_TweenBackAndForth_003Ed__14(int _003C_003E1__state)
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

		private sealed class _003CC_TweenFloat_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public float startValue;

			public float endValue;

			public SampleRadialFillBar _003C_003E4__this;

			private float _003Ctime_003E5__2;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CC_TweenFloat_003Ed__15(int _003C_003E1__state)
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

		public Image image;

		public TMP_Text text;

		public float fillAmountFull;

		public float inSpeed;

		public float outSpeed;

		public float startDelay;

		public float inDelay;

		public float outDelay;

		public string labelText;

		public string LabelText => null;

		private void Awake()
		{
		}

		private void Reset()
		{
		}

		private void Start()
		{
		}

		private IEnumerator C_TweenBackAndForth()
		{
			return null;
		}

		private IEnumerator C_TweenFloat(float startValue, float endValue, float duration)
		{
			return null;
		}
	}
}
