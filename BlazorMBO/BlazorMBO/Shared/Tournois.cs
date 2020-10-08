using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMBO.Shared
{
    public class Tournois
    {
        public string NomTournois { get; set; }
        public DateTime DateDebutTournois { get; set; }
        public DateTime DateFinTournois { get; set; }
        public int NbPersonne { get; set; }
        public bool IsActif { get; set; }
    }
}
