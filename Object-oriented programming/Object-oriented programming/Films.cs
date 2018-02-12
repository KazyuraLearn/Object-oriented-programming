using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
	public class Films : IComparable<Films>
	{
		protected string name;
		protected string country;

		public Films(string name, string country)
		{
			this.name = name;
			this.country = country;
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

		public int CompareTo(Films ob)
		{
			if (this.VowelCount == ob.VowelCount)
				return 0;
			return (this.VowelCount > ob.VowelCount) ? 1 : -1;
		}

		public override string ToString()
		{
			return "Название фильма: " + name + ". Страна: " + country + ". Жанр: " + this.GetType().Name;
		}
	}
}
