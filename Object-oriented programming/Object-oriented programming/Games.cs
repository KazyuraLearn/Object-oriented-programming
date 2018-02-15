using System;
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

		public override string Information(Films obj)
		{
			if (obj is Games)
				return InformationChildren(obj as Games);
			else
				return InformationChildren(obj as Cartoon);
		}

		private string InformationChildren(Cartoon obj)
		{
			return this.ToString() + "\n" + obj.ToString();
		}

		private string InformationChildren(Games obj)
		{
			return this.ToString() + "\n" + obj.ToString();
		}

		public override string ToString()
		{
			return "Название игрового фильма: " + name + ". Режисёр: " + director;
		}
	}
}
