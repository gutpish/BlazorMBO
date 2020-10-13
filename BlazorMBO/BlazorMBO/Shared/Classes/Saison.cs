using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMBO.Shared
{
    public class Saison
    {
        public int SeasonId { get; set; }
        public int CompetitionId { get; set; }
        public int Season { get; set; }
        public string Name { get; set; }
        public string CompetitionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CurrentSeason { get; set; }
        public List<Round> Rounds { get; set; }
    }
}
