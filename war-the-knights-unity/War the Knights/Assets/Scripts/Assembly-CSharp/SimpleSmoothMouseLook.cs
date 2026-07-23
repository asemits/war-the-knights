using System;
using System.Collections;
using System.Collections.Generic;
using KinematicCharacterController;
using UnityEngine;

public class SimpleSmoothMouseLook : MonoBehaviour
{
	private sealed class _003CRotateTarget_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleSmoothMouseLook _003C_003E4__this;

		public Transform target;

		private Quaternion _003CstartRot_003E5__2;

		private float _003Ctimer_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRotateTarget_003Ed__25(int _003C_003E1__state)
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

	private sealed class _003CRotateToTarget_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleSmoothMouseLook _003C_003E4__this;

		public Transform target;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRotateToTarget_003Ed__24(int _003C_003E1__state)
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

	public bool m_filter;

	public bool inverted;

	public float currentRotationHorizontal;

	public float currentRotationVertical;

	public float mouseMovementHorizontal;

	public float mouseMovementVertical;

	public float lastFrameMouseMovementHorizontal;

	public float lastFrameMouseMovementVertical;

	public int clampInDegreesHorizontal;

	public int clampInDegreesVerticalLookUp;

	public int clampInDegreesVerticalLookDown;

	public float sensitivityHorizontal;

	public float sensitivityVertical;

	public KinematicCharacterMotor characterBody;

	public Transform characterTransform;

	private bool setRotation;

	public CameraRecoil camRecoil;

	public bool isRotating;

	public Coroutine rotateToTargetCoroutine;

	public Transform _transform;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UpdateRotation()
	{
	}

	public void SetRotation(Vector3 rot)
	{
	}

	public IEnumerator RotateToTarget(Transform target)
	{
		return null;
	}

	private IEnumerator RotateTarget(Transform target)
	{
		return null;
	}
}
