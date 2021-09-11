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
            const int EMP_RATE_PER_HUR = 20;
                //variables
                int empHrs = 0;
                int empWage = 0;
                int totalEmpWage = 0;
            ///Computation
            for(int days = 0; days < NUM_OF_WORKING_DAYS; days++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HUR;
                totalEmpWage += empWage;
                Console.WriteLine("emp Wage : " + empWage);
            }
            Console.WriteLine("total Emp Wage : " + totalEmpWage);
        }  
    }
}
