using System;

namespace Prime_Number_3
{
    class Program
    {
        public void PrimeNumber()
        {
            Console.WriteLine("Enter Number");
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
                Console.WriteLine("Number Is Prime");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
        }
    }
}
