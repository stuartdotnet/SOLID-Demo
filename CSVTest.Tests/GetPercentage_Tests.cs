using CSVTest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSVTest.Tests
{
	[TestClass]
	public class GetPercentage_Tests
	{
		[TestMethod]
		public void GetPercentage_When25percentof4_ThenReturn1()
		{
			double input = 4;
			double percentage = 25;

			double result = input.GetPercentage(percentage);

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void GetPercentage_When100percentof10_ThenReturn10()
		{
			double input = 10;
			double percentage = 100;

			double result = input.GetPercentage(percentage);

			Assert.AreEqual(10, result);
		}

		[TestMethod]
		public void GetPercentage_When0percentof4_ThenReturn0()
		{
			double input = 4;
			double percentage = 0;

			double result = input.GetPercentage(percentage);

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void GetPercentage_When32percentof423_ThenReturn135point36()
		{
			double input = 423;
			double percentage = 32;

			double result = input.GetPercentage(percentage);

			Assert.AreEqual(135.36, result);
		}
	}
}
