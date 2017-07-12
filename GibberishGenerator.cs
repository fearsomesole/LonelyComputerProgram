using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LonelyComputerProgram
{
    public class
        GibberishGenerator // todo: possibly make the program scan the hard drives to figure out which drives to display using DriveInfo.GetDrives. REQUIRES PERMISSIONS
    {
        private readonly List<string> _gibberish1;
        private readonly List<string> _gibberish2;
        private readonly List<string> _gibberish3;
        private readonly List<string> _gibberish4;
        private readonly List<string> _gibberish5;
        private readonly List<string> _gibberish6;

        public GibberishGenerator()
        {
            _gibberish1 = new List<string>()
            {
                @"C:\",
                @"D:\",
                @"E:\"

            };
            _gibberish2 = new List<string>()
            {
                @"Logs\",
                @"Program Files\",
                @"Program Files (x86)\",
                @"temp\",
                @"Users\",
                @"Windows",
                @"PerfLogs\"
            };
            _gibberish3 = new List<string>()
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
            _gibberish4 = new List<string>()
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
            _gibberish5 = new List<string>()
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
            _gibberish6 = new List<string>()
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
            };
            
        }

        public void PathGenerator()
        {
            string path = null;
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        path += _gibberish1[rand.Next(0, 2)];
                        break;
                    case 1:
                        path += _gibberish2[rand.Next(0, 6)];
                        break;
                    case 2:
                        path += _gibberish3[rand.Next(0, 12)];
                        break;
                    case 3:
                        path += _gibberish4[rand.Next(0, 12)];
                        break;
                    case 4:
                        path += _gibberish5[rand.Next(0, 12)];
                        break;
                    case 5:
                        path += _gibberish6[rand.Next(0, 25)];
                        break;
                }
            }
            Console.Write(path + "\n");
            path = null;
        }

    }
}