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

namespace CodeLouisville.Web
{
    public class WebHelpers
    {
                
        public static WeeklySchedule GetWeeklySchedule(int week)
        {
            WeeklySchedule data = new WeeklySchedule();
            if (data is Common.WeeklySchedule)
            {
                using (var webClient = new WebClient())
                {
                    Console.WriteLine("Downloading...");

                    byte[] weekData = webClient.DownloadData(string.Format(
                        "http://api.sportradar.us/nfl/official/trial/v5/en/games/2018/REG/{0}/schedule.json?api_key=p55z9gnh7nsphukhrk36v8xf", week));

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


    }
}
