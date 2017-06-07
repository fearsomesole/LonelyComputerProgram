using System.Collections.Generic;

namespace LonelyComputerProgram
{
	public class GibberishGenerator
	{
		private List<string> _gibberish1 =
			new List<string>() // todo: possibly make the program scan the hard drives to figure out which drives to display using DriveInfo.GetDrives. REQUIRES PERMISSIONS
			{
				@"C:\",
				@"D:\",
				@"E:\"

			};

		private List<string> _gibberish2 =
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

		private List<string> _gibberish3 =
			new List<string>()
			{
				@"Download\",
				@"Music\",
				@"Pictures\",
				@"Videos\",
				@"Games\",
				@"Torrents\",
				@"Microsoft\",
				@"Windows Defender\",
				@"WinRAR\",
				@"Resources\",
				@"Setup\",
				@"Public\",
				@"system32\"
			};

		private List<string> _gibberish4 =
			new List<string>()
			{
				@"Salt\",
				@"Sea spice\",
				@"Passwords\",
				@"Dont look\",
				@"High ground\",
				@"Incriminating evidence\",
				@"World domination plans\",
				@"My hopes and dreams\",
				@"Asdf\",
				@"Qwerty\",
				@"Totally Not Nuclear Launch Codes\",
				@"MLP all seasons\",
				@"Cofveve\"
			};

		private List<string> _gibberish5 =
			new List<string>()
			{
				@"Tax Evasion\",
				@"the folder is empty\",
				@"TOTALLY not dirty laundry\",
				@"Shirtless buff guys\",
				@"Sanic\",
				@"Sonic fanfic\",
				@"Qwerty\",
				@"Asdf\",
				@"Nuclear launch codes\",
				@"Mom's spaghetti\",
				@"Big eskimos\",
				@"Dealer numbers\",
				@"Super secret russian spy folder\"
			};

		private List<string> _gibberish6 =
			new List<string>()
			{
				"LitMixtape.mp4",
				"NotVirus.bat",
				"NsaWetDreams.txt",
				"10_hours_of_yodeling.mp4⁠⁠⁠⁠",
				"Candycrush.exe",
				"Interstellar_br_sub.ini",
				"Ihave3legs.rar",
				"Manifesto.ppt",
				"Manifesto.pdf",
				"Manifesto.mp4",
				"CureForLisp.pdf",
				"MeinKampf.pdf",
				"Book_of_Mormon.txt",
				"More_ram.bat",
				"Always_nuke_twice.docx",
				"Obama_birth_certificate.png",
				"Mikke_Windhelm_2017_6_2.sav",
				"The_life_and_times_of_ron_jeremy.tiff",
				"Detective_wee_wee_super_secret_file.exe",
				"Defective_pee_pees.zip",
				"DownloadFreeGamez.exe",
				"Its_only_fun_when_they_run.rar",
				"ZombieApocalypseTraining.mov",
				"Minecarft.exe",
				"Im_mary_poppins_yall.exe",
				"Free_movie_downloader.exe"
				//@"",
				//@"",
				//@"",
				//@"",
				//@"",
				//@"",
				//@"",
				//@"",
				//@"",
				//@"",
				//@"",
				//@"",
				//@""
			};

		public GibberishGenerator(List<string> gibberish5, List<string> gibberish6, List<string> gibberish4, List<string> gibberish3, List<string> gibberish2, List<string> gibberish1)
		{
			_gibberish1 = gibberish1;
			_gibberish2 = gibberish2;
			_gibberish3 = gibberish3;
			_gibberish4 = gibberish4;
			_gibberish5 = gibberish5;
			_gibberish6 = gibberish6;
		}

	}
}