using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace Aevus
{
	public static class EmergencyExit
	{
		private static Thread mainThread;

		private static Thread emergencyThread;

		private static bool lastESC;

		static EmergencyExit()
		{
		}

		private static void Start()
		{
		}

		private static void CatchThreadAbort(string condition, string stackTrace, LogType type)
		{
		}

		public static void ResetAbortThreadFlag()
		{
		}

		private static void SpawnEmergencyThreadIfItDoesNotAlreadyExist()
		{
		}

		private static void EmergencyTerminationThread()
		{
		}

		[PreserveSig]
		public static extern short GetAsyncKeyState(int keycode);

		private static bool EmergencyStopCode()
		{
			return false;
		}

		private static bool ShowEmergencyThreadActivity()
		{
			return false;
		}
	}
}
