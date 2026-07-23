using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MapManager : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CapturePoint, bool> _003C_003E9__58_0;

		public static Func<CapturePoint, bool> _003C_003E9__58_1;

		public static TweenCallback _003C_003E9__65_0;

		public static TweenCallback _003C_003E9__65_1;

		internal bool _003CSetupAIAndPointsAfterChoosingSide_003Eb__58_0(CapturePoint p)
		{
			return false;
		}

		internal bool _003CSetupAIAndPointsAfterChoosingSide_003Eb__58_1(CapturePoint p)
		{
			return false;
		}

		internal void _003COpeningCamShot_003Eb__65_0()
		{
		}

		internal void _003COpeningCamShot_003Eb__65_1()
		{
		}
	}

	private sealed class _003CEndingCamShot_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapManager _003C_003E4__this;

		private float _003CoriginalFov_003E5__2;

		private Transform _003Ccam_003E5__3;

		private Quaternion _003CoriginalRotation_003E5__4;

		private Vector3 _003CoriginalPosition_003E5__5;

		private float _003Ctime_003E5__6;

		private float _003CmoveDuration_003E5__7;

		private bool _003CshownPoints_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CEndingCamShot_003Ed__66(int _003C_003E1__state)
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

	private sealed class _003CMoveCamToSpawn_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Camera targetCameraToSwitchTo;

		public MapManager _003C_003E4__this;

		private Transform _003Cmap_003E5__2;

		private Quaternion _003CoriginalRotation_003E5__3;

		private Vector3 _003CoriginalPosition_003E5__4;

		private float _003CoriginalFov_003E5__5;

		private float _003CoriginalFogDensity_003E5__6;

		private float _003Ctime_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveCamToSpawn_003Ed__64(int _003C_003E1__state)
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

	private sealed class _003CMoveSpawnCam_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapManager _003C_003E4__this;

		private float _003CoriginalFov_003E5__2;

		private Quaternion _003CoriginalRotation_003E5__3;

		private Vector3 _003CoriginalPosition_003E5__4;

		private float _003CoriginalFogDensity_003E5__5;

		private float _003Ctime_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveSpawnCam_003Ed__63(int _003C_003E1__state)
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

	private sealed class _003COpeningCamShot_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapManager _003C_003E4__this;

		private Transform _003Ccam_003E5__2;

		private Quaternion _003CoriginalRotation_003E5__3;

		private Vector3 _003CoriginalPosition_003E5__4;

		private float _003CoriginalFov_003E5__5;

		private float _003Ctime_003E5__6;

		private float _003CmoveDuration_003E5__7;

		private bool _003CshownTitleCard_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpeningCamShot_003Ed__65(int _003C_003E1__state)
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

	public string mapName;

	public string[] mapLocacalizationNames;

	public string mapSide1Name;

	public string[] mapSide1LocacalizationNames;

	public string mapSide2Name;

	public string[] mapSide2LocacalizationNames;

	public bool mapSide2ShowOnLeftInSideSelectionMenu;

	public Terrain mapTerrain;

	public Transform mapTerrainTransform;

	public float mapTerrainPositionX;

	public float mapTerrainPositionZ;

	public float mapTerrainSizeX;

	public float mapTerrainSizeZ;

	public int mapTerrainAlphaMapWidth;

	public int mapTerrainAlphaMapHeight;

	public PhysicsMaterial[,] mapTerrainSurfacePhysicsMaterial;

	private bool hasMapTerrain;

	public List<PhysicsMaterial> terrainMaterialLayersList;

	public PhysicsMaterial[] terrainMaterialLayers;

	public AINavmeshBaker aiNavmeshBaker;

	public List<VehicleSpawn> vehicleSpawns;

	public List<CapturePoint> capturePoints;

	public List<CapturePoint> basePoints;

	public List<CapturePoint> allPoints;

	public List<CapturePoint> basePointsTeam1;

	public List<CapturePoint> basePointsTeam2;

	public PointFlow[] pointFlow;

	public int capturePointsTotal;

	public int capturePointsHeldByTeam1;

	public int capturePointsHeldByTeam2;

	public Transform openingShotCameraPos;

	public Vector3 mapCameraPosition;

	public Quaternion mapCameraRotation;

	public AmbientSound ambientSound;

	public AudioClip customAmbientSoundClip;

	public float customAmbientSoundVolume;

	public bool hasWind;

	public WindZone wind;

	public bool hasSun;

	public Transform sunLightTransform;

	public Light sunLight;

	public bool noSunLight;

	public Weather defaultMapWeather;

	public bool customWeather;

	public bool customWeatherHasSnow;

	public CloudsPreset customWeatherClouds;

	public bool customCloudWindSpeed;

	public float customCloudSpeed;

	public bool dontChangeLightIntensityIfWeatherIsChanged;

	public Camera mapSpawnCam;

	public float mapCamFov;

	public static MapManager Instance;

	private float fogDensity;

	public bool differentFogDensityInSpawnCamera;

	public float fogDensitySpawnCamera;

	public GameObject playerPrefab;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetupAIAndPointsAfterChoosingSide()
	{
	}

	public void SpawnAllowed()
	{
	}

	public void ShowDefaultSpawnScreen()
	{
	}

	public void SetIndividualPointFlow()
	{
	}

	public void SpawnVehicles()
	{
	}

	public IEnumerator MoveSpawnCam()
	{
		return null;
	}

	public IEnumerator MoveCamToSpawn(Camera targetCameraToSwitchTo = null)
	{
		return null;
	}

	public IEnumerator OpeningCamShot()
	{
		return null;
	}

	public IEnumerator EndingCamShot()
	{
		return null;
	}
}
