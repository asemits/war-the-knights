using System;
using System.Reflection;

namespace ES3Types
{
	public class ES3StackType : ES3CollectionType
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<MethodInfo, bool> _003C_003E9__4_0;

			internal bool _003CRead_003Eb__4_0(MethodInfo t)
			{
				return false;
			}
		}

		public ES3StackType(Type type)
			: base(null)
		{
		}

		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		public override object Read(ES3Reader reader)
		{
			return null;
		}

		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
}
