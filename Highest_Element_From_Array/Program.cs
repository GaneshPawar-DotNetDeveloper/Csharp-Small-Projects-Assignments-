using System;

namespace Highest_Element_From_Array
{
    class Program
    {
        //higest string from array
        public void HigestStringFromArray()
        {
            Console.WriteLine("Please Enter String ");

            string str = Console.ReadLine();
            string[] strs = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = string.Empty;
            int tr = 0;

            foreach (string s in strs)
            {
                if (s.Length > tr)
                {
                    word = s;
                    tr = s.Length;
                }
            }
            Console.WriteLine(word);
        }


    }
}

