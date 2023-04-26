using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageComputation276
{
    public class CompanyDetails
    {
        public string companyName;
        public int empRatePerHr, numberofWorkingDays, maxWorkingHrs, totalWage;
        public CompanyDetails(string companyName, int empRatePerHr, int numberofWorkingDays, int maxWorkingHrs)
        {
            this.companyName = companyName;
            this.empRatePerHr = empRatePerHr;
            this.numberofWorkingDays = numberofWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void SetTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
    }
}
