using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineEfficiencySystem.Models
{
    public class Station
    {

        public int StationId { get; set; }
        public string Name { get; set; }

        public int LineId { get; set; }
        public virtual Line Line { get; set; }
    }

}