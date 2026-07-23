using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBreakable : HealthBase
{
	private sealed class _003CDefeat_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealthBreakable _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDefeat_003Ed__27(int _003C_003E1__state)
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

	public HitboxBreakable hitHitbox;

	public HitboxBreakable mainHitbox;

	public DestructibleMaterial soundAndEffectMaterial;

	public AudioClip customBreakingSound;

	public MeshRenderer breakableMesh;

	public GameObject destroyedObjectDebrisPhysicsPrefab;

	private static readonly HitType hitType;

	private string healthName;

	public bool hasFireSurfaceBurnEffect;

	public bool canBurn;

	public bool startBurningWhenTakingDamage;

	public float startBurningWhenHealthIsLowerThanPercentage;

	public bool explodeWhenDestroyed;

	public bool createsEnvironmentFlames;

	public bool scattersFlameDebris;

	public int flameDebrisCount;

	public SplashDamage splashDamage;

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

	public override void SetTeamColors()
	{
	}

	public override Vector3 GetCurrentCorrectedForwardDirection()
	{
		return default(Vector3);
	}
}
