using System;
using System.Threading;
using System.Timers;

namespace LonelyComputerProgram
{
	public class SlowWriter
	{
		//private static System.Timers.Timer aTimer;
		private static readonly Random Rnd = new Random();

		public static void Write(string text)
		{
			foreach (char c in text)
			{
				Console.Write(c);
				Thread.Sleep(Rnd.Next(20, 30) + 50);
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
//class Program
//{
//	static void Main(string[] args)
//	{
//		Timer tim = new Timer(1000);
//		tim.Elapsed += Tim_Elapsed;
//		tim.Start();
//		//program ends when Q is pressed.
//		while (Console.ReadKey().Key != ConsoleKey.Q)//Readkey blocks main thread, but it keeps the process responsive.
//		{

//		}
//	}

//	private static void Tim_Elapsed(object sender, ElapsedEventArgs e)//will run on a different thread. 
//	{
//		Console.Write('.');
//	}
//}
