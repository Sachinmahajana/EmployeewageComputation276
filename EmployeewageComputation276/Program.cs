using System.Security.Cryptography.X509Certificates;

namespace EmployeewageComputation276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage Computation Program");
            Program.CalculateEmpWage();
        }
        //Create the method and call in main method
        public static void CalculateEmpWage()
        {
            //UC6-Calculatewageoftotal Workinghrs
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int NUMBER_OF_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int empHrs = 0, empWage = 0, totalWage = 0, day = 1, totalHrs = 0;
            Random random = new Random();
            while (day <= NUMBER_OF_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
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
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Employeewage for day{0} and {1} hrs is:{2}", day, totalHrs, empWage);
                day++;
                totalWage = totalWage + empWage;
                totalHrs = totalHrs + empHrs;
            }
            Console.WriteLine("Totalwage for {0} days and {1} hrs is:{2}", (day - 1), totalHrs, totalWage);
            Console.ReadLine();
        }
    }
}