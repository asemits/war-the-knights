using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractionRaycast : MonoBehaviour
{
	public float distanceToSee;

	public Transform playerCamera;

	public RectTransform useUITransform;

	public CanvasGroup useUICanvas;

	public GameObject Target;

	public GameObject DirectTarget;

	public TextMeshProUGUI interactText;

	public RaycastHit hitObject;

	public bool lookingAtInteractible;

	public bool dontShowInteractibleCrosshair;

	public GameObject currentLookedAtObject;

	public LayerMask layerMask;

	public RaycastHit hitEnemy;

	private GameObject EnemyTarget;

	public HealthBase currentEnemy;

	public LayerMask enemyLayerMask;

	public Color colorEnemy;

	public Color colorEnemyCantFire;

	public Color colorDefault;

	public Color colorCantFire;

	public float progress;

	public Image progressCircle;

	public bool canBuy;

	public bool carryingPhysicsPickup;

	public InteractablePhysicsPickup physicsPickup;

	public Quaternion physicsPickupTargetRotation;

	public Quaternion targetRotationOnPickup;

	public Transform currentPickupTargetTransform;

	public float stopCarryingTimer;

	public static InteractionRaycast Instance;

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	public void Use()
	{
	}

	public void UseUIToggle(bool show)
	{
	}

	public void ToggleCarryingPhysicsPickup(bool start, InteractablePhysicsPickup interactablePhysicsPickup = null, bool defeat = false)
	{
	}

	public void OnPlayerDeath()
	{
	}

	public void HideInteractionTip()
	{
	}

	public void UpdateRay()
	{
	}
}
