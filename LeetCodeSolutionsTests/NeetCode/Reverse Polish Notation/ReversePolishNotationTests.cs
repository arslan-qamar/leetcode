using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Reverse_Polish_Notation.Tests
{
    [TestClass()]
    public class ReversePolishNotationTests
    {
        [TestMethod()]
        public void EvalRPNTest()
        {
            ReversePolishNotation.EvalRPN(new string[] { "1", "2", "+", "3", "*", "4", "-" }).Should().Be(5);
            ReversePolishNotation.EvalRPN(new string[] { "1", "2", "+" }).Should().Be(3);
            ReversePolishNotation.EvalRPN(new string[] { "1" }).Should().Be(1);
            ReversePolishNotation.EvalRPN(new string[] { "1", "2" }).Should().Be(0);

        }
    }
}