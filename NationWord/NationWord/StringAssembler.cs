using System.Collections.Generic;
using System.Linq;

namespace NationWord
{
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

        public int FindLongestAssembledString(string[] S)
        {
            if (!S.Any())
            {
                return 0;
            }

            if (S.Length == 1)
            {
                if (CheckForDuplicateLetters(S[0]))
                {
                    return -1;
                }

                return S[0].Length;
            }

            List<string> fragments = S.ToList();

            int longestConcatenation = -1;

            foreach (string fragment in fragments)
            {
                List<string> otherFragments = fragments.Except(new List<string>(){fragment}).ToList();

                string concatenation = fragment;
                string originalConcatenation;

                foreach (string otherFragment in otherFragments)
                {
                    originalConcatenation = concatenation;
                    concatenation += otherFragment;

                    if (!CheckForDuplicateLetters(concatenation))
                    {
                        if (concatenation.Length > longestConcatenation)
                        {
                            longestConcatenation = concatenation.Length;
                        }
                    }
                    else
                    {
                        concatenation = originalConcatenation;
                    }
                }
            }

            return longestConcatenation;
        }
    }
}