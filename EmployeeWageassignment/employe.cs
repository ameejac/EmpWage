using System;
using System.Collections.Generic;
using System.Text;

namespace employeewages
{
    class employee
    {
	 //uc7 compute employee wage
        //Constants
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int NUM_OF_WORKING_DAYS = 20;
        const int EMP_RATE_PER_HUR = 20;
        const int MAX_NO_OF_WORKING_DAYS = 2;
        
        public static int ComputeEmpWage()
        {
            //variables
            int empHrs = 0;
            int totalempHrs = 0;
            int totalworkingdays = 0;
            while (totalempHrs <= EMP_RATE_PER_HUR && totalworkingdays <MAX_NO_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
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
                }
                Console.WriteLine("emphrs:" + totalempHrs+"total working days :"+totalworkingdays);
                totalempHrs = +empHrs;
            }
            int totalwage = totalempHrs * EMP_RATE_PER_HUR;
            Console.WriteLine("totalwage:" + totalwage);
            return totalwage;
        }
        
    }
}
