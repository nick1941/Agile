using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace GameTest
{
    /// <summary>
    /// A test class to test the Game.
    /// </summary>
    [TestClass]
    public class GameTest
    {
        private Game game;

        /// <summary>
        /// Initialize the game test.
        /// </summary>
        [TestInitialize]
        public void GameTestInitialize ()
        {
            game = new Game ();
        }

        /// <summary>
        /// Test two throws that don't constitute a strike or spare.
        /// </summary>
        [TestMethod]
        public void TestTwoThrowsNoMark ()
        {
            game.Add (5);
            game.Add (4);
            Assert.AreEqual (9, game.Score);
        }

        /// <summary>
        /// Test four throws that don't constitute a strike or spare.
        /// </summary>
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
        }

        /// <summary>
        /// Test three throws that constitute a spare.
        /// </summary>
        [TestMethod]
        public void TestSimpleSpare ()
        {
            game.Add (3);
            game.Add (7);
            game.Add (3);
            Assert.AreEqual (13, game.ScoreForFrame (1));
        }

        /// <summary>
        /// Test the frame after a spare.
        /// </summary>
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
        }

        /// <summary>
        /// Test three throws that constitute a strike.
        /// </summary>
        [TestMethod]
        public void TestSimpleStrike ()
        {
            game.Add (10);
            game.Add (3);
            game.Add (6);
            Assert.AreEqual (19, game.ScoreForFrame (1));
            Assert.AreEqual (28, game.Score);
        }

        /// <summary>
        /// Test a perfect game
        /// </summary>
        [TestMethod]
        public void TestPerfectGame ()
        {
            for (int i = 0; i < 12; i++)
            {
                game.Add (10);
            }
            Assert.AreEqual (300, game.Score);
        }

        /// <summary>
        /// Test the end of the throws array containing
        /// a 10th frame spare and a strike in the last position.
        /// </summary>
        [TestMethod]
        public void TestEndOfArray ()
        {
            for (int i = 0; i < 9; i++)
            {
                game.Add (0);
                game.Add (0);
            }
            game.Add (2);
            game.Add (8);   // 10th frame spare
            game.Add (10);  // Strike in last position of array
            Assert.AreEqual (20, game.Score);
        }

        /// <summary>
        /// Test a sample complete game.
        /// </summary>
        [TestMethod]
        public void TestSampleGame ()
        {
            game.Add (1);
            game.Add (4);
            game.Add (4);
            game.Add (5);
            game.Add (6);
            game.Add (4);
            game.Add (5);
            game.Add (5);
            game.Add (10);
            game.Add (0);
            game.Add (1);
            game.Add (7);
            game.Add (3);
            game.Add (6);
            game.Add (4);
            game.Add (10);
            game.Add (2);
            game.Add (8);
            game.Add (6);
            Assert.AreEqual (133, game.Score);
        }

        /// <summary>
        /// Test a heartbreak loss (299 score)
        /// </summary>
        [TestMethod]
        public void TestHeartBreak ()
        {
            for (int i = 0; i < 11; i++)
            {
                game.Add (10);
            }
            game.Add (9);
            Assert.AreEqual (299, game.Score);
        }

        /// <summary>
        /// Test a 10th frame spare
        /// </summary>
        [TestMethod]
        public void TestTenthFrameSpare ()
        {
            for (int i = 0; i < 9; i++)
            {
                game.Add (10);
            }
            game.Add (9);
            game.Add (1);
            game.Add (1);
            Assert.AreEqual (270, game.Score);
        }

    } // class GameTest
} // namespace GameTest
