using FluentAssertions;

namespace Generate_Parentheses
{
    [TestClass()]
    public class GenerateParenthesesTests
    {
        [TestMethod()]
        public void GenerateParenthesisTest()
        {
            _ = GenerateParentheses.GenerateParenthesis(1).Should().BeEquivalentTo(new string[] { "()" });
            _ = GenerateParentheses.GenerateParenthesis(3).Should().BeEquivalentTo(new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" });
        }
    }
}