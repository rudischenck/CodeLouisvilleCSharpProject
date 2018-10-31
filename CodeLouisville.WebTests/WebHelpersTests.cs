using Xunit;
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
            int week = 1;
            var target = WebHelpers.GetWeeklySchedule(week);

            Assert.True(target is WeeklySchedule);
        }
    }
}