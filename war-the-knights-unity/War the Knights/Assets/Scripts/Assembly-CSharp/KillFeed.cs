using System;
using System.Collections;
using System.Collections.Generic;
using EZObjectPools;
using UnityEngine;

public class KillFeed : MonoBehaviour
{
	private sealed class _003CShowNextElement_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KillFeed _003C_003E4__this;

		public bool playerTeam;

		private CanvasGroup _003Ccanvas_003E5__2;

		private RectTransform _003Crect_003E5__3;

		private Transform _003Crect2_003E5__4;

		private Transform _003CtextFade_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowNextElement_003Ed__11(int _003C_003E1__state)
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

	public EZObjectPool killFeedElementPool;

	public List<RectTransform> currentElements;

	public Color backgroundColorAllies;

	public Color backgroundColorEnemy;

	private string nameToShow;

	private bool destroyed;

	private static readonly Vector3 startRotation;

	private static readonly Vector3 endRotation;

	private static readonly Vector3 scalePunch;

	private static readonly WaitForSeconds WaitForFeedFadeTimer;

	public void AddElement(bool playerTeam, string name, bool destroyed)
	{
	}

	private IEnumerator ShowNextElement(bool playerTeam)
	{
		return null;
	}
}
