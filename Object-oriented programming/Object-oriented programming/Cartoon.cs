﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
	public class Cartoon : Films
	{
		enum Type { рисованный, кукольный, пластилиновый };
		Type ob;

		public Cartoon(string name, string country, int type)
			: base(name, country)
		{
			if (type == 0) ob = Type.кукольный;
			if (type == 1) ob = Type.пластилиновый;
			if (type == 2) ob = Type.рисованный;
		}

		public override string ToString()
		{
			return base.ToString() + ". Тип: " + ob;
		}
	}
}
