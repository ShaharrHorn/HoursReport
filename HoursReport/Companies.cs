using System;
using System.Collections.Generic;
using System.Text;

namespace HoursReport
{
    class Companies
    {
        public Dictionary<string, Company> companies { get; set; }
        double totalWorkingHoursForDay;
        public List<WorkingHours> splittedHours;


        public Companies()
        {
            companies = new Dictionary<string, Company>();
            splittedHours = new List<WorkingHours>();
        }

        public void addCompany(Company company)
        {
            companies.Add(company.name , company);
        }
    }


}
