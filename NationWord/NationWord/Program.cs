using System;
using System.Collections.Generic;

namespace NationWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class StringAssembler
    {
        public bool CheckForDuplicateLetters(string word)
        {
            List<string> letters = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                string letter = word.Substring(i, 1);
                if (letters.Contains(letter))
                {
                    return true;
                }
                else
                {
                    letters.Add(letter);
                }
            }

            return false;
        }
    }
}
