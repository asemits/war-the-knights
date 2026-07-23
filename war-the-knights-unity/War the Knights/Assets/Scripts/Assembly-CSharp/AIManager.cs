using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIManager : MonoBehaviour
{
	public class BotDistanceStatuses
	{
		public List<AllBotDistances> distances;

		public List<AITarget> teamRespawning;
	}

	public class BotDistances
	{
		public int pointIndex;

		public float distance;
	}

	public class AllBotDistances
	{
		public List<BotDistances> distances;

		public AITarget bot;
	}

	public class BotVisibility
	{
		public bool visibleToBot1;

		public bool visibleToBot2;

		public AITarget botTeam1;

		public AITarget botTeam2;

		public float distance;

		public int visibilityCheckPausedForFrames;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<AllBotDistances, AITarget> _003C_003E9__71_0;

		public static Func<AllBotDistances, AITarget> _003C_003E9__71_1;

		public static Func<BotDistances, float> _003C_003E9__72_0;

		public static Func<AllBotDistances, float> _003C_003E9__74_0;

		internal AITarget _003CAssignObjectivesPerTeam_003Eb__71_0(AllBotDistances o)
		{
			return null;
		}

		internal AITarget _003CAssignObjectivesPerTeam_003Eb__71_1(AllBotDistances o)
		{
			return null;
		}

		internal float _003CGetBotDistancesFromPoints_003Eb__72_0(BotDistances o)
		{
			return 0f;
		}

		internal float _003CAssignBotsBasedOnDistance_003Eb__74_0(AllBotDistances o)
		{
			return 0f;
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public int i;

		public Predicate<BotDistances> _003C_003E9__2;

		internal bool _003CAssignObjectivesPerTeam_003Eb__2(BotDistances o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public int i;

		public Predicate<BotDistances> _003C_003E9__1;

		internal bool _003CAssignBotsBasedOnDistance_003Eb__1(BotDistances o)
		{
			return false;
		}
	}

	private sealed class _003CRespawnCountdown_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AIManager _003C_003E4__this;

		public AITarget target;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRespawnCountdown_003Ed__77(int _003C_003E1__state)
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

	private sealed class _003CVehicleRespawnCountdown_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AITarget vehicle;

		public AIManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CVehicleRespawnCountdown_003Ed__80(int _003C_003E1__state)
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

	public int botsTeam1;

	public int botsTeam2;

	public AIPointBehaviorPrioritization aIPointBehaviorPrioritizationTeam1;

	public AIPointBehaviorPrioritization aIPointBehaviorPrioritizationTeam2;

	private int noDefendablePointsTeam1;

	private int noDefendablePointsTeam2;

	public int maxAttackersPerUnit;

	public int maxChasersPerUnit;

	public const float attackRateKick = 1.2f;

	public int botCountTotal;

	public AITarget[] bots;

	public BotVisibility[][] botVisibility;

	public Material blueMainMat;

	public Material blueHeadMat;

	public Material redMainMat;

	public Material redHeadMat;

	public GameObject botPrefab;

	public LayerMask viewRayLayermask;

	public LayerMask botBaseOnlyLayermask;

	public LayerMask attackLayermask;

	public LayerMask floorCollisionLayerMask;

	public LayerMask footstepCheckLayerMask;

	public static readonly LayerMask navmeshBotLayerMask;

	public static readonly LayerMask navmeshBotAreaMask;

	public static NavMeshPath navMeshPath;

	public AnimationCurve jumpNavmeshLinkHorizontalCurve;

	public int botToCheck;

	public CombatBehaviorConfig[] combatBehaviorConfig;

	public CustomHelmet[] helmets;

	public GameObject[] hairStyles;

	public SphereCollider vehicleTrigger;

	public List<VehicleBase> vehicles;

	public List<CapturePoint> attackablePointsTeam1;

	public List<CapturePoint> attackablePointsTeam2;

	public List<CapturePoint> defensePointsTeam1;

	public List<CapturePoint> defensePointsTeam2;

	public List<CapturePoint> allPointsTeam1;

	public List<CapturePoint> allPointsTeam2;

	public List<CapturePoint> temporaryCapturePointList;

	private int capturePointCountTotal;

	public int botRespawnTime;

	public const float minWaitTimeBeforeChoosingNewObjectivePoint = 3f;

	public const float maxWaitTimeBeforeChoosingNewObjectivePoint = 9f;

	public const float standingHeightY = 1.73f;

	public const float crouchingHeightY = 1.23f;

	public const float maxViewDotProductAngle = 0.38f;

	public WeaponMelee[] botMeleeWeapons;

	public int botMeleeWeaponsCount;

	public WeaponGun[] botBows;

	public int botBowsCount;

	public WeaponGun[] botCrossbows;

	public int botCrossbowsCount;

	public WeaponGun[] botMagicWeapons;

	public int botMagicWeaponsCount;

	public WeaponShield[] botShields;

	public int botShieldsCount;

	public int navmeshAreaMaskBots;

	public int navmeshAreaMaskSmallVehicles;

	public static AIManager Instance;

	private static List<CapturePoint> allPossibleTeamSpawnPoints;

	private WaitForSeconds WaitForBotRespawnTimer;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void StartAI()
	{
	}

	public void SpawnVehicleEnterTrigger(VehicleBase vehicle)
	{
	}

	public void SpawnTeams()
	{
	}

	public void UpdateObjectiveGoals()
	{
	}

	public void AssignObjectivesPerTeam(ref List<AllBotDistances> botDistances, ref List<AITarget> respawningBots, ref List<CapturePoint> attackablePoints, ref List<CapturePoint> defensePoints, bool team1)
	{
	}

	public BotDistanceStatuses GetBotDistancesFromPoints(ref List<AITarget> botsToCheck, ref List<CapturePoint> connectedPoints, int connectedPointsCount, bool attack)
	{
		return null;
	}

	public BotDistanceStatuses GetBotDistancesForRespawningBotsFromPoints(ref List<AITarget> botsToCheck, int connectedPointsCount)
	{
		return null;
	}

	public int AssignBotsBasedOnDistance(ref List<AllBotDistances> distances, ref int[] assignedBotsCounter, ref List<CapturePoint> points, bool attack, bool team1, bool fillCompletely)
	{
		return 0;
	}

	private int GetMaxAttackersPerObjective(bool team1, int attackablePointCount, bool fillPointsWhenNoDefenseOnesAreAvailable)
	{
		return 0;
	}

	public void RespawnBot(AITarget bot)
	{
	}

	public IEnumerator RespawnCountdown(AITarget target)
	{
		return null;
	}

	public void BotDefeat(AITarget target)
	{
	}

	public void RespawnVehicle(AITarget vehicle)
	{
	}

	public IEnumerator VehicleRespawnCountdown(AITarget vehicle)
	{
		return null;
	}

	public void VehicleDefeat(AITarget vehicle)
	{
	}
}
