using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LonelyComputerProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			Initialization();
			MainMenu();
		}

		static void MainMenu()
		{
			Console.WriteLine("1. ");
			Console.WriteLine("2. ");
			Console.WriteLine("3. ");
			Console.WriteLine("4. Exit");
		Start:
			int userPick = Convert.ToInt16(Console.ReadLine());
			switch (userPick)
			{
				case 1:
					Case1();
					break;
				case 2:
					Case2();
					break;
				case 3:
					Case3();
					break;
				case 4:
					Exit();
					break;
				default:
					SlowWriter.Write("I am sorry, but I do not have those commands. Would you try one of the upper ones?");
					goto Start;
			}
		}

		static void Initialization()
		{
			Console.Clear();
			string username = Environment.UserName;
			SlowWriter.Write("Hello, " + username + ", how can I help you?\n \n");
		}

		static void Case1()
		{
			Console.WriteLine("you chose first case \nTry again?\n");
			MainMenu();
		}

		static void Case2()
		{
			Console.WriteLine("you chose second case \nTry again?\n");
			MainMenu();
		}
		static void Case3()
		{
			Console.WriteLine("you chose third case \nTry again?\n");
			MainMenu();
		}
		static void Exit()
		{
			SlowWriter.Write("Are you sure you want to leave me? \ny/n\n");
			Console.ReadLine();
		}//hello

	}
}
