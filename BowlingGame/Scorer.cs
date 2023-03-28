
namespace BowlingGame;

public class Scorer
{
    #region Constants
    private const int MAX_THROWS_IN_GAME = 21;
    #endregion Constants

    #region PrivateFields
    // Keeps track of the number of balls thrown in the frame.
    private int    ball;

    // Keeps track of the current throw number.
    private int    currentThrow;

    // Array to keep track of the number of throws in the game.
    private int [] throws = new int [MAX_THROWS_IN_GAME];
    #endregion PrivateFields

    #region PrivateProperties
    // Gets the next two balls for computing a strike
    private int NextTwoBallsForStrike
    {
        get { return throws [ball + 1] + throws [ball + 2]; }
    }

    // Gets the next ball for computing a spare
    private int NextBallForSpare
    {
        get { return throws [ball + 2]; }
    }

    // Gets the two non-strike non-spare balls in the frame.
    private int TwoBallsInFrame
    {
        get { return throws [ball] + throws [ball + 1];}
    }
    #endregion PrivateProperties

    #region PublicMethods
    /// <summary>
    /// Put the number of pins knocked down into the currentThrow
    /// position of the 'throws' array.
    /// </summary>
    /// <param name="pins">Number of pins knocked down on this throw</param>
    public void AddThrow (int pins)
    {
        throws [currentThrow++] = pins;
    }

    /// <summary>
    /// Compute the score for the specified frame.
    /// </summary>
    /// <param name="theFrame">The frame for which
    /// to compute the score</param>
    /// <returns>The score for the specified frame</returns>
    public int ScoreForFrame (int theFrame)
    {
        ball = 0;

        int score = 0;

        for (int currentFrame = 0; currentFrame < theFrame; currentFrame++)
        {
            if (Strike ())
            {
                score += 10 + NextTwoBallsForStrike;
                ball++;
            }
            else if (Spare ())
            {
                score += 10 + NextBallForSpare;
                ball  += 2;
            }
            else
            {
                score += TwoBallsInFrame;
                ball  += 2;
            }
        } // for
        return score;

    }
    #endregion PublicMethods

    #region PrivateMethods
    // Does this throw constitute a strike?
    // Returns: true if strike; otherwise, false.
    private bool Strike ()
    {
        return throws [ball] == 10;
    }

    // Does this throw constitute a spare?
    // Returns: true if spare; otherwise, false.
    private bool Spare ()
    {
        return throws [ball] + throws [ball + 1] == 10;
    }
    #endregion PrivateMethods
} // class Scorer
