﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace LonelyComputerProgram
{
	class Program
	{
		public static string CurrentDateTime = DateTime.Now.ToString();
		//public static string machineName = Environment.MachineName; todo: mention user machine name if opinion too low
		Random rnd = new Random();
		//private int _opinion; todo: implement the opinion system

		static void Main(string[] args)
		{
			SlowWriter.Write("Do you wish to start me?\nY/N\n");
			string choise = Convert.ToString(Console.ReadLine());
			if (choise == "n" || choise == "N")
			{
				Environment.Exit(0); //todo: Remember this decision to ask user about it later. How to save it?
			}
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
			Console.Write("\nWhat will you pick:");
			try
			{
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
			catch (Exception)
			{
				SlowWriter.Write("Please, pick a number!\n");
				goto Start;
			}
		}

		static void Initialization()
		{
			OutputGibberish();
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
			//todo: make it want to continue regardless
		}

		static void OutputGibberish()
		{
            ConsoleSpinner spin = new ConsoleSpinner();
            GibberishGenerator gibGen = new GibberishGenerator();

			SlowWriter.Write("Initializing start........");
		    for (int i = 0; i < 30; i++)
		    {
		        spin.Turn();
                Thread.Sleep(150);
		    }
            Console.Write("\n");
			for (int i = 0; i < 100; i++)
			{
				Console.Write($"[{CurrentDateTime}] Gathering files:");
                gibGen.PathGenerator();
				Thread.Sleep(150);
			}
			SlowWriter.Write("Gathering files........OK\n\nPreparing next phase........");
		    for (int i = 0; i < 30; i++)
		    {
		        spin.Turn();
		        Thread.Sleep(150);
		    }
		    Console.Write("\n");
            for (int i = 0; i < 100; i++)
			{
				Console.Write($"[{CurrentDateTime}] Deconstructing files:");
			    gibGen.PathGenerator();
                Thread.Sleep(150);
			}
			SlowWriter.Write("Deconstructing files........OK\n\nFiguring what this PC has........FAILED\nNot giving a damn........OK\n");
			SlowWriter.Write("Preparing last phase......");
		    for (int i = 0; i < 30; i++)
		    {
		        spin.Turn();
		        Thread.Sleep(150);
		    }
		    Console.Write("\n");
            for (int i = 0; i < 100; i++)
			{
				Console.Write($"[{CurrentDateTime}] Applying files:");
			    gibGen.PathGenerator();
                Thread.Sleep(150);
			}
			SlowWriter.Write("Applying files........OK\nInitialization........OK");
			Thread.Sleep(100);
		}

	}
}
