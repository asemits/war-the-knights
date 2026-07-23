using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIFadeDirectional : MonoBehaviour
{
	private sealed class _003CFadeIn_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFadeDirectional _003C_003E4__this;

		public float duration;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFadeIn_003Ed__6(int _003C_003E1__state)
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

	private sealed class _003CFadeOut_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFadeDirectional _003C_003E4__this;

		public float duration;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFadeOut_003Ed__7(int _003C_003E1__state)
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

	public Image maskImage;

	public bool adaptToTextWidth;

	public TextMeshProUGUI textWidthToAdaptTo;

	public int maskSizeOffset;

	private Coroutine fadeCoroutine;

	public void Fade(bool fadeIn, float duration, bool restartFadeProgress, bool horizontalFadeReverse = false)
	{
	}

	private IEnumerator FadeIn(float duration)
	{
		return null;
	}

	private IEnumerator FadeOut(float duration)
	{
		return null;
	}
}
