using System;

namespace Fibonanci_series
{
    class Program
    {
        public void Fibonanciseries()
        {
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int c;

            for (int i = 1; i <= 10; i++)
            {
                c = num1 + num2;
                Console.WriteLine(c);
                num1 = num2;
                num2 = c;
            }
        }

    }
}
