using System.Collections.Generic;
using UnityEngine;

namespace Ara
{
	public class TrailSection : ScriptableObject
	{
		public List<Vector2> vertices;

		public int snapX;

		public int snapY;

		public int Segments => 0;

		public void OnEnable()
		{
		}

		public void CirclePreset(int segments)
		{
		}

		public static int SnapTo(float val, int snapInterval, int threshold)
		{
			return 0;
		}
	}
}
