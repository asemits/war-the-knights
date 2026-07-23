using System;
using System.Collections.Generic;
using UnityEngine;

public class ES3AutoSave : MonoBehaviour, ISerializationCallbackReceiver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<Component> _003C_003E9__13_0;

		internal bool _003COnAfterDeserialize_003Eb__13_0(Component c)
		{
			return false;
		}
	}

	public bool saveLayer;

	public bool saveTag;

	public bool saveName;

	public bool saveHideFlags;

	public bool saveActive;

	public bool saveChildren;

	private bool isQuitting;

	public List<Component> componentsToSave;

	public void Reset()
	{
	}

	public void Awake()
	{
	}

	public void OnApplicationQuit()
	{
	}

	public void OnDestroy()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
