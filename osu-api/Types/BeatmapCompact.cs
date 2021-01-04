using System;
using System.Collections.Generic;
using System.Text;
using OsuAPI.Types.Enums;

namespace OsuAPI.Types
{
    [Serializable()]
    struct BeatmapCompact
    {
        public float DifficultyRating;

        public int Id;

        public GameMode Mode;

        public int TotalLength;

        public string Version;
    }
}
