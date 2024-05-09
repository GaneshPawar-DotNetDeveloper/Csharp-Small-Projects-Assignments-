using System;

namespace Second_Higest_Number_From_Array
{
    class Program
    {
        //Second Higest Number From Array 
        public void SecondElementFromArray()
        {
            int[] numbers = new int[] { 10, 50, 100, 90, 70, 80, 60, 30, 40, 20 };
            Array.Sort(numbers);
            Console.WriteLine("Higest Number In Array is=" + numbers[numbers.Length - 2]);

        }
    }
}
