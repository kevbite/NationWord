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

        [Test]
        public void When_Array_Is_Empty_Return_Zero()
        {
            StringAssembler assembler = new StringAssembler();
            int result = assembler.FindLongestAssembledString(new string[0]);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void When_Array_Has_One_Element_Return_Length_Of_Element()
        {
            StringAssembler assembler = new StringAssembler();
            int result = assembler.FindLongestAssembledString(new string[1]{"co"});
            Assert.That(result, Is.EqualTo(2));
        }
    }
}