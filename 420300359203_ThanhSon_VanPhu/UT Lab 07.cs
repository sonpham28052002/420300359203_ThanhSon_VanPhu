using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace _420300359203_ThanhSon_VanPhu
{
    [TestClass]
    public class UT_Lab_07
    {
        private MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_UT_Lab_07.csv", "data_UT_Lab_07#csv",
        DataAccessMethod.Sequential), TestMethod]
        public void TestMethod1()
        {
            string aStr = TestContext.DataRow[0]+"";
            Assert.AreEqual(aStr, "");
            int[] a = aStr.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int expectedResult = Convert.ToInt32(TestContext.DataRow[1]);

            int actualResult = obj.Largest(a);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
