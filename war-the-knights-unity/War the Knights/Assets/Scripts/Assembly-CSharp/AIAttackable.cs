using UnityEngine;

public abstract class AIAttackable : MonoBehaviour
{
	public Vector3 cachedLookAtPosition;

	public AttackBehavior bestOfferableAttackBehavior;

	public abstract void CheckBestOfferableAttackBehavior();

	public abstract void AssignAttacker(AITarget attacker);

	public abstract void ForceAssignAttacker(AITarget attacker);

	public abstract void UnassignAttacker(AITarget attacker);

	public abstract void HideFromView();
}
