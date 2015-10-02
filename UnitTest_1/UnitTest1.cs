using System;
using NKaiju;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSortedByID()
        {
            try
            {
                ContextKaiju o1 = new ContextKaiju(-1);
            }
            catch (System.Exception ex1)
            {
                if (ex1.Message != "ContextKaijy(int i) - argument exeption.")
                {
                    throw new System.Exception("www");
                }
            }
        }
    }
}
