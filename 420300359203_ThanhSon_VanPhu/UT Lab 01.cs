using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _420300359203_ThanhSon_VanPhu
{
    [TestClass]
    public class UT_Lab_01
    {
        private MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_UT_Lab_01.csv", "data_UT_Lab_01#csv",
        DataAccessMethod.Sequential),TestMethod]
        public void TestCase()
        {
            int A = Convert.ToInt32(TestContext.DataRow[0]);
            int B = Convert.ToInt32(TestContext.DataRow[1]);
            int C = Convert.ToInt32(TestContext.DataRow[2]);
            Object expectedResult =TestContext.DataRow[3];
            if (expectedResult.ToString() == "IndexOutOfRangeException")
            {
                Assert.ThrowsException<IndexOutOfRangeException>(() => obj.Max(A, B, C));
            }
            else
            {
                int actualResult = obj.Max(A, B, C);
                Assert.AreEqual(Convert.ToInt32(expectedResult), actualResult);
            }
        }
    }
}
