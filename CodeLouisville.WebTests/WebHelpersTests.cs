using Xunit;
using QuickType;
using CodeLouisville.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLouisville.Common;

namespace CodeLouisville.Web.Tests
{
    public class WebHelpersTests
    {
        [Fact()]
        public void GetWeeklyScheduleValidWeeklySchedule()
        {
            string url;
            var target = WebHelpers.GetWeeklySchedule(1, out url);

            Assert.True(target is WeeklySchedule);
        }

        [Fact()]
        public void GetBoxScoreValidBoxScore()
        {
            var target = WebHelpers.GetBoxScore("0c38ce7b-ab8e-4474-a051-db8f00dd3799");

            Assert.True(target is BoxScore);
        }

        [Fact()]
        public void GetWeeklyScheduleString()
        {
            string target = "http://api.sportradar.us/nfl/official/trial/v5/en/games/2018/REG/1/schedule.json?api_key=p55z9gnh7nsphukhrk36v8xf";
            string url;

            var weeklySchedule = WebHelpers.GetWeeklySchedule(1, out url);
            Assert.True(url == target);
        }
    }
}