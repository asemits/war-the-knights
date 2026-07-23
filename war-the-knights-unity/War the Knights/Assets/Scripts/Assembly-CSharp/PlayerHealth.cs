using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : HealthBase
{
	private sealed class _003CDefeat_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerHealth _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDefeat_003Ed__47(int _003C_003E1__state)
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

	private sealed class _003CHealOverTime_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerHealth _003C_003E4__this;

		public int amount;

		private float _003CamountLeft_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHealOverTime_003Ed__54(int _003C_003E1__state)
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

	private sealed class _003CHealthRegen_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerHealth _003C_003E4__this;

		private float _003ChealthRegenThreshold_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHealthRegen_003Ed__55(int _003C_003E1__state)
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

	private float blockDamageBuildup;

	private float poiseDamageBuildup;

	private float lastHitTime;

	private float lastBlockHitTime;

	private float lastPoiseHitTime;

	public ActiveRagdoll ragdoll;

	public HitboxPlayer hitHitbox;

	public bool hitBlockHitbox;

	public HitboxPlayer chestHitbox;

	public HitboxPlayer chestHitboxRagdoll;

	public HitboxPlayer upperChestHitbox;

	public HitboxPlayer upperChestHitboxRagdoll;

	public HitboxPlayer leftHandHitbox;

	public HitboxPlayer rightHandHitbox;

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

	public Coroutine healthRegenCoroutine;

	public int healthDrinkCount;

	public int healthDrinkMax;

	public TextMeshProUGUI healthDrinkText;

	public DamageIndicator damageIndicator;

	private static readonly WaitForSeconds WaitForHealIntervalTimer;

	private static readonly WaitForSeconds WaitForQuickHealthRegenTimer;

	private static readonly WaitForSeconds WaitForSlowHealthRegenTimer;

	private static readonly WaitForSeconds WaitForHealthRegenIntervalTimer;

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

	public override IEnumerator Defeat()
	{
		return null;
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

	public override void Respawn()
	{
	}

	public void ToggleProjectileVisibility(bool enable)
	{
	}

	public void HealPlayerOverTime(int amount)
	{
	}

	private IEnumerator HealOverTime(int amount)
	{
		return null;
	}

	private IEnumerator HealthRegen()
	{
		return null;
	}

	public override void SetTeamColors()
	{
	}

	public override Vector3 GetCurrentCorrectedForwardDirection()
	{
		return default(Vector3);
	}
}
