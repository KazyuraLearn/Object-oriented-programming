using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
	public abstract class Films
	{
		protected string name;

		public Films(string name)
		{
			this.name = name;
		}

		public virtual string Information(Films obj)
		{
			return this.ToString() + "\n" + obj.ToString();
		}

		public override string ToString()
		{
			return "Название фильма: " + name;
		}
	}
}
