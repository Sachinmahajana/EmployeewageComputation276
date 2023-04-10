﻿namespace EmployeewageComputation276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage Computation Program");
            //UC5-Calculate Wages for month
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int NUMBER_OF_WORKING_DAYS = 20;
            int empHrs = 0, empWage = 0, totalWage = 0,  day = 0;
            Random random = new Random();
            for ( day = 1; day <= NUMBER_OF_WORKING_DAYS; day++)
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
                Console.WriteLine("Employeewage for day{0} is:{1}",day, empWage);
                totalWage = totalWage + empWage;
            }
            Console.WriteLine("Totalwage for {0} days is:{1}", (day - 1), totalWage);
            Console.ReadLine();
        }
    }
}