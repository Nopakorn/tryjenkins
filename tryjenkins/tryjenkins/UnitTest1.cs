﻿using System;
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
            var b = 2;
            Assert.IsFalse(a == b, "test failed.");
        }
    }
}