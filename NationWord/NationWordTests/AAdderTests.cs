﻿using System;
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
    }
}