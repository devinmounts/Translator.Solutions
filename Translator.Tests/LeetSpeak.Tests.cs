using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator;

namespace Translator.Tests
{
    [TestClass]
    public class LeetSpeakTests
    {
        [TestMethod]
        public void ToLeetSpeak_ContainsE_True()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("3", testLeetSpeak.ToLeetSpeak("e"));
        }

        [TestMethod]
        public void ToLeetSpeak_ContainsO_True()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("0", testLeetSpeak.ToLeetSpeak("o"));
        }

        [TestMethod]
        public void ToLeetSpeak_ContainsI_True()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("1", testLeetSpeak.ToLeetSpeak("I"));
        }

        [TestMethod]
        public void ToLeetSpeak_ContainsT_True()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("7", testLeetSpeak.ToLeetSpeak("t"));
        }

        [TestMethod]
        public void ToLeetSpeak_ContainsS_True()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("az", testLeetSpeak.ToLeetSpeak("as"));
        }

        [TestMethod]
        public void ToLeetSpeak_ContainsExceptionS_True()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("s3zzi0nz", testLeetSpeak.ToLeetSpeak("sessions"));
        }

    }
}
