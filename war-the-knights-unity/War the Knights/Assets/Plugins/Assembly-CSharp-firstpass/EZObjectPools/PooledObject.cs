using UnityEngine;

namespace EZObjectPools
{
	public class PooledObject : MonoBehaviour
	{
		public EZObjectPool ParentPool;

		public virtual void Disable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
