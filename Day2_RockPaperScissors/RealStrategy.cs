using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_RockPaperScissors
{
    internal class RealStrategy : IStrategy
    {
        public int CalculateScore(string opponentChoice, string strategyGuide)
        {
            int choiceScore = Choices.OpponentChoiceScore(opponentChoice);

            if (strategyGuide == "Y")
                return 3 + Choices.ChoiceScore(Choices.DrawChoices[opponentChoice]);
            else if (strategyGuide == "X")
                return Choices.ChoiceScore(Choices.LoseChoices[opponentChoice]);
            else if (strategyGuide == "Z")
                return 6 + Choices.ChoiceScore(Choices.WinChoices[opponentChoice]); 

            else throw new Exception("Invalid input");
        }

    }
}
