using FluentAssertions;

namespace WiseTechPractice.Test_2.Tests
{
    [TestClass()]
    public class DiscountsTests
    {

        [TestMethod()]
        public void findLowestPriceTestSample()
        {
            _ = Discounts.findLowestPrice(
                [
                    ["10","d0","d1"],
                    ["15","EMPTY","EMPTY"],
                    ["20","d1","EMPTY"],
                ]
                ,
                [
                    ["d0", "1", "27"],
                    ["d1", "2", "5"]
                ]).Should().Be(35);

        }


        [TestMethod()]
        public void findLowestPriceTestCase1()
        {
            _ = Discounts.findLowestPrice(
                [
                    ["100", "dcoupon1"],
                    ["50", "dcoupon1"],
                    ["30", "dcoupon1"],
                    ["100", "dcoupon2"],
                    ["50", "dcoupon2"],
                    ["30", "dcoupon2"],
                ]
                ,
                [
                    ["dcoupon1", "0", "60"],
                    ["dcoupon1", "1", "30"],
                    ["dcoupon1", "1", "20"],
                    ["dcoupon2", "2", "20"],
                    ["dcoupon2", "1", "85"],
                    ["dcoupon2", "0", "15"]

                ]).Should().Be(142);

        }



        [TestMethod()]
        public void findLowestPriceTestSampleNulls()
        {
            _ = Discounts.findLowestPrice(
                [
                    ["10","d0","d1"],
                    ["15","","NULL"],
                    ["20","d1",null],
                ]
                ,
                [
                    ["d0", "1", "27"],
                    ["d1", "2", "5"]
                ]).Should().Be(35);

        }
    }
}