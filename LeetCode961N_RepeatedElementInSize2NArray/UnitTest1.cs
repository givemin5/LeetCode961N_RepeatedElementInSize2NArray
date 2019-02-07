using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode961N_RepeatedElementInSize2NArray
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var items = new int[] {1, 2, 3, 3};

            Solution solution = new Solution();

            var expected = 3;
            var actual = solution.RepeatedNTimes(items);

            Assert.AreEqual(expected, actual);


        }
    }
}
