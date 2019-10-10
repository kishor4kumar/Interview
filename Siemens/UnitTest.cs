using NUnit.Framework;

namespace Siemens
{
    class UnitTest
    {
        [Test]
        public void ArrayElementChangesTest()
        {
            Assert.AreEqual(3, ArrayElementChanges.Solve(new int[] { 1, 2, 3, 2, 1 }));
        }

        [Test]
        public void TokenizeStringTest()
        {
            var stringData = TokenizeString.GetTokenizedString("This is \"S P A R T AAAA\"");
            Assert.AreEqual(3, stringData.Count);
            Assert.AreEqual("This", stringData[0]);
            Assert.AreEqual("is", stringData[1]);
            Assert.AreEqual("\"S P A R T AAAA\"", stringData[2]);
        }
    }
}
