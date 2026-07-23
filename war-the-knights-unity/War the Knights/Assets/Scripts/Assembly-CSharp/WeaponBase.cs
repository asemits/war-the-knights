using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
	public Animator anim;

	public AIBehaviorBot bot;

	public bool isBot;

	public abstract void PlayerStart();

	public abstract void BotStart();

	public abstract void BotAttack();

	public abstract void BotCancelAttack();

	public abstract void BlockHit(bool breakBlock);

	public abstract void Kick();
}
