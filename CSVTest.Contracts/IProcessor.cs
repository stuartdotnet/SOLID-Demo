using CSVTest.Model;
using System.Collections.Generic;

namespace CSVTest
{
	public interface IProcessor<T> where T : IReading
	{
		IEnumerable<T> ProcessRows();
	}
}
