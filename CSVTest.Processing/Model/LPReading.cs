using System;

namespace CSVTest.Model
{
	public class LPReading : Reading
	{
		public double RawDataValue { get; set; }

		public override double DataValue { get { return this.RawDataValue; } }
	}
}
