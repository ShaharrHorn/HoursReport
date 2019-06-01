using System;

namespace HoursReport
{
    public class WorkingHours
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string sum { get; set; }
        public DayOfWeek day { get; set; }

        public WorkingHours(string startingTime)
        {
            this.startTime = startingTime;
            this.day = (DayOfWeek)DateTime.Now.DayOfWeek;
        }
        public WorkingHours(string starting , string end,string sumTime, string dayOfWeek)
        {
            DayOfWeek newDay =(DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayOfWeek);
            startTime = starting;
            endTime = end;
            sum = sumTime;
            day = newDay;
        }
    }

}