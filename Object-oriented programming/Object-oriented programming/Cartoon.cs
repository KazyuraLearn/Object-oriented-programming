﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
	class Cartoon : Films
	{
		enum Type { рисованный, кукольный, пластилиновый };
		Type ob;

		public Cartoon(string name, int type)
			: base(name)
		{
			if (type == 0) ob = Type.кукольный;
			if (type == 1) ob = Type.пластилиновый;
			if (type == 2) ob = Type.рисованный;
		}

		public override string ToString()
		{
			return "Название мультфильма: " + name + ". Тип: " + ob;
		}
	}
}
