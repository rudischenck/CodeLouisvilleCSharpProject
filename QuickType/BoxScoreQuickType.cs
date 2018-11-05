// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var boxScore = BoxScore.FromJson(jsonString);

using System;
using CodeLouisville.Common;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace QuickType
{
    public partial class BoxScoreConverter
    {
        public static BoxScore FromJson(string json) => JsonConvert.DeserializeObject<BoxScore>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this BoxScore self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                EndReasonConverter.Singleton,
                DetailCategoryConverter.Singleton,
                AliasConverter.Singleton,
                MarketConverter.Singleton,
                NameConverter.Singleton,
                SrIdConverter.Singleton,
                PositionConverter.Singleton,
                RoleEnumConverter.Singleton,
                ResultConverter.Singleton,
                HashMarkConverter.Singleton,
                HuddleConverter.Singleton,
                PlayDirectionConverter.Singleton,
                StatTypeEnumConverter.Singleton,
                PocketLocationConverter.Singleton,
                QbAtSnapConverter.Singleton,
                IncompletionTypeConverter.Singleton,
                PlayTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class EndReasonConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EndReason) || t == typeof(EndReason?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Field Goal":
                    return EndReason.FieldGoal;
                case "Touchdown":
                    return EndReason.Touchdown;
            }
            throw new Exception("Cannot unmarshal type EndReason");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EndReason)untypedValue;
            switch (value)
            {
                case EndReason.FieldGoal:
                    serializer.Serialize(writer, "Field Goal");
                    return;
                case EndReason.Touchdown:
                    serializer.Serialize(writer, "Touchdown");
                    return;
            }
            throw new Exception("Cannot marshal type EndReason");
        }

        public static readonly EndReasonConverter Singleton = new EndReasonConverter();
    }

    internal class DetailCategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DetailCategory) || t == typeof(DetailCategory?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "field_goal":
                    return DetailCategory.FieldGoal;
                case "kick_off":
                    return DetailCategory.KickOff;
                case "kick_off_return":
                    return DetailCategory.KickOffReturn;
                case "pass_completion":
                    return DetailCategory.PassCompletion;
                case "pass_incompletion":
                    return DetailCategory.PassIncompletion;
                case "pass_reception":
                    return DetailCategory.PassReception;
                case "penalty":
                    return DetailCategory.Penalty;
                case "review":
                    return DetailCategory.Review;
                case "rush":
                    return DetailCategory.Rush;
                case "tackle":
                    return DetailCategory.Tackle;
                case "touchback":
                    return DetailCategory.Touchback;
                case "touchdown":
                    return DetailCategory.Touchdown;
                case "two_point_pass":
                    return DetailCategory.TwoPointPass;
            }
            throw new Exception("Cannot unmarshal type DetailCategory");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DetailCategory)untypedValue;
            switch (value)
            {
                case DetailCategory.FieldGoal:
                    serializer.Serialize(writer, "field_goal");
                    return;
                case DetailCategory.KickOff:
                    serializer.Serialize(writer, "kick_off");
                    return;
                case DetailCategory.KickOffReturn:
                    serializer.Serialize(writer, "kick_off_return");
                    return;
                case DetailCategory.PassCompletion:
                    serializer.Serialize(writer, "pass_completion");
                    return;
                case DetailCategory.PassIncompletion:
                    serializer.Serialize(writer, "pass_incompletion");
                    return;
                case DetailCategory.PassReception:
                    serializer.Serialize(writer, "pass_reception");
                    return;
                case DetailCategory.Penalty:
                    serializer.Serialize(writer, "penalty");
                    return;
                case DetailCategory.Review:
                    serializer.Serialize(writer, "review");
                    return;
                case DetailCategory.Rush:
                    serializer.Serialize(writer, "rush");
                    return;
                case DetailCategory.Tackle:
                    serializer.Serialize(writer, "tackle");
                    return;
                case DetailCategory.Touchback:
                    serializer.Serialize(writer, "touchback");
                    return;
                case DetailCategory.Touchdown:
                    serializer.Serialize(writer, "touchdown");
                    return;
                case DetailCategory.TwoPointPass:
                    serializer.Serialize(writer, "two_point_pass");
                    return;
            }
            throw new Exception("Cannot marshal type DetailCategory");
        }

        public static readonly DetailCategoryConverter Singleton = new DetailCategoryConverter();
    }

    internal class AliasConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Alias) || t == typeof(Alias?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "NE":
                    return Alias.Ne;
                case "PHI":
                    return Alias.Phi;
            }
            throw new Exception("Cannot unmarshal type Alias");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Alias)untypedValue;
            switch (value)
            {
                case Alias.Ne:
                    serializer.Serialize(writer, "NE");
                    return;
                case Alias.Phi:
                    serializer.Serialize(writer, "PHI");
                    return;
            }
            throw new Exception("Cannot marshal type Alias");
        }

        public static readonly AliasConverter Singleton = new AliasConverter();
    }

    internal class MarketConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Market) || t == typeof(Market?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "New England":
                    return Market.NewEngland;
                case "Philadelphia":
                    return Market.Philadelphia;
            }
            throw new Exception("Cannot unmarshal type Market");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Market)untypedValue;
            switch (value)
            {
                case Market.NewEngland:
                    serializer.Serialize(writer, "New England");
                    return;
                case Market.Philadelphia:
                    serializer.Serialize(writer, "Philadelphia");
                    return;
            }
            throw new Exception("Cannot marshal type Market");
        }

        public static readonly MarketConverter Singleton = new MarketConverter();
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Eagles":
                    return Name.Eagles;
                case "Patriots":
                    return Name.Patriots;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Name)untypedValue;
            switch (value)
            {
                case Name.Eagles:
                    serializer.Serialize(writer, "Eagles");
                    return;
                case Name.Patriots:
                    serializer.Serialize(writer, "Patriots");
                    return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }

    internal class SrIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SrId) || t == typeof(SrId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "sr:competitor:4424":
                    return SrId.SrCompetitor4424;
                case "sr:competitor:4428":
                    return SrId.SrCompetitor4428;
            }
            throw new Exception("Cannot unmarshal type SrId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SrId)untypedValue;
            switch (value)
            {
                case SrId.SrCompetitor4424:
                    serializer.Serialize(writer, "sr:competitor:4424");
                    return;
                case SrId.SrCompetitor4428:
                    serializer.Serialize(writer, "sr:competitor:4428");
                    return;
            }
            throw new Exception("Cannot marshal type SrId");
        }

        public static readonly SrIdConverter Singleton = new SrIdConverter();
    }

    internal class PositionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Position) || t == typeof(Position?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CB":
                    return Position.Cb;
                case "DB":
                    return Position.Db;
                case "DE":
                    return Position.De;
                case "DL":
                    return Position.Dl;
                case "DT":
                    return Position.Dt;
                case "FB":
                    return Position.Fb;
                case "K":
                    return Position.K;
                case "LB":
                    return Position.Lb;
                case "LS":
                    return Position.Ls;
                case "P":
                    return Position.P;
                case "QB":
                    return Position.Qb;
                case "RB":
                    return Position.Rb;
                case "S":
                    return Position.S;
                case "TE":
                    return Position.Te;
                case "WR":
                    return Position.Wr;
            }
            throw new Exception("Cannot unmarshal type Position");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Position)untypedValue;
            switch (value)
            {
                case Position.Cb:
                    serializer.Serialize(writer, "CB");
                    return;
                case Position.Db:
                    serializer.Serialize(writer, "DB");
                    return;
                case Position.De:
                    serializer.Serialize(writer, "DE");
                    return;
                case Position.Dl:
                    serializer.Serialize(writer, "DL");
                    return;
                case Position.Dt:
                    serializer.Serialize(writer, "DT");
                    return;
                case Position.Fb:
                    serializer.Serialize(writer, "FB");
                    return;
                case Position.K:
                    serializer.Serialize(writer, "K");
                    return;
                case Position.Lb:
                    serializer.Serialize(writer, "LB");
                    return;
                case Position.Ls:
                    serializer.Serialize(writer, "LS");
                    return;
                case Position.P:
                    serializer.Serialize(writer, "P");
                    return;
                case Position.Qb:
                    serializer.Serialize(writer, "QB");
                    return;
                case Position.Rb:
                    serializer.Serialize(writer, "RB");
                    return;
                case Position.S:
                    serializer.Serialize(writer, "S");
                    return;
                case Position.Te:
                    serializer.Serialize(writer, "TE");
                    return;
                case Position.Wr:
                    serializer.Serialize(writer, "WR");
                    return;
            }
            throw new Exception("Cannot marshal type Position");
        }

        public static readonly PositionConverter Singleton = new PositionConverter();
    }

    internal class RoleEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RoleEnum) || t == typeof(RoleEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ast_tackle":
                    return RoleEnum.AstTackle;
                case "catch":
                    return RoleEnum.Catch;
                case "defend":
                    return RoleEnum.Defend;
                case "hit":
                    return RoleEnum.Hit;
                case "hold":
                    return RoleEnum.Hold;
                case "kick":
                    return RoleEnum.Kick;
                case "kick_return":
                    return RoleEnum.KickReturn;
                case "pass":
                    return RoleEnum.Pass;
                case "penalty":
                    return RoleEnum.Penalty;
                case "receive":
                    return RoleEnum.Receive;
                case "return":
                    return RoleEnum.Return;
                case "rush":
                    return RoleEnum.Rush;
                case "snap":
                    return RoleEnum.Snap;
                case "tackle":
                    return RoleEnum.Tackle;
            }
            throw new Exception("Cannot unmarshal type RoleEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RoleEnum)untypedValue;
            switch (value)
            {
                case RoleEnum.AstTackle:
                    serializer.Serialize(writer, "ast_tackle");
                    return;
                case RoleEnum.Catch:
                    serializer.Serialize(writer, "catch");
                    return;
                case RoleEnum.Defend:
                    serializer.Serialize(writer, "defend");
                    return;
                case RoleEnum.Hit:
                    serializer.Serialize(writer, "hit");
                    return;
                case RoleEnum.Hold:
                    serializer.Serialize(writer, "hold");
                    return;
                case RoleEnum.Kick:
                    serializer.Serialize(writer, "kick");
                    return;
                case RoleEnum.KickReturn:
                    serializer.Serialize(writer, "kick_return");
                    return;
                case RoleEnum.Pass:
                    serializer.Serialize(writer, "pass");
                    return;
                case RoleEnum.Penalty:
                    serializer.Serialize(writer, "penalty");
                    return;
                case RoleEnum.Receive:
                    serializer.Serialize(writer, "receive");
                    return;
                case RoleEnum.Return:
                    serializer.Serialize(writer, "return");
                    return;
                case RoleEnum.Rush:
                    serializer.Serialize(writer, "rush");
                    return;
                case RoleEnum.Snap:
                    serializer.Serialize(writer, "snap");
                    return;
                case RoleEnum.Tackle:
                    serializer.Serialize(writer, "tackle");
                    return;
            }
            throw new Exception("Cannot marshal type RoleEnum");
        }

        public static readonly RoleEnumConverter Singleton = new RoleEnumConverter();
    }

    internal class ResultConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Result) || t == typeof(Result?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "No Good Pass Incomplete":
                    return Result.NoGoodPassIncomplete;
                case "Touchback":
                    return Result.Touchback;
                case "Touchdown":
                    return Result.Touchdown;
                case "good":
                    return Result.Good;
                case "pushed out of bounds":
                    return Result.PushedOutOfBounds;
                case "ran out of bounds":
                    return Result.RanOutOfBounds;
                case "tackled":
                    return Result.Tackled;
            }
            throw new Exception("Cannot unmarshal type Result");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Result)untypedValue;
            switch (value)
            {
                case Result.NoGoodPassIncomplete:
                    serializer.Serialize(writer, "No Good Pass Incomplete");
                    return;
                case Result.Touchback:
                    serializer.Serialize(writer, "Touchback");
                    return;
                case Result.Touchdown:
                    serializer.Serialize(writer, "Touchdown");
                    return;
                case Result.Good:
                    serializer.Serialize(writer, "good");
                    return;
                case Result.PushedOutOfBounds:
                    serializer.Serialize(writer, "pushed out of bounds");
                    return;
                case Result.RanOutOfBounds:
                    serializer.Serialize(writer, "ran out of bounds");
                    return;
                case Result.Tackled:
                    serializer.Serialize(writer, "tackled");
                    return;
            }
            throw new Exception("Cannot marshal type Result");
        }

        public static readonly ResultConverter Singleton = new ResultConverter();
    }

    internal class HashMarkConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HashMark) || t == typeof(HashMark?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Left Hash":
                    return HashMark.LeftHash;
                case "Middle":
                    return HashMark.Middle;
                case "Right Hash":
                    return HashMark.RightHash;
            }
            throw new Exception("Cannot unmarshal type HashMark");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HashMark)untypedValue;
            switch (value)
            {
                case HashMark.LeftHash:
                    serializer.Serialize(writer, "Left Hash");
                    return;
                case HashMark.Middle:
                    serializer.Serialize(writer, "Middle");
                    return;
                case HashMark.RightHash:
                    serializer.Serialize(writer, "Right Hash");
                    return;
            }
            throw new Exception("Cannot marshal type HashMark");
        }

        public static readonly HashMarkConverter Singleton = new HashMarkConverter();
    }

    internal class HuddleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Huddle) || t == typeof(Huddle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Huddle":
                    return Huddle.Huddle;
                case "No Huddle":
                    return Huddle.NoHuddle;
            }
            throw new Exception("Cannot unmarshal type Huddle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Huddle)untypedValue;
            switch (value)
            {
                case Huddle.Huddle:
                    serializer.Serialize(writer, "Huddle");
                    return;
                case Huddle.NoHuddle:
                    serializer.Serialize(writer, "No Huddle");
                    return;
            }
            throw new Exception("Cannot marshal type Huddle");
        }

        public static readonly HuddleConverter Singleton = new HuddleConverter();
    }

    internal class PlayDirectionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PlayDirection) || t == typeof(PlayDirection?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Left":
                    return PlayDirection.Left;
                case "Left Sideline":
                    return PlayDirection.LeftSideline;
                case "Middle":
                    return PlayDirection.Middle;
                case "Right":
                    return PlayDirection.Right;
                case "Right Sideline":
                    return PlayDirection.RightSideline;
            }
            throw new Exception("Cannot unmarshal type PlayDirection");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PlayDirection)untypedValue;
            switch (value)
            {
                case PlayDirection.Left:
                    serializer.Serialize(writer, "Left");
                    return;
                case PlayDirection.LeftSideline:
                    serializer.Serialize(writer, "Left Sideline");
                    return;
                case PlayDirection.Middle:
                    serializer.Serialize(writer, "Middle");
                    return;
                case PlayDirection.Right:
                    serializer.Serialize(writer, "Right");
                    return;
                case PlayDirection.RightSideline:
                    serializer.Serialize(writer, "Right Sideline");
                    return;
            }
            throw new Exception("Cannot marshal type PlayDirection");
        }

        public static readonly PlayDirectionConverter Singleton = new PlayDirectionConverter();
    }

    internal class StatTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StatTypeEnum) || t == typeof(StatTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "conversion":
                    return StatTypeEnum.Conversion;
                case "defense":
                    return StatTypeEnum.Defense;
                case "down_conversion":
                    return StatTypeEnum.DownConversion;
                case "extra_point":
                    return StatTypeEnum.ExtraPoint;
                case "field_goal":
                    return StatTypeEnum.FieldGoal;
                case "first_down":
                    return StatTypeEnum.FirstDown;
                case "kick":
                    return StatTypeEnum.Kick;
                case "kickoff":
                    return StatTypeEnum.Kickoff;
                case "pass":
                    return StatTypeEnum.Pass;
                case "penalty":
                    return StatTypeEnum.Penalty;
                case "receive":
                    return StatTypeEnum.Receive;
                case "return":
                    return StatTypeEnum.Return;
                case "rush":
                    return StatTypeEnum.Rush;
            }
            throw new Exception("Cannot unmarshal type StatTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StatTypeEnum)untypedValue;
            switch (value)
            {
                case StatTypeEnum.Conversion:
                    serializer.Serialize(writer, "conversion");
                    return;
                case StatTypeEnum.Defense:
                    serializer.Serialize(writer, "defense");
                    return;
                case StatTypeEnum.DownConversion:
                    serializer.Serialize(writer, "down_conversion");
                    return;
                case StatTypeEnum.ExtraPoint:
                    serializer.Serialize(writer, "extra_point");
                    return;
                case StatTypeEnum.FieldGoal:
                    serializer.Serialize(writer, "field_goal");
                    return;
                case StatTypeEnum.FirstDown:
                    serializer.Serialize(writer, "first_down");
                    return;
                case StatTypeEnum.Kick:
                    serializer.Serialize(writer, "kick");
                    return;
                case StatTypeEnum.Kickoff:
                    serializer.Serialize(writer, "kickoff");
                    return;
                case StatTypeEnum.Pass:
                    serializer.Serialize(writer, "pass");
                    return;
                case StatTypeEnum.Penalty:
                    serializer.Serialize(writer, "penalty");
                    return;
                case StatTypeEnum.Receive:
                    serializer.Serialize(writer, "receive");
                    return;
                case StatTypeEnum.Return:
                    serializer.Serialize(writer, "return");
                    return;
                case StatTypeEnum.Rush:
                    serializer.Serialize(writer, "rush");
                    return;
            }
            throw new Exception("Cannot marshal type StatTypeEnum");
        }

        public static readonly StatTypeEnumConverter Singleton = new StatTypeEnumConverter();
    }

    internal class PocketLocationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PocketLocation) || t == typeof(PocketLocation?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Boot Left":
                    return PocketLocation.BootLeft;
                case "Boot Right":
                    return PocketLocation.BootRight;
                case "Middle":
                    return PocketLocation.Middle;
                case "Rollout Right":
                    return PocketLocation.RolloutRight;
                case "Scramble Left":
                    return PocketLocation.ScrambleLeft;
                case "Scramble Right":
                    return PocketLocation.ScrambleRight;
            }
            throw new Exception("Cannot unmarshal type PocketLocation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PocketLocation)untypedValue;
            switch (value)
            {
                case PocketLocation.BootLeft:
                    serializer.Serialize(writer, "Boot Left");
                    return;
                case PocketLocation.BootRight:
                    serializer.Serialize(writer, "Boot Right");
                    return;
                case PocketLocation.Middle:
                    serializer.Serialize(writer, "Middle");
                    return;
                case PocketLocation.RolloutRight:
                    serializer.Serialize(writer, "Rollout Right");
                    return;
                case PocketLocation.ScrambleLeft:
                    serializer.Serialize(writer, "Scramble Left");
                    return;
                case PocketLocation.ScrambleRight:
                    serializer.Serialize(writer, "Scramble Right");
                    return;
            }
            throw new Exception("Cannot marshal type PocketLocation");
        }

        public static readonly PocketLocationConverter Singleton = new PocketLocationConverter();
    }

    internal class QbAtSnapConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(QbAtSnap) || t == typeof(QbAtSnap?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Shotgun":
                    return QbAtSnap.Shotgun;
                case "Under Center":
                    return QbAtSnap.UnderCenter;
            }
            throw new Exception("Cannot unmarshal type QbAtSnap");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (QbAtSnap)untypedValue;
            switch (value)
            {
                case QbAtSnap.Shotgun:
                    serializer.Serialize(writer, "Shotgun");
                    return;
                case QbAtSnap.UnderCenter:
                    serializer.Serialize(writer, "Under Center");
                    return;
            }
            throw new Exception("Cannot marshal type QbAtSnap");
        }

        public static readonly QbAtSnapConverter Singleton = new QbAtSnapConverter();
    }

    internal class IncompletionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IncompletionType) || t == typeof(IncompletionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Dropped Pass":
                    return IncompletionType.DroppedPass;
                case "Pass Defended":
                    return IncompletionType.PassDefended;
                case "Poorly Thrown":
                    return IncompletionType.PoorlyThrown;
            }
            throw new Exception("Cannot unmarshal type IncompletionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (IncompletionType)untypedValue;
            switch (value)
            {
                case IncompletionType.DroppedPass:
                    serializer.Serialize(writer, "Dropped Pass");
                    return;
                case IncompletionType.PassDefended:
                    serializer.Serialize(writer, "Pass Defended");
                    return;
                case IncompletionType.PoorlyThrown:
                    serializer.Serialize(writer, "Poorly Thrown");
                    return;
            }
            throw new Exception("Cannot marshal type IncompletionType");
        }

        public static readonly IncompletionTypeConverter Singleton = new IncompletionTypeConverter();
    }

    internal class PlayTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PlayType) || t == typeof(PlayType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "play")
            {
                return PlayType.Play;
            }
            throw new Exception("Cannot unmarshal type PlayType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PlayType)untypedValue;
            if (value == PlayType.Play)
            {
                serializer.Serialize(writer, "play");
                return;
            }
            throw new Exception("Cannot marshal type PlayType");
        }

        public static readonly PlayTypeConverter Singleton = new PlayTypeConverter();
    }
}


