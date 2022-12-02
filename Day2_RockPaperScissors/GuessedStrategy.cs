using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_RockPaperScissors
{
    public class GuessedStrategy : IStrategy
    {
        

        public int PlayScore(string opponentChoice, string yourChoice)
        {

            if (Choices.WinChoices[opponentChoice] == yourChoice)
                return 6;
            else if (Choices.DrawChoices[opponentChoice] == yourChoice)
                return 3;
            else if (Choices.LoseChoices[opponentChoice] == yourChoice)
                return 0;
            else
                throw new Exception("Invalid choice");
        }
           
        public int CalculateScore(string opponentChoice, string yourChoice)
        {
            return PlayScore(opponentChoice, yourChoice) + Choices.ChoiceScore(yourChoice);
        }
    }
}
