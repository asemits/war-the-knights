using EnhancedUI.EnhancedScroller;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MapSelectionView : EnhancedScrollerCellView
{
	public GameObject container;

	public Image mapIcon;

	public Image buttomImage;

	public TextMeshProUGUI mapName;

	public MapButtonHover mapButtonHover;

	public GameObject rewarded;

	public void SetData(MapSelectionData data)
	{
	}
}
