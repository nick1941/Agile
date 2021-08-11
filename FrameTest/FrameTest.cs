using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace FrameTest
{
    [TestClass]
    public class FrameTest
    {
        [TestMethod]
        public void TestScoreNoThrows ()
        {
            Frame frame = new Frame ();

            Assert.AreEqual (0, frame.Score);
        }

        [TestMethod]
        public void TestAddOneThrow ()
        {
            Frame frame = new Frame ();

            frame.Add (5);
            Assert.AreEqual (5, frame.Score);
        }
    }
}
