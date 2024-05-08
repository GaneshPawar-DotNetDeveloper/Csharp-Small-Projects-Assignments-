using System;

namespace Odd_Even
{
    class Program
    {
        public void Assignmenttask11()
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            string oddnum = string.Empty;
            string EvenNum = string.Empty;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    EvenNum = EvenNum + ' ' + i;
                }
                else
                {
                    oddnum = oddnum + ' ' + i;
                }
            }
            Console.WriteLine(oddnum + " " + EvenNum);
        }
    }
}
