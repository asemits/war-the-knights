using System;
using System.Collections;
using System.Collections.Generic;
using KinematicCharacterController;
using UnityEngine;
using UnityEngine.AI;

public class VehicleManager : MonoBehaviour
{
	private sealed class _003CEnterVehicleAtEndOfFrame_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VehicleBase vehicle;

		public VehicleManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CEnterVehicleAtEndOfFrame_003Ed__34(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public KinematicCharacterMotor motor;

	public InputHandling inputHandling;

	public Camera defaultCamera;

	public Camera weaponCamera;

	public Camera thirdPersonCamera;

	public MouseLookThirdPerson thirdPersonMouseLook;

	public bool flightControlsInverted;

	public float inputSensitivityFlightRatioHorizontal;

	public float inputSensitivityFlightRatioVertical;

	public float inputSensitivityHorizontal;

	public float inputSensitivityVertical;

	public Transform player;

	public VehicleBase currentVehicle;

	public Vehicle vehicleSpawnHorse;

	public Vehicle vehicleSpawnCatapult;

	public Vehicle vehicleSpawnCrossbow;

	public LayerMask vehicleExitCollisionOverlapLayerMask;

	public NavMeshAgent playerAgent;

	private bool shouldUsePlayerAgent;

	public MeshRenderer weaponShadowMeshRenderer;

	private Material weaponShadowMaterial;

	private Color currentWeaponShadowColor;

	public LayerMask weaponShadowSunCheckLayerMask;

	public static readonly Collider[] vehicleExitCollisionOverlapResults;

	public static VehicleManager Instance;

	private void Awake()
	{
	}

	private void UpdateFirstPersonWeaponShadowInstantly()
	{
	}

	private void LateUpdate()
	{
	}

	public Vehicle GetVehicleByType(VehicleType type)
	{
		return null;
	}

	public void ExitVehicle(Vector3 ragdollForce, OnDestroyDriverAction onDestroyDriverAction, AITarget vehicleDestroyer)
	{
	}

	public void EnterVehicle(VehicleBase vehicle)
	{
	}

	public void ResetPlayerVehicleStatus()
	{
	}

	public void EnablePlayer()
	{
	}

	public void DisablePlayer(bool vehicle, bool ragdoll = false)
	{
	}

	public IEnumerator EnterVehicleAtEndOfFrame(VehicleBase vehicle)
	{
		return null;
	}

	public void EnableThirdPerson(Transform target, float distance, float startingDistance = -100f, bool smoothTransition = false, bool lockCamera = false, int fov = 65, int aimFov = 65, bool showCharacter = true, bool showWeapons = false, int verticalLimitUp = 90, int verticalLimitDown = 90, bool clampVerticallyInRelationToTarget = false, int horizontalLimit = 360)
	{
	}

	public void OpenSpawnMenu()
	{
	}

	public void DisableThirdPersonRenderers()
	{
	}

	public void DisableThirdPerson(bool setFirstPersonCamRotationToThirdPerson)
	{
	}

	private void DisableThirdPersonCam(bool setFirstPersonCamRotationToThirdPerson)
	{
	}
}
