using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_RockPaperScissors
{
    public static class Choices
    {
        public static int ChoiceScore(string yourChoice)
        {
            var choiceScores = new Dictionary<string, int>
            {
                { "X", 1 }, { "Y", 2 }, { "Z", 3 }
            };

            return choiceScores[yourChoice];

        }

        public static int OpponentChoiceScore(string yourChoice)
        {
            var choiceScores = new Dictionary<string, int>
            {
                { "A", 1 }, { "B", 2 }, { "C", 3 }
            };

            return choiceScores[yourChoice];

        }

        public static Dictionary<string, string> WinChoices
        {
            get
            {
                return new Dictionary<string, string> { { "A", "Y" }, { "B", "Z" }, { "C", "X" } };
            }
        }

        public static Dictionary<string, string> DrawChoices
        {
            get
            {
                return new Dictionary<string, string> { { "A", "X" }, { "B", "Y" }, { "C", "Z" } };
            }
        }

        public static Dictionary<string, string> LoseChoices
        {
            get
            {
                return new Dictionary<string, string> { { "A", "Z" }, { "B", "X" }, { "C", "Y" } };
            }
        }
    }
}
