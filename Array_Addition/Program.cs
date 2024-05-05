using System;

namespace Array_Addition
{
    class Program
    {
        public void ArrayAddition()
        {
            int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sum = 0;
            int i;
            for (i = 0; i <= number.Length - 1; i++)
            {
                sum = sum + number[i];
            }
            Console.WriteLine(sum);
        }
    }
}
