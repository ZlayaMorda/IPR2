using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ButtonsPlugins;

namespace WithButton.Tests
{
    [TestClass]
    public class AnimationTests
    {
        private Animation anim;
        [TestInitialize]
        public void TestInitialize()
        {
            anim = new Animation("", 10, 110);
        }

        [TestMethod]
        public void TestMethod1()
        {
            const double del = 0.01;
            const float expected_p15 = 2.597f;

            float actual_p15 = anim.Step();

            Assert.AreEqual(expected_p15, actual_p15, del, "{0} should have been {1}", actual_p15, expected_p15);
        }

        [TestMethod]
        public void TestMethod2()
        {
            const double del = 0.01;
            const float expected_p30 = 3.636f;

            anim.Value = 30;
            anim.Volume = 80;
            float actual_p30 = anim.Step();

            Assert.AreEqual(expected_p30, actual_p30, del, "{0} should have been {1}", actual_p30, expected_p30);
        }

        [TestMethod]
        public void TestMethod4()
        {
            anim.Reverse = true;
            anim.Value = 30;
            anim.Volume = 80;
            const double del = 0.01;
            const float expected_p15 = 2.078f;

            float actual_p15 = anim.Step();

            Assert.AreEqual(expected_p15, actual_p15, del, "{0} should have been {1}", actual_p15, expected_p15);
        }

        [TestMethod]
        public void TestMethod5()
        {
            anim.Reverse = true;
            anim.Value = 40;
            anim.Volume = 70;
            const double del = 0.01;
            const float expected_p30 = 3.182f;

            float actual_p30 = anim.Step();

            Assert.AreEqual(expected_p30, actual_p30, del, "{0} should have been {1}", actual_p30, expected_p30);
        }

        [ExpectedException(typeof(NullReferenceException), "Exception was not thrown")]
        [TestMethod]
        public void TestMethod3()
        {
            anim.UpdateFrame();
        }
    }
}
