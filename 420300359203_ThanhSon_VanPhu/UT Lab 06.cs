using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _420300359203_ThanhSon_VanPhu
{
    [TestClass]
    public class UnitTest6
    {
        private MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_UT_Lab_06.csv", "data_UT_Lab_06#csv",
        DataAccessMethod.Sequential), TestMethod]
        public void TestCase()
        {
            String s1 = Convert.ToString(TestContext.DataRow[0]);
            String s2 = Convert.ToString(TestContext.DataRow[1]);
            String s3 = Convert.ToString(TestContext.DataRow[2]);
            String expectedResult = Convert.ToString(TestContext.DataRow[3]);

            String actualResult = obj.ThayThe(s1, s2, s3);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
