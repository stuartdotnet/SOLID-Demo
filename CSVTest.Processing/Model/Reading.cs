using System;

namespace CSVTest.Model
{
	public abstract class Reading : IReading
	{
		public int MeterPointCode { get; set; }
		public int SerialNumber { get; set; }
		public string PlantCode { get; set; }
		public DateTime DateTime { get; set; }
		public string DataType { get; set; }
		public string Units { get; set; }
		public string Status { get; set; }

		public abstract double DataValue { get; }
	}
}
