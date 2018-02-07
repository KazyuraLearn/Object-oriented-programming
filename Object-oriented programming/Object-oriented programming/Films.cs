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

		static int Compare(Films one, Films two)
		{
			if (one.VowelCount == two.VowelCount)
				return 0;
			return (one.VowelCount > two.VowelCount) ? 1 : -1;
		}

		public static bool operator ==(Films one, Films two)
		{
			return (Compare(one, two) == 0) ? true : false;
		}

		public static bool operator !=(Films one, Films two)
		{
			return (Compare(one, two) == 0) ? false : true;
		}

		public static bool operator >(Films one, Films two)
		{
			return (Compare(one, two) == 1) ? true : false;
		}

		public static bool operator <(Films one, Films two)
		{
			return (Compare(one, two) == 1) ? false : true;
		}

		public override string ToString()
		{
			return "Название фильма: " + name;
		}
	}
}
