using FluentAssertions;

namespace Reverse_Polish_Notation
{
    [TestClass()]
    public class ReversePolishNotationTests
    {
        [TestMethod()]
        public void EvalRPNTest()
        {
            _ = ReversePolishNotation.EvalRPN(new string[] { "1", "2", "+", "3", "*", "4", "-" }).Should().Be(5);
            _ = ReversePolishNotation.EvalRPN(new string[] { "1", "2", "+" }).Should().Be(3);
            _ = ReversePolishNotation.EvalRPN(new string[] { "1" }).Should().Be(1);
            _ = ReversePolishNotation.EvalRPN(new string[] { "1", "2" }).Should().Be(0);

        }
    }
}