
namespace BowlingGame;

public class Scorer
{
    #region Constants
    private const int MAX_THROWS_IN_GAME = 21;
    #endregion Constants

    #region PrivateFields
    private int    ball;
    private int    currentThrow;
    private int [] throws = new int [MAX_THROWS_IN_GAME];
    #endregion PrivateFields

    #region PrivateProperties
    private int NextTwoBallsForStrike
    {
        get { return throws [ball + 1] + throws [ball + 2]; }
    }

    private int NextBallForSpare
    {
        get { return throws [ball + 2]; }
    }

    private int TwoBallsInFrame
    {
        get { return throws [ball] + throws [ball + 1];}
    }
    #endregion PrivateProperties

    #region PublicMethods
    public void AddThrow (int pins)
    {
        throws [currentThrow++] = pins;
    }

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
                ball += 2;
            }
        } // for
        return score;

    } // method ScoreForFrame
    #endregion PublicMethods

    #region PrivateMethods
    private bool Strike ()
    {
        return throws [ball] == 10;
    }

    private bool Spare ()
    {
        return throws [ball] + throws [ball + 1] == 10;
    }
    #endregion PrivateMethods
} // class Scorer
