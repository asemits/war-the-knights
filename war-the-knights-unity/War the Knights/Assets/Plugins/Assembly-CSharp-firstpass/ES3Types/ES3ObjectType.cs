using System;

namespace ES3Types
{
	public abstract class ES3ObjectType : ES3Type
	{
		public ES3ObjectType(Type type)
			: base(null)
		{
		}

		protected abstract void WriteObject(object obj, ES3Writer writer);

		protected abstract object ReadObject<T>(ES3Reader reader);

		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
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
