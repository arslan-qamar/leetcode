using FluentAssertions;

namespace Encode_Decode_Strings
{
    [TestClass()]
    public class EncodeDecodeTests
    {
        [TestMethod()]
        public void EncodeDecodeSingleTest()
        {
            List<string> input = ["!"];

            string result = EncodeDecode.Encode(input);

            _ = result.Should().Be("1#!");

            _ = EncodeDecode.Decode(result).Should().BeEquivalentTo(input);
        }

        [TestMethod()]
        public void EncodeDecodeFailedTest()
        {
            List<string> input = ["we", "say", ":", "yes", "!@#$%^&*()"];

            string result = EncodeDecode.Encode(input);

            _ = result.Should().Be("2#we3#say1#:3#yes10#!@#$%^&*()");

            _ = EncodeDecode.Decode(result).Should().BeEquivalentTo(input);
        }


        [TestMethod()]
        public void EncodeDecodeTest()
        {
            List<string> input = ["neet", "code", "love", "you"];

            string result = EncodeDecode.Encode(input);

            _ = result.Should().Be("4#neet4#code4#love3#you");

            _ = EncodeDecode.Decode(result).Should().BeEquivalentTo(input);
        }

        [TestMethod()]
        public void EncodeDecodeTestComplex()
        {
            List<string> input = ["4#et", "co4#", "4#ve", "3#u"];
            string result = EncodeDecode.Encode(input);

            _ = result.Should().Be("4#4#et4#co4#4#4#ve3#3#u");

            _ = EncodeDecode.Decode(result).Should().BeEquivalentTo(input);
        }

    }
}