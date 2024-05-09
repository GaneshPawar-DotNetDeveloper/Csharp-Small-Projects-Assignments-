using System;

namespace Reverse_array
{
    class Program
    {
        //Reverse Array//
        public void ReverseArray()
        {
            int[] numbers = new int[] { 10, 20, 30, 40, 50, 60 };


            for (int i = (numbers.Length - 1); i >= 0; i--)
            {
                Console.Write(" " + numbers[i]);
            }

        }
    }
}
