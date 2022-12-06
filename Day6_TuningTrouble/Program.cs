internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "C:\\Users\\dujardm\\Desktop\\Advent Of Code 2022\\Day6_TuningTrouble\\input.txt";
        string message = File.ReadAllLines(filePath)[0];
        
        Console.WriteLine("Part 1: " + GetMarkerPosition(message, 4));
        Console.WriteLine("Part 2: " + GetMarkerPosition(message, 14));

    }

    private static int GetMarkerPosition(string message, int frameLength)
    {
        int position = 0;

        for (int i = 0; i < message.Length - frameLength; i++)
        {
            var frame = message.Substring(i, frameLength);

            bool isUnique = frame.Distinct().Count() == frameLength;

            if (isUnique)
            {
                position = i + frameLength;
                break;
            }   
        }
        return position;
    }

}