using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	public static class DOTweenModuleUnityVersion
	{
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public Material target;

			public int propertyID;

			internal Vector2 _003CDOOffset_003Eb__0()
			{
				return default(Vector2);
			}

			internal void _003CDOOffset_003Eb__1(Vector2 x)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public Material target;

			public int propertyID;

			internal Vector2 _003CDOTiling_003Eb__0()
			{
				return default(Vector2);
			}

			internal void _003CDOTiling_003Eb__1(Vector2 x)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _003CAsyncWaitForCompletion_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Tween t;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _003CAsyncWaitForElapsedLoops_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Tween t;

			public int elapsedLoops;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _003CAsyncWaitForKill_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Tween t;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _003CAsyncWaitForPosition_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Tween t;

			public float position;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _003CAsyncWaitForRewind_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Tween t;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _003CAsyncWaitForStart_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Tween t;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public static Sequence DOGradientColor(Material target, Gradient gradient, float duration)
		{
			return null;
		}

		public static Sequence DOGradientColor(Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		public static CustomYieldInstruction WaitForCompletion(Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		public static CustomYieldInstruction WaitForRewind(Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		public static CustomYieldInstruction WaitForKill(Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		public static CustomYieldInstruction WaitForElapsedLoops(Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		public static CustomYieldInstruction WaitForPosition(Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		public static CustomYieldInstruction WaitForStart(Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		public static Task AsyncWaitForCompletion(Tween t)
		{
			return null;
		}

		public static Task AsyncWaitForRewind(Tween t)
		{
			return null;
		}

		public static Task AsyncWaitForKill(Tween t)
		{
			return null;
		}

		public static Task AsyncWaitForElapsedLoops(Tween t, int elapsedLoops)
		{
			return null;
		}

		public static Task AsyncWaitForPosition(Tween t, float position)
		{
			return null;
		}

		public static Task AsyncWaitForStart(Tween t)
		{
			return null;
		}
	}
}
