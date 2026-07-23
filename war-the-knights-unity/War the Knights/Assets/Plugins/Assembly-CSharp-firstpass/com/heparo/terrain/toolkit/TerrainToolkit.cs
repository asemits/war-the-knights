using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.heparo.terrain.toolkit
{
	public class TerrainToolkit : MonoBehaviour
	{
		public enum ToolMode
		{
			Create = 0,
			Erode = 1,
			Texture = 2
		}

		public enum ErosionMode
		{
			Filter = 0,
			Brush = 1
		}

		public enum ErosionType
		{
			Thermal = 0,
			Hydraulic = 1,
			Tidal = 2,
			Wind = 3,
			Glacial = 4
		}

		public enum HydraulicType
		{
			Fast = 0,
			Full = 1,
			Velocity = 2
		}

		public enum Neighbourhood
		{
			Moore = 0,
			VonNeumann = 1
		}

		public enum GeneratorType
		{
			Voronoi = 0,
			DiamondSquare = 1,
			Perlin = 2,
			Smooth = 3,
			Normalise = 4
		}

		public enum VoronoiType
		{
			Linear = 0,
			Sine = 1,
			Tangent = 2
		}

		public enum FeatureType
		{
			Mountains = 0,
			Hills = 1,
			Plateaus = 2
		}

		public struct Peak
		{
			public Vector2 peakPoint;

			public float peakHeight;
		}

		public delegate void ErosionProgressDelegate(string titleString, string displayString, int iteration, int nIterations, float percentComplete);

		public delegate void TextureProgressDelegate(string titleString, string displayString, float percentComplete);

		public delegate void GeneratorProgressDelegate(string titleString, string displayString, float percentComplete);

		public class PeakDistance : IComparable
		{
			public int id;

			public float dist;

			public int CompareTo(object obj)
			{
				return 0;
			}
		}

		public class voronoiPresetData
		{
			public string presetName;

			public VoronoiType p_voronoiType;

			public int voronoiCells;

			public float voronoiFeatures;

			public float voronoiScale;

			public float voronoiBlend;

			public voronoiPresetData(string pn, VoronoiType vt, int c, float vf, float vs, float vb)
			{
			}
		}

		public class fractalPresetData
		{
			public string presetName;

			public float diamondSquareDelta;

			public float diamondSquareBlend;

			public fractalPresetData(string pn, float dsd, float dsb)
			{
			}
		}

		public class perlinPresetData
		{
			public string presetName;

			public int perlinFrequency;

			public float perlinAmplitude;

			public int perlinOctaves;

			public float perlinBlend;

			public perlinPresetData(string pn, int pf, float pa, int po, float pb)
			{
			}
		}

		public class thermalErosionPresetData
		{
			public string presetName;

			public int thermalIterations;

			public float thermalMinSlope;

			public float thermalFalloff;

			public thermalErosionPresetData(string pn, int ti, float tms, float tba)
			{
			}
		}

		public class fastHydraulicErosionPresetData
		{
			public string presetName;

			public int hydraulicIterations;

			public float hydraulicMaxSlope;

			public float hydraulicFalloff;

			public fastHydraulicErosionPresetData(string pn, int hi, float hms, float hba)
			{
			}
		}

		public class fullHydraulicErosionPresetData
		{
			public string presetName;

			public int hydraulicIterations;

			public float hydraulicRainfall;

			public float hydraulicEvaporation;

			public float hydraulicSedimentSolubility;

			public float hydraulicSedimentSaturation;

			public fullHydraulicErosionPresetData(string pn, int hi, float hr, float he, float hso, float hsa)
			{
			}
		}

		public class velocityHydraulicErosionPresetData
		{
			public string presetName;

			public int hydraulicIterations;

			public float hydraulicVelocityRainfall;

			public float hydraulicVelocityEvaporation;

			public float hydraulicVelocitySedimentSolubility;

			public float hydraulicVelocitySedimentSaturation;

			public float hydraulicVelocity;

			public float hydraulicMomentum;

			public float hydraulicEntropy;

			public float hydraulicDowncutting;

			public velocityHydraulicErosionPresetData(string pn, int hi, float hvr, float hve, float hso, float hsa, float hv, float hm, float he, float hd)
			{
			}
		}

		public class tidalErosionPresetData
		{
			public string presetName;

			public int tidalIterations;

			public float tidalRangeAmount;

			public float tidalCliffLimit;

			public tidalErosionPresetData(string pn, int ti, float tra, float tcl)
			{
			}
		}

		public class windErosionPresetData
		{
			public string presetName;

			public int windIterations;

			public float windDirection;

			public float windForce;

			public float windLift;

			public float windGravity;

			public float windCapacity;

			public float windEntropy;

			public float windSmoothing;

			public windErosionPresetData(string pn, int wi, float wd, float wf, float wl, float wg, float wc, float we, float ws)
			{
			}
		}

		public class PerlinNoise2D
		{
			private double[,] p_noiseValues;

			private float p_amplitude;

			private int p_frequency;

			public float Amplitude => 0f;

			public int Frequency => 0;

			public PerlinNoise2D(int freq, float _amp)
			{
			}

			public double getInterpolatedPoint(int _xa, int _xb, int _ya, int _yb, double Px, double Py)
			{
				return 0.0;
			}

			public double interpolate(double Pa, double Pb, double Px)
			{
				return 0.0;
			}
		}

		public const string EMPTY = "";

		public const string TERRAIN_LAYER_EXTENSION = ".terrainlayer";

		public const string TERRAIN_LAYER_PREFIX = "Layer_";

		public const string TOOLKIT_LAYERS_FOLDER = "TerrainToolkitLayers";

		public const string TERRAIN_LAYERS_FOLDER = "_Layers";

		private ErosionMode p_erosionMode;

		private ErosionType p_erosionType;

		private GeneratorType p_generatorType;

		private Neighbourhood p_neighbourhood;

		private HydraulicType p_hydraulicType;

		private VoronoiType p_voronoiType;

		public int toolModeInt;

		public int erosionTypeInt;

		public int generatorTypeInt;

		public bool isBrushOn;

		public bool isBrushHidden;

		public bool isBrushPainting;

		public Vector3 brushPosition;

		public float brushSize;

		public float brushOpacity;

		public float brushSoftness;

		public int neighbourhoodInt;

		public bool useDifferenceMaps;

		public int thermalIterations;

		public float thermalMinSlope;

		public float thermalFalloff;

		public int hydraulicTypeInt;

		public int hydraulicIterations;

		public float hydraulicMaxSlope;

		public float hydraulicFalloff;

		public float hydraulicRainfall;

		public float hydraulicEvaporation;

		public float hydraulicSedimentSolubility;

		public float hydraulicSedimentSaturation;

		public float hydraulicVelocityRainfall;

		public float hydraulicVelocityEvaporation;

		public float hydraulicVelocitySedimentSolubility;

		public float hydraulicVelocitySedimentSaturation;

		public float hydraulicVelocity;

		public float hydraulicMomentum;

		public float hydraulicEntropy;

		public float hydraulicDowncutting;

		public int tidalIterations;

		public float tidalSeaLevel;

		public float tidalRangeAmount;

		public float tidalCliffLimit;

		public int windIterations;

		public float windDirection;

		public float windForce;

		public float windLift;

		public float windGravity;

		public float windCapacity;

		public float windEntropy;

		public float windSmoothing;

		public TerrainLayer[] terrainLayers;

		public float slopeBlendMinAngle;

		public float slopeBlendMaxAngle;

		public List<float> heightBlendPoints;

		public string[] gradientStyles;

		public int voronoiTypeInt;

		public int voronoiCells;

		public float voronoiFeatures;

		public float voronoiScale;

		public float voronoiBlend;

		public float diamondSquareDelta;

		public float diamondSquareBlend;

		public int perlinFrequency;

		public float perlinAmplitude;

		public int perlinOctaves;

		public float perlinBlend;

		public float smoothBlend;

		public int smoothIterations;

		public float normaliseMin;

		public float normaliseMax;

		public float normaliseBlend;

		public ArrayList voronoiPresets;

		public ArrayList fractalPresets;

		public ArrayList perlinPresets;

		public ArrayList thermalErosionPresets;

		public ArrayList fastHydraulicErosionPresets;

		public ArrayList fullHydraulicErosionPresets;

		public ArrayList velocityHydraulicErosionPresets;

		public ArrayList tidalErosionPresets;

		public ArrayList windErosionPresets;

		[NonSerialized]
		public bool presetsInitialised;

		[NonSerialized]
		public int voronoiPresetId;

		[NonSerialized]
		public int fractalPresetId;

		[NonSerialized]
		public int perlinPresetId;

		[NonSerialized]
		public int thermalErosionPresetId;

		[NonSerialized]
		public int fastHydraulicErosionPresetId;

		[NonSerialized]
		public int fullHydraulicErosionPresetId;

		[NonSerialized]
		public int velocityHydraulicErosionPresetId;

		[NonSerialized]
		public int tidalErosionPresetId;

		[NonSerialized]
		public int windErosionPresetId;

		private string layersPath;

		private string assetPath;

		public void addPresets()
		{
		}

		public void setVoronoiPreset(voronoiPresetData preset)
		{
		}

		public void setFractalPreset(fractalPresetData preset)
		{
		}

		public void setPerlinPreset(perlinPresetData preset)
		{
		}

		public void setThermalErosionPreset(thermalErosionPresetData preset)
		{
		}

		public void setFastHydraulicErosionPreset(fastHydraulicErosionPresetData preset)
		{
		}

		public void setFullHydraulicErosionPreset(fullHydraulicErosionPresetData preset)
		{
		}

		public void setVelocityHydraulicErosionPreset(velocityHydraulicErosionPresetData preset)
		{
		}

		public void setTidalErosionPreset(tidalErosionPresetData preset)
		{
		}

		public void setWindErosionPreset(windErosionPresetData preset)
		{
		}

		public void Update()
		{
		}

		public void OnDrawGizmos()
		{
		}

		public void paint()
		{
		}

		public void erodeTerrainWithBrush()
		{
		}

		public void erodeAllTerrain(ErosionProgressDelegate erosionProgressDelegate)
		{
		}

		public float[,] fastErosion(float[,] heightMap, Vector2 arraySize, int iterations, ErosionProgressDelegate erosionProgressDelegate)
		{
			return null;
		}

		public float[,] velocityHydraulicErosion(float[,] heightMap, Vector2 arraySize, int iterations, ErosionProgressDelegate erosionProgressDelegate)
		{
			return null;
		}

		public float[,] fullHydraulicErosion(float[,] heightMap, Vector2 arraySize, int iterations, ErosionProgressDelegate erosionProgressDelegate)
		{
			return null;
		}

		public float[,] windErosion(float[,] heightMap, Vector2 arraySize, int iterations, ErosionProgressDelegate erosionProgressDelegate)
		{
			return null;
		}

		public void textureTerrain(TextureProgressDelegate textureProgressDelegate)
		{
		}

		public void BuildPaths()
		{
		}

		public void addTerrainLayer(Texture2D tex, int index)
		{
		}

		public void deleteTerrainLayer(Texture2D tex, int index)
		{
		}

		public void deleteAllTerrainLayers()
		{
		}

		public void addBlendPoints()
		{
		}

		public void deleteBlendPoints()
		{
		}

		public void deleteAllBlendPoints()
		{
		}

		public void generateTerrain(GeneratorProgressDelegate generatorProgressDelegate)
		{
		}

		public float[,] generateVoronoi(float[,] heightMap, Vector2 arraySize, GeneratorProgressDelegate generatorProgressDelegate)
		{
			return null;
		}

		public float[,] generateDiamondSquare(float[,] heightMap, Vector2 arraySize, GeneratorProgressDelegate generatorProgressDelegate)
		{
			return null;
		}

		public void dsCalculateHeight(float[,] heightMap, Vector2 arraySize, int Tx, int Ty, Vector2[] points, float heightRange)
		{
		}

		public float[,] generatePerlin(float[,] heightMap, Vector2 arraySize, GeneratorProgressDelegate generatorProgressDelegate)
		{
			return null;
		}

		public float[,] smooth(float[,] heightMap, Vector2 arraySize, GeneratorProgressDelegate generatorProgressDelegate)
		{
			return null;
		}

		public float[,] normalise(float[,] heightMap, Vector2 arraySize, GeneratorProgressDelegate generatorProgressDelegate)
		{
			return null;
		}

		public void FastThermalErosion(int iterations, float minSlope, float blendAmount)
		{
		}

		public void FastHydraulicErosion(int iterations, float maxSlope, float blendAmount)
		{
		}

		public void FullHydraulicErosion(int iterations, float rainfall, float evaporation, float solubility, float saturation)
		{
		}

		public void VelocityHydraulicErosion(int iterations, float rainfall, float evaporation, float solubility, float saturation, float velocity, float momentum, float entropy, float downcutting)
		{
		}

		public void TidalErosion(int iterations, float seaLevel, float tidalRange, float cliffLimit)
		{
		}

		public void WindErosion(int iterations, float direction, float force, float lift, float gravity, float capacity, float entropy, float smoothing)
		{
		}

		public void TextureTerrain(float[] slopeStops, float[] heightStops, Texture2D[] textures)
		{
		}

		public void VoronoiGenerator(FeatureType featureType, int cells, float features, float scale, float blend)
		{
		}

		public void FractalGenerator(float fractalDelta, float blend)
		{
		}

		public void PerlinGenerator(int frequency, float amplitude, int octaves, float blend)
		{
		}

		public void SmoothTerrain(int iterations, float blend)
		{
		}

		public void NormaliseTerrain(float minHeight, float maxHeight, float blend)
		{
		}

		public void NormalizeTerrain(float minHeight, float maxHeight, float blend)
		{
		}

		public void convertIntVarsToEnums()
		{
		}

		public void dummyErosionProgress(string titleString, string displayString, int iteration, int nIterations, float percentComplete)
		{
		}

		public void dummyTextureProgress(string titleString, string displayString, float percentComplete)
		{
		}

		public void dummyGeneratorProgress(string titleString, string displayString, float percentComplete)
		{
		}

		public void resetTerrain()
		{
		}

		public void invertTerrain()
		{
		}

		public void applyArtifacts(Texture2D artifacts, float pivot, float neutral, float strength)
		{
		}

		public void seamlessTerrain(float amount)
		{
		}
	}
}
