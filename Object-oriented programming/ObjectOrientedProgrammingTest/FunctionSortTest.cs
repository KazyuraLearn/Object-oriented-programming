using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedProgramming;

namespace ObjectOrientedProgrammingTest
{
	[TestClass]
	public class FunctionSortTest
	{
		[TestMethod]
		public void EmptyList()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>();

			filmsList.Sort();

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void NotEmptyList()
		{
			MyList<Films> filmsList = new MyList<Films>()
			{ 
				new Films("Aaaa", ""),
				new Films("Daaa", ""),
				new Films("Ddaa", ""),
				new Films("Ddda", ""),
				new Films("Dddd", ""),
			};
			MyList<Films> expected = new MyList<Films>()
			{				
				new Films("Dddd", ""),
				new Films("Ddda", ""),
				new Films("Ddaa", ""),
				new Films("Daaa", ""),
				new Films("Aaaa", ""),
			};

			filmsList.Sort();

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void OnlyVowelList()
		{
			MyList<Films> filmsList = new MyList<Films>()
			{ 
				new Films("Ауи", ""),
				new Films("Ieи", ""),
				new Films("уЕY", ""),
				new Films("ЯюЭ", ""),
				new Films("UоЮ", ""),
			};
			MyList<Films> expected = new MyList<Films>()
			{				
				new Films("Ауи", ""),
				new Films("Ieи", ""),
				new Films("уЕY", ""),
				new Films("ЯюЭ", ""),
				new Films("UоЮ", ""),
			};

			filmsList.Sort();

			Assert.AreEqual(expected, filmsList);
		}
	}
}
