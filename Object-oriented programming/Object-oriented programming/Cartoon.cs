using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming
{
	class Cartoon : Films
	{
		enum Type { Рисованный, Кукольный, Пластилиновый };
		Type Ob;

		public Cartoon(string Name, int T)
			: base(Name)
		{
			if (T == 0) Ob = Type.Кукольный;
			if (T == 1) Ob = Type.Пластилиновый;
			if (T == 2) Ob = Type.Рисованный;
		}

		public override string ToString()
		{
			return "Название мультфильма: " + Name + ". Тип: " + Ob;
		}
	}
}
