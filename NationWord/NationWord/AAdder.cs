using System;

namespace NationWord
{
    public class AAdder
    {
        public int AddAsTo(string word)
        {
            int result = int.MaxValue;

            if (DoesWordContainaaa(word))
            {
                result = -1;
            }

            if (word == "aa")
            {
                result = 0;
            }

            return result;
        }

        public bool DoesWordContainaaa(string word)
        {
            return word.Contains("aaa");
        }
    }
}