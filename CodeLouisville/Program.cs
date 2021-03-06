﻿using System;
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
            //initialize games list, will contain games requested by user
            List<Game> games = new List<Game>();
            string input = "";
            var weeklySchedule = new WeeklySchedule();


            //directory to save .json file serialized from requested games
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            string fileToWrite = Path.Combine(directory.FullName, "games.json");

            
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


            //main loop for displaying menus
            while (input.ToLower() != "q")
            {
                weeklySchedule = Menus.WeekMenu(out input, weeklyScheduleCache);
                if (input.ToLower() != "q")
                {
                    Menus.GameMenu(games, weeklySchedule, out input);
                }
                //add the requested week to the cache if the cache does not contain the requested week
                if (weeklySchedule.Id != null && !weeklyScheduleCache.Contains(weeklySchedule))
                {
                    weeklyScheduleCache.Add(weeklySchedule);
                }
            }
            //serialize requested games to disk
            if (games.Count() != 0)
            {
                GamesSerialize.SerializeGamesToFile(games, fileToWrite, out string serializeGamesOutput);
                Console.WriteLine(serializeGamesOutput);
            }
            //write cache
            WebHelpers.WeeklySchedulesWriteCache(weeklyScheduleCache, out string writeCacheOutput);
            Console.WriteLine(writeCacheOutput);

            //end program
            Console.WriteLine("Thanks for using Rudi's box score fetcher! I hope you had a good time!");

        }


    }
}
