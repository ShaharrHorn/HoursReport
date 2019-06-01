using System;
using System.Collections.Generic;
using System.Text;

namespace HoursReport
{
    public class Company
    {

        public String name { get; set; }
        public List<WorkingHours> workingHours;
        public DateTime sumOfDay , sumOfWeek;

        public Company(string name)
        {
            this.name = name;
            workingHours = new List<WorkingHours>();
        }
    }
}
