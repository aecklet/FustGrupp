
using System;
using System.Collections.Generic;
using System.Text;

namespace rednit.Domain
{
    class Match
    {
        public string MatchID { get; set; }
        public string MessageID { get; set; }
        DateTime GetTime;

        public Match(string matchID, string messageID, DateTime getTime)
        {
            MatchID = matchID;
            MessageID = messageID;
            GetTime = getTime;
        }
    }
}
