using System;

namespace Prime_Number
{
    class Program
    {
        public void prime()
        {
            Console.WriteLine("Enter num1");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;


            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count += 1;
                }

            }
            if (count == 2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
