using CSVTest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSVTest.Tests
{
	[TestClass]
	public class GetMedian_Tests
	{
		[TestMethod]
		public void GetMedian_When1_5_10_ThenMedianIs5()
		{
			List<double> numbers = new List<double>
			{
				1, 5, 10
			};

			double median = numbers.GetMedian();

			Assert.AreEqual(5, median);
		}

		[TestMethod]
		public void GetMedian_When1_50_100_ThenMedianIs50()
		{
			List<double> numbers = new List<double>
			{
				1, 50, 100
			};

			double median = numbers.GetMedian();

			Assert.AreEqual(50, median);
		}

		[TestMethod]
		public void GetMedian_When1_500_100_ThenMedianIs500()
		{
			List<double> numbers = new List<double>
			{
				1, 500, 1000
			};

			double median = numbers.GetMedian();

			Assert.AreEqual(500, median);
		}
	}
}
