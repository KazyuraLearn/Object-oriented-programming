using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming
{
	abstract class Films
	{
		protected string Name;

		public Films(string Name)
		{
			this.Name = Name;
		}

		public int VowelCount
		{
			get
			{
				int Result = 0;
				string Vowel = "AЕЁИОУЫЭЮЯаеёиоуыэюяAEIOUYaeiouy";
				foreach (var el in Name)
					if (Vowel.IndexOf(el) != -1)
						Result++;
				return Result;
			}
		}

		public override string ToString()
		{
			return "Название фильма: " + Name;
		}
	}
}
