using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
	public class Games : Films
	{
		string director;

		public Games(string name, string country, string director)
			: base(name, country)
		{
			this.director = director;
		}

		public override string ToString()
		{
			return base.ToString() + ". Режисёр: " + director;
		}
	}
}
