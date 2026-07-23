using System;
using System.Collections;
using System.Collections.Generic;

namespace Ara
{
	public class ElasticArray<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		private sealed class _003CGetEnumerator_003Ed__11 : IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			public ElasticArray<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			T IEnumerator<T>.Current => default(T);

			object IEnumerator.Current => null;

			public _003CGetEnumerator_003Ed__11(int _003C_003E1__state)
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

		private T[] data;

		private int count;

		public int Count => 0;

		public bool IsReadOnly => false;

		public T this[int index]
		{
			get
			{
				return data[index];
			}
			set
			{
				data[index] = value;
			}
		}

		public T[] Data => null;

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveRange(int index, int num)
		{
		}

		public void SetCount(int count)
		{
		}

		public void EnsureCapacity(int capacity)
		{
		}

		public void Reverse()
		{
		}
	}
}
