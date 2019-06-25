using System;
using NUnit.Framework;

namespace tryjenkins
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var a = 1;
            var b = 3;
            var yo = "yo";
            Assert.IsFalse(a == b, "test failed.");
        }

        [Test]
        public void TestMethod22()
        {
            var a = 1;
            var b = 3;
            Assert.IsFalse(a == b, "test failed.");
        }

        [Test]
        public void TestMethod3()
        {
            var a = 1;
            var b = 2;
            Assert.IsFalse(a != b, "test failed.");
        }

        [Test]
        public void TestMethod4()
        {
            var a = 1;
            var b = 2;
            Assert.IsFalse(a == b, "test failed.");
        }
    }
}
