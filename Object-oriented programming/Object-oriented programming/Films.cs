﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
	abstract class Films
	{
		protected string name;

		public Films(string name)
		{
			this.name = name;
		}

		public override string ToString()
		{
			return "Название фильма: " + name;
		}
	}
}
