using System;
using UnityEngine;

[Serializable]
public class LoadoutItemData
{
	public enum ItemEquipStatus
	{
		None = 0,
		OtherGadgetSlot = 1,
		Equipped = 2
	}

	public ItemEquipStatus itemEquipStatus;

	public Sprite itemSprite;

	public string itemName;

	public int item;

	public bool rewardReceived;
}
