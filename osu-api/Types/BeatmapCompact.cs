using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OsuAPI.Types.Converters;
using OsuAPI.Types.Enums;

namespace OsuAPI.Types
{
    [Serializable()]
    struct BeatmapCompact
    {
        [JsonProperty(PropertyName = "difficulty_rating")]
        public float DifficultyRating;

        [JsonProperty(PropertyName = "id")]
        public int Id;

        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(GameModeConverter))]
        public GameMode Mode;

        [JsonProperty(PropertyName = "total_length")]
        public int TotalLength;

        [JsonProperty(PropertyName = "version")]
        public string Version;

        [JsonProperty(PropertyName = "beatmapset")]
        public BeatmapsetCompact? Beatmapset;

        [JsonProperty(PropertyName = "checksum")]
        public string Checksum;

        [JsonProperty(PropertyName = "failtimes")]
        public FailTimes? Failtimes;

        [JsonProperty(PropertyName = "max_combo")]
        public int MaxCombo;

        public struct FailTimes
        {
            [JsonProperty(PropertyName = "exit")]
            public int?[] Exit;

            [JsonProperty(PropertyName = "fail")]
            public int?[] Fail;
        }
    }
}
