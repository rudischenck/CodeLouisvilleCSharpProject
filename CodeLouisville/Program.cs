using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //directory to save .json file serialized from requested scores
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileToWrite = Path.Combine(directory.FullName, "scores.json");

            
            Console.WriteLine("Welcome to Rudi's Box Score Fetcher!");
            Console.WriteLine();

            while (true)
            {
                //loop to select from nfl weekly schedules
                Console.WriteLine();
                Console.WriteLine("Please select a week from 1-9 or 'q' to quit");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                int nflWeek;

                if(int.TryParse(input, out int result))
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
                    var weeklySchedule = WebHelpers.GetWeeklySchedule(nflWeek);

                    while (true)
                    {
                        Console.WriteLine();
                        int counter = 1;
                        foreach (var gameToDisplay in weeklySchedule.Week.Games)
                        {
                            Console.Write(counter.ToString() + ". ");
                            gameToDisplay.DisplayMatchup();
                            counter++;
                        }
                        Console.WriteLine("Select the score you would like to see from the numbered menu above or 'q' to quit");

                        string input2 = Console.ReadLine();
                        int gameNumber = -1;
                        Game game = new Game();

                        if(input2.ToLower() == "q")
                        {
                            break;
                        }
                        else if(int.TryParse(input2, out int result2))
                        {
                            gameNumber = result2;
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

                        if(!scores.Contains(game.Scoring))
                        {
                            scores.Add(game.Scoring);
                        }

                        game.DisplayScore();
                    }
                }
            }

            ScoreSerialize.SerializeScoresToFile(scores, fileToWrite);

        }
    }
}
