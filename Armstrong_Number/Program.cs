using System;

namespace Armstrong_Number
{
    class Program
    {
        public void Armstrong()
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());

            int rem;
            int sum = 0;
            int temp = number;

            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is palindrom");
            }
            else
            {

                Console.WriteLine("Number is not Palindrom");
            }
        }
    }
}
