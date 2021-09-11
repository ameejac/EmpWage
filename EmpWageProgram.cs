using System;

namespace employeewages
{

    class EmpWageCal
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HUR = 20;
            Random random = new Random();
            //variables
            int empHrs = 0;
            int empWage = 0;
            ///Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("IS_FULL_TIME");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("employeeWage ");
            }
            empWage = empHrs * EMP_RATE_PER_HUR;
            Console.WriteLine("empHrs Wage :" + empWage)
            }

	}
    }
}
