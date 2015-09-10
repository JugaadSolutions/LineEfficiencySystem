using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineEfficiencySystem.Models
{
    public class StationInput
    {
        public int StationInputId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public int ReferenceId { get; set; }
        public virtual Reference Reference { get; set; }

        public int StationId { get; set; }
        public virtual Station Station { get; set; }

        public ICollection<Barrier> Barriers { get; set; }
    }
}