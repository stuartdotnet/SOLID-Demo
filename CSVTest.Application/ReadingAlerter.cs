using CSVTest.Model;
using CSVTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSVTest
{
	public class ReadingAlerter<TProcessor> 
		where TProcessor : IProcessor<IReading>
	{
		private IProcessor<IReading> _processor;

		public ReadingAlerter(TProcessor processor)
		{
			_processor = processor;
		}

		public void PrintAlerts(string file)
		{
			var readings = _processor.ProcessRows();
			double median = readings.Select(r => r.DataValue).ToList().GetMedian();

			var abnormals = GetAbnormals(readings, median, 20, 20);

			foreach (var i in abnormals)
			{
				Console.WriteLine($"{file} {i.DateTime} {i.DataValue} {median}");
			}
		}

		private static IEnumerable<IReading> GetAbnormals(IEnumerable<IReading> readings, double median, double lowRangePercentage, double highRangePercentage)
		{
			return readings.Where(r =>
			r.DataValue > (median + median.GetPercentage(highRangePercentage)) ||
			r.DataValue > (median - median.GetPercentage(lowRangePercentage)));
		}
	}
}
