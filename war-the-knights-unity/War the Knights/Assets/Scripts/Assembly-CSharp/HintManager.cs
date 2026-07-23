using TMPro;
using UnityEngine;

public class HintManager : MonoBehaviour
{
	public CanvasGroup hintCanvas;

	public TextMeshProUGUI hintText;

	public TextMeshProUGUI hintAdditionalDescriptionText;

	public RectTransform hintBackground;

	public static float timeSinceLastHint;

	public static float timeLastSpecialHint;

	public static float timeLastBlock;

	public static bool hasKicked;

	public static int spawnedWithoutChangingPoint;

	public static int lightAttacksWithoutHeavyInBetween;

	public static int meleeEquippedWithoutThrowing;

	public static bool throwTipShown;

	public static bool hintsActiveInOptions;

	public static bool hintsActive;

	private static int blockTipsCount;

	private static int heavyAttackTipsCount;

	private static int gadgetTipsCount;

	private static int throwableTipsCount;

	private static int meleeThrowableTipsCount;

	private static int kickTipsCount;

	private static int sprintOnLadderTipsCount;

	private static int getUpTipsCount;

	private static int stopDropRollTipCount;

	private static int spawnTipsCount;

	private static int quickSpawnTipsCount;

	private static int commandWheelTipsCount;

	private static int reinforcementTipsCount;

	public static HintManager Instance;

	public bool CanShowHint(HintTypes hintType)
	{
		return false;
	}

	public void ShowHint(HintTypes hintType)
	{
	}

	public void ShowCustomHint(string hint, string hintAdditionalDescription = "")
	{
	}

	private void _003CShowHint_003Eb__29_0()
	{
	}

	private void _003CShowCustomHint_003Eb__30_0()
	{
	}
}
