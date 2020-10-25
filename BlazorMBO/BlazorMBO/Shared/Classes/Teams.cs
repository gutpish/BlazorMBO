using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMBO.Shared.Classes
{
    public class Team
    {
        public int TeamId { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool Active { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Website { get; set; }
        public object Email { get; set; }
        public int? Founded { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public object TertiaryColor { get; set; }
        public object QuaternaryColor { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string YouTube { get; set; }
        public string Instagram { get; set; }
    }
}
