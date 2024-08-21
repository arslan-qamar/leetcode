using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Stacks.Generate_Parentheses.Tests
{
    [TestClass()]
    public class GenerateParenthesesTests
    {
        [TestMethod()]
        public void GenerateParenthesisTest()
        {
            GenerateParentheses.GenerateParenthesis(1).Should().BeEquivalentTo(new string[] { "()" });
            GenerateParentheses.GenerateParenthesis(3).Should().BeEquivalentTo(new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" });
        }
    }
}