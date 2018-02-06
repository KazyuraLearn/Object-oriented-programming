using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming
{
	abstract class Films
	{
		protected string Name;

		public Films(string Name)
		{
			this.Name = Name;
		}

		public override string ToString()
		{
			return "Название фильма: " + Name;
		}
	}
}
