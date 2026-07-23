using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
	public bool showInteractionTip;

	public string interactableName;

	public InteractionTip interactionTip;

	public abstract InteractionTip GetInteractionTip();

	public abstract void Interact();
}
