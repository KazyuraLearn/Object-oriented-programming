using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming
{
	public class MyList<T> : IEnumerable<T>
	{
		Node<T> Head;
		Node<T> Tail;
		int Count;

		public int Length { get { return Count; } }
		
		public void Add(T data)
		{
			Node<T> node = new Node<T>(data);
			if (Head == null)
				Head = node;
			else
				Tail.Next = node;
			Tail = node;

			Count++;
		}

		public bool Remove(T data)
		{
			Node<T> Current = Head;
			Node<T> Previous = null;

			while (Current != null)
			{
				if (Current.Data.Equals(data))
				{
					if (Previous != null)
					{
						Previous.Next = Current.Next;
						if (Current.Next == null)
							Tail = Previous;
					}
					else
					{
						Head = Head.Next;
						if (Head == null)
							Tail = null;
					}
					Count--;
					return true;
				}

				Previous = Current;
				Current = Current.Next;
			}
			return false;
		}		

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this).GetEnumerator();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			Node<T> Current = Head;
			while (Current != null)
			{
				yield return Current.Data;
				Current = Current.Next;
			}
		}
	}
}
