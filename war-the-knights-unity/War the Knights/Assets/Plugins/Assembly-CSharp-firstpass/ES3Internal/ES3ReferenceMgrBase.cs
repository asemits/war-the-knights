using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ES3Internal
{
	[Serializable]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<long, UnityEngine.Object>, bool> _003C_003E9__33_0;

			public static Func<KeyValuePair<long, UnityEngine.Object>, long> _003C_003E9__33_1;

			public static Func<KeyValuePair<long, UnityEngine.Object>, bool> _003C_003E9__34_0;

			public static Func<KeyValuePair<long, UnityEngine.Object>, long> _003C_003E9__34_1;

			internal bool _003CRemoveNullValues_003Eb__33_0(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return false;
			}

			internal long _003CRemoveNullValues_003Eb__33_1(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return 0L;
			}

			internal bool _003CRemoveNullOrInvalidValues_003Eb__34_0(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return false;
			}

			internal long _003CRemoveNullOrInvalidValues_003Eb__34_1(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return 0L;
			}
		}

		private sealed class _003C_003Ec__DisplayClass31_0
		{
			public UnityEngine.Object obj;

			public Func<KeyValuePair<long, UnityEngine.Object>, bool> _003C_003E9__0;

			internal bool _003CRemove_003Eb__0(KeyValuePair<long, UnityEngine.Object> kvp)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass32_0
		{
			public long referenceID;

			public Func<KeyValuePair<UnityEngine.Object, long>, bool> _003C_003E9__0;

			internal bool _003CRemove_003Eb__0(KeyValuePair<UnityEngine.Object, long> kvp)
			{
				return false;
			}
		}

		internal object _lock;

		public const string referencePropertyName = "_ES3Ref";

		private static ES3ReferenceMgrBase _current;

		private static HashSet<ES3ReferenceMgrBase> mgrs;

		private static System.Random rng;

		public bool openPrefabs;

		public List<ES3Prefab> prefabs;

		public ES3IdRefDictionary idRef;

		private ES3RefIdDictionary _refId;

		public static ES3ReferenceMgrBase Current => null;

		public bool IsInitialised => false;

		public ES3RefIdDictionary refId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ES3GlobalReferences GlobalReferences => null;

		public static ES3ReferenceMgrBase GetManagerFromScene(Scene scene)
		{
			return null;
		}

		private static void Init()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		public long Get(UnityEngine.Object obj)
		{
			return 0L;
		}

		internal UnityEngine.Object Get(long id, Type type, bool suppressWarnings = false)
		{
			return null;
		}

		public UnityEngine.Object Get(long id, bool suppressWarnings = false)
		{
			return null;
		}

		public ES3Prefab GetPrefab(long id, bool suppressWarnings = false)
		{
			return null;
		}

		public long GetPrefab(ES3Prefab prefabToFind, bool suppressWarnings = false)
		{
			return 0L;
		}

		public long Add(UnityEngine.Object obj)
		{
			return 0L;
		}

		public long Add(UnityEngine.Object obj, long id)
		{
			return 0L;
		}

		public bool AddPrefab(ES3Prefab prefab)
		{
			return false;
		}

		public void Remove(UnityEngine.Object obj)
		{
		}

		public void Remove(long referenceID)
		{
		}

		public void RemoveNullValues()
		{
		}

		public void RemoveNullOrInvalidValues()
		{
		}

		public void Clear()
		{
		}

		public bool Contains(UnityEngine.Object obj)
		{
			return false;
		}

		public bool Contains(long referenceID)
		{
			return false;
		}

		public void ChangeId(long oldId, long newId)
		{
		}

		internal static long GetNewRefID()
		{
			return 0L;
		}

		internal static bool CanBeSaved(UnityEngine.Object obj)
		{
			return false;
		}
	}
}
