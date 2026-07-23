using System;
using System.Collections.Generic;
using ES3Internal;
using UnityEngine;

namespace ES3Types
{
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public Type type;

			public Predicate<Component> _003C_003E9__0;

			internal bool _003CReadComponents_003Eb__0(Component x)
			{
				return false;
			}
		}

		private const string prefabPropertyName = "es3Prefab";

		private const string transformPropertyName = "transformID";

		public static ES3Type Instance;

		public bool saveChildren;

		public ES3Type_GameObject()
			: base(null)
		{
		}

		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		private void ReadComponents(ES3Reader reader, GameObject go)
		{
		}

		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
}
