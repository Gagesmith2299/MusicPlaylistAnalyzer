using System;
using System.Collections.Generic;
using System.IO;

namespace MusicPlaylistLoader
{
	public static class MusicPlaylistLoader
	{
		private static int NumItems = 7;
		public static object Intg32 { get; private set; }

		internal static List<MusicStats> Load (string csvDataFile)
		{
			List<MusicStats> musicStatsList = new List<MusicStats>();

			try
			{
				using (var read = new StreamReader(csvDataFile))
				{
					int num = 0;
					while (!read.EndOfStream)
					{
						var lines = read.ReadLine();
						num++;
						if (num == 1) continue;

						var value = lines.Split(',');

						if (value.Length != NumItems)
						{
							throw new Exception("Row {num} contains {value.Length}.");
						}
						try
						{
							string name = Intg32.Parse(value[0]);
							string artist = Intg32.Parse(value[1]);
							string album = Intg32.Parse(value[2]);
							string genre = Intg32.Parse(value[3]);
							int size = Int32.Parse(value[4]);
							int time = Int32.Parse(value[5]);
							int year = Int32.Parse(value[6]);
							int plays = Int32.Parse(value[7]);

							MusicStats musicStats = new MusicStats(name, artist, album, genre, size, time, year, plays);
							musicStatsList.Add(musicStats);
						}
						catch (FormatException e)
						{
							throw new Exception($"Row {num} contains invalid information.");
						}
					}
				}
			}
			catch (Exception e)
			{
				throw new Exception("Unable to open csv file properly.");
			}
			return musicStatsList;
		}
	}
}

		











