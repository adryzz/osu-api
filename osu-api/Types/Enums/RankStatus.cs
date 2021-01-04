using System;
using System.Collections.Generic;
using System.Text;

namespace OsuAPI.Types.Enums
{
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
}
