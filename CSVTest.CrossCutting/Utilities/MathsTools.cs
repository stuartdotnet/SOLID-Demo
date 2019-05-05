using System.Collections.Generic;

namespace CSVTest.Utilities
{
	public static class MathsTools
	{
		public static double GetMedian(this List<double> values)
		{
			values.Sort();

			int size = values.Count;
			int mid = size / 2;
			double median = (size % 2 != 0) ? (double)values[mid] : ((double)values[mid] + (double)values[mid - 1]) / 2;
			return median;
		}

		public static double GetPercentage(this double input, double percentage)
		{
			return (input * percentage) / 100;
		}
	}
}
