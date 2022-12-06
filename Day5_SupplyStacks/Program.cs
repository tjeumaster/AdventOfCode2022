using Day5_SupplyStacks;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, SupplyStack> supplyStacks = new Dictionary<int, SupplyStack>
        {
            { 1, new SupplyStack(new List<string> { "R", "G", "J", "B", "T", "V", "Z" }) },
            { 2, new SupplyStack(new List<String> { "J", "R", "V", "L"}) },
            { 3, new SupplyStack(new List<String> { "S", "Q", "F"}) },
            { 4, new SupplyStack(new List<String> { "Z", "H", "N", "L", "F", "V", "Q", "G"}) },
            { 5, new SupplyStack(new List<String> { "R", "Q", "T", "J", "C", "S", "M", "W"}) },
            { 6, new SupplyStack(new List<String> { "S", "W", "T", "C", "H", "F"}) },
            { 7, new SupplyStack(new List<String> { "D", "Z", "C", "V", "F", "N", "J"}) },
            { 8, new SupplyStack(new List<String> { "L", "G", "Z", "D", "W", "R", "F", "Q"}) },
            { 9, new SupplyStack(new List<String> { "J", "B", "W", "V", "P"}) },

        };

        string filePath = "C:\\Users\\dujardm\\Desktop\\Advent Of Code 2022\\Day5_SupplyStacks\\moves.txt";
        string[] moves = File.ReadAllLines(filePath);

        foreach (var move in moves)
        {
            var amount = int.Parse(move.Substring(move.IndexOf("move") + 5, 2));
            var from = int.Parse(move.Substring(move.IndexOf("from") + 5, 1));
            var to = int.Parse(move.Substring(move.IndexOf("to") + 3, 1));
            supplyStacks[from].AddMultipleTo(amount, supplyStacks[to]);

        }

        foreach (var stack in supplyStacks)
        {
            Console.WriteLine(stack.ToString());
        }


    }
}