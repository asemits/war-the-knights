using System;
using UnityEngine;

namespace ES3Internal
{
	[Serializable]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return false;
		}

		protected override bool ValuesAreEqual(long a, long b)
		{
			return false;
		}
	}
}
