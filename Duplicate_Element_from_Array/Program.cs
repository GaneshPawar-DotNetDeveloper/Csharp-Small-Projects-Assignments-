using System;

namespace Duplicate_Element_from_Array
{
    class Program
    {
        //Duplicate Elements From Array
        public void DuplicateElementFromArray()
        {
            int[] number = new int[] { 10, 20, 10, 50, 40, 40, 60, 70, 20 };


            for (int i = 0; i <= (number.Length); i++)
            {
                for (int j = i + 1; j < (number.Length); j++)
                {
                    if (number[i] == number[j])
                    {

                        Console.WriteLine(number[i]);
                    }
                }
            }
        }

    }
}
