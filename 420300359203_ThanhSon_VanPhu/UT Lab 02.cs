using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _420300359203_ThanhSon_VanPhu
{
    [TestClass]
    public class UT_Lab_02
    {
            [TestMethod]
            public void TestMethod1()
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                float x1, x2;

                String actualResult = obj.SolveQuadratic(1, 0, 2, out x1, out x2);

                Assert.AreEqual("Vô nghiệm", actualResult);
                Assert.IsTrue(float.IsNaN(x1));
                Assert.IsTrue(float.IsNaN(x2));

            }
            [TestMethod]
            public void TestMethod2()
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                float x1, x2;

                String actualResult = obj.SolveQuadratic(0, 3, 3, out x1, out x2);
                Assert.AreEqual("Có 1 nghiệm", actualResult);
                Assert.AreEqual(-1, x1);
                Assert.AreEqual(-1, x2);

            }
            [TestMethod]
            public void TestMethod3()
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                float x1, x2;
                int a = 1, b = -3, c = 2;

                String actualResult = obj.SolveQuadratic(a, b, c, out x1, out x2);
                Assert.AreEqual("Có 2 nghiệm phân biệt", actualResult);
                Assert.AreEqual(1, x1);
                Assert.AreEqual(1, x2);

            }
            [TestMethod]
            public void TestMethod4()
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                float x1, x2;

                String actualResult = obj.SolveQuadratic(1, 2, 1, out x1, out x2);
                Assert.AreEqual("Có nghiệm kép", actualResult);
                Assert.AreEqual(-2, x1);
                Assert.AreEqual(-2, x2);

            }
            [TestMethod]
            public void TestMethod5()
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                float x1, x2;

                String actualResult = obj.SolveQuadratic(0, 0, 0, out x1, out x2);
                Assert.AreEqual("Vô số nghiệm", actualResult);
                Assert.AreEqual(float.NaN, x1);
                Assert.AreEqual(float.NaN, x2);

            }
    }
}
