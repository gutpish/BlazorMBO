using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMBO.Shared.Classes
{
    public class Pari
    {
        public int GameId { get; set; }
        public int RoundId { get; set; }
        public int Season { get; set; }
        public int SeasonType { get; set; }
        public string Group { get; set; }
        public int TeamAId { get; set; }
        public int TeamBId { get; set; }
        public object VenueId { get; set; }
        public DateTime Day { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
        public object Week { get; set; }
        public string BestOf { get; set; }
        public string Winner { get; set; }
        public object VenueType { get; set; }
        public string TeamAKey { get; set; }
        public string TeamAName { get; set; }
        public object TeamAScore { get; set; }
        public string TeamBKey { get; set; }
        public string TeamBName { get; set; }
        public object TeamBScore { get; set; }
        public object TeamAMoneyLine { get; set; }
        public object TeamBMoneyLine { get; set; }
        public object DrawMoneyLine { get; set; }
        public object PointSpread { get; set; }
        public object TeamAPointSpreadPayout { get; set; }
        public object TeamBPointSpreadPayout { get; set; }
        public DateTime Updated { get; set; }
        public DateTime UpdatedUtc { get; set; }
        public bool IsClosed { get; set; }
    }
}
