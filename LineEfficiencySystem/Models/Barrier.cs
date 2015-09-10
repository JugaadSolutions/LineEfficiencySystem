using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineEfficiencySystem.Models
{
    public class Barrier
    {
        public int BarrierId { get; set; }
        public int IssueId { get; set; }
        public virtual Issue Issue { get; set; }

        public Nullable<DateTime> From { get; set; }
        public Nullable<DateTime> To { get; set; }

    }
}