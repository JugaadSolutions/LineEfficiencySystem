﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LineEfficiencySystem.Models
{
    public class LESContext :DbContext
    {
        public DbSet<Line> Lines { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<ReferenceStation> ReferenceMachines { get; set; }
        public DbSet<Operator> Operator { get; set; }
        public DbSet<StationInput> StationInputs { get; set; }

        public LESContext()
          : base("name=LESConnection")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }
        
    }
}