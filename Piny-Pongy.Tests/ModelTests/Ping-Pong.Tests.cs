using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void ConvertToNum_CheckForPosNumber_InvalidNumber()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(-1, testPingPong.ConvertToNum("-7"));
        }

        [TestMethod]
        public void OutputPingPong_DisplayNumRange_NumberRange()
        {
            PingPong testPingPong = new PingPong();
            List<string> expected = new List<string>() { "0", "1", "2" };
            // Cannot use .AreEqual(new List<int> ... , ..OutputPingPong(4)) because compares 2 objects that are different - need to compare internal values
            // Use .SequenceEquals (!! *Import System.Linq* !!) to iterate through list and check values & order
            Assert.IsTrue(expected.SequenceEqual(testPingPong.OutputPingPong(2)));
        }

        [TestMethod]
        public void OutputPingPong_DisplayPing_RangeWithPing()
        {
            PingPong testPingPong = new PingPong();
            List<string> expected = new List<string>(){ "0", "1", "2", "ping", "4" };
            List<string> actual = testPingPong.OutputPingPong(4);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

    }
}