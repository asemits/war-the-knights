using System;
using System.Collections.Generic;
using UnityEngine;

namespace ES3Internal
{
	[Serializable]
	public abstract class ES3SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<TKey, TVal>, bool> _003C_003E9__6_0;

			public static Func<KeyValuePair<TKey, TVal>, TKey> _003C_003E9__6_1;

			internal bool _003CRemoveNullValues_003Eb__6_0(KeyValuePair<TKey, TVal> pair)
			{
				return false;
			}

			internal TKey _003CRemoveNullValues_003Eb__6_1(KeyValuePair<TKey, TVal> pair)
			{
				return default(TKey);
			}
		}

		private List<TKey> _Keys;

		private List<TVal> _Values;

		protected abstract bool KeysAreEqual(TKey a, TKey b);

		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public int RemoveNullValues()
		{
			return 0;
		}

		public bool ChangeKey(TKey oldKey, TKey newKey)
		{
			return false;
		}
	}
}
