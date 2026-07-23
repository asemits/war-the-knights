namespace ES3Types
{
	public class ES3Type_Burst : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_Burst()
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
