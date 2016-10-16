using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Example.ONE.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sm_CheckWithoutContent()
        {
            var sm = new StringManager();

            Assert.IsTrue(sm.IsNullOrEmpty);
        }

        [TestMethod]
        public void sm_CheckStringAdd()
        {
            var sm = new StringManager();

            var _s = "Roberto";

            Assert.AreEqual(sm.Add(_s).ToString(), "roberto");
        }
    }
}
