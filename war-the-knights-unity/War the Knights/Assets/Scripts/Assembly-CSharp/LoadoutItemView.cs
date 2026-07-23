using EnhancedUI.EnhancedScroller;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadoutItemView : EnhancedScrollerCellView
{
	public GameObject container;

	public Image itemIcon;

	public Image buttomImage;

	public TextMeshProUGUI itemName;

	public ItemButtonHover itemButtonHover;

	public GameObject reward;

	public Button button;

	public void SetData(LoadoutItemData data)
	{
	}
}
