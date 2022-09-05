using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestDoubleLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        public int[] CreateTestData()
        {
            int[] testData = new int[10];
            for (int index = 0; index < testData.Length; index++)
            {
                testData[index] = index;
            }
            return testData;
        }

        [TestMethod]
        public void Test_Add_Last()
        {
            int[] testData = CreateTestData();

        }
    }
}
