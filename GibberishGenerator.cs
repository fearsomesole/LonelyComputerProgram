using System.Collections.Generic;

namespace LonelyComputerProgram
{
	public class GibberishGenerator
	{
		private List<string> Gibberish1 =
			new List<string>() // possibly make the program scan the hard drives to figure out which drives to display
			{
				@"C:\",
				@"D:\",
				@"E:\"

			};

		private List<string> Gibberish2 =
			new List<string>()
			{
				@"Logs\",
				@"Program Files\",
				@"Program Files (x86)\",
				@"temp\",
				@"Users\",
				@"Windows",
				@"PerfLogs\"
			};

		private List<string> Gibberish3 =
			new List<string>()
			{
				@"",
				@"",
				@"",
				@"",
				@"",
				@"",
				@"",
				@"",
				@"",
				@""
			};

		private List<string> Gibberish4 =
			new List<string>()
			{
				@"",
				@"",
				@""
			};

		private List<string> Gibberish5 =
			new List<string>()
			{
				@"",
				@""
			};

		private List<string> Gibberish6 =
			new List<string>()
			{
				@"",
				@""
			};
	}
}