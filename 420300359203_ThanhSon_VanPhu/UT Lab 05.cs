using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _420300359203_ThanhSon_VanPhu
{
    [TestClass]
    public class UnitTest5
    {
        public MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
        [TestMethod]
        [DataRow("phamthanhson", 2, 3, "phhanhson")]
        [DataRow("", 3, 4, "")]
        [DataRow("thanhson", -3, 6, "thanhson")]
        [DataRow("son", 6, 3, "son")]
        [DataRow("pham", 2, -5, "pham")]
        [DataRow("sonpham", 4, 5, "sonp")]
        [DataRow("s", 0, 0, "s")]
        [DataRow("phamthanhson", 11, 1, "phamthanhsn")]
        [DataRow("", 3, 2, "")]
        [DataRow("sonpham", -1, 3, "sonpham")]
        [DataRow("sons", 4, 2, "sons")]
        [DataRow("leons", 2, -1, "leons")]
        [DataRow("phamson", 5, 3, "phams")]
        public void TestCase(String s , int p, int n, String expectesResult)
        {
                String actualResult = obj.HuyChuoi(s, n, p);
                Assert.AreEqual(expectesResult, actualResult);
           
        }
    }
}
