using System;

namespace ES3Types
{
	internal class ES3ReflectedValueType : ES3Type
	{
		public ES3ReflectedValueType(Type type)
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

		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
