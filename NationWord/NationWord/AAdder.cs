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

            int aCount = 0;
            while (!DoesWordContainaaa(word))
            {
                word = "a" + word;
                aCount++;

                if (DoesWordContainaaa(word))
                {
                    aCount--;
                    result = aCount;
                    break;
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