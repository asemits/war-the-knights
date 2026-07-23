using System;

namespace ES3Types
{
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		public ES3ReflectedObjectType(Type type)
			: base(null)
		{
		}

		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
}
