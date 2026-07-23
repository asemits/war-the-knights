using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

public class MapSelectionController : MonoBehaviour, IEnhancedScrollerDelegate
{
	private List<MapSelectionData> _data;

	public EnhancedScroller scroller;

	public MapSelectionViewGrid mapSelectionViewPrefab;

	public void Start()
	{
	}

	public void UpdateController()
	{
	}

	public void ClearData()
	{
	}

	public void AddData(MapSelectionData data)
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
