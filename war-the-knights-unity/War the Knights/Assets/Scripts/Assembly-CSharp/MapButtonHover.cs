using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MapButtonHover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler
{
	public int index;

	public bool revardReceived;

	public Button button;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
