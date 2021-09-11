using System;

namespace employeewages
{

    class EmpWageCal
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HUR = 20;
           // int PART_TIME_HRS = 8;
            Random random = new Random();
            //variables
            int empHrs = 0;
            int empWage = 0;
            ///Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 8;
                Console.WriteLine("IS_PART_TIME");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("employeeWage ");
            }
            empWage = empHrs * EMP_RATE_PER_HUR;
            Console.WriteLine("empHrs Wage :" + empWage);
	}
    }
}
