using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundCamera : MonoBehaviour
{
	private sealed class _003CUpdateRotation_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RotateAroundCamera _003C_003E4__this;

		public Transform target;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdateRotation_003Ed__12(int _003C_003E1__state)
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

	public float distance;

	public float xSpeed;

	public float ySpeed;

	public float yMinLimit;

	public float yMaxLimit;

	public float distanceMin;

	public float distanceMax;

	private float x;

	private float y;

	public bool inverted;

	public LayerMask cameraRaycastLayerMask;

	public Transform cam;

	public IEnumerator UpdateRotation(Transform target)
	{
		return null;
	}

	public static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}
}
