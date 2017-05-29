using System;
using System.Threading;

namespace LonelyComputerProgram
{
	public class SlowWriter
	{
		public static void Write(string text)
		{
			Random rnd = new Random();
			foreach (char c in text)
			{
				Console.Write(c);
				Thread.Sleep(rnd.Next(40, 60));

			}
		}
	}
}