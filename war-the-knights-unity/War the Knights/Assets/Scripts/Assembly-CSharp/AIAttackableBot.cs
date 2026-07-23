public class AIAttackableBot : AIAttackable
{
	public AITarget attackedBy1;

	public AITarget attackedBy2;

	public int attackedByCount;

	private static int maxAttackers;

	public AITarget[] chasedBy;

	public int chasedByCount;

	private static int maxChasers;

	public AITarget[] lookedAtBy;

	public int lookedAtByCount;

	private static int maxLookedAtBy;

	public override void AssignAttacker(AITarget attacker)
	{
	}

	public override void ForceAssignAttacker(AITarget attacker)
	{
	}

	private void AddAttacker(AITarget attacker)
	{
	}

	private void AddChaser(AITarget attacker)
	{
	}

	private void AddWatcher(AITarget attacker)
	{
	}

	private void RemoveAttacker(AITarget attacker)
	{
	}

	private void RemoveChaser(AITarget attacker)
	{
	}

	private int SelectFarthestAttacker()
	{
		return 0;
	}

	private int SelectFarthestChaser()
	{
		return 0;
	}

	private AITarget SelectBestAttackerFromChasers()
	{
		return null;
	}

	private AITarget SelectBestChaserFromWatchers()
	{
		return null;
	}

	private void RemoveWatcher(AITarget attacker)
	{
	}

	public override void CheckBestOfferableAttackBehavior()
	{
	}

	public override void UnassignAttacker(AITarget attacker)
	{
	}

	public override void HideFromView()
	{
	}
}
