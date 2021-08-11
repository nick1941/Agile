using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
