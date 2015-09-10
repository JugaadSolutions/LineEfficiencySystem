using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineEfficiencySystem.Models
{
    public class ReferenceStation
    {
        public int ReferenceStationId { get; set; }
        public double UT { get; set; }
        public int ReferenceId { get; set; }
        public virtual Reference Reference { get; set; }
        public int StationId { get; set; }
        public virtual Station Station{ get; set; }
    }
}