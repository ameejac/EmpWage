using System;

namespace employeewages
{

    class EmpWageCal
    {
        static void Main(string[] args)
        {
            //Constants
            const  int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HUR = 20;

            Random random = new Random();
            //variables
            int empHrs = 0;
            int empWage = 0;
            ///Computation
            int empCheck = random.Next(0, 3);
            switch(empCheck)
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
	  }  Console.WriteLine("emp Wage :" +empWage)
    }
}
