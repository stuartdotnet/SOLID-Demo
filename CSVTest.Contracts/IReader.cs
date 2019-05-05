using System.Collections.Generic;

namespace CSVTest
{
	public interface IReader
	{
		void Read();
		IEnumerable<List<string>> Rows { get; }
		List<string> Headers { get; }
	}
}
