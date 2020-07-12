using NationWord;
using NUnit.Framework;

namespace NationWordTests
{
    public class StringAssemblyTests
    {
        [TestCase("aa", true)]
        [TestCase("abc", false)]
        [TestCase("banana", true)]
        [TestCase("abcba", true)]
        public void When_String_Contains_Duplicate_Letters_Return_True(string word, bool expected)
        {
            StringAssembler assembler = new StringAssembler();
            bool result = assembler.CheckForDuplicateLetters(word);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}