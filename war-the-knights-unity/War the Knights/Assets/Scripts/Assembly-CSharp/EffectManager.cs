using System;
using System.Collections;
using System.Collections.Generic;
using EZObjectPools;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
	private sealed class _003CDestructionEffect_003Ed__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealthDestructible healthDestructible;

		public HealthDestructibleObject oldObject;

		public GameObject destructionPrefab;

		public Vector3 hitPoint;

		public Vector3 hitNormal;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDestructionEffect_003Ed__137(int _003C_003E1__state)
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

	private Vector3 positionToPlayEffectAt;

	private Quaternion rotationToPlayEffectAt;

	private Vector3 normalToPlayEffectAt;

	public PhysicsMaterial physicsMaterialDirt;

	public PhysicsMaterial physicsMaterialGrass;

	public PhysicsMaterial physicsMaterialGravel;

	public PhysicsMaterial physicsMaterialMetal;

	public PhysicsMaterial physicsMaterialWood;

	public PhysicsMaterial physicsMaterialWater;

	public PhysicsMaterial physicsMaterialSnow;

	public PhysicsMaterial physicsMaterialSand;

	public PhysicsMaterial physicsMaterialIce;

	public PhysicsMaterial physicsMaterialDust;

	public PhysicsMaterial physicsMaterialBloodPlayerTeam;

	public PhysicsMaterial physicsMaterialBloodEnemyTeam;

	public PhysicsMaterial physicsMaterialTerrain;

	public Color allyBloodColor1;

	public Color allyBloodColor2;

	public Color allyBloodColorSplat1;

	public Color allyBloodColorSplat2;

	public Color enemyBloodColor1;

	public Color enemyBloodColor2;

	public Color enemyBloodColorSplat1;

	public Color enemyBloodColorSplat2;

	public static EffectManager Instance;

	public ParticleSystemEffect[] particleHitDefault;

	public ParticleSystemEffect[] particleHitWood;

	public ParticleSystemEffect[] particleHitMetal;

	public ParticleSystemEffect[] particleHitDirt;

	public ParticleSystemEffect[] particleHitSand;

	public ParticleSystemEffect[] particleHitSnow;

	public ParticleSystemEffect[] particleHitIce;

	public ParticleSystemEffect[] particleHitWater;

	public ParticleSystemEffect[] particleHitWaterLarge;

	public ParticleSystemEffect[] particleHitDust;

	public ParticleSystemEffect[] particleHitWeaponSpark;

	public ParticleSystemEffect particleHitBloodPlayerTeam;

	public ParticleSystemEffect particleHitBloodBigPlayerTeam;

	public ParticleSystemEffect particleHitBloodEnemyTeam;

	public ParticleSystemEffect particleHitBloodBigEnemyTeam;

	public ParticleSystemEffect particleHitHorseMovementDirt;

	public ParticleSystemEffect particleHitHorseMovementSnow;

	public ParticleSystemEffect[] particleFireHit;

	public EZObjectPool particleExplosionPool;

	public EZObjectPool particleExplosionBigPool;

	public EZObjectPool particleExplosionWaterPool;

	public EZObjectPool particleExplosionDirtPool;

	public EZObjectPool particleExplosionSandPool;

	public EZObjectPool particleExplosionSnowPool;

	public EZObjectPool particleExplosionStonePool;

	public EZObjectPool particleExplosionFlamePool;

	public EZObjectPool particleDebrisGenericPool;

	public EZObjectPool particleDebrisGenericLargePool;

	public EZObjectPool particleDebrisExplosionPool;

	public EZObjectPool fireLightFadeOutPool;

	private static ParticleSystem.EmitParams particleEffectEmitParams;

	public FireLight fireLightPrefab;

	public Color fireColor;

	public ParticleSystem burningMeshParticleSystem;

	public ParticleSystem botHealParticleSystem;

	public static float fireBurnDamageTimer;

	public static int fireBurnDamageCurrentIndex;

	public static List<FireEffect> fireEffectPool;

	public static int fireEffectPoolCount;

	public static int fireEffectCurrentCount;

	public static ParticleSystem.Particle[] particleCache;

	public ParticleSystem fireEffectParticleSystem;

	public ParticleSystem fireEffectSmallParticleSystem;

	private static ParticleSystem.EmitParams fireEmitParams;

	public ParticleSystem[] debrisParticleSystemStone;

	public ParticleSystem[] debrisParticleSystemWood;

	public ParticleSystem[] debrisParticleSystemGlass;

	public ParticleSystem particleDebrisSpawner;

	public ParticleSystem[] particleDebrisPhysicsInteraction;

	public DestructibleMaterial[] particleDebrisPhysicsInteractionMaterials;

	public ParticleSystem[] breakParticleSystemStone;

	public ParticleSystem[] breakParticleSystemWood;

	public ParticleSystem[] breakParticleSystemGlass;

	public ParticleSystem fireDebrisSmall;

	public ParticleSystem fireDebrisBigWithSmoke;

	private static ParticleSystem.EmitParams fireDebrisEmitParams;

	public static ParticleSystem.Particle[] fireParticles;

	private static ParticleSystem.ShapeModule shapeModuleDebris;

	private static ParticleSystem.EmitParams debrisParticleSystemEmitParams;

	private static ParticleSystem.EmitParams debrisVelocityParticleSystemEmitParams;

	private static ParticleSystem.EmitParams debrisSecondaryParticleSystemEmitParams;

	public static ParticleSystem.EmitParams debrisSmokeParticleSystemEmitParams;

	private static readonly Collider[] particleOverlapCheckColliderCache;

	private static readonly LayerMask particleOverlapCheckLayerMask;

	private static Vector3 fireExtinguishBoundExtension;

	public ParticleSystem decalBlood;

	public ParticleSystem particleBloodImpactPlayerTeam;

	public ParticleSystem particleBloodImpactEnemyTeam;

	public Color colorBloodPlayerTeam;

	public Color colorBloodPlayerTeam2;

	public Color colorBloodEnemyTeam;

	public Color colorBloodEnemyTeam2;

	private Color colorBloodPlayerTeamShadowed;

	private Color colorBloodEnemyTeamShadowed;

	public ParticleSystemEffect decalSlashImpact;

	public ParticleSystemEffect decalArrowImpact;

	public ParticleSystemEffect decalStabImpact;

	public ParticleSystemEffect decalBluntImpact;

	public ParticleSystemEffect decalScratchImpact;

	public ParticleSystemEffect decalExplosion;

	public ParticleSystemEffect decalExplosionSmall;

	public ParticleSystemEffect decalFootprint;

	public LayerMask raycastHitCheckLayerMask;

	private float decalSize;

	private Vector3 decalExtents;

	private static ParticleSystem.EmitParams bloodDecalEmitParams;

	private static ParticleSystem.EmitParams decalEmitParams;

	public void SetFXLighting()
	{
	}

	public void SetParticleLightingColors(ParticleSystemEffect particleSystemEffect)
	{
	}

	public void SetParticleLightingColors(ParticleSystemEffect[] particleSystemEffects)
	{
	}

	public void RefreshPools()
	{
	}

	public VisualImpactEffects GetEffectFromWeaponMaterial(WeaponBlockEffectPhysicsMaterial weaponEffectPhysicsMaterial)
	{
		return VisualImpactEffects.DefaultOrStone;
	}

	public PhysicsMaterial GetPhysicsMaterialFromWeaponMaterial(WeaponBlockEffectPhysicsMaterial weaponEffectPhysicsMaterial)
	{
		return null;
	}

	public VisualImpactEffects GetEffectFromPhysicsMaterial(PhysicsMaterial physicMaterial)
	{
		return VisualImpactEffects.DefaultOrStone;
	}

	public VisualImpactEffects GetEffectFromTerrain(float positionX, float positionZ)
	{
		return VisualImpactEffects.DefaultOrStone;
	}

	public void SpawnImpactEffectWithImpactNormal(Vector3 position, Vector3 normal, VisualImpactEffects effect, bool playSound, float pitch, bool playEffect = true)
	{
	}

	public void SpawnImpactEffectWithImpactDeflectOffOfNormal(Vector3 position, Vector3 normal, Vector3 impactDirection, VisualImpactEffects effect, bool playSound, float pitch, bool playEffect = true)
	{
	}

	public void SpawnImpactEffectWithRotation(Vector3 position, Quaternion rotation, VisualImpactEffects effect, bool playSound, float pitch, bool playEffect = true)
	{
	}

	public void SpawnVisualEffectWithImpactNormal(Vector3 position, Vector3 normal, VisualEffects effect, bool playSound)
	{
	}

	private void SpawnEffect(ref VisualEffects effect, bool playSound)
	{
	}

	private void SpawnEffect(ref VisualImpactEffects effect, bool playSound, float pitch, bool playEffect)
	{
	}

	private void SpawnEffect(AdditionalVisualEffects effect)
	{
	}

	private bool IsParticlePositionShadowed()
	{
		return false;
	}

	private void PlayParticleEffect(ref ParticleSystemEffect[] effects, bool shadowed)
	{
	}

	private void PlayParticleEffect(ref ParticleSystemEffect effect, bool shadowed)
	{
	}

	public void SpawnFireDebris(bool bigDebris, Vector3 position, Vector3 surfaceNormal, int debrisAmount, bool sphereInsteadOfCone, float coneAngle)
	{
	}

	public void FireDamage()
	{
	}

	public bool SpawnFireInRadius(Vector3 position, Vector3 surfaceNormal, bool smallFire, AITarget damageSource)
	{
		return false;
	}

	public bool SpawnFire(Vector3 position, Vector3 surfaceNormal, bool smallFire, AITarget damageSource, bool shorterDuration = false)
	{
		return false;
	}

	public void InitializeFireEffectPool()
	{
	}

	private FireEffect GetFireEffectFromPool()
	{
		return null;
	}

	public void StartDestructionEffect(HealthDestructible healthDestructible, HealthDestructibleObject oldObject, GameObject destructionPrefab, Vector3 hitPoint, Vector3 hitNormal)
	{
	}

	private static IEnumerator DestructionEffect(HealthDestructible healthDestructible, HealthDestructibleObject oldObject, GameObject destructionPrefab, Vector3 hitPoint, Vector3 hitNormal)
	{
		return null;
	}

	public void SpawnBloodDecalWithImpactNormal(Vector3 position, Vector3 normal, bool playerTeamBloodColor)
	{
	}

	private void PlayBloodDecalEffect(bool playerTeam)
	{
	}

	public void SpawnMeleeImpactDecal(Vector3 position, Vector3 normal, DecalEffect decalEffect, float size, Quaternion rotation)
	{
	}

	public void SpawnDecalWithImpactNormal(Vector3 position, Vector3 normal, DecalEffect decalEffect, float size)
	{
	}

	private void PlayDecalEffect(ref DecalEffect decalEffect)
	{
	}
}
