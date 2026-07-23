using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleHealth : HealthBase
{
	private sealed class _003CDefeat_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VehicleHealth _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDefeat_003Ed__51(int _003C_003E1__state)
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

	public bool destroyInsteadOfKillInKillfeed;

	public OnDestroyDriverAction onDestroyDriverAction;

	public bool takeLessMeleeDamageIfHasDriver;

	public Vector3 spawnPos;

	public Quaternion spawnRot;

	public float damageTakenFromTarget;

	private float poiseDamageBuildup;

	private float lastHitTime;

	private float lastPoiseHitTime;

	public ActiveRagdoll ragdoll;

	public Hitbox[] ignoreCollisionWithPlayerMovementHitboxes;

	public HitboxVehicle hitHitbox;

	public HitboxVehicle mainHitbox;

	public Transform spine;

	public VehicleBase vehicle;

	public AITarget aiTarget;

	[NonSerialized]
	public GameObject[] attachedProjectiles;

	[NonSerialized]
	public Transform[] attachedProjectilesOppositeTransform;

	[NonSerialized]
	public bool[] attachedProjectileIsOnRagdoll;

	public VehiclePart[] vehicleParts;

	public bool changeLayerOnDestroy;

	public bool hasGetHitAnimation;

	public bool canRagdoll;

	public bool teamColoredBlood;

	public AudioSource vehicleBreakAudioSource;

	public VehicleBreakSounds vehicleBreakSound;

	public AudioClip customVehicleBreakSound;

	public Collider[] enterInteraction;

	private Vector3 hitForceDirection;

	private Vector2 forwardVector2;

	private Vector2 attackerForwardVector2;

	private static readonly HitType hitType;

	public bool canBurn;

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

	private void SetSounds()
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

	public float GetRepaired(float healing)
	{
		return 0f;
	}

	public void DestroyWithoutRespawn()
	{
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
