using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Synty.Interface.FantasyWarriorHUD.Samples
{
	public class SampleXPBar : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<RectTransform, bool> _003C_003E9__9_0;

			public static Func<RectTransform, bool> _003C_003E9__9_1;

			internal bool _003CReset_003Eb__9_0(RectTransform c)
			{
				return false;
			}

			internal bool _003CReset_003Eb__9_1(RectTransform c)
			{
				return false;
			}
		}

		public Animator animator;

		public Slider xpSlider;

		public TMP_Text xpText;

		public TMP_Text levelText;

		public int xpPerLevelUp;

		private int currentLevel;

		private float currentXPNormalized;

		private float secondsPerLevelUp;

		private void Awake()
		{
		}

		private void Reset()
		{
		}

		private void Update()
		{
		}
	}
}
