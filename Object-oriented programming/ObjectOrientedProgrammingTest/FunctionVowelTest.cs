using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedProgramming;

namespace ObjectOrientedProgrammingTest
{
	[TestClass]
	public class FunctionVowelTest
	{
		[TestMethod]
		public void EmptyString()
		{
			string arg = "";
			int expected = 0;

			Films film = new Films(arg, arg);
			int actual = film.VowelCount;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NotVowel()
		{
			string arg = "bcDF БВДж \n lkr";
			int expected = 0;

			Films film = new Films(arg, arg);
			int actual = film.VowelCount;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SixVowel()
		{
			string arg = "bcDFое БВДиж \n eailkr";
			int expected = 6;

			Films film = new Films(arg, arg);
			int actual = film.VowelCount;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ThirtyTwoVowel()
		{
			string arg = "АЕЁИОУЫЭЮЯаеёиоуыэюяAEIOUYaeiouy";
			int expected = 31;

			Films film = new Films(arg, arg);
			int actual = film.VowelCount;

			Assert.AreEqual(expected, actual);
		}
	}
}
