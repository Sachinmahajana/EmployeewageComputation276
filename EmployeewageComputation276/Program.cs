namespace EmployeewageComputation276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage Computation Program");
            //UC1-Employeeattendence
            int isPresent = 1;
            Random random = new Random();
            int empAttendence = random.Next(0, 2);

            if(empAttendence == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}