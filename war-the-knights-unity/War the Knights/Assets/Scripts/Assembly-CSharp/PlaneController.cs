using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
	private sealed class _003CMoveCamToPerspective_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlaneController _003C_003E4__this;

		public bool thirdperson;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveCamToPerspective_003Ed__17(int _003C_003E1__state)
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

	public Rigidbody rb;

	public float speed;

	public float maxVelocity;

	public float hoverDrag;

	public float normalDrag;

	public float chargeSpeedMultiplier;

	public bool hovering;

	public bool altFire;

	public bool isCharging;

	public int camFovDefault;

	public int camFovCharging;

	public Transform firstPersonCamPos;

	public Transform thirdPersonCamPos;

	public Coroutine perspectiveChangeCoroutine;

	public bool isInThirdPerson;

	public Transform shipVisualTransform;

	private void Update()
	{
	}

	private IEnumerator MoveCamToPerspective(bool thirdperson)
	{
		return null;
	}

	public void StartControlling()
	{
	}

	public void StopControlling()
	{
	}

	public void EnterNavmesh()
	{
	}
}
