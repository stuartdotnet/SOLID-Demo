using Microsoft.Extensions.Configuration;
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
				var builder = new ConfigurationBuilder()
					.SetBasePath(Directory.GetCurrentDirectory())
					.AddJsonFile("appsettings.json", optional: true);
				var configuration = builder.Build();
				string filePath = configuration["FilePath"];

				foreach (var file in Directory.GetFiles(filePath, "*.csv", SearchOption.AllDirectories))
				{
					string fileName = Path.GetFileName(file);
					if (File.Exists(fileName))
					{
						var reader = new CSVReader(file);
						reader.Read();

						if (fileName.StartsWith("TOU"))
						{
							var pro = new TOUProcessor(reader);
							var alert = new ReadingAlerter<TOUProcessor>(pro);
							alert.PrintAlerts(fileName);
						}
						else if (fileName.StartsWith("LP"))
						{
							var pro = new LPProcessor(reader);
							var alert = new ReadingAlerter<LPProcessor>(pro);
							alert.PrintAlerts(fileName);
						}

					}
					else
					{
						Console.WriteLine("File does not exist");
					}
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
