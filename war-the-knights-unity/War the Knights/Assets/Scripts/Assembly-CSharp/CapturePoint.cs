using System.Collections.Generic;
using UnityEngine;

public class CapturePoint : MonoBehaviour
{
	public int team1Fighters;

	public int team2Fighters;

	private float _captureProgress;

	public Transform flagTransform;

	public Vector3 flagLocalPositionRaised;

	public Vector3 flagLocalPositionLowered;

	public Cloth flagCloth;

	public Transform hudPointPosition;

	public Vector3 position;

	public CapturePoint[] connectedPoints;

	public string capturePointName;

	public string capturePointLetter;

	public AreaBounds[] archerDefensePositionArea;

	private TeamStatus _status;

	private bool _fullyCaptured;

	public bool uncapturable;

	public int pointIndex;

	public int allPointIndex;

	public Vector3 retreatDirection;

	public Renderer[] flagMaterials;

	public Material flagTeam1Material;

	public Material flagTeam2Material;

	public Material flagNeutralMaterial;

	public List<Vector3> spawnPositions;

	public List<Vector3> spawnPositionsPlayer;

	public Transform customSpawnConnection;

	public static readonly Collider[] overlaps;

	public static readonly Vector3 sphereCastOffset;

	public static readonly Vector3 overlapCheckOffset;

	public float CaptureProgress
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public TeamStatus Status
	{
		get
		{
			return TeamStatus.None;
		}
		set
		{
		}
	}

	public bool FullyCaptured
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void InitializeOnStart()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void RemoveFighter(AIAlliance alliance)
	{
	}

	public bool CanSpawn(bool team1)
	{
		return false;
	}

	private bool TransformExtentsFromLocalToWorldSpaceOfParent(ref Vector3[] extents, ref Vector3 center, Transform from, Transform to)
	{
		return false;
	}

	public bool GenerateSpawnPositions()
	{
		return false;
	}

	public Vector3 GetSpawnPos(bool team1, int areaMask)
	{
		return default(Vector3);
	}

	public Vector3 GetSpawnPosPlayer(bool team1, int areaMask)
	{
		return default(Vector3);
	}

	public Vector3 GetPointPos(bool attacking, CombatBehavior behavior, int areaMask)
	{
		return default(Vector3);
	}
}
