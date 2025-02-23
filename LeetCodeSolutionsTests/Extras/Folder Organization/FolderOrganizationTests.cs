using FluentAssertions;

namespace Extras.Problem_2.Tests
{
    [TestClass()]
    public class FolderOrganizationTests
    {
        [TestMethod()]
        public void minFoldersTest()
        {
            Assert.IsTrue(FolderOrganization.minFolders(1, 1, 0, 1) == 2);
        }

        [TestMethod()]
        public void minFoldersTest2()
        {
            Assert.IsTrue(FolderOrganization.minFolders(5, 0, 2, 2) == 5);
        }

        [TestMethod()]
        public void minFoldersTest3()
        {
            Assert.IsTrue(FolderOrganization.minFolders(500, 0, 0, 1) == 500);
        }


        [TestMethod()]
        public void minFoldersTest4()
        {
            Assert.IsTrue(FolderOrganization.minFolders(500, 500, 0, 1) == 1000);
        }

        [TestMethod()]
        public void minFoldersTest5()
        {
            _ = FolderOrganization.minFolders(500, 500, 0, 2).Should().Be(500);
        }

        [TestMethod()]
        public void minFoldersTest6()
        {
            //79320
            _ = FolderOrganization.minFolders(2364, 76956, 35794, 2).Should().Be(76956);
        }


        [TestMethod()]
        public void minFoldersTest7()
        {
            //cssFiles:64236, jsFiles:49164, readMeFiles:38865, capacity:2
            _ = FolderOrganization.minFolders(64236, 49164, 38865, 2).Should().Be(76133);
        }


    }
}