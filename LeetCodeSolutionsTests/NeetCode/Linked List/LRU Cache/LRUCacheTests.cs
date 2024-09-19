using Shouldly;

namespace LRU_Cache.Tests
{
    [TestClass()]
    public class LRUCacheTests
    {
        [TestMethod()]
        public void LRUCacheTest()
        {
            LRUCache lRUCache = new(1);

            lRUCache.Put(1, 1);
            lRUCache.Put(2, 1);
            lRUCache.Put(3, 1);

            lRUCache.Get(1).ShouldBe(-1);
            lRUCache.Get(2).ShouldBe(-1);
            lRUCache.Get(3).ShouldBe(1);

        }

        [TestMethod()]
        public void LRUCacheTest2()
        {
            LRUCache lRUCache = new(2);

            lRUCache.Put(1, 1);
            lRUCache.Put(1, 1);
            lRUCache.Put(2, 1);

            lRUCache.Get(1).ShouldBe(1);
            lRUCache.Get(2).ShouldBe(1);

            lRUCache.Put(3, 1);

            lRUCache.Get(3).ShouldBe(1);
            lRUCache.Get(1).ShouldBe(-1);

        }


    }
}