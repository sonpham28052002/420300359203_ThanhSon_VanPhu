using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _420300359203_ThanhSon_VanPhu
{
    [TestClass]
    public class UT_Lab_04
    {
       
            [TestMethod]
            public void TestMethod1()
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                long s = 3;
                long actualResult = obj.Sum(3, out s);
                long expectedK = 2;
                Assert.AreEqual(expectedK, actualResult);
            }
            [TestMethod]
            public void TestMethod2()
            {
                Exception expectedException = null;
                try
                {
                    MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                    long s = -100;
                    long actualResult = obj.Sum(0, out s);
                }
                catch (Exception ex)
                {
                    expectedException = ex;

                }
                Assert.IsNotNull(expectedException);

            }

            [TestMethod]
            public void TestMethod3()
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                long s = 1;
                long actualResult = obj.Sum(0, out s);
                long expectedK = 1;
                Assert.AreEqual(expectedK, actualResult);
            }
            [TestMethod]
            public void TestMethod4()
            {
                Exception expectedException = null;
                try
                {
                    MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                    long s = -1;
                    long actualResult = obj.Sum(0, out s);
                }
                catch (Exception ex)
                {
                    expectedException = ex;

                }
                Assert.IsNotNull(expectedException);


            }
        }
}
