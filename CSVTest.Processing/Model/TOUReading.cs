using System;

namespace CSVTest.Model
{
	public class TOUReading : Reading
	{
		public double Energy { get; set; }
		public double MaximumDemand { get; set; }
		public DateTime TimeOfMaxDemand { get; set; }
		public string Period { get; set; }
		public bool DLSActive { get; set; }
		public int BillingResetCount { get; set; }
		public DateTime BillingResetDateTime { get; set; }
		public string Rate { get; set; }

		public override double DataValue { get { return this.Energy; } }
	}
}
