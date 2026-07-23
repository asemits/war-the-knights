using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotHealth : HealthBase
{
	private sealed class _003CDefeat_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BotHealth _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDefeat_003Ed__42(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public Collider[] colliders;

	public Hitbox[] hitboxes;

	public AITarget aiTarget;

	public float damageTakenFromTarget;

	public float blockDamageBuildup;

	public float poiseDamageBuildup;

	private float lastHitTime;

	private float lastBlockHitTime;

	private float lastPoiseHitTime;

	public ActiveRagdoll ragdoll;

	public HitboxBot hitHitbox;

	public bool hitBlockHitbox;

	public HitboxBot chestHitbox;

	public HitboxBot chestHitboxRagdoll;

	public HitboxBot upperChestHitbox;

	public HitboxBot upperChestHitboxRagdoll;

	public HitboxBot leftHandHitbox;

	public HitboxBot rightHandHitbox;

	public Transform spine;

	public Transform head;

	public Transform upperSpine;

	public bool lostHelmet;

	public TwoRenderers armorRenderer;

	[NonSerialized]
	public GameObject[] attachedProjectiles;

	[NonSerialized]
	public Transform[] attachedProjectilesOppositeTransform;

	[NonSerialized]
	public bool[] attachedProjectileIsOnRagdoll;

	private Vector2 forwardVector2;

	private Vector2 attackerForwardVector2;

	private static readonly HitType hitType;

	public override string HealthName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override bool FireSurfaceBurnEffect => false;

	public override bool CanTakeFireDamage => false;

	public override bool CanBurnWhilstDefeated => false;

	private void Start()
	{
	}

	public override HitType GetHit(float damage, float poiseDamage, DamageTypes damageType, AITarget damageSource, bool isCritical, Vector3 hitPoint, Vector3 force, bool playImpactEffectAndSound, Vector3 hitNormal)
	{
		return null;
	}

	public override void GetStaggered(Vector3 attackOrigin, AITarget damageSource, Vector3 hitPoint, Vector3 force)
	{
	}

	public override float GetHealed(float healing, float maxOverheal = 0f)
	{
		return 0f;
	}

	public override IEnumerator Defeat()
	{
		return null;
	}

	public override void Respawn()
	{
	}

	public override void SetTeamColors()
	{
	}

	public override Vector3 GetCurrentCorrectedForwardDirection()
	{
		return default(Vector3);
	}
}
