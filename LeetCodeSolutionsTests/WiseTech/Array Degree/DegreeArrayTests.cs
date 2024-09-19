namespace WiseTechPractice.Problem_1.Tests
{
    [TestClass()]
    public class DegreeArrayTests
    {
        [TestMethod()]
        public void degreeOfArrayTest()
        {
            Assert.IsTrue(DegreeArray.degreeOfArray([1, 2, 1, 3, 2]) == 3);
        }

    }
}