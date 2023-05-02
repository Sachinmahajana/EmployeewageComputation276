using System.Collections.Generic;

namespace EmployeewageComputation276
{
    public class EmpWageBuilder
    {
        // public int[] arr = new int[5];
        // public CompanyDetails[] companies;
        public List<CompanyDetails> list;
        public Dictionary<string, int> companyTotalWage;
        // public int numberofcompanies = 0;
        public EmpWageBuilder()
        {
            //companies = new CompanyDetails[5];
            list = new List<CompanyDetails>();
            companyTotalWage = new Dictionary<string, int>();
        }
        public void AddCompanies(string companyName, int empRatePerHr, int numberofWorkingDays, int maxWorkingHrs)
        {
            CompanyDetails company = new CompanyDetails(companyName, empRatePerHr, numberofWorkingDays, maxWorkingHrs);
            // companies[numberofcompanies] = company;
            list.Add(company);
            // numberofcompanies++;
        }
        public void FetchCompanyDetailsFromArray()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int totalWage = CalculateEmpWage(list[i]);
                list[i].SetTotalWage(totalWage);
                Console.WriteLine(list[i]);
                companyTotalWage.Add(list[i].companyName, totalWage);
            }
        }
        public void DisplayTotalWageBaseOnCompanyName(string companyName)
        {
            if (companyTotalWage.ContainsKey(companyName))
                Console.WriteLine("CompanyName:" + companyName + "totalWage" + companyTotalWage[companyName]);
            else
                Console.WriteLine("This company Not exist");
        }
        public int CalculateEmpWage(CompanyDetails companyDetails)
        {
            //UC6-Calculatewageoftotal Workinghrs
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            //const int EMP_RATE_PER_HR = 20;
            //const int NUMBER_OF_WORKING_DAYS = 20;
            //const int MAX_WORKING_HRS = 100;
            int empHrs = 0, empWage = 0, totalWage = 0, day = 1, totalHrs = 0;
            Random random = new Random();
            while (day <= companyDetails.numberofWorkingDays && totalHrs < companyDetails.maxWorkingHrs)
            {
                int empAttendence = random.Next(0, 3);
                switch (empAttendence)
                {
                    case FULL_TIME:
                        Console.WriteLine("Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("Employee is Parttime Present");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = companyDetails.empRatePerHr * empHrs;

                //Console.WriteLine("Employeewage for day{0} and {1} hrs is:{2}", day, totalHrs, empWage);
                day++;
                totalWage = totalWage + empWage;
                totalHrs = totalHrs + empHrs;
            }
            Console.WriteLine("Totalwage for {0} {1} days and {2} hrs is:{3}", companyDetails.companyName, (day - 1), totalHrs, totalWage);
            Console.ReadLine();
            return totalWage;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage Computation Program");
            EmpWageBuilder empwageBuilder = new EmpWageBuilder();
            empwageBuilder.AddCompanies("Deloite", 40, 23, 60);
            empwageBuilder.AddCompanies("Microsoft", 50, 26, 70);
            empwageBuilder.AddCompanies("Infosys", 70, 30, 59);
            empwageBuilder.FetchCompanyDetailsFromArray();
            Console.WriteLine("Please enter company Name");
            string name = Console.ReadLine();
            empwageBuilder.DisplayTotalWageBaseOnCompanyName(name);
        }

        //Create the method and call in main method

    }
}
