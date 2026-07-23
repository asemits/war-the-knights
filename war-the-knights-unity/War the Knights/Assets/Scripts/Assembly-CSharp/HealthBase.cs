using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HealthBase : MonoBehaviour
{
	private sealed class _003CFireDamageOverTime_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealthBase _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFireDamageOverTime_003Ed__41(int _003C_003E1__state)
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

	public float currentHealth;

	public float maxHealth;

	public AIAlliance alliance;

	public AITarget lastDamageSource;

	public bool defeated;

	public MeshRenderer meshRendererToPlayFireEffectOn;

	public MeshRenderer meshRendererToPlayFireEffectOnWhenRagdolledOrDestroyed;

	public SkinnedMeshRenderer skinnedMeshRendererToPlayFireEffectOn;

	public SkinnedMeshRenderer skinnedMeshRendererToPlayFireEffectOnWhenRagdolledOrDefeated;

	private bool fireEmitsLight;

	public GameObject objectToEmitFireLightFrom;

	public GameObject objectToEmitFireLightFromWhenRagdolledOrDestroyed;

	private bool canPlayFireEffect;

	private bool usingFireSkinnedMeshRenderer;

	public AITarget fireDamageSource;

	private ParticleSystem instantiatedFireParticles;

	private FireLight fireLight;

	public float fireDamageBuildup;

	public bool isOnFire;

	public Coroutine fireDamageOverTimeCoroutine;

	private static readonly WaitForSeconds fireDamageTimer;

	private ParticleSystem.ShapeModule shapeModule;

	private ParticleSystem.ShapeModule shapeModuleSurface;

	private bool useDestroyedOrDefeatedFireEffect;

	public abstract string HealthName { get; set; }

	public abstract bool FireSurfaceBurnEffect { get; }

	public abstract bool CanTakeFireDamage { get; }

	public abstract bool CanBurnWhilstDefeated { get; }

	public abstract HitType GetHit(float damage, float poiseDamage, DamageTypes damageType, AITarget damageSource, bool isCritical, Vector3 hitPoint, Vector3 force, bool playImpactEffectAndSound, Vector3 hitNormal);

	public abstract void GetStaggered(Vector3 attackOrigin, AITarget damageSource, Vector3 hitPoint, Vector3 force);

	public abstract float GetHealed(float healing, float maxOverheal = 0f);

	public abstract IEnumerator Defeat();

	public abstract void Respawn();

	public abstract void SetTeamColors();

	public abstract Vector3 GetCurrentCorrectedForwardDirection();

	public void GetHitFireDamage(float fireDamage, AITarget damageSource)
	{
	}

	private IEnumerator FireDamageOverTime()
	{
		return null;
	}

	public void StartFireDamage()
	{
	}

	public void ChangeFireParticleMesh(bool destroyedOrRagdoll)
	{
	}

	public void StopFireDamage(bool fadeFireOutInPlace = false)
	{
	}
}
