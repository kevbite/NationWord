using System;
using System.Linq;

namespace NationWord
{
    public class AAdder
    {
        public int AddAsTo(string word)
        {
            int result;

            if (DoesWordContainaaa(word))
            {
                result = -1;
            }
            else
            {
                if (word == "aa")
                {
                    result = 0;
                }
                else
                {
                    int numberOfNonAChars = word.Count(c => (c != 'a'));
                    int numberOfAChars = word.Count(c => (c == 'a'));

                    return ((numberOfNonAChars * 2) + 2) - numberOfAChars;

                }
            }


            return result;
        }

        public bool DoesWordContainaaa(string word)
        {
            return word.Contains("aaa");
        }
    }
}