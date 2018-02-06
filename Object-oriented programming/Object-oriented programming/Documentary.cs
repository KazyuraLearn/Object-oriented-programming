using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming
{
	class Documentary : Films
	{
		int YearRelease;

		public Documentary(string Name, int YearRelease)
			: base(Name)
		{
			this.YearRelease = YearRelease;
		}

		public override string ToString()
		{
			return "Название документального фильма: " + Name + ". Год выпуска: " + YearRelease;
		}
	}
}
