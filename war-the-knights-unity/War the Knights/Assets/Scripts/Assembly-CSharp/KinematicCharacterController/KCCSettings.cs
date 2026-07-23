using UnityEngine;

namespace KinematicCharacterController
{
	public class KCCSettings : ScriptableObject
	{
		public bool AutoSimulation;

		public bool Interpolate;

		public int MotorsListInitialCapacity;

		public int MoversListInitialCapacity;
	}
}
