using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Synty.Interface.FantasyWarriorHUD.Samples
{
	public class SampleSceneLoader : MonoBehaviour
	{
		private sealed class _003CC_SwitchScene_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SampleSceneLoader _003C_003E4__this;

			public string sceneName;

			private AsyncOperation _003CasyncLoad_003E5__2;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CC_SwitchScene_003Ed__8(int _003C_003E1__state)
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

		public bool showCursor;

		private List<string> _sceneNames;

		private void OnEnable()
		{
		}

		public void QuitApplication()
		{
		}

		public void NextScene()
		{
		}

		public void PreviousScene()
		{
		}

		public void SwitchScene(string sceneName)
		{
		}

		private IEnumerator C_SwitchScene(string sceneName)
		{
			return null;
		}
	}
}
