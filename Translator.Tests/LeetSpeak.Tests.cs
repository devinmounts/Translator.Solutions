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
            Assert.AreEqual(true, testLeetSpeak.ToLeetSpeak("e"));
        }
    }
}
