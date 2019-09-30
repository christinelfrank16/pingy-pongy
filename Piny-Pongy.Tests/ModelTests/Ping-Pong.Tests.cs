using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingyPongy;

namespace PingyPongy.Tests
{
    [TestClass]
    public class PingPongTest
    {
        [TestMethod]
        public void ConvertToNum_CheckForNumber_Number()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(4, testPingPong.ConvertToNum("4"));
        }
    }
}