using UnityEngine;

namespace UnityToolbag
{
	public sealed class ConditionallyVisibleAttribute : PropertyAttribute
	{
		private readonly string _003CpropertyName_003Ek__BackingField;

		public string propertyName => _003CpropertyName_003Ek__BackingField;

		public ConditionallyVisibleAttribute(string propName)
		{
		}
	}
}
