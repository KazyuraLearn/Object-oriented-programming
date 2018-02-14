using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedProgramming;

namespace ObjectOrientedProgrammingTest
{
	[TestClass]
	public class FunctionReadToFileTest
	{
		[TestMethod]
		public void EmptyFile()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>();

			filmsList = filmsList.ReadToFile("EmptyFile.txt");

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void ImaginaryFile()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>();

			filmsList = filmsList.ReadToFile("H:\\File.txt");

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void IncorrectFile()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>()
			{
				new Cartoon("Рапунцель", "Англия", 2),
				new Games("Неудержимые", "США", "Сильвестр Сталоне")
			};

			filmsList = filmsList.ReadToFile("IncorrectFile.txt");

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void CorrectFile()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>()
			{
				new Cartoon("Побег из курятника", "Франция", 2),
				new Games("Мстители", "Германия", "Джосс Уидон"),
				new Documentary("Сквозь вселенную", "Канада", 1997)
			};

			filmsList = filmsList.ReadToFile("CorrectFile.txt");

			Assert.AreEqual(expected, filmsList);
		}
	}
}
