using System;

namespace ES3Types
{
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		public ES3ReflectedScriptableObjectType(Type type)
			: base(null)
		{
		}

		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
}
