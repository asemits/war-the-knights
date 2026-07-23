using System;
using System.Collections.Generic;
using ES3Types;

namespace ES3Internal
{
	public static class ES3TypeMgr
	{
		private static object _lock;

		public static Dictionary<Type, ES3Type> types;

		private static ES3Type lastAccessedType;

		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		internal static void Init()
		{
		}
	}
}
