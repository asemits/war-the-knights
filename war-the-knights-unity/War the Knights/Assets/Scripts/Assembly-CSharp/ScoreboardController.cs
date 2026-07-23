using System;
using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

public class ScoreboardController : MonoBehaviour, IEnhancedScrollerDelegate
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ScoreboardData, int> _003C_003E9__4_0;

		public static Func<ScoreboardData, string> _003C_003E9__4_1;

		internal int _003CUpdateController_003Eb__4_0(ScoreboardData o)
		{
			return 0;
		}

		internal string _003CUpdateController_003Eb__4_1(ScoreboardData o)
		{
			return null;
		}
	}

	private List<ScoreboardData> _data;

	public EnhancedScroller scroller;

	public ScoreboardView scoreboardViewPrefab;

	public void SetupController()
	{
	}

	public void UpdateController()
	{
	}

	public void ClearData()
	{
	}

	public void AddData(ScoreboardData data)
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
