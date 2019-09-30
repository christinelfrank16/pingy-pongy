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

        [TestMethod]
        public void ConvertToNum_CheckForNumber_InvalidString()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(-1, testPingPong.ConvertToNum("Invalid input"));
        }

        // [TestMethod]
        // public void ConvertToNum_CheckForNumber_InvalidString()
        // {
        //     PingPong testPingPong = new PingPong();
        //     Assert.AreEqual("Invalid input", testPingPong.ConvertToNum("Invalid input"));
        // }
    }
}