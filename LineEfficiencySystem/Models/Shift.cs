using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineEfficiencySystem.Models
{
    public class Shift
    {
        public int ShiftId { get; set; }
        public string Name { get; set; }

        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }

        public int StartDay { get; set; }
        public int EndDay { get; set; }

        public DateTime GetShiftStart(DateTime dt)
        {
            DateTime shiftStart = new DateTime(dt.Year, dt.Month, dt.Day,
                      Start.Hours, Start.Minutes, Start.Seconds);

            shiftStart = shiftStart.AddDays(StartDay);

            return shiftStart;
        }

        public DateTime GetShiftEnd(DateTime dt)
        {
            DateTime shiftEnd = new DateTime(dt.Year, dt.Month, dt.Day,
                      End.Hours, End.Minutes, End.Seconds);

            shiftEnd = shiftEnd.AddDays(EndDay);

            return shiftEnd;
        }

    }

}