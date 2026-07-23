using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDestructible : HealthBase
{
	private sealed class _003CDefeat_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealthDestructible _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDefeat_003Ed__38(int _003C_003E1__state)
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

	public HealthDestructibleObject aliveObject;

	public HealthDestructibleObject destroyedObject;

	public GameObject debrisPrefab;

	public HealthDestructibleObject aliveObjectRebuilt;

	public HealthDestructibleObject destroyedObjectRebuilt;

	public GameObject rebuiltDebrisPrefab;

	public bool spawnDestroyed;

	public bool repairable;

	public bool repairingRestoresStructuralIntegrity;

	private bool hasBeenRebuilt;

	private HealthDestructibleState currentHealthDestructibleState;

	public VehicleBase[] connectedStationaryVehicles;

	public NavLinkPointMover[] connectedLadders;

	private static readonly HitType hitType;

	private string healthName;

	public bool canBurn;

	public bool canBurnRebuiltVersion;

	public int structuralIntegrityHealth;

	public int structuralIntegrityCurrentHealth;

	public StructuralIntegrity[] structuralIntegrity;

	private bool topPartMissing;

	private bool bottomPartMissing;

	public bool canTakeMeleeDamage;

	public HitboxDestructible hitHitbox;

	private Vector3 hitPoint;

	private Vector3 hitNormal;

	public AITarget damageSource;

	public bool collapse;

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

	private void Awake()
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

	public void TakeStructuralIntegrityDamage(int damage, AITarget damageSource, Vector3 hitNormal)
	{
	}

	public void RepairStructuralIntegrity(int repairAmount, AITarget repairSource)
	{
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

	public void Test()
	{
	}
}
