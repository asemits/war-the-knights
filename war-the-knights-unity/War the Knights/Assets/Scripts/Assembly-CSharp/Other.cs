using UnityEngine;

public static class Other
{
	public static YieldInstruction WaitForEndOfFrame;

	public static WaitForSeconds WaitForOneSecond;

	public static float deltaTime;

	public static float smoothDeltaTime;

	public static float unscaledDeltaTime;

	public static float fixedDeltaTime;

	public static float time;

	public static readonly Vector3 Vector3Zero;

	public static readonly Vector3 Vector3One;

	public static readonly Vector3 Vector3Forward;

	public static RaycastHit[] raycastHits;

	public static Collider[] colliderOverlaps;

	public static Ray raycastCache;

	private static Vector3[] worldCorners;

	public static PhysicsScene physicsScene;

	public static float physicsGravityY;

	private static Quaternion smoothDampQuaternion;

	public static void ToggleCanvasUsability(CanvasGroup canvas, bool enable)
	{
	}

	public static void ToggleCanvas(CanvasGroup canvas, bool enable)
	{
	}

	public static bool IsOutOfScreen(RectTransform uiElement)
	{
		return false;
	}

	public static void SplashDamage(Vector3 position, float damage, float poiseDamage, float physicsForce, float radius, AITarget damageSource, float cameraShakeIntensityMultiplier = 1f, float fireDamage = 0f, float staggerMaxDistanceThresholdPercentage = 0.9f, bool dontHitDestructiblesOrParticles = false)
	{
	}

	public static bool RaycastWithoutCollidingWithUnit(Vector3 position, Vector3 direction, float length, float radius, out RaycastHit hit, ref LayerMask layerMask, ref HealthBase health)
	{
		hit = default(RaycastHit);
		return false;
	}

	public static bool RaycastWithoutCollidingWithUnitAndVehicle(Vector3 position, Vector3 direction, float length, float radius, out RaycastHit hit, ref LayerMask layerMask, ref HealthBase health, ref VehicleHealth secondaryHealth)
	{
		hit = default(RaycastHit);
		return false;
	}

	public static bool RaycastWithoutCollidingWithUnitPlayerOnly(Vector3 position, Vector3 direction, float length, float radius, out RaycastHit hit, ref LayerMask layerMask)
	{
		hit = default(RaycastHit);
		return false;
	}

	public static bool RaycastColliderOnlyToGetNormalOfCollisionEvent(ref Collision collision, ref ContactPoint contact, out RaycastHit hit)
	{
		hit = default(RaycastHit);
		return false;
	}

	public static bool CalculateProjectileAngle(Vector3 from, Vector3 to, float speed, bool chooseHighPath, out float angle)
	{
		angle = default(float);
		return false;
	}

	public static Vector3 FirstOrderIntercept(Vector3 shooterPosition, Vector3 shooterVelocity, float shotSpeed, Vector3 targetPosition, Vector3 targetVelocity)
	{
		return default(Vector3);
	}

	private static float FirstOrderInterceptTime(float shotSpeed, Vector3 targetRelativePosition, Vector3 targetRelativeVelocity)
	{
		return 0f;
	}

	public static Vector2 DegreeToVector2(float degree)
	{
		return default(Vector2);
	}

	public static bool FastApproximately(float a, float b, float threshold)
	{
		return false;
	}

	public static float LimitToRange(float value, float inclusiveMinimum, float inclusiveMaximum)
	{
		return 0f;
	}

	public static bool RandomBoolean()
	{
		return false;
	}

	public static int[] RandomUniqueValue(int start, int end, int amount)
	{
		return null;
	}

	public static Vector3 SmoothDampEuler(Vector3 current, Vector3 target, ref Vector3 velocity, float smoothTime)
	{
		return default(Vector3);
	}

	public static Vector3 LerpAngle(Vector3 StartAngle, Vector3 FinishAngle, float t)
	{
		return default(Vector3);
	}

	public static Vector3 MultiplyVectors(Vector3 v, Vector3 w)
	{
		return default(Vector3);
	}

	public static Vector3 ClampMagnitude(Vector3 vector, float minLength)
	{
		return default(Vector3);
	}

	public static Vector3 RandomPointInBounds(Bounds bounds)
	{
		return default(Vector3);
	}

	public static float NormalizeEulerAngle(float eulerAngle)
	{
		return 0f;
	}

	public static float ClampNormalizedEulerAngleInverted(float eulerAngle, float min, float max)
	{
		return 0f;
	}

	public static Quaternion SmoothDamp(Quaternion rot, Quaternion target, ref Vector4 velocity)
	{
		return default(Quaternion);
	}

	public static bool CheckCurrentAnimation(ref Animator anim, int animationName, int layer = 0)
	{
		return false;
	}

	public static bool CheckCurrentAnimation(ref int animStateCurrentHash, ref int animStateNextHash, int animationName)
	{
		return false;
	}

	public static bool IsPointInCollider(Vector3 point, Collider collider)
	{
		return false;
	}
}
