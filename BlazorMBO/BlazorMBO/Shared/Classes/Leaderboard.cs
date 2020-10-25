using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMBO.Shared.Classes
{
    public class Leaderboard
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string MatchName { get; set; }
        public string Team { get; set; }
        public bool IsClosed { get; set; }
        public int GameId { get; set; }
        public int OpponentId { get; set; }
        public string Opponent { get; set; }
        public DateTime Day { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Updated { get; set; }
        public object UpdatedUtc { get; set; }
        public object Games { get; set; }
        public double Maps { get; set; }
        public double FantasyPoints { get; set; }
        public double Kills { get; set; }
        public double Assists { get; set; }
        public double Deaths { get; set; }
        public double Headshots { get; set; }
        public double AverageDamagePerRound { get; set; }
        public double Kast { get; set; }
        public double Rating { get; set; }
        public object EntryKills { get; set; }
        public object QuadKills { get; set; }
        public object Aces { get; set; }
        public object Clutch1v2s { get; set; }
        public object Clutch1v3s { get; set; }
        public object Clutch1v4s { get; set; }
        public object Clutch1v5s { get; set; }
    }
}
