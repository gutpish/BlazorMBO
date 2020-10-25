using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorMBO.Shared.Classes
{
    public class Competition
    {
        public int CompetitionId { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
        public bool PlayerStatsCoverage { get; set; }
        public List<Saison> Seasons { get; set; }
    }
}
