using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual("", "");
		}

		[TestMethod]
		public void TestMethod2()
		{
			Assert.AreEqual("2", "2");
		}

		[TestMethod]
		public void TestMethod3()
		{
			Assert.AreEqual("2", "2");
		}

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("2", "2");
        }
    

		[TestMethod]
		public void TestMethod6()
		{
			Assert.AreEqual("2", "2");
		}
	}
}
