// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var boxScore = BoxScore.FromJson(jsonString);




using CodeLouisville.Common;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using QuickType;
using System.Collections.Generic;

namespace CodeLouisville.Web
{
    public class WebHelpers
    {
                
        public static WeeklySchedule GetWeeklySchedule(int week, out string url)
        {
            url = string.Format(
                "http://api.sportradar.us/nfl/official/trial/v5/en/games/2018/REG/{0}/schedule.json?api_key=p55z9gnh7nsphukhrk36v8xf", week);
            WeeklySchedule data = new WeeklySchedule
            {
                Url = url
            };
            if (data is WeeklySchedule)
            {
                using (var webClient = new WebClient())
                {
                    Console.WriteLine("Downloading...");
                    byte[] weekData = webClient.DownloadData(url);

                    Console.WriteLine("Data successfully downloaded.");
                    var serializer = new JsonSerializer();

                    using (var stream = new MemoryStream(weekData))
                    using (var reader = new StreamReader(stream))
                    using (var jsonReader = new JsonTextReader(reader))
                    {
                        data = serializer.Deserialize<WeeklySchedule>(jsonReader);
                    }
                }
            }

            return data;
        }

        public static BoxScore GetBoxScore(string id)
        {
            BoxScore data = new BoxScore();
            if (data is Common.BoxScore)
            {
                using (var webClient = new WebClient())
                {
                    Console.WriteLine("Downloading...");

                    byte[] weekData = webClient.DownloadData(string.Format(
                        "http://api.sportradar.us/nfl/official/trial/v5/en/games/{0}/boxscore.json?api_key=p55z9gnh7nsphukhrk36v8xf", id));

                    Console.WriteLine("Data successfully downloaded.");

                    var json = System.Text.Encoding.UTF8.GetString(weekData, 0, weekData.Length);
                    data = BoxScoreConverter.FromJson(json); 
                    //var serializer = new JsonSerializer();

                    //using (var stream = new MemoryStream(weekData))
                    //using (var reader = new StreamReader(stream))
                    //using (var jsonReader = new JsonTextReader(reader))
                    //{
                    //    data = serializer.Deserialize<BoxScore>(jsonReader);
                    //}
                }
            }

            return data;
        }

        //TODO finish these methods
        public static void WeeklySchedulesWriteCache(List<WeeklySchedule> weeklySchedules, string fileName)
        {
            weeklySchedules = WeeklySchedulesReadCache();

            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, weeklySchedules);
            }
        }

        public static List<WeeklySchedule> WeeklySchedulesReadCache()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileToRead = Path.Combine(directory.FullName, "weeks.json");

            List<WeeklySchedule> weeklySchedules = new List<WeeklySchedule>();
            var serializer = new JsonSerializer();
            using (var reader = new StreamReader(fileToRead))
            using (var jsonReader = new JsonTextReader(reader))
            {
                weeklySchedules = serializer.Deserialize<List<WeeklySchedule>>(jsonReader);
            }

            return weeklySchedules;
        }
    }
}
