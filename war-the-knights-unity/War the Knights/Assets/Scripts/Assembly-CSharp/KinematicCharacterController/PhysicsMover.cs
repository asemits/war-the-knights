using System;
using UnityEngine;

namespace KinematicCharacterController
{
	public class PhysicsMover : MonoBehaviour
	{
		public Rigidbody Rigidbody;

		public bool MoveWithPhysics;

		[NonSerialized]
		public IMoverController MoverController;

		[NonSerialized]
		public Vector3 LatestInterpolationPosition;

		[NonSerialized]
		public Quaternion LatestInterpolationRotation;

		[NonSerialized]
		public Vector3 PositionDeltaFromInterpolation;

		[NonSerialized]
		public Quaternion RotationDeltaFromInterpolation;

		private Vector3 _internalTransientPosition;

		private Quaternion _internalTransientRotation;

		private int _003CIndexInCharacterSystem_003Ek__BackingField;

		private Vector3 _003CVelocity_003Ek__BackingField;

		private Vector3 _003CAngularVelocity_003Ek__BackingField;

		private Vector3 _003CInitialTickPosition_003Ek__BackingField;

		private Quaternion _003CInitialTickRotation_003Ek__BackingField;

		private Transform _003CTransform_003Ek__BackingField;

		private Vector3 _003CInitialSimulationPosition_003Ek__BackingField;

		private Quaternion _003CInitialSimulationRotation_003Ek__BackingField;

		public int IndexInCharacterSystem
		{
			get
			{
				return _003CIndexInCharacterSystem_003Ek__BackingField;
			}
			set
			{
				_003CIndexInCharacterSystem_003Ek__BackingField = value;
			}
		}

		public Vector3 Velocity
		{
			get
			{
				return _003CVelocity_003Ek__BackingField;
			}
			protected set
			{
				_003CVelocity_003Ek__BackingField = value;
			}
		}

		public Vector3 AngularVelocity
		{
			get
			{
				return _003CAngularVelocity_003Ek__BackingField;
			}
			protected set
			{
				_003CAngularVelocity_003Ek__BackingField = value;
			}
		}

		public Vector3 InitialTickPosition
		{
			get
			{
				return _003CInitialTickPosition_003Ek__BackingField;
			}
			set
			{
				_003CInitialTickPosition_003Ek__BackingField = value;
			}
		}

		public Quaternion InitialTickRotation
		{
			get
			{
				return _003CInitialTickRotation_003Ek__BackingField;
			}
			set
			{
				_003CInitialTickRotation_003Ek__BackingField = value;
			}
		}

		public Transform Transform
		{
			get
			{
				return _003CTransform_003Ek__BackingField;
			}
			private set
			{
				_003CTransform_003Ek__BackingField = value;
			}
		}

		public Vector3 InitialSimulationPosition
		{
			get
			{
				return _003CInitialSimulationPosition_003Ek__BackingField;
			}
			private set
			{
				_003CInitialSimulationPosition_003Ek__BackingField = value;
			}
		}

		public Quaternion InitialSimulationRotation
		{
			get
			{
				return _003CInitialSimulationRotation_003Ek__BackingField;
			}
			private set
			{
				_003CInitialSimulationRotation_003Ek__BackingField = value;
			}
		}

		public Vector3 TransientPosition
		{
			get
			{
				return default(Vector3);
			}
			private set
			{
			}
		}

		public Quaternion TransientRotation
		{
			get
			{
				return default(Quaternion);
			}
			private set
			{
			}
		}

		private void Reset()
		{
		}

		private void OnValidate()
		{
		}

		public void ValidateData()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		public void SetPosition(Vector3 position)
		{
		}

		public void SetRotation(Quaternion rotation)
		{
		}

		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
		}

		public PhysicsMoverState GetState()
		{
			return default(PhysicsMoverState);
		}

		public void ApplyState(PhysicsMoverState state)
		{
		}

		public void VelocityUpdate(float deltaTime)
		{
		}
	}
}
