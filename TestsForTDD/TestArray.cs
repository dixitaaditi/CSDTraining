using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForTDD
{
    [TestClass]
    public class TestArray
    {
        
        [TestMethod]
        public void TestMaxWithPositive()
        {
            int[] arr = new int[] { 1, 8, 9, 20, 100 };
            Assert.AreEqual(100, new Calculator().FindMAx(arr));
        }

        [TestMethod]
        public void TestMaxWithNegative()
        {
            int[] arr = new int[] { -1, -8, -9, -20, -100 };
            Assert.AreEqual(-1, new Calculator().FindMAx(arr));
        }

        [TestMethod]
        public void TestMaxWithMixed()
        {
            int[] arr = new int[] { -1, 8, 9, 20, -100 };
            Assert.AreEqual(20, new Calculator().FindMAx(arr));
        }

        [TestMethod]
        public void TestMaxWithNull()
        {
            string msg="";
           
            try
            {
                new Calculator().FindMAx(null);
            }
            catch (Exception ex)
            {
                
                msg = ex.Message;
            }

            Assert.AreEqual("Null or empty array", msg);
        }

        [TestMethod]
        public void TestMaxWithSingleNumber()
        {
            int[] arr = new int[] { -1 };
            Assert.AreEqual(-1, new Calculator().FindMAx(arr));
        }

        [TestMethod]
        public void TestMaxWithSameNumbers()
        {
            int[] arr = new int[] { 67, 67};
            Assert.AreEqual(67, new Calculator().FindMAx(arr));
        }

        [TestMethod]
        public void TestMaxWithEmpty()
        {
            string msg="";
            int[] arr = new int[] {};
            try
            {
                new Calculator().FindMAx(arr);
            }
            catch (Exception ex)
            {
                
                msg = ex.Message;
            }

            Assert.AreEqual("Null or empty array", msg);
        }
    }
}
