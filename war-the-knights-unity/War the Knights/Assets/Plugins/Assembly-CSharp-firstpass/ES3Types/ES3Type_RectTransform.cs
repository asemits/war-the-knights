namespace ES3Types
{
	public class ES3Type_RectTransform : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_RectTransform()
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
