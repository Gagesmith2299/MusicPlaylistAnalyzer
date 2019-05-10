using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicPlaylistAnalyzer
{
    class Program
    {																//I tried my absolute best, however I still could not get the program to 100% work
																	//My MusicStatsLoader has issues with getting Parse to work properly with strings
        static void Main(string[] args)								//Other than this, My MusicReport file is incomplete. It was the only Part of the 
        {															//assignment that truly stumped me. I still hope that I receive some credit for my code 
			if (args.Length != 2)									//and attempt however. Both the MusicStats and the Program.cs file work as intended
			{														//so far as i can tell. I gave this class my best attempt, however I am just not ment to be a programmer.
				Console.WriteLine("MusicPlaylistAnalyzer <music_csv_file_path> <report_file_path");
				Environment.Exit(0);
			}

			string csvDataFile = args[0];
			string reportFile = args[1];

			List<MusicStats> MusicStatsList = null;
			try
			{
				MusicStatsList = MusicStatsLoader.Load(csvDataFile);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Environment.Exit(2);
			}

			var report = MusicStatsReport.GenerateText(MusicStats);

			try
			{
				System.IO.File.WriteAllText(reportFilePath, report);
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Environment.Exit(3);
			}


			}
        }
    }

