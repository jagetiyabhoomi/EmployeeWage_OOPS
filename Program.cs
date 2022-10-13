namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            SwitchCase.CalConditionalWage();
            EmployeeCheck.EmployeeAttendance();
            EmpWageBuilerArray empWageBuilerArray = new EmpWageBuilerArray();

            empWageBuilerArray.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilerArray.addCompanyEmpWage("Reilance", 10, 4, 20);

            empWageBuilerArray.computeEmpWage();
            Console.WriteLine("Total Wage for DMart company: " + empWageBuilerArray.getTotalEmpWage(0));
        }
    }
}
