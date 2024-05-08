using System;

namespace Number_Divisible_By_3
{
    class Program
    {
        //Three if Number is divisible by 3//
        public void PrintLetterIfNumberDivisible()
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Number is Divisible by Three  and Five");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Number is divisible by 5");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Number is Divisible by Three");
            }
            else
            {
                Console.WriteLine("Number is not Divisible by Three and Five");
            }
        }
    }
}
