using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Binary_Search.Search_2D_Matrix.Tests
{
    [TestClass()]
    public class Search2DMatrixTests
    {
        [TestMethod()]
        public void SearchMatrixTest()
        {
            Search2DMatrix.SearchMatrix(new int[][]
            {
                new int [] {1,2,4,8 },
                new int [] {10, 11, 12, 13 },
                new int [] {14, 20, 30, 40 }
            }, 10).Should().BeTrue();
        }

        [TestMethod()]
        public void SearchMatrixTest2()
        {
            Search2DMatrix.SearchMatrix(new int[][]
            {
                new int [] {1,2,4,8 },
                new int [] {10, 11, 12, 13 },
                new int [] {14, 20, 30, 40 }
            }, 15).Should().BeFalse();
        }

        [TestMethod()]
        public void SearchMatrixTest3()
        {
            Search2DMatrix.SearchMatrix(new int[][]
            {
                new int [] {1,3,5,7 },
                new int [] {10,11,16,20 },
                new int [] { 23, 30, 34, 60 }
            }, 3).Should().BeTrue();
        }


        [TestMethod()]
        public void SearchMatrixTest4()
        {
            Search2DMatrix.SearchMatrix(new int[][]
            {
                new int [] {1},
                new int [] {3}
            }, 3).Should().BeTrue();
        }

        [TestMethod()]
        public void SearchMatrixTest5()
        {
            Search2DMatrix.SearchMatrix(new int[][]
            {
                new int [] {1}
            }, 1).Should().BeTrue();
        }
    }
}