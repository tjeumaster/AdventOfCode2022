using Day2_RockPaperScissors;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "C:\\Users\\dujardm\\Desktop\\Advent Of Code 2022\\Day2_RockPaperScissors\\input.txt";
        string[] lines = File.ReadAllLines(filePath);
        int score1 = 0;
        int score2 = 0;

        foreach (var line in lines)
        {
            var roundInputs = line.Split(' ');
            var opponentChoice = roundInputs[0];
            var yourChoice = roundInputs[1];
            var round = new Round(opponentChoice, yourChoice);

            round.SetStrategy(new GuessedStrategy());
            score1 += round.GetScore();

            round.SetStrategy(new RealStrategy());
            score2 += round.GetScore();

        }

        Console.WriteLine("Score 1: " + score1);
        Console.WriteLine("Score 2: " + score2);
    }
}