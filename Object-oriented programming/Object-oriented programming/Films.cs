using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
	abstract class Films
	{
		protected string name;
		protected string country;

		public Films(string name, string country)
		{
			this.name = name;
			this.country = country;
		}

		public override string ToString()
		{
			return "Название фильма: " + name + ". Страна: " + country;
		}
	}
}
