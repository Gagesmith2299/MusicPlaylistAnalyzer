using System;
using System.Collections.Generic;
using Stytem.IO;
using System.Linq;


namespace MusicReport
{
    public static class MusicReport
    {
		public static string GenerateText(List<MusicStats> musicStatsList)
		{
		string report = "Music Playlist Analyzer\n";

			if (musicStatsList.Count() < 1)
			{
				report += "There is no data.\t";

				return report;
			}

			var yearStart = (from musicStats in musicStatsList select musicStats.Year).Min();
			var yearEnd = (from musicStats in musicStatsList select musicStats.Year).Max();

			report += $"period: {yearStart} - {yearEnd} ({musicStatsList.Count} years)\t";

			







	}
}
