using System;

namespace Reverse_String
{
    class Program
    {
        //Reverse String//
        public void ReverseString()
        {
            Console.WriteLine("Enter String");
            string Str = Console.ReadLine();
            string temp = string.Empty;

            for (int i = (Str.Length - 1); i >= 0; i--)
            {
                temp = temp + Str[i];
            }
            Console.WriteLine(temp);

        }
    }
}
