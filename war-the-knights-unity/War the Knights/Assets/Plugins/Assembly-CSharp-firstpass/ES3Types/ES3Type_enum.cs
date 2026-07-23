using System;

namespace ES3Types
{
	public class ES3Type_enum : ES3Type
	{
		public static ES3Type Instance;

		private Type underlyingType;

		public ES3Type_enum(Type type)
			: base(null)
		{
		}

		public override void Write(object obj, ES3Writer writer)
		{
		}

		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
}
