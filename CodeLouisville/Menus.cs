//this class contains UI elements for the program.

using CodeLouisville.Common;
using CodeLouisville.Web;
using System;
using System.Collections.Generic;

namespace CodeLouisville
{
    class Menus
    {
        public static WeeklySchedule WeekMenu(out string input, List<WeeklySchedule> weeklyScheduleCache)
        {
            var output = new List<string>();
            var weeklySchedule = new WeeklySchedule();

            while (true)
            {
                //loop to select from nfl weekly schedules
                Console.WriteLine();
                Console.WriteLine("Please select a week from 1-9 or 'q' to quit");
                input = Console.ReadLine();
                Console.WriteLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                int nflWeek;

                if (int.TryParse(input, out int result))
                {
                    nflWeek = result;
                }
                else
                {
                    Console.WriteLine("That is not valid input, please try again.");
                    continue;
                }

                if (0 >= nflWeek || nflWeek > 9)

                {
                    Console.WriteLine("That is not a valid input, please try again.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Retrieving weekly schedule...");
                    weeklySchedule = WebHelpers.GetWeeklySchedule(nflWeek, out output, weeklyScheduleCache);
                    foreach(string s in output)
                    {
                        Console.WriteLine(s);
                    }
                    break;
                }

            }

            return weeklySchedule;
        }

        public static void GameMenu(List<Game> games, WeeklySchedule weeklySchedule, out string input)
        {
            input = "";
            if (weeklySchedule != null)
            {
                while (true)
                {
                    Console.WriteLine();
                    int counter = 1;
                    Console.WriteLine("================");
                    foreach (var gameToDisplay in weeklySchedule.Week.Games)
                    {
                        Console.Write(counter.ToString() + ". ");
                        Console.WriteLine(gameToDisplay.DisplayMatchup());
                        counter++;
                    }
                    Console.WriteLine("================");

                    Console.WriteLine("Select the score you would like to see from the menu above, 'q' to quit, or 'w' to return to week selection menu.");
                    input = Console.ReadLine();
                    Console.WriteLine("================");
                    Console.WriteLine();

                    int gameNumber = -1;
                    Game game = new Game();

                    if (input.ToLower() == "q" || input.ToLower() == "w")
                    {
                        break;
                    }
                    else if (int.TryParse(input, out int result))
                    {
                        gameNumber = result;
                    }
                    else
                    {
                        Console.WriteLine("That is not valid input, please try again.");
                        continue;
                    }

                    try
                    {
                        game = weeklySchedule.Week.Games[gameNumber - 1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("That is not a valid input. Please try again.");
                        continue;
                    }

                    if (!games.Contains(game))
                    {
                        games.Add(game);
                    }

                    Console.WriteLine(game.DisplayScore());
                }

            }
        }

    }
}
