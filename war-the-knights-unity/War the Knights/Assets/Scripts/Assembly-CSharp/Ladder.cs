using UnityEngine;

public class Ladder : NavLinkPointMover
{
	public bool setUpCompletely;

	public int ladderLength;

	public float ladderActualLength;

	public bool topToBottomLink;

	public GameObject ladder;

	public GameObject ladderPrefabTop;

	public GameObject ladderPrefabMiddle;

	public GameObject ladderPrefabBottom;

	public CapsuleCollider ladderColliderLeft;

	public CapsuleCollider ladderColliderRight;

	public Collider interactionCollider;

	public bool madeOutOfMetal;

	public bool buildableLadder;

	public bool buildableLadderSpawnBuilt;

	public float buildStartRotationOffset;

	public float buildFinishParticleEffectOffset;

	public bool buildableLadderIndestructible;

	public bool buildableLadderCantKickOver;

	public int buildableLadderHealth;

	public int buildableLadderRespawnDuration;

	public bool bidirectionalLadder;

	public bool buildableLadderHasBeenConstructed;

	public HealthLadder ladderHealth;

	public Rigidbody ladderRigidbody;

	public Vector3 originalLadderPosition;

	public Quaternion originalLadderRotation;

	public void CreateLadder()
	{
	}

	public void Awake()
	{
	}

	public void BuildLadderStart()
	{
	}

	public void BuildLadderFinish()
	{
	}
}
