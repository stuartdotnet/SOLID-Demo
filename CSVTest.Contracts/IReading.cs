using System;

namespace CSVTest.Model
{
	public interface IReading
	{
		string DataType { get; set; }
		double DataValue { get; }
		DateTime DateTime { get; set; }
		int MeterPointCode { get; set; }
		string PlantCode { get; set; }
		int SerialNumber { get; set; }
		string Status { get; set; }
		string Units { get; set; }
	}
}