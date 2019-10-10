using NUnit.Framework;

namespace ArraysTest
{
    class SockMerchantTest
    {
        [Test]
        public void MaxPairTest()
        {
            Assert.AreEqual(3,Arrays.SockMerchant.GetMaxPairs(new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }));
        }
    }
}
