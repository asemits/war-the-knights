using System;

namespace ES3Types
{
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		public ES3ReflectedComponentType(Type type)
			: base(null)
		{
		}

		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
}
