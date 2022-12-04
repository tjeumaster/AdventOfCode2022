using Day4_CampCleanup;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "C:\\Users\\dujardm\\Desktop\\Advent Of Code 2022\\Day4_CampCleanup\\input.txt";
        string[] lines = File.ReadAllLines(filePath);

        int containsCount = 0;
        int overlapsCount = 0;

        foreach (var pair in lines)
        {
            var assignments = pair.Split(",");

            var assignment1 = new Assignment(assignments[0]);
            var assignment2 = new Assignment(assignments[1]);

            if (assignment1.Contains(assignment2) || assignment2.Contains(assignment1))
                containsCount++;

            if (assignment1.Overlaps(assignment2))
                overlapsCount++;
        }

        Console.WriteLine(containsCount);
        Console.WriteLine(overlapsCount);
    }
}