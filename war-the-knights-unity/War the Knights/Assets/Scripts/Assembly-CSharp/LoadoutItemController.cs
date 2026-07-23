using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

public class LoadoutItemController : MonoBehaviour, IEnhancedScrollerDelegate
{
	private List<LoadoutItemData> _data;

	public EnhancedScroller scroller;

	public LoadoutItemViewGrid loadoutItemViewPrefab;

	public void Start()
	{
	}

	public void UpdateController()
	{
	}

	public void ClearData()
	{
	}

	public void AddData(LoadoutItemData data)
	{
	}

	public int GetNumberOfCells(EnhancedScroller scroller)
	{
		return 0;
	}

	public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
	{
		return 0f;
	}

	public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
	{
		return null;
	}
}
