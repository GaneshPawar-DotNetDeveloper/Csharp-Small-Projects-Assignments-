using System;

namespace Sum_of_pair_is_30
{
    class Program
    {
        public void AdditionOfPairInArray()
        {
            int[] arr = new int[] { 12, 25, 5, 18, 22, 17 };
            int sum = 30;

            foreach (int i in arr)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] + arr[j]) == sum)
                    {
                        Console.WriteLine(arr[i] + "  and " + arr[j]);
                    }
                }
            }
            Console.ReadLine();
        }

    }
}
