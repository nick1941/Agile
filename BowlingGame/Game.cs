
namespace BowlingGame;

/// <summary>
/// Defines the operation of scoring a bowling game.
/// </summary>
public class Game
{
    #region Fields
    // Is this the first throw in the frame?
    private bool   isFirstThrow = true;
    private int    currentFrame = 1;

    // Instantiate an object that scores the game.
    private Scorer scorer       = new ();
    #endregion Fields

    #region Properties
    /// <summary>
    /// Gets the score for the current frame.
    /// </summary>
    public int Score 
    { 
        get { return ScoreForFrame (currentFrame);}
    }
    #endregion Properties

    #region PublicMethods
    /// <summary>
    /// Save the number of pins knocked down at the current position
    /// in the 'throws' array, then adjust the current frame as needed.
    /// </summary>
    /// <param name="pins">Number of pins knocked down</param>
    public void Add (int pins)
    {
        scorer.AddThrow    (pins);
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
    }
    #endregion PublicMethods

    #region PrivateMethods
    // Advanced the frame number if this is the last ball in the frame;
    // Otherwise, note that this is not the first throw in the frame.
    // Parameters:
    //  pins:   Number of pins knocked down
    private void AdjustCurrentFrame (int pins)
    {
        if (LastBallInFrame (pins))
        {
            AdvanceFrame ();
        }
        else
        {
            isFirstThrow = false;
        }

    } // method AdjustCurrentFrame

    // Is this the last ball in the frame?
    // Parameters:
    //  pins: Number of pins knocked down
    // Returns: true if this is the last ball in the frame; otherwise, false
    private bool LastBallInFrame (int pins)
    {
        return Strike (pins) || !isFirstThrow;
    }

    // Does this throw constitute a strike?
    // Parameters:
    //  pins: Number of pins knocked down
    // Returns: true if strike; otherwise, false
    private bool Strike (int pins)
    {
        return isFirstThrow && pins == 10;
    }

    // Advance the current frame number.
    // If it's greater than 10, set it to 10
    // indicating the end of the game.
    private void AdvanceFrame ()
    {
        currentFrame++;

        if (currentFrame > 10)
            currentFrame = 10;
    }

    #endregion PrivateMethods

} // class Game
