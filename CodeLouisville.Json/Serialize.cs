using CodeLouisville.Common;
using Newtonsoft.Json;

namespace CodeLouisville.Json
{
    public static class WeeklyScheduleSerialize
    {
        public static string ToJson(this WeeklySchedule self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }
}
