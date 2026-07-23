using UnityEngine;
using UnityEngine.EventSystems;

public class OptionsButtonDescription : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
{
	public string settingDescription;

	public UIManagerOptionsMenu optionsMenu;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}
}
