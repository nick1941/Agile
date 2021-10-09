using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace GameTest
{
    [TestClass]
    public class GameTest
    {
        private Game game;

        [TestInitialize]
        public void GameTestInitialize ()
        {
            game = new Game ();
        }

        //[TestMethod]
        //public void TestOneThrow ()
        //{
        //    game.Add (5);
        //    Assert.AreEqual (5, game.Score);
        //    Assert.AreEqual (1, game.CurrentFrame);
        //}

        [TestMethod]
        public void TestTwoThrowsNoMark ()
        {
            game.Add (5);
            game.Add (4);
            Assert.AreEqual (9, game.Score);
            Assert.AreEqual (2, game.CurrentFrame);
        }

        [TestMethod]
        public void TestFourThrowsNoMark ()
        {
            game.Add (5);
            game.Add (4);
            game.Add (7);
            game.Add (2);
            Assert.AreEqual (18, game.Score);
            Assert.AreEqual ( 9, game.ScoreForFrame (1));
            Assert.AreEqual (18, game.ScoreForFrame (2));
            Assert.AreEqual ( 3, game.CurrentFrame);
        }

        [TestMethod]
        public void TestSimpleSpare ()
        {
            game.Add (3);
            game.Add (7);
            game.Add (3);
            Assert.AreEqual (13, game.ScoreForFrame (1));
            Assert.AreEqual ( 2, game.CurrentFrame);
        }

        [TestMethod]
        public void TestSimpleFrameAfterSpare ()
        {
            game.Add (3);
            game.Add (7);
            game.Add (3);
            game.Add (2);
            Assert.AreEqual (13, game.ScoreForFrame (1));
            Assert.AreEqual (18, game.ScoreForFrame (2));
            Assert.AreEqual (18, game.Score);
            Assert.AreEqual ( 3, game.CurrentFrame);
        }
    } // class GameTest
} // namespace GameTest
