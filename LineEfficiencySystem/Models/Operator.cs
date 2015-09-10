using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineEfficiencySystem.Models
{
    public enum OperatorLevel {OJT = 1, C = 2};
    public class Operator
    {
        public int OperatorId { get; set; }
        public String Code { get; set; }
        public OperatorLevel OperatorLevel { get; set; }

        public bool LoggedIn { get; set; }

        public ICollection<Station> Stations { get; set; }
    }
}