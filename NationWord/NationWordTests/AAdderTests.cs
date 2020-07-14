using System;
using NationWord;
using NUnit.Framework;

namespace NationWordTests
{

    [TestFixture]
    public class AAdderTests
    {
        [TestCase("aaa")]
        [TestCase("baaa")]
        public void When_Word_Contains_aaa_Return_Minus_One(string word)
        {
            AAdder adder = new AAdder();
            int result = adder.AddAsTo(word);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void When_Word_Is_aa_Return_Zero()
        {
            AAdder adder = new AAdder();
            int result = adder.AddAsTo("aa");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void When_Word_Contains_aaa_Return_True()
        {
            AAdder adder = new AAdder();
            bool result = adder.DoesWordContainaaa("aaa");
            Assert.That(result, Is.True);
        }

        [TestCase("a", 1)]
        [TestCase("b", 4)]
        public void When_Word_Is_One_Letter_as_Can_Be_Added_To_It(string word, int expected)
        {
            AAdder adder = new AAdder();
            int result = adder.AddAsTo(word);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void When_Word_Is_dog_Eight_As_Can_Be_Added_To_It()
        {
            AAdder adder = new AAdder();
            int result = adder.AddAsTo("dog");
            Assert.That(result, Is.EqualTo(8));
        }


    }
}