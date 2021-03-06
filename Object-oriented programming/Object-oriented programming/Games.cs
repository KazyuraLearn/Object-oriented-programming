﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
	class Games : Films
	{
		string director;

		public Games(string name, string director)
			: base(name)
		{
			this.director = director;
		}

		public override string ToString()
		{
			return "Название игрового фильма: " + name + ". Режисёр: " + director;
		}
	}
}
