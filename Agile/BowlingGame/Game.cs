
namespace BowlingGame;

public class Game
{
    #region Fields
    private bool   isFirstThrow = true;
    private int    currentFrame = 1;
    private Scorer scorer = new Scorer ();
    #endregion Fields

    #region Properties
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
        scorer.AddThrow (pins);

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
        return scorer.ScoreForFrame (theFrame);
    } // method ScoreForFrame
    #endregion PublicMethods
} // class Game
