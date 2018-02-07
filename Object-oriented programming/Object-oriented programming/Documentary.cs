using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
	class Documentary : Films
	{
		int yearRelease;

		public Documentary(string name, string country, int yearRelease)
			: base(name, country)
		{
			this.yearRelease = yearRelease;
		}

		public override string ToString()
		{
			return "Название документального фильма: " + name + ". Страна: " + country + ". Год выпуска: " + yearRelease;
		}
	}
}
