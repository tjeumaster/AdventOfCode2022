using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_RockPaperScissors
{
    public class Round
    {
        private string opponentChoice;
        private string choice;
        private IStrategy strategy;

        public Round(string opponentChoice, string choice)
        {
            this.opponentChoice = opponentChoice;
            this.choice = choice;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int GetScore()
        {
            return this.strategy.CalculateScore(this.opponentChoice, this.choice);
        }







    }
}
