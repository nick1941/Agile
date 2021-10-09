namespace BowlingGame
{
    public class Frame
    {
        public int Score { get; set; }

        public void Add (int pins)
        {
            Score += pins;
        }
    }
}
