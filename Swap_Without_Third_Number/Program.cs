using System;

namespace Swap_Without_Third_Number
{
    class Program
    {
        //SwapWithout third Variable//
        public void SwapWithoutThirdVariable()
        {
            Console.WriteLine("Enter number1");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;//10+20=30
            b = a - b;//30-20=10
            a = a - b;//30-10=20 

            Console.WriteLine(a + " " + b);
        }

    }
}
