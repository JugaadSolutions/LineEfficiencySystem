using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineEfficiencySystem.Models
{
    public class Line
    {

        public int LineId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Station> Stations { get; set; }
    }

}