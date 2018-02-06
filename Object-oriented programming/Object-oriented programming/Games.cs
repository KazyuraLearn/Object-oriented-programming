using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming
{
	class Games : Films
	{
		string Director;

		public Games(string Name, string Director)
			: base(Name)
		{
			this.Director = Director;
		}

		public override string ToString()
		{
			return "Название игрового фильма: " + Name + ". Режисёр: " + Director;
		}
	}
}
