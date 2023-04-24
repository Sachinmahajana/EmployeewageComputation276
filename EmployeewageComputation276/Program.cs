﻿using System.Security.Cryptography.X509Certificates;

namespace EmployeewageComputation276
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage Computation Program");
            Console.WriteLine("TotalWage:"+ CalculateEmpWage("Deloite", 40, 23, 60)+"\n");
            Console.WriteLine("TotalWage:" + CalculateEmpWage("Microsoft", 50, 26, 70)+"\n");
            Console.WriteLine("TotalWage:" + CalculateEmpWage("Infosys", 70, 30, 59)+"\n");
        }
            //Create the method and call in main method
            public static int CalculateEmpWage(string companyName, int empRaterPerHr, int numberofWorkingDays, int maxWorkingHrs)
            {
            //UC6-Calculatewageoftotal Workinghrs
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            //const int EMP_RATE_PER_HR = 20;
            //const int NUMBER_OF_WORKING_DAYS = 20;
            //const int MAX_WORKING_HRS = 100;
            int empHrs = 0, empWage = 0, totalWage = 0, day = 1, totalHrs = 0;
            Random random = new Random();
            while (day <= numberofWorkingDays && totalHrs <= maxWorkingHrs)
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
                empWage = empHrs * empRaterPerHr;
                Console.WriteLine("Employeewage for day{0} and {1} hrs is:{2}", day, totalHrs, empWage);
                day++;
                totalWage = totalWage + empWage;
                totalHrs = totalHrs + empHrs;
            }
            Console.WriteLine("Totalwage for {0} {1} days and {2} hrs is:{3}", companyName, (day - 1), totalHrs, totalWage);
            Console.ReadLine();
            return totalWage;
        }
    }
}
