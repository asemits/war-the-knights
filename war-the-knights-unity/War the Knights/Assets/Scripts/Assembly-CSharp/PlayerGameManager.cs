using System;
using System.Collections;
using System.Collections.Generic;
using HorizonBasedAmbientOcclusion;
using UnityEngine;

public class PlayerGameManager : MonoBehaviour
{
	private sealed class _003CStartMatchAfterFirstSpawnWaitTime_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerGameManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartMatchAfterFirstSpawnWaitTime_003Ed__90(int _003C_003E1__state)
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

	public bool isRunning;

	public bool isMoving;

	public bool ableToMove;

	public bool isGrapelling;

	public bool isCrouching;

	public bool isInVehicle;

	public bool isInMenu;

	public bool isInSpawnMenu;

	public bool closedMenu;

	public bool isAttacking;

	public bool isInAir;

	public bool isInPauseMenu;

	public bool isAiming;

	public bool isChargingWeapon;

	public bool isBlocking;

	public bool isSwimming;

	public bool isSwimmingOnSurface;

	public bool isDead;

	public bool isInCutscene;

	public bool isInCircleMenu;

	public bool isWallrunning;

	public bool isFallingDown;

	public bool isPaused;

	public bool isReloading;

	public bool isOnLadder;

	public bool isPlacingGadget;

	public bool isRagdolled;

	public bool isInThirdPerson;

	public float aimOrBlockMovementMultiplier;

	public CoolMove currentCoolMove;

	public float timeLastLanded;

	public float sensitivityHorizontal;

	public float sensitivityVertical;

	public float sensitivityHorizontalAiming;

	public float sensitivityVerticalAiming;

	public float sensitivityMultiplierScope;

	public SimpleSmoothMouseLook mouseLook;

	private Coroutine killSlowMotionCoroutine;

	public BattleStatus currentBattleStatus;

	public TeamStatus dominatingFaction;

	public int ticketsNeeded;

	private int ticketsTeam1;

	private int ticketsTeam2;

	public int respawnTime;

	public float pointCaptureDuration;

	public float ticketAddTimer;

	public float timeIntervalTicketGain;

	public int ticketsGainAmountDominating;

	public int ticketsGainAmountDefeat;

	public bool quickStart;

	public bool quickStartTeam2;

	public bool firstSpawn;

	public bool mapSideChosenByPlayerIsSide1;

	public Camera mapCameraPrefab;

	public HBAO hbaoFirstPerson;

	public HBAO hbaoThirdPerson;

	public HBAO hbaoMapCamera;

	public bool showEndScreenOnVictoryOrDefeat;

	public bool currentPointShownOnHud;

	public bool currentPointRatioShownOnHud;

	public EffectManager impactManagerInstance;

	public InteractionRaycast interactionRaycastInstance;

	public PlayerStats playerStatsInstance;

	public UIManager uiManagerInstance;

	public VehicleManager vehicleManagerInstance;

	public WeaponManager weaponmangerInstance;

	public AIManager aiManagerInstance;

	public SoundManager soundManagerInstance;

	public SkyManager skyManagerInstance;

	public HintManager hintManagerInstance;

	public static PlayerGameManager Instance;

	private Coroutine startMatchAfterFirstSpawnWaitTimeCoroutine;

	public bool aiStarted;

	private bool matchScoringEnded;

	public bool isInKillSlowMotion;

	public int TicketsTeam1
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int TicketsTeam2
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public bool CanUse()
	{
		return false;
	}

	public bool CanSprint()
	{
		return false;
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	public void CalculateDominatingFaction()
	{
	}

	public void StartMatchAfterChoosingLoadout()
	{
	}

	public void StartMatchAfterInspiring()
	{
	}

	public void StartMatchAfterFirstSpawn()
	{
	}

	private IEnumerator StartMatchAfterFirstSpawnWaitTime()
	{
		return null;
	}

	public void EndMatch(bool winningTeamIsTeam1)
	{
	}

	public void FighterDefeated(bool team1)
	{
	}

	public void SetTimescale(float timescale)
	{
	}
}
