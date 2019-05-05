using CSVTest.Model;
using System;
using System.Collections.Generic;

namespace CSVTest
{
	public class LPProcessor : IProcessor<IReading>
	{
		private IReader _reader;
		public LPProcessor(IReader reader)
		{
			_reader = reader;
		}

		public IEnumerable<IReading> ProcessRows()
		{
			var indexes = new
			{
				RawDataValue = _reader.Headers.IndexOf("data value"),
				DateTime = _reader.Headers.IndexOf("date/time")
			};

			foreach (var row in _reader.Rows)
			{
				yield return new LPReading
				{
					// TODO more robust parsing of course!
					RawDataValue = double.Parse(row[indexes.RawDataValue]),
					DateTime = DateTime.Parse(row[indexes.DateTime])
				};
			}
		}
	}
}
