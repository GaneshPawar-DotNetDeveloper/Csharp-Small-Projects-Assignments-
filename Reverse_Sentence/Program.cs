using System;

namespace Reverse_Sentence
{
    class Program
    {
        //Reverse Sentence //
        public void reversesentences()
        {
            string str = " how are you";
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = string.Empty;

            for (int i = (words.Length - 1); i >= 0; i--)
            {
                Console.Write(word = words[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
