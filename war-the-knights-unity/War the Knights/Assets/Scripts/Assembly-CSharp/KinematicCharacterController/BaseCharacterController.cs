using UnityEngine;

namespace KinematicCharacterController
{
	public abstract class BaseCharacterController : MonoBehaviour
	{
		private KinematicCharacterMotor _003CMotor_003Ek__BackingField;

		public KinematicCharacterMotor Motor
		{
			get
			{
				return _003CMotor_003Ek__BackingField;
			}
			private set
			{
				_003CMotor_003Ek__BackingField = value;
			}
		}

		public void SetupCharacterMotor(KinematicCharacterMotor motor)
		{
		}

		public abstract void UpdateRotation(ref Quaternion currentRotation, float deltaTime);

		public abstract void UpdateVelocity(ref Vector3 currentVelocity, float deltaTime);

		public abstract void BeforeCharacterUpdate(float deltaTime);

		public abstract void PostGroundingUpdate(float deltaTime);

		public abstract void AfterCharacterUpdate(float deltaTime);

		public abstract bool IsColliderValidForCollisions(Collider coll);

		public abstract void OnGroundHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, ref HitStabilityReport hitStabilityReport);

		public abstract void OnMovementHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, ref HitStabilityReport hitStabilityReport);

		public abstract void ProcessHitStabilityReport(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, Vector3 atCharacterPosition, Quaternion atCharacterRotation, ref HitStabilityReport hitStabilityReport);

		public virtual void OnDiscreteCollisionDetected(Collider hitCollider)
		{
		}

		public virtual void HandleMovementProjection(ref Vector3 movement, Vector3 obstructionNormal, bool stableOnHit)
		{
		}

		public virtual void HandleSimulatedRigidbodyInteraction(ref Vector3 processedVelocity, RigidbodyProjectionHit hit, float deltaTime)
		{
		}
	}
}
