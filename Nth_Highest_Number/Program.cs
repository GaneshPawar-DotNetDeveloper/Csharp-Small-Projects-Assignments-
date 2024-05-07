using System;

namespace Nth_Highest_Number
{
    class Program
    {
        // Nth Higest Number  from array//
        public void NthHighestNumberFromArray()
        {


            int[] Number = { 10, 20, 30, 40, 50, 45, 65, 100, 95 };
            Array.Sort(Number);
            Console.WriteLine("Higest Number =" + Number[Number.Length - 1]);

        }

    }
}
