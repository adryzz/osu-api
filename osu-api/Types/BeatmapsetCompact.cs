using System;
using System.Collections.Generic;
using System.Text;

namespace OsuAPI.Types
{
    [Serializable()]
    public struct BeatmapsetCompact
    {
        string Artist;
        string ArtistUnicode;
        BeatmapCovers Covers;
        string Creator;
        long FvouriteCount;
        long Id;
        long PlayCount;
        string PreviewURL;
        string Source;
        RankStatus Status;
        string Title;
        string TitleUnicode;
        long UserId;
        string Video;
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
