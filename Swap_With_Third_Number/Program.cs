using System;

namespace Swap_With_Third_Number
{
    class Program
    {
        // Swap With Third Variable
        public void WithThirdVariable()
        {

            Console.WriteLine("Enter number1");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2");
            int b = Convert.ToInt32(Console.ReadLine());

            int temp = 0;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a + " " + b);
        }
    }
}
