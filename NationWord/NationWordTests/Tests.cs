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
        public void When_Array_Has_One_Element_With_No_Duplicate_Characters_Return_Length_Of_Element()
        {
            StringAssembler assembler = new StringAssembler();
            int result = assembler.FindLongestAssembledString(new string[1]{"co"});
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void When_Array_Has_One_Element_With_Duplicate_Characters_Return_Minus_One()
        {
            StringAssembler assembler = new StringAssembler();
            int result = assembler.FindLongestAssembledString(new string[1]{"coc"});
            Assert.That(result, Is.EqualTo(-1));
        }

        [TestCase(new string[2]{"co", "dil"}, 5)]
        [TestCase(new string[3]{"co", "dil", "ity"}, 5)]
        [TestCase(new string[3]{"ezy", "jnx", "btp"}, 9)]
        public void When_Array_Has_Multiple_Elements_Combine_Them_To_Get_The_Length(string[] fragments, int expected)
        {
            StringAssembler assembler = new StringAssembler();
            int result = assembler.FindLongestAssembledString(fragments);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}