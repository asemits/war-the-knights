using System.Collections.Generic;
using UnityEngine;

namespace EZObjectPools
{
	public class EZObjectPool : MonoBehaviour
	{
		private static Dictionary<string, EZObjectPool> SharedPools;

		private static GameObject Marker;

		public GameObject Template;

		public string PoolName;

		public List<GameObject> ObjectList;

		public bool AutoResize;

		public int PoolSize;

		public bool InstantiateOnAwake;

		public bool Shared;

		private List<GameObject> AvailableObjects;

		public static EZObjectPool CreateObjectPool(GameObject template, string name, int size, bool autoResize, bool instantiateImmediate, bool shared)
		{
			return null;
		}

		private void Awake()
		{
		}

		public void SetProperties(GameObject objectTemplate, int size, string name, bool autoResize)
		{
		}

		public void InstantiatePool()
		{
		}

		public bool TryGetNextObject(Vector3 pos, Quaternion rot, out GameObject obj)
		{
			obj = null;
			return false;
		}

		public void TryGetNextObject(Vector3 pos, Quaternion rot)
		{
		}

		private GameObject NewActiveObject()
		{
			return null;
		}

		public void ClearPool()
		{
		}

		public void DeletePool(bool deleteActiveObjects)
		{
		}

		public void AddToAvailableObjects(GameObject obj)
		{
		}

		public GameObject GetPoolObject(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		public int ActiveObjectCount()
		{
			return 0;
		}

		public int AvailableObjectCount()
		{
			return 0;
		}
	}
}
