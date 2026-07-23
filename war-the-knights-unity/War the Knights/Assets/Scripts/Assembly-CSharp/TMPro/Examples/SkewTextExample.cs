using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	public class SkewTextExample : MonoBehaviour
	{
		private sealed class _003CWarpText_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkewTextExample _003C_003E4__this;

			private float _003Cold_CurveScale_003E5__2;

			private float _003Cold_ShearValue_003E5__3;

			private AnimationCurve _003Cold_curve_003E5__4;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CWarpText_003Ed__7(int _003C_003E1__state)
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

		public AnimationCurve VertexCurve;

		public float CurveScale;

		public float ShearAmount;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		private IEnumerator WarpText()
		{
			return null;
		}
	}
}
