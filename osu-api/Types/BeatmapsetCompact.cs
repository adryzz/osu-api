using System;
using System.Collections.Generic;
using System.Text;

namespace OsuAPI.Types
{
    [Serializable()]
    public struct BeatmapsetCompact
    {
        public string Artist;
        public string ArtistUnicode;
        public BeatmapCovers Covers;
        public string Creator;
        public long FvouriteCount;
        public long Id;
        public long PlayCount;
        public string PreviewURL;
        public string Source;
        public RankStatus Status;
        public string Title;
        public string TitleUnicode;
        public long UserId;
        public string Video;

        [Serializable()]
        public enum RankStatus : int
        {
            Graveyard = -2,
            WIP = -1,
            Pending = 0,
            Ranked = 1,
            Approved = 2,
            Qualified = 3,
            Loved = 4
        }

        [Serializable()]
        public struct BeatmapCovers
        {
            public string Cover;
            public string Cover2x;
            public string Card;
            public string Card2x;
            public string List;
            public string List2x;
            public string SlimCover;
            public string SlimCover2x;
        }
    }
}
