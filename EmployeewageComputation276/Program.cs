namespace EmployeewageComputation276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage Computation Program");
            //UC4-Switch case
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;
            Random random = new Random();
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
            Console.WriteLine("Employeewage is: {0} wage", empWage);
            Console.ReadLine();
        }
    }
}