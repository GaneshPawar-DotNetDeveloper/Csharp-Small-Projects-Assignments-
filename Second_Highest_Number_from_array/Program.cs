using System;

namespace Second_Highest_Number_from_array
{
    class Program
    {
        //2nd higest number from Array//
        public void HighestNumberFromArray()
        {
            int[] Number = { 10, 20, 30, 40, 50, 45, 65, 100, 95 };
            Array.Sort(Number);
            Console.WriteLine("Higest Number =" + Number[Number.Length - 2]);

        }
    }
}
