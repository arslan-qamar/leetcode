using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Encode_Decode_Strings.Tests
{
    [TestClass()]
    public class EncodeDecodeTests
    {
        [TestMethod()]
        public void EncodeDecodeSingleTest()
        {
            List<string> input = new List<string>() { "!" };

            string result = EncodeDecode.Encode(input);

            result.Should().Be("1#!");

            EncodeDecode.Decode(result).Should().BeEquivalentTo(input);
        }

        [TestMethod()]
        public void EncodeDecodeFailedTest()
        {
            List<string> input = new List<string>() { "we", "say", ":", "yes", "!@#$%^&*()" };

            string result = EncodeDecode.Encode(input);

            result.Should().Be("2#we3#say1#:3#yes10#!@#$%^&*()");

            EncodeDecode.Decode(result).Should().BeEquivalentTo(input);
        }


        [TestMethod()]
        public void EncodeDecodeTest()
        {
            List<string> input = new List<string>() { "neet", "code", "love", "you" };

            string result = EncodeDecode.Encode(input);

            result.Should().Be("4#neet4#code4#love3#you");

            EncodeDecode.Decode(result).Should().BeEquivalentTo(input);
        }

        [TestMethod()]
        public void EncodeDecodeTestComplex()
        {
            List<string> input = new List<string>() { "4#et", "co4#", "4#ve", "3#u" };
            string result = EncodeDecode.Encode(input);

            result.Should().Be("4#4#et4#co4#4#4#ve3#3#u");

            EncodeDecode.Decode(result).Should().BeEquivalentTo(input);
        }

    }
}