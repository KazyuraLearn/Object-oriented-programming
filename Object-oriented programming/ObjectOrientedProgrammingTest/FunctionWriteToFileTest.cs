using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedProgramming;
using System.IO;

namespace ObjectOrientedProgrammingTest
{
	[TestClass]
	public class FunctionWriteToFileTest
	{
		[TestMethod]
		public void NotEmptyList()
		{
			MyList<Films> filmsList = new MyList<Films>()
			{
				new Games("Тест", "Тест", "Тест")
			};
			var expected = File.ReadAllText("ExpectedWriteTest.txt");			

			filmsList.WriteToFile<Films>("Actual.txt");
			var actual = File.ReadAllText("Actual.txt");

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void EmptyList()
		{
			MyList<Films> filmsList = new MyList<Films>();
			var expected = File.ReadAllText("EmptyFile.txt");

			filmsList.WriteToFile<Films>("Actual.txt");
			var actual = File.ReadAllText("Actual.txt");

			Assert.AreEqual(expected, actual);
		}
	}
}
