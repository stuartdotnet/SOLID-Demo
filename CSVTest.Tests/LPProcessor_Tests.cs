using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace CSVTest.Tests
{
	[TestClass]
	public class LPProcessor_Tests
	{
		[TestMethod]
		public void ProcessRows_WhenDataValuePresent_ProcessedCorrectly()
		{
			// Arrange
			double DATAVALUE = 124;

			var mockReader = new Mock<IReader>();
			mockReader.Setup(r => r.Headers).Returns(new List<string> { "data value", "date/time" });

			var row = new List<List<string>>() { new List<string> { $"{DATAVALUE}", "2000-1-1" } };
			mockReader.Setup(r => r.Rows).Returns(row);

			var proc = new LPProcessor(mockReader.Object);

			// Act
			var readings = proc.ProcessRows();

			// Assert
			Assert.AreEqual(DATAVALUE, readings.ToList().First().DataValue);
		}
	}
}
