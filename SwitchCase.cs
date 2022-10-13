using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class SwitchCase
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int PER_HR_WAGE = 20;
        //public const int NUM_OF_WORKING_DAYS = 20;
        //public const int NUM_OF_WORKING_HRS = 100;
        public static void CalConditionalWage()
        {

            int EmpHrs = 0;
            int EmpWage = 0;
            //int totalemphrs = 0;
            //int totalWorkingDays = 0;
           // while (totalemphrs < NUM_OF_WORKING_HRS && totalWorkingDays < NUM_OF_WORKING_DAYS)
            //{
                //totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        EmpHrs = 8;
                        break;
                    case IS_PART_TIME:
                        EmpHrs = 4;
                        break;
                    default:
                        EmpHrs = 0;
                        break;

                }
                EmpWage = EmpHrs * PER_HR_WAGE;
                Console.WriteLine("Employee Wage is: " + EmpWage);
                //Console.WriteLine("Day{0} -> {1}Hours Worked", totalWorkingDays, EmpHrs);
                //totalemphrs += EmpHrs;
            //}
            //EmpWage = totalemphrs * PER_HR_WAGE;
           // Console.WriteLine("Total Employee Hours :" + totalemphrs);
            //Console.WriteLine("Employee Total Wage is: " + EmpWage);
        }
    }
}