using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

public class LoadoutCategoryController : MonoBehaviour, IEnhancedScrollerDelegate
{
	private List<LoadoutCategoryData> _data;

	public EnhancedScroller scroller;

	public LoadoutCategoryView loadoutCategoryViewPrefab;

	public void Start()
	{
	}

	public void UpdateController()
	{
	}

	public void ClearData()
	{
	}

	public void AddData(LoadoutCategoryData data)
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
