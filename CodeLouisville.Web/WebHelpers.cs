using CodeLouisville.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisville.Web
{
    public static class WebHelpers
    {
        public static WeeklySchedule GetWeeklySchedule(int week)
        {
            var weeklySchedule = new WeeklySchedule();
            var webClient = new WebClient();

            byte[] weekData = webClient.DownloadData(string.Format(
                "https://api.sportradar.us/nfl/official/trial/v5/en/games/2018/REG/{0}/schedule.json?api_key=p55z9gnh7nsphukhrk36v8xf", week));

            var serializer = new JsonSerializer();

            using (var stream = new MemoryStream(weekData))
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                weeklySchedule = serializer.Deserialize<WeeklySchedule>(jsonReader);
            }

            return weeklySchedule;
        }
    }
}
