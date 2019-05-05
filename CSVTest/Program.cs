using System;
using System.IO;

namespace CSVTest
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				//if (args.Length < 1)
				//{
				//	Console.WriteLine("Please enter a filename argument");
				//	return;
				//}

				//string file = args[0];

				// Testing //
				 string file = "LP_210095893_20150901T011608049.csv";
				// string file = "TOU_212621145_20150911T022358.csv";


				if (File.Exists(file))
				{
					var reader = new CSVReader(file);
					reader.Read();

					if (file.StartsWith("TOU"))
					{
						var pro = new TOUProcessor(reader);
						var alert = new ReadingAlerter<TOUProcessor>(pro);
						alert.PrintAlerts(file);
					}
					else if (file.StartsWith("LP"))
					{
						var pro = new LPProcessor(reader);
						var alert = new ReadingAlerter<LPProcessor>(pro);
						alert.PrintAlerts(file);
					}

				}
				else
				{
					Console.WriteLine("File does not exist");
				}

				Console.WriteLine("Press any key to exit...");
				Console.ReadLine();
			}
			catch (Exception e)
			{
				Console.WriteLine("Processing Error \n" + e);
			}
		}
	}
}
