using System;

namespace Prime_Number_uipto_that_Number
{
    class Program
    {
        //prime numberupto that number
        public void PrimenumbersuptoEnterNumber()
        {

            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool isprimenumber = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isprimenumber = false;
                        break;
                    }
                }
                if (isprimenumber)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
