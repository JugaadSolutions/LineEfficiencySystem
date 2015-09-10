using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineEfficiencySystem.Models
{
    public class Reference
    {
        public Reference()
        {

        }
        public int ReferenceId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ReferenceStation> ReferenceStation { get; set; }
       
    }

    public class ReferenceDTO
    {
        public int ReferenceId { get; set; }
        public String Name { get; set; }
        public double UsefullTime { get; set; }
    }
}