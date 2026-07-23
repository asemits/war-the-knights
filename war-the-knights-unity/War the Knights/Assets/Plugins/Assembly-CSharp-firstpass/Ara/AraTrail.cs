using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ara
{
	public class AraTrail : MonoBehaviour
	{
		public enum TrailAlignment
		{
			View = 0,
			Velocity = 1,
			Local = 2
		}

		public enum TrailSpace
		{
			World = 0,
			Self = 1,
			Custom = 2
		}

		public enum TrailSorting
		{
			OlderOnTop = 0,
			NewerOnTop = 1
		}

		public enum Timescale
		{
			Normal = 0,
			Unscaled = 1
		}

		public enum TextureMode
		{
			Stretch = 0,
			Tile = 1,
			WorldTile = 2
		}

		public struct CurveFrame
		{
			public Vector3 position;

			public Vector3 normal;

			public Vector3 bitangent;

			public Vector3 tangent;

			public CurveFrame(Vector3 position, Vector3 normal, Vector3 bitangent, Vector3 tangent)
			{
				this.position = default(Vector3);
				this.normal = default(Vector3);
				this.bitangent = default(Vector3);
				this.tangent = default(Vector3);
			}

			public Vector3 Transport(Vector3 newTangent, Vector3 newPosition)
			{
				return default(Vector3);
			}
		}

		public struct Point
		{
			public Vector3 position;

			public Vector3 velocity;

			public Vector3 tangent;

			public Vector3 normal;

			public Color color;

			public float thickness;

			public float life;

			public float texcoord;

			public bool discontinuous;

			public Point(Vector3 position, Vector3 velocity, Vector3 tangent, Vector3 normal, Color color, float thickness, float texcoord, float lifetime)
			{
				this.position = default(Vector3);
				this.velocity = default(Vector3);
				this.tangent = default(Vector3);
				this.normal = default(Vector3);
				this.color = default(Color);
				this.thickness = 0f;
				life = 0f;
				this.texcoord = 0f;
				discontinuous = false;
			}

			public static float CatmullRom(float p0, float p1, float p2, float p3, float t)
			{
				return 0f;
			}

			public static Point operator +(Point p1, Point p2)
			{
				return default(Point);
			}

			public static Point operator -(Point p1, Point p2)
			{
				return default(Point);
			}
		}

		public const float epsilon = 1E-05f;

		public TrailSection section;

		public TrailSpace space;

		public Transform customSpace;

		public Timescale timescale;

		public TrailAlignment alignment;

		public TrailSorting sorting;

		public float thickness;

		public int smoothness;

		public float smoothingDistance;

		public bool highQualityCorners;

		public int cornerRoundness;

		public AnimationCurve thicknessOverLength;

		public Gradient colorOverLength;

		public AnimationCurve thicknessOverTime;

		public Gradient colorOverTime;

		public bool emit;

		public float initialThickness;

		public Color initialColor;

		public Vector3 initialVelocity;

		public float timeInterval;

		public float minDistance;

		public float time;

		public bool enablePhysics;

		public float warmup;

		public Vector3 gravity;

		public float inertia;

		public float velocitySmoothing;

		public float damping;

		public Material[] materials;

		public ShadowCastingMode castShadows;

		public bool receiveShadows;

		public bool useLightProbes;

		public bool quadMapping;

		public TextureMode textureMode;

		public float uvFactor;

		public float uvWidthFactor;

		public float tileAnchor;

		public ElasticArray<Point> points;

		private ElasticArray<Point> renderablePoints;

		private List<int> discontinuities;

		private Mesh mesh_;

		private Vector3 velocity;

		private Vector3 prevPosition;

		private float accumTime;

		private List<Vector3> vertices;

		private List<Vector3> normals;

		private List<Vector4> tangents;

		private List<Vector4> uvs;

		private List<Color> vertColors;

		private List<int> tris;

		private Vector3 nextV;

		private Vector3 prevV;

		private Vector3 vertex;

		private Vector3 normal;

		private Vector3 bitangent;

		private Vector4 tangent;

		private Vector4 texTangent;

		private Vector4 uv;

		private Color color;

		private Action<ScriptableRenderContext, Camera> renderCallback;

		public Vector3 Velocity => default(Vector3);

		private float DeltaTime => 0f;

		private float FixedDeltaTime => 0f;

		public Mesh mesh => null;

		public Matrix4x4 worldToTrail => default(Matrix4x4);

		public event Action onUpdatePoints
		{
			add
			{
			}
			remove
			{
			}
		}

		public void OnValidate()
		{
		}

		public void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void AttachToCameraRendering()
		{
		}

		private void DetachFromCameraRendering()
		{
		}

		public void Clear()
		{
		}

		private void UpdateVelocity()
		{
		}

		private void LateUpdate()
		{
		}

		private void EmissionStep(float time)
		{
		}

		private void Warmup()
		{
		}

		private void PhysicsStep(float timestep)
		{
		}

		private void FixedUpdate()
		{
		}

		public void EmitPoint(Vector3 position, bool adjustEnd = true)
		{
		}

		private void SnapLastPointToTransform()
		{
		}

		private void UpdatePointsLifecycle()
		{
		}

		private void ClearMeshData()
		{
		}

		private void CommitMeshData()
		{
		}

		private void RenderMesh(Camera cam)
		{
		}

		private ElasticArray<Point> GetRenderablePoints(int start, int end)
		{
			return null;
		}

		private CurveFrame InitializeCurveFrame(Vector3 point, Vector3 nextPoint)
		{
			return default(CurveFrame);
		}

		private void UpdateTrailMesh(Camera cam)
		{
		}

		private void UpdateSegmentMesh(int start, int end, Vector3 localCamPosition)
		{
		}

		private void AppendSection(Point[] data, ref CurveFrame frame, int i, int count, float sectionThickness, float vCoord)
		{
		}

		private void AppendFlatTrail(Point[] data, ref CurveFrame frame, int i, int count, float sectionThickness, float vCoord, ref int va, ref int vb)
		{
		}

		private void _003CAttachToCameraRendering_003Eb__85_0(ScriptableRenderContext cntxt, Camera cam)
		{
		}
	}
}
