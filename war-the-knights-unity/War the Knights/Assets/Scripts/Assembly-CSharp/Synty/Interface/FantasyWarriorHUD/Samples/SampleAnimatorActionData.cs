using System;
using UnityEngine;

namespace Synty.Interface.FantasyWarriorHUD.Samples
{
	[Serializable]
	public class SampleAnimatorActionData
	{
		public enum AnimatorActionType
		{
			Trigger = 0,
			Bool = 1,
			Float = 2,
			Int = 3
		}

		public Animator animator;

		public AnimatorActionType type;

		public string parameterName;

		public bool boolToggle;

		public bool boolValue;

		public float floatValue;

		public int intValue;

		public void Execute()
		{
		}
	}
}
