using System;

namespace Longest_String_From_Array
{
    class Program
    {
        //Longest String From Array//
        public void HigestStringFromArray()
        {
            string str = "Please waer Mask and Sanitise hand regularly";
            //string[] strs = str.Split(new[] { " " }, StringSplitOptions.None);
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
