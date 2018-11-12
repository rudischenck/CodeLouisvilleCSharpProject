//Helper functions for data serialization and download.




using CodeLouisville.Common;
using Newtonsoft.Json;
using System.Linq;
using System;
using System.IO;
using System.Net;
using QuickType;
using System.Collections.Generic;

namespace CodeLouisville.Web
{
    public class WebHelpers
    {
        //checks cache then web and writes cache for requested weeklyschedule.        
        public static WeeklySchedule GetWeeklySchedule(int week, out List<string> output, List<WeeklySchedule> weeklyScheduleCache)
        {

            output = new List<string>();

            //List<WeeklySchedule> weeklyScheduleCache = new List<WeeklySchedule>();
            WeeklySchedule requestedWeek = new WeeklySchedule();

            //weeklyScheduleCache = ReadWeeklyScheduleCache(out string readCacheOutput);
            //output.Add(readCacheOutput);
            try
            {
                requestedWeek = weeklyScheduleCache.Single((weeklySchedule) => weeklySchedule.Week.Title == week);
                output.Add("Requested week found in cache.");
            }
            catch (ArgumentNullException)
            {
                output.Add("Requested week not found in cache.");
                requestedWeek = DownloadWeeklySchedule(week, out string downloadWeeklyScheduleOutput);
                output.Add(downloadWeeklyScheduleOutput);
                weeklyScheduleCache.Add(requestedWeek);
            }
            catch (InvalidOperationException)
            {
                output.Add("Requested week not found in cache.");
                requestedWeek = DownloadWeeklySchedule(week, out string downloadWeeklyScheduleOutput);
                output.Add(downloadWeeklyScheduleOutput);
                weeklyScheduleCache.Add(requestedWeek);

            }
            //try
            //{
            //    WeeklySchedulesWriteCache(weeklyScheduleCache, out string writeCacheOutput);
            //    output.Add(writeCacheOutput);
            //}
            ////TODO figure this out Environment.Exit(0);
            //catch(IOException)
            //{
            //    output.Add("New cache file created. Please restart the program.");
            //    Environment.Exit(0);
            //}
            return requestedWeek;
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

        //
        public static void WeeklySchedulesWriteCache(List<WeeklySchedule> weeklySchedules, out string writeCacheOutput)
        {
            writeCacheOutput = "";
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileToWrite = Path.Combine(directory.FullName, "weekscache.json");

            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileToWrite))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                writeCacheOutput = "Writing weekly schedule cache.";
                try
                {
                    serializer.Serialize(jsonWriter, weeklySchedules);
                    writeCacheOutput += "\n Success!";
                }
                catch
                {
                    writeCacheOutput += "\n Failure!";
                }
            }
        }

        public static List<WeeklySchedule> ReadWeeklyScheduleCache(out string readCacheOutput, out bool foundCache)
        {
            foundCache = false;
            readCacheOutput = "";
            List <WeeklySchedule> weeklyScheduleCache = new List<WeeklySchedule>();

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            string scoresCacheFile = Path.Combine(directory.FullName, "weekscache.json");

            if (!File.Exists(scoresCacheFile))
            {
                
                File.Create(scoresCacheFile);
                readCacheOutput = "The weekly schedule cache was not found and has been created. Please restart the program.";
                return weeklyScheduleCache;
            }
            else
            {
                foundCache = true;
                var serializer = new JsonSerializer();
                using (var reader = new StreamReader(scoresCacheFile))
                using (var jsonReader = new JsonTextReader(reader))
                {
                    readCacheOutput = "Reading weekly schedule cache...";
                    try
                    {
                        weeklyScheduleCache = serializer.Deserialize<List<WeeklySchedule>>(jsonReader);
                        if (weeklyScheduleCache == null)
                        {
                            weeklyScheduleCache = new List<WeeklySchedule>();
                        }
                        readCacheOutput += "\nSuccess!";
                    }
                    catch
                    {
                        readCacheOutput += "\nFailure!";
                    }
                }
            }
                //TODO figure this out Environment.Exit(0);

            
            return weeklyScheduleCache;
        }

        public static WeeklySchedule DownloadWeeklySchedule(int week, out string downloadWeeklyScheduleOutput)
        {
            downloadWeeklyScheduleOutput = "";
            var weeklySchedule = new WeeklySchedule();


            using (var webClient = new WebClient())
            {

                string url = string.Format(
                    "http://api.sportradar.us/nfl/official/trial/v5/en/games/2018/REG/{0}/schedule.json?api_key=p55z9gnh7nsphukhrk36v8xf", week.ToString());

                downloadWeeklyScheduleOutput = "Downloading data...";

                try
                {
                    byte[] weekData = webClient.DownloadData(url);
                    var serializer = new JsonSerializer();

                    using (var stream = new MemoryStream(weekData))
                    using (var reader = new StreamReader(stream))
                    using (var jsonReader = new JsonTextReader(reader))
                    {
                        weeklySchedule = serializer.Deserialize<WeeklySchedule>(jsonReader);
                    }
                    downloadWeeklyScheduleOutput += "\nData successfully downloaded.";
                }
                catch
                {
                    downloadWeeklyScheduleOutput += "\nDownload failed!";
                }
            }


            return weeklySchedule;
        }
    }
}
