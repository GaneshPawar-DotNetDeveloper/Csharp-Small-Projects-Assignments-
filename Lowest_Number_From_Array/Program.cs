using System;

namespace Lowest_Number_From_Array
{
    class Program
    {
        //Lowest Number From Array
        public void LowestElementFromArray()
        {
            int[] numbers = new int[] { 10, 50, 100, 90, 70, 80, 60, 30, 40, 20 };
            Array.Sort(numbers);
            Console.WriteLine("Lowest Number In Array is=" + numbers[0]);

        }
    }
}
