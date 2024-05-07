using System;

namespace K_th_Largest_element_from_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] number = new int[] { 10, 30, 20, 90, 40, 50, 60 };
            Array.Sort(number);
            int b = Convert.ToInt32(Console.ReadLine());
            int a = number[number.Length - b];
            Console.WriteLine("Largest Element in Array is=" + a);
        }
    }
}
