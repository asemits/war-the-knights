using System;

namespace ES3Types
{
	public class ES3PropertiesAttribute : Attribute
	{
		public readonly string[] members;

		public ES3PropertiesAttribute(string[] members)
		{
		}
	}
}
