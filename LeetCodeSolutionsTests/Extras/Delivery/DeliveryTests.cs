using FluentAssertions;

namespace Extras.Test_4.Tests
{
    [TestClass()]
    public class DeliveryTests
    {
        [TestMethod()]
        public void orderTest()
        {
            int cityNodes = 4;
            List<int> cityFrom = [1, 2, 2];
            List<int> cityTo = [2, 3, 4];
            int company = 1;
            _ = Delivery.order(cityNodes, cityFrom, cityTo, company).Should().BeEquivalentTo(new List<int>() { 2, 3, 4 });


            int cityNodes2 = 5;
            List<int> cityFrom2 = [1, 1, 2, 3, 1];
            List<int> cityTo2 = [2, 3, 4, 5, 5];
            int company2 = 1;
            _ = Delivery.order(cityNodes2, cityFrom2, cityTo2, company2).Should().BeEquivalentTo(new List<int>() { 2, 3, 5, 4 }); ;

            int cityNodes3 = 3;
            List<int> cityFrom3 = [1];
            List<int> cityTo3 = [2];
            int company3 = 2;

            _ = Delivery.order(cityNodes3, cityFrom3, cityTo3, company3).Should().BeEquivalentTo(new List<int>() { 1 });
        }

        [TestMethod()]
        public void orderTest1()
        {
            int cityNodes = 3;
            List<int> cityFrom = [3, 3, 1, 2, 3];
            List<int> cityTo = [4, 1, 4, 1, 2];
            int company = 3;
            _ = Delivery.order(cityNodes, cityFrom, cityTo, company).Should().BeEquivalentTo(new List<int>() { 1, 2, 4 });

        }
    }
}