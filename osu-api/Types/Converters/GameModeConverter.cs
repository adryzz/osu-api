using Newtonsoft.Json;
using OsuAPI.Types.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OsuAPI.Types.Converters
{
    public class GameModeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            GameMode mode = (GameMode)value;

            switch (mode)
            {
                case GameMode.Osu:
                    writer.WriteValue("osu");
                    break;
                case GameMode.Taiko:
                    writer.WriteValue("taiko");
                    break;
                case GameMode.Catch:
                    writer.WriteValue("fruits");
                    break;
                case GameMode.Mania:
                    writer.WriteValue("mania");
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;

            switch(enumString)
            {
                case "osu":
                    return GameMode.Osu;
                case "taiko":
                    return GameMode.Taiko;
                case "fruits":
                    return GameMode.Catch;
                case "mania":
                    return GameMode.Mania;
            }
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
