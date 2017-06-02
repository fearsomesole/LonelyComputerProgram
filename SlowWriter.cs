using System;
using System.Threading;
using System.Timers;

namespace LonelyComputerProgram
{
	public class SlowWriter
	{
		private static System.Timers.Timer aTimer;
		private static Random _rnd = new Random();

		public static void Write(string text)
		{
			foreach (char c in text)
			{
				Console.Write(c);
				Thread.Sleep(_rnd.Next(75) + 50);
			}
		}
		//private static void SetTimer()
		//{
		//	aTimer = new System.Timers.Timer(_rnd.Next(40, 60))
		//	{
		//		AutoReset = true,
		//		Enabled = true
		//	};
		//}
	}
}