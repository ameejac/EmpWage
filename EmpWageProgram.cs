using System;

namespace employeewages
{
    class us1
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            ///Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is abcent");
            }
	}
    }
}
