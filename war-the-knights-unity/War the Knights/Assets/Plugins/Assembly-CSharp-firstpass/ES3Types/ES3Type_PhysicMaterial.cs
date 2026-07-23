namespace ES3Types
{
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		public static ES3Type Instance;

		public ES3Type_PhysicMaterial()
			: base(null)
		{
		}

		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
}
