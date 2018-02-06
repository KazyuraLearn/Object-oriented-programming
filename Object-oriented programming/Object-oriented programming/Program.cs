using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Object_oriented_programming
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<Films> FilmsList = new MyList<Films>();
			ReadToFile(args[0], FilmsList);
			WriteToFile(args[1], FilmsList);
			System.Diagnostics.Process P = new System.Diagnostics.Process();
			P.StartInfo.FileName = args[1];
			P.Start();
		}

		static void ReadToFile(string FileName, MyList<Films> FilmsList)
		{
			FileStream F = new FileStream(FileName, FileMode.Open);
			StreamReader R = new StreamReader(F, Encoding.GetEncoding(1251));
			while (R.Peek() > -1)
			{
				string[] buf = R.ReadLine().Split(new char[] { '#' });
				if (buf[0] == "1")
					FilmsList.Add(new Games(buf[1], buf[2]));
				else if (buf[0] == "2")
					FilmsList.Add(new Cartoon(buf[1], Convert.ToInt32(buf[2])));
				else
					FilmsList.Add(new Documentary(buf[1], Convert.ToInt32(buf[2])));
			}
			R.Close(); F.Close();
		}

		static void WriteToFile(string FileName, MyList<Films> FilmsList)
		{
			FileStream F = new FileStream(FileName, FileMode.Open);
			StreamWriter W = new StreamWriter(F);
			W.WriteLine("Список фильмов содержит: " + FilmsList.Length + " элементов");
			W.WriteLine("----------------------------------------------------------");
			foreach (var el in FilmsList)
				W.WriteLine(el.ToString());
			W.Close(); F.Close();
		}
	}
}
