using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace _420300359203_ThanhSon_VanPhu
{
    [TestClass]
    public class UT_Lab_08
    {
        public MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
        [TestMethod]
        [DataRow("4,5,6,2,7,8", 0, 3, "2,4,5,6,7,8")]
        [DataRow("1,2,6,5,4", 2, 4, "1,2,4,5,6")]
        [DataRow("3,5,7,9,2,8", -5, 5, "3,5,7,9,2,8")]
        [DataRow("2,3,9,7,5,8,4", 10, 6, "2,3,9,7,5,8,4")]
        [DataRow("2,3,4,9,8,5", 3, 1, "2,3,4,9,8,5")]
        [DataRow("3,5,2,6,7,4", 0, 10, "3,5,2,6,7,4")]
        [DataRow("3,5,7,9,2,8", 0, 5, "2,3,5,7,8,9")]
        [DataRow("4,5,7,6,8,9", 2, 3, "4,5,6,7,8,9")]
        [DataRow("1,2,6,5,4", -1, 4, "1,2,6,5,4")]
        [DataRow("4,5,6,2,7,8", 6, 5, "4,5,6,2,7,8")]
        [DataRow("2,3,9,7,5,8,4", 2, 1, "2,3,9,7,5,8,4")]
        [DataRow("2,3,4,9,8,5", 3, 6, "2,3,4,9,8,5")]
        [DataRow("4,5,6,2,7,8", 0, 3, "2,4,5,6,7,8")]
        public void TestCase(Object list, int left, int right , Object expectedResult)
        {
            int[] a = ((String)list).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] kq = ((String)expectedResult).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            obj.QuickSort(a,left,right);
            Assert.IsTrue(a.SequenceEqual(kq));

        }
    }
}
