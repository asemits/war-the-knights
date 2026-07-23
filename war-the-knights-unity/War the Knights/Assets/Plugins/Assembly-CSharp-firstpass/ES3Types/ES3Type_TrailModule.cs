namespace ES3Types
{
	public class ES3Type_TrailModule : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_TrailModule()
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
