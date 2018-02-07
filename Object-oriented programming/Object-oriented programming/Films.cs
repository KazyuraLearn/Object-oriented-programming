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

		public Films(string name)
		{
			this.name = name;
		}

		public int VowelCount
		{
			get
			{
				int result = 0;
				string vowel = "AЕЁИОУЫЭЮЯаеёиоуыэюяAEIOUYaeiouy";
				foreach (var el in name)
					if (vowel.IndexOf(el) != -1)
						result++;
				return result;
			}
		}

		public override string ToString()
		{
			return "Название фильма: " + name;
		}
	}
}
