using UnityEngine;

namespace ES3Types
{
	public class ES3Type_Color32 : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_Color32()
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

		public static bool Equals(Color32 a, Color32 b)
		{
			return false;
		}
	}
}
