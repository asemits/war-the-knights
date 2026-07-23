using UnityEngine;

namespace KinematicCharacterController
{
	public abstract class BaseMoverController : MonoBehaviour
	{
		private PhysicsMover _003CMover_003Ek__BackingField;

		public PhysicsMover Mover
		{
			get
			{
				return _003CMover_003Ek__BackingField;
			}
			private set
			{
				_003CMover_003Ek__BackingField = value;
			}
		}

		public void SetupMover(PhysicsMover mover)
		{
		}

		public abstract void UpdateMovement(out Vector3 goalPosition, out Quaternion goalRotation, float deltaTime);
	}
}
