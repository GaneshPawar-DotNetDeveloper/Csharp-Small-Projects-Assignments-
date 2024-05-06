using System;

namespace Assignment_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Palindrom String//

            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            string temp = string.Empty;

            for (int i = (str.Length - 1); i >= 0; i--)
            {
                temp = temp + str[i];
            }
            if (str == temp)
            {
                Console.WriteLine("PAlindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }

        }

        
    }
}


