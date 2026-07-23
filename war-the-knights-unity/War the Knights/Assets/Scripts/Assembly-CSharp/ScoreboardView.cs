using EnhancedUI.EnhancedScroller;
using TMPro;
using UnityEngine;

public class ScoreboardView : EnhancedScrollerCellView
{
	public TextMeshProUGUI botNameText;

	public TextMeshProUGUI botScoreText;

	public TextMeshProUGUI botKillsText;

	public TextMeshProUGUI botDeathsText;

	public TextMeshProUGUI botObjectiveText;

	public TextMeshProUGUI botSupportText;

	public TextMeshProUGUI botPlaceText;

	public GameObject playerBackground;

	public GameObject spacingBackground1;

	public GameObject spacingBackground2;

	public void SetData(ScoreboardData data)
	{
	}
}
