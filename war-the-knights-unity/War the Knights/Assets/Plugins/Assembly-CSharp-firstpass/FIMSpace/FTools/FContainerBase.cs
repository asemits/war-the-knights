using System;
using System.Collections.Generic;
using UnityEngine;

namespace FIMSpace.FTools
{
	public abstract class FContainerBase : ScriptableObject
	{
		[Serializable]
		public class AssetReference
		{
			public UnityEngine.Object Reference;

			public string OriginalExtension;
		}

		public List<AssetReference> ContainedAssets;

		public virtual bool Contains(UnityEngine.Object obj)
		{
			return false;
		}

		public virtual void Remove(UnityEngine.Object obj)
		{
		}

		public virtual void RemoveAndDestroy(UnityEngine.Object obj)
		{
		}

		public virtual void CopyAsset(UnityEngine.Object obj, string extension = ".asset")
		{
		}

		public virtual void Add(UnityEngine.Object obj)
		{
		}

		public AssetReference GetReferenceTo(UnityEngine.Object asset)
		{
			return null;
		}

		public virtual void AddAsset(UnityEngine.Object obj)
		{
		}

		public virtual void UnpackSingleAsset(UnityEngine.Object asset)
		{
		}

		public virtual void UnpackAll()
		{
		}

		public void _SetDirty()
		{
		}

		public static void AddAssetTo(ScriptableObject container, UnityEngine.Object asset)
		{
		}

		public static void UnpackAll(FContainerBase container)
		{
		}

		public static void UnpackSingleAsset(FContainerBase container, UnityEngine.Object tgt)
		{
		}
	}
}
