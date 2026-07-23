using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRagdoll : MonoBehaviour
{
	private sealed class _003CEndOfFrameToggleActiveObject_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActiveRagdoll _003C_003E4__this;

		public bool disableRagdoll;

		public bool standUp;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CEndOfFrameToggleActiveObject_003Ed__28(int _003C_003E1__state)
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

	private sealed class _003CRagdollToAnim_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActiveRagdoll _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRagdollToAnim_003Ed__27(int _003C_003E1__state)
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

	public Animator anim;

	public AITarget aiTarget;

	public GameObject ragdoll;

	public GameObject ragdollAnimator;

	public Transform[] bones;

	public Transform[] bonesAnimated;

	public Rigidbody[] ragdollRigidbodies;

	public Joint[] ragdollJoints;

	public Transform hipAnimated;

	public Transform hipRagdoll;

	public Rigidbody spineRagdoll;

	public AnimationBoneTransform[] defaultRigidbodyBoneTransform;

	public AnimationBoneTransform[] standUpFromBackAnimationBoneTransform;

	public AnimationBoneTransform[] standUpFromFrontAnimationBoneTransform;

	public bool ragdolled;

	public bool animatorInactive;

	public bool ragdolledStandUp;

	public bool standUpFromFront;

	private Coroutine ragdollToAnimCoroutine;

	private float ragdollStandUpTimer;

	public TwoTransforms[] reparentOnRagdollStateChange;

	public bool[] reparentObjectIsOnRagdollObject;

	private Coroutine endOfFrameToggleActiveObjectCoroutine;

	private AnimationBoneTransform[] ragdollBonesTransformTarget;

	public void CheckGetUp()
	{
	}

	public void StartRagdoll(bool defeated, Vector3 force)
	{
	}

	public void StopRagdoll(bool standUp, bool respawned = false)
	{
	}

	public IEnumerator RagdollToAnim()
	{
		return null;
	}

	public IEnumerator EndOfFrameToggleActiveObject(bool disableRagdoll, bool standUp)
	{
		return null;
	}
}
