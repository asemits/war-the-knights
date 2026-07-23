using UnityEngine;

namespace RootMotion
{
	public static class LayerMaskExtensions
	{
		public static bool Contains(LayerMask mask, int layer)
		{
			return false;
		}

		public static LayerMask Create(string[] layerNames)
		{
			return default(LayerMask);
		}

		public static LayerMask Create(int[] layerNumbers)
		{
			return default(LayerMask);
		}

		public static LayerMask NamesToMask(string[] layerNames)
		{
			return default(LayerMask);
		}

		public static LayerMask LayerNumbersToMask(int[] layerNumbers)
		{
			return default(LayerMask);
		}

		public static LayerMask Inverse(LayerMask original)
		{
			return default(LayerMask);
		}

		public static LayerMask AddToMask(LayerMask original, string[] layerNames)
		{
			return default(LayerMask);
		}

		public static LayerMask RemoveFromMask(LayerMask original, string[] layerNames)
		{
			return default(LayerMask);
		}

		public static string[] MaskToNames(LayerMask original)
		{
			return null;
		}

		public static int[] MaskToNumbers(LayerMask original)
		{
			return null;
		}

		public static string MaskToString(LayerMask original)
		{
			return null;
		}

		public static string MaskToString(LayerMask original, string delimiter)
		{
			return null;
		}
	}
}
