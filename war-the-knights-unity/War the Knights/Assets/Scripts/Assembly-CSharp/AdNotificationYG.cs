using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdNotificationYG : MonoBehaviour
{
	private sealed class _003CCloseNotification_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdNotificationYG _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseNotification_003Ed__8(int _003C_003E1__state)
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

	public GameObject notificationObj;

	public float waitingForAds;

	public static bool isShowNotification;

	public static AdNotificationYG Instance;

	private Coroutine closeNotifCoroutine;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnAdNotification()
	{
	}

	private IEnumerator CloseNotification()
	{
		return null;
	}

	private void OnOpenAd()
	{
	}
}
