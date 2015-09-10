using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineEfficiencySystem.Models
{
    public enum StationStatus {IDLE, ACTIVE,PAUSED};
    public class Station
    {

        public int StationId { get; set; }
        public string Name { get; set; }

        public int LineId { get; set; }
        public virtual Line Line { get; set; }

        public StationStatus Status { get; set; }

        public bool FinalStage { get; set; }

        public ICollection<Operator> Operators { get; set; }
    }



    public class StationDTO
    {
        public int StationId { get; set; }
        public string Name { get; set; }
        public int LineId {get;set;}
        public StationStatus Status { get; set; }
        public bool FinalStage { get; set; }
        public Operator[] Operators { get; set; }
        
    }

}