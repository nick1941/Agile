using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        #region Constants
        private const int MAX_THROWS_IN_GAME = 21;
        #endregion Constants

        #region Fields
        private bool   isFirstThrow = true;
        private int    ball;
        private int    currentFrame = 1;
        private int    currentThrow;
        private int    firstThrow;
        private int    secondThrow;
        private int [] throws = new int [MAX_THROWS_IN_GAME];
        #endregion Fields

        #region Properties
        // Get a count of the next ball thrown
        private int NextBall
        {
            get { return throws [ball]; }
        }

        // Get a count of the next two balls thrown.
        private int NextTwoBalls
        {
            get { return (throws [ball] + throws [ball + 1]); }
        }

        // Get a count from two balls in the frame.
        private int TwoBallsInFrame
        {
            get { return throws [ball] + throws [ball + 1]; }
        }
        /// <summary>
        /// Get the score for the specified frame.
        /// </summary>
        public int Score 
        { 
            get 
            { return ScoreForFrame (CurrentFrame - 1);}
            set
            { }
        }

        /// <summary>
        /// Get the current frame number.
        /// </summary>
        public int CurrentFrame
        {
            get { return currentFrame; }
        }
        #endregion Properties

        #region PrivateMethods
        // Adjust the current frame number based on the number of pins.
        // Parameters:
        //  pins:   Number of pins knocked down
        private void AdjustCurrentFrame (int pins)
        {
            if (isFirstThrow)
            {
                if (pins == 10) // strike
                    currentFrame++;
                else
                    isFirstThrow = false;
            }
            else
            {
                isFirstThrow = true;
                currentFrame++;
            }
            if (currentFrame > 11)
                currentFrame = 11;
        }

        // Handle the second throw by adjusting the score.
        private int HandleSecondThrow ()
        {
            int score = 0;

            secondThrow = throws[ball + 1];

            // spare needs next frame's first throw
            if (Spare ())
            {
                ball  += 2;
                score += 10 + NextBall;
            }
            else
            {
                score += TwoBallsInFrame;
                ball  += 2;
            }
            return score;
        }

        // Is this a spare?
        // returns true if a spare; false if not
        private bool Spare ()
        {
            return throws [ball] + throws [ball + 1] == 10;
        }

        // Is this a strike?
        // returns true if a strike; false if not
        private bool Strike ()
        {
            return throws [ball] == 10;
        }

        #endregion PrivateMethods

        #region PublicMethods
        /// <summary>
        /// Save the number of pins knocked down at the current position
        /// in the 'throws' array, incrementing the currentThrow number.
        /// Then add the number of pins to the score.
        /// </summary>
        /// <param name="pins">Number of pins knocked down</param>
        public void Add (int pins)
        {
            throws [currentThrow++] = pins;
            Score += pins;

            AdjustCurrentFrame (pins);
        }

        /// <summary>
        /// Compute the score for the specified frame.
        /// </summary>
        /// <param name="frame">The frame number</param>
        /// <returns>The score for the specified frame number</returns>
        public int ScoreForFrame (int theFrame)
        {
            int score = 0;

            ball = 0;

            // Initialize the current frame to 0;
            // while the current frame is less than the passed-in frame,
            // compute the score
            // by adding the pins knocked down by the first two balls,
            // incrementing the ball count for each throw.
            for (int currentFrame = 0;
                 currentFrame < theFrame;
                 currentFrame++)
            {
                firstThrow  = throws [ball];

                if (Strike ())
                {
                    ball++;
                    score += 10 + NextTwoBalls;
                }
                else
                {
                    score += HandleSecondThrow ();
                }

            } // method ScoreForFrame
            return score;
        }
        #endregion PublicMethods
    } // class Game
} // namespace Bowling Game
