using NUnit.Framework;

namespace ArraysTest
{
    public class HourGlassTest
    {
        [Test]
        public void BasicTest()
        {
            int[][] arr = new int[][]
                {
                   new int[]{ 1, 1, 1, 0, 0, 0 },
                   new int[]{ 0, 1, 0, 0, 0, 0 },
                   new int[]{ 1, 1, 1, 0, 0, 0 },
                   new int[]{ 0, 0, 2, 4, 4, 0 },
                   new int[]{ 0, 0, 0, 2, 0, 0 },
                   new int[]{ 0, 0, 1, 2, 4, 0 }
                };

            Assert.AreEqual(19, Arrays.HourGlass.GetHourGlassMaxSum(arr));
        }
    }
}
