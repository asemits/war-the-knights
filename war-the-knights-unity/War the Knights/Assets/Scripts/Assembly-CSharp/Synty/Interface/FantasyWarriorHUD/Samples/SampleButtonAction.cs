using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Synty.Interface.FantasyWarriorHUD.Samples
{
	public class SampleButtonAction : MonoBehaviour
	{
		private sealed class _003CC_ActivateObject_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SampleButtonAction _003C_003E4__this;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CC_ActivateObject_003Ed__11(int _003C_003E1__state)
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

		public Button button;

		public List<GameObject> toggleObjects;

		public GameObject activateObject;

		public List<SampleAnimatorActionData> animatorActions;

		public float activeTime;

		public bool runOnEnable;

		public bool applyRandomRotationToActivateObject;

		private void Awake()
		{
		}

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void OnClick()
		{
		}

		private IEnumerator C_ActivateObject()
		{
			return null;
		}
	}
}
