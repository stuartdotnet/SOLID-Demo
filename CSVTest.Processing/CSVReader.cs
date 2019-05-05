using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVTest
{
	public class CSVReader : IReader
	{
		private string _file;
		protected const char DELIMETER = ',';
		protected const int HEADERINDEX = 0, HEADERROWCOUNT = HEADERINDEX + 1;

		public IEnumerable<List<string>> Rows { get; private set; }
		public List<string> Headers { get; private set; }

		public CSVReader(string file)
		{
			_file = file;
		}

		public void Read()
		{
			try
			{
				var rows = File.ReadAllLines(_file);

				Headers = rows
					.ElementAt(HEADERINDEX)
					.Split(DELIMETER)
					.Select(x => x.Trim().ToLowerInvariant())
					.ToList();

				Rows = rows.Skip(HEADERROWCOUNT)
								   .Select(x => x.Split(',').Select(y => y.Trim()).ToList());
			}
			catch (Exception e)
			{
				Console.WriteLine("Problem reading/parsing CSV. \n" + e);
				throw;
			}
		}
	}
}
