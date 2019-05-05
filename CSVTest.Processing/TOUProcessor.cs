using CSVTest.Model;
using System;
using System.Collections.Generic;

namespace CSVTest
{
	public class TOUProcessor : IProcessor<IReading>
	{
		private IReader _reader;
		public TOUProcessor(IReader reader)
		{
			_reader = reader;
		}

		public IEnumerable<IReading> ProcessRows()
		{
			var indexes = new
			{
				Energy = _reader.Headers.IndexOf("energy"),
				DateTime = _reader.Headers.IndexOf("date/time")
			};

			foreach (var row in _reader.Rows)
			{
				yield return new TOUReading
				{
					// TODO more robust parsing of course!
					Energy = double.Parse(row[indexes.Energy]),
					DateTime = DateTime.Parse(row[indexes.DateTime])
				};
			}
		}
	}
}
