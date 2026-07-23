using System;

[Serializable]
public class CombatBehaviorConfig
{
	public CombatBehavior combatBehavior;

	public float chaseDistanceMin;

	public float chaseDistanceMax;

	public float fleeDistance;

	public float attackDistance;

	public float attackFrequency;

	public float attackFrequencyHeavy;

	public float attackFrequencyChargeMin;

	public float attackFrequencyChargeMax;

	public float howLongToWaitAfterVisibilityLossTime;

	public float forgetTime;

	public int viewDistance;

	public string GetBehaviorTitle()
	{
		return null;
	}
}
