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
        private int    currentFrame = 1;
        private int    currentThrow;
        private int [] throws = new int [MAX_THROWS_IN_GAME];
        #endregion Fields

        #region Properties
        public int Score 
        { 
            get 
            { return ScoreForFrame (CurrentFrame - 1);}
            set
            { }
        }

        public int CurrentFrame
        {
            get { return currentFrame; }
        }
        #endregion Properties

        #region PrivateMethods
        private void AdjustCurrentFrame ()
        {
            if (isFirstThrow)
            {
                isFirstThrow = false;
            }
            else
            {
                isFirstThrow = true;
                currentFrame++;
            }
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

            AdjustCurrentFrame ();
        }

        /// <summary>
        /// Compute the score for the specified frame.
        /// </summary>
        /// <param name="frame">The frame number</param>
        /// <returns>The score for the specified frame number</returns>
        public int ScoreForFrame (int theFrame)
        {
            int ball  = 0;
            int score = 0;
            
            // Initialize the current frame to 0;
            // while the current frame is less than the passed-in frame,
            // compute the score
            // by adding the pins knocked down by the first two balls,
            // incrementing the ball count for each throw.
            for (int currentFrame = 0;
                 currentFrame < theFrame;
                 currentFrame++)
            {
                int firstThrow  = throws [ball++];
                int secondThrow = throws [ball++];
                int frameScore  = firstThrow + secondThrow;

                // spare needs next frame's first throw
                if (frameScore == 10)
                    score += frameScore + throws [ball];
                else
                    score += frameScore;

            }
            return score;
        }
        #endregion PublicMethods
    } // class Game
} // namespace Bowling Game
