using System;

namespace Highest_Number_In_Array
{
    class Program
    {
        //Higest Number From Array
        public void HigestElementFromArray()
        {
            int[] numbers = new int[] { 10, 50, 100, 90, 70, 80, 60, 30, 40, 20 };
            Array.Sort(numbers);
            Console.WriteLine("Higest Number In Array is=" + numbers[numbers.Length - 1]);

        }
    }
}
