using System;
using UnityEngine;

[Serializable]
public class VehicleSeat
{
	public Transform seatPosition;

	public SeatTypes seatType;

	public VehicleEmoteType emoteType;

	public bool keepWeaponsEquipped;

	public bool keepShieldEquipped;

	public bool rotateLookAtVerticallyWithVehicleObject;

	public Transform verticalRotationObject;
}
