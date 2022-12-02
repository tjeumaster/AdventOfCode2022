
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "C:\\Users\\dujardm\\Desktop\\Advent Of Code 2022\\Day1_CalorieCounting\\input.txt";
        string[] lines = File.ReadAllLines(filePath);
        int sumCalories = 0;
        int maxCalories = 0;
        List<int> topThreeCalories = new List<int>();

        foreach (var line in lines)
        {
            if (!string.IsNullOrEmpty(line))
                sumCalories += Convert.ToInt32(line);
                
            else
            {
                if (sumCalories >= maxCalories)
                {
                    maxCalories = sumCalories;
                }

                Update(topThreeCalories, sumCalories);

                sumCalories = 0;
            }


        }

        Console.WriteLine("Max calories: " + maxCalories);
        Console.WriteLine("Sum of top 3: " + topThreeCalories.Sum());
    }

    private static void Update(List<int> topThreeCalories, int sumCalories)
    {
        if (topThreeCalories.Count < 3)
        {
            topThreeCalories.Add(sumCalories);
        }      

        else
        {
            topThreeCalories.Sort();

            if (topThreeCalories[0] < sumCalories)
            {
                topThreeCalories[0] = sumCalories;
            }   
        }
    }
}




