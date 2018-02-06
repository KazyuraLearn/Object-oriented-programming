using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming
{
	public class Node<T>
	{
		public T Data;
		public Node<T> Next;

		public Node(T Data)
		{
			this.Data = Data;
		}		
	}
}
