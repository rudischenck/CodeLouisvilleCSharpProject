using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodeLouisville.Common;
using CodeLouisville.Web;
using CodeLouisville.Utils;

namespace CodeLouisville
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize scores list, will contain scores requested by user
            List<Scoring> scores = new List<Scoring>();
            string input = "";
            var weeklySchedule = new WeeklySchedule();


            //directory to save .json file serialized from requested scores
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            string fileToWrite = Path.Combine(directory.FullName, "scores.json");

            
            Console.WriteLine("Welcome to Rudi's Box Score Fetcher!");
            Console.WriteLine();

            //Attempt to read cache, if not found create cache and restart program
            var weeklyScheduleCache = WebHelpers.ReadWeeklyScheduleCache(out string readCacheOutput, out bool foundCache);
            if(foundCache == false)
            {
                Console.WriteLine(readCacheOutput);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine(readCacheOutput);
            }

            while (input.ToLower() != "q")
            {
                weeklySchedule = Menus.WeekMenu(out input, weeklyScheduleCache);
                if (input.ToLower() != "q")
                {
                    Menus.GameMenu(scores, weeklySchedule, out input);
                }
            }
            if (scores.Count() != 0)
            {
                ScoreSerialize.SerializeScoresToFile(scores, fileToWrite, out string serializeScoresOutput);
                Console.WriteLine(serializeScoresOutput);
            }
            WebHelpers.WeeklySchedulesWriteCache(weeklyScheduleCache, out string writeCacheOutput);
            Console.WriteLine(writeCacheOutput);
            Console.WriteLine("Thanks for using Rudi's box score fetcher! I hope you had a good time!");

        }


    }
}
