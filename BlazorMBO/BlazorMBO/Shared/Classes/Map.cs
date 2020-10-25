using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMBO.Shared.Classes
{
    public class Map
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int CurrentRound { get; set; }
        public object TeamAScore { get; set; }
        public object TeamBScore { get; set; }
        public List<Leaderboard> Leaderboards { get; set; }
    }
}
