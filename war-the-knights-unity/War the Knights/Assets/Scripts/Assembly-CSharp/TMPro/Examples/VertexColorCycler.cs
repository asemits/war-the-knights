using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	public class VertexColorCycler : MonoBehaviour
	{
		private sealed class _003CAnimateVertexColors_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VertexColorCycler _003C_003E4__this;

			private TMP_TextInfo _003CtextInfo_003E5__2;

			private int _003CcurrentCharacter_003E5__3;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CAnimateVertexColors_003Ed__3(int _003C_003E1__state)
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

		private TMP_Text m_TextComponent;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
}
