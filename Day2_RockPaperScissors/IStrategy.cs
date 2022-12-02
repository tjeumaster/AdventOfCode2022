using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_RockPaperScissors
{
    public interface IStrategy
    {
        public int CalculateScore(string opponentChoice, string yourChoice);
    }
}
