using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "C:\\Users\\dujardm\\Desktop\\Advent Of Code 2022\\Day3_RucksackReorganization\\input.txt";
        string[] lines = File.ReadAllLines(filePath);
        int sum = 0;
        int badgeSum = 0;
        List<string> groupItems = new List<string>();

        foreach (string items in lines) {
            groupItems.Add(items);

            if (groupItems.Count == 3)
            {
                var badge = GetBadge(groupItems);
                badgeSum += GetPriority(badge);
                groupItems = new List<string>();
            }
                
            string itemsCompartment1 = items.Substring(0, items.Length / 2);
            string itemsCompartment2 = items.Substring(items.Length / 2, items.Length / 2);
         
            foreach (var item in itemsCompartment1)
            {
                if (itemsCompartment2.IndexOf(item) != -1)
                {
                    sum += GetPriority(item);
                    break;
                }
            }
        }

        Console.WriteLine(sum);
        Console.WriteLine(badgeSum);    
    }

    public static char GetBadge(List<string> groupItems)
    {

        foreach (var item in groupItems[0])
        {
            if (groupItems[1].IndexOf(item) != -1)
            {
                if (groupItems[2].IndexOf(item) != -1) 
                {
                    return item;
                }
            }
        }

        throw new Exception("Badge not found");
    }

    public static int GetPriority(char item)
    {
        if (Char.IsLetter(item))
        {
            if (Char.IsLower(item))
                return (int)item - (int)'a' + 1;
            else
                return (int)item - (int)'A' + 27;
        }

        else
            throw new Exception("The item is invalid");
    }
}