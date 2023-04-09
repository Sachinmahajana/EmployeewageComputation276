namespace EmployeewageComputation276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage Computation Program");
            //UC2-Employeedailywage
            const int FULL_TIME = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;
            Random random = new Random();
            int empAttendence = random.Next(0, 2);

            if(empAttendence == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employeewage {0} wage", empWage);
            Console.ReadLine();
        }
    }
}