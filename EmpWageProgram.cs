using System;

namespace employeewages
{

    class EmpWageCal
   {
        static void Main(string[] args)
        {
       //Constants
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int NUM_OF_WORKING_DAYS = 20;
            const int EMP_RATE_PER_HOUR = 20;
            const int MAX_HRS_IN_MONTH = 100;
                //variables
                int empHrs = 0;
                int totalworkingdays= 0;
                int totalEmpHrs = 0;
            ///Computation
            while(totalEmpHrs <=MAX_HRS_IN_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                        //Console.WriteLine("employeeWage ");
                }
                     totalEmpHrs += empHrs;
                Console.WriteLine("days :" + totalworkingdays + "Emp Hrs :" + empHrs);
            }
            int employeewage = totalworkingdays * EMP_RATE_PER_HOUR;
            Console.WriteLine("total Emp Wage : " + totalEmpHrs);
        }
    }
}
