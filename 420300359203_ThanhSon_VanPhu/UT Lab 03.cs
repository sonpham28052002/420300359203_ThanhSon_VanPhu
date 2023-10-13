using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _420300359203_ThanhSon_VanPhu
{
    [TestClass]
    public class UnitTest3
    {
        private MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_UT_Lab_03.csv", "data_UT_Lab_03#csv",
        DataAccessMethod.Sequential), TestMethod]
        public void TestCase()
        {
            int SoCu = Convert.ToInt32(TestContext.DataRow[0]);
            int SoMoi = Convert.ToInt32(TestContext.DataRow[1]);
            double expectedResult = Convert.ToDouble(TestContext.DataRow[2]);
            String actualResult = obj.TinhTienDien(SoCu, SoMoi) + "";
            Assert.AreEqual(expectedResult + "", actualResult);
        }
    }
}
